// This file is part of zetbox.
//
// Zetbox is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as
// published by the Free Software Foundation, either version 3 of
// the License, or (at your option) any later version.
//
// Zetbox is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public
// License along with zetbox.  If not, see <http://www.gnu.org/licenses/>.
// http://www.codeproject.com/KB/WPF/wpf_vista_preview_handler.aspx

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Windows;
using System.Runtime.InteropServices.ComTypes;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Interop;
using System.Security;
using Zetbox.API.Utils;

namespace Zetbox.Client.WPF.View.DocumentManagement
{
    class PreviewersManager : IDisposable
    {
        private IPreviewHandler pHandler;
        private COMStream stream;

        public void InvalidateAttachedPreview(IntPtr handler, Rect viewRect)
        {
            if (pHandler != null)
            {
                RECT r = new RECT(viewRect);
                pHandler.SetRect(ref r);
            }
        }

        public void AttachPreview(IntPtr handler, string fileName, Rect viewRect)
        {
            Release();

            string CLSID = "8895b1c6-b41f-4c1c-a562-0d564250836f";
            Guid g = new Guid(CLSID);
            string[] exts = fileName.Split('.');
            string ext = exts[exts.Length - 1];
            using (RegistryKey hk = Registry.ClassesRoot.OpenSubKey(string.Format(@".{0}\ShellEx\{1:B}", ext, g)))
            {
                if (hk != null)
                {
                    g = new Guid(hk.GetValue("").ToString());

                    Type type = Type.GetTypeFromCLSID(g, true);
                    object comObj = Activator.CreateInstance(type);

                    IInitializeWithFile fileInit = comObj as IInitializeWithFile;
                    IInitializeWithStream streamInit = comObj as IInitializeWithStream;

                    bool isInitialized = false;
                    try
                    {
                        if (fileInit != null)
                        {
                            fileInit.Initialize(fileName, 0);
                            isInitialized = true;
                        }
                        else if (streamInit != null)
                        {
                            stream = new COMStream(File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.Read));
                            streamInit.Initialize((IStream)stream, 0);
                            isInitialized = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Logging.Log.Warn("Unable to initialize IPreviewHandler", ex);
                    }

                    pHandler = comObj as IPreviewHandler;
                    if (isInitialized && pHandler != null)
                    {
                        RECT r = new RECT(viewRect);

                        pHandler.SetWindow(handler, ref r);
                        pHandler.SetRect(ref r);

                        pHandler.DoPreview();
                    }
                    else
                    {
                        Marshal.FinalReleaseComObject(comObj);
                        Release();
                    }
                }
            }
        }

        public void Dispose()
        {
            Release();
        }

        private void Release()
        {
            if (pHandler != null)
            {
                try
                {
                    pHandler.Unload();
                }
                catch { }
                Marshal.FinalReleaseComObject(pHandler);
                pHandler = null;
            }

            if (stream != null)
            {
                stream.Dispose();
                stream = null;
            }
        }
    }

    public class Previewer
    {
        public Guid CLSID { get; set; }
        public string Title { get; set; }
    }

    #region COM Interfaces
    [ComImport]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [Guid("8895b1c6-b41f-4c1c-a562-0d564250836f")]
    interface IPreviewHandler
    {
        void SetWindow(IntPtr hwnd, ref RECT rect);
        void SetRect(ref RECT rect);
        void DoPreview();
        void Unload();
        void SetFocus();
        void QueryFocus(out IntPtr phwnd);
        [PreserveSig]
        uint TranslateAccelerator(ref MSG pmsg);
    }

    [ComImport]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [Guid("b7d14566-0509-4cce-a71f-0a554233bd9b")]
    interface IInitializeWithFile
    {
        void Initialize([MarshalAs(UnmanagedType.LPWStr)] string pszFilePath, uint grfMode);
    }

    [ComImport]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [Guid("b824b49d-22ac-4161-ac8a-9916e8fa3f7f")]
    interface IInitializeWithStream
    {
        void Initialize(IStream pstream, uint grfMode);
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RECT
    {
        public int left;
        public int top;
        public int right;
        public int bottom;

        public RECT(Rect rect)
        {
            this.top = (int)rect.Top;
            this.bottom = (int)rect.Bottom;
            this.left = (int)rect.Left;
            this.right = (int)rect.Right;
        }
    }

    public sealed class COMStream : IStream, IDisposable
    {
        Stream _stream;

        ~COMStream()
        {
            if (_stream != null)
            {
                _stream.Close();
                _stream.Dispose();
                _stream = null;
            }
        }

        private COMStream() { }

        public COMStream(Stream sourceStream)
        {
            _stream = sourceStream;
        }

        #region IStream Members

        public void Clone(out IStream ppstm)
        {
            throw new NotSupportedException();
        }

        public void Commit(int grfCommitFlags)
        {
            throw new NotSupportedException();
        }

        public void CopyTo(IStream pstm, long cb, IntPtr pcbRead, IntPtr pcbWritten)
        {
            throw new NotSupportedException();
        }

        public void LockRegion(long libOffset, long cb, int dwLockType)
        {
            throw new NotSupportedException();
        }

        [SecurityCritical]
        public void Read(byte[] pv, int cb, IntPtr pcbRead)
        {
            int count = this._stream.Read(pv, 0, cb);

            // destination expects an ULONG, therefore we must guard against negative values
            if (pcbRead != IntPtr.Zero && count >= 0)
            {
                Marshal.WriteInt64(pcbRead, count);
            }
        }

        public void Revert()
        {
            throw new NotSupportedException();
        }

        [SecurityCritical]
        public void Seek(long dlibMove, int dwOrigin, IntPtr plibNewPosition)
        {
            SeekOrigin origin = (SeekOrigin)dwOrigin;
            long pos = this._stream.Seek(dlibMove, origin);
            if (plibNewPosition != IntPtr.Zero)
            {
                Marshal.WriteInt64(plibNewPosition, pos);
            }
        }

        public void SetSize(long libNewSize)
        {
            this._stream.SetLength(libNewSize);
        }

        public void Stat(out System.Runtime.InteropServices.ComTypes.STATSTG pstatstg, int grfStatFlag)
        {
            pstatstg = new System.Runtime.InteropServices.ComTypes.STATSTG();
            pstatstg.type = 2;
            pstatstg.cbSize = this._stream.Length;
            pstatstg.grfMode = 0;
            if (this._stream.CanRead && this._stream.CanWrite)
            {
                pstatstg.grfMode |= 2;
            }
            else if (this._stream.CanRead && !_stream.CanWrite)
            {
                pstatstg.grfMode |= 1;
            }
            else
            {
                throw new IOException();
            }

        }

        public void UnlockRegion(long libOffset, long cb, int dwLockType)
        {
            throw new NotSupportedException();
        }

        [SecurityCritical]
        public void Write(byte[] pv, int cb, IntPtr pcbWritten)
        {
            this._stream.Write(pv, 0, cb);
            if (pcbWritten != IntPtr.Zero)
            {
                Marshal.WriteInt32(pcbWritten, cb);
            }
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            if (this._stream != null)
            {
                this._stream.Close();
                this._stream.Dispose();
                this._stream = null;
            }
        }

        #endregion
    }
    #endregion
}
