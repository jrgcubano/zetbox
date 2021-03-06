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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Threading;
using System.Diagnostics;

namespace Zetbox.Client.Presentables
{

    /// <summary>
    /// The ThreadManager takes care of executing task on a specific Thread.
    /// This is a necessary abstraction to decouple the <see cref="ViewModel"/>s
    /// from the underlying Toolkit.
    /// 
    /// Implementations are allowed to execute tasks in a blocking fashion on the calling Thread 
    /// if the Toolkit (like ASP.NET) doesn't allow asynchronous task handling.
    /// </summary>
    public interface IThreadManager
    {
        /// <summary>
        /// Verifies that the caller is running on this Thread.
        /// </summary>
        /// <exception cref="InvalidOperationException">when the method is called on a different thread</exception>
        void Verify();

        /// <summary>
        /// Tries to queue a task to execute on this Thread.
        /// </summary>
        /// <param name="lck">the object to synchronize on, pass <value>null</value> for free threading</param>
        /// <param name="asyncTask">the task to execute</param>
        /// <returns>true if the task was queued</returns>
        void Queue(object lck, Action asyncTask);
        /// <summary>
        /// Tries to queue a task to execute on this Thread.
        /// </summary>
        /// <param name="lck">the object to synchronize on, pass <value>null</value> for free threading</param>
        /// <param name="asyncTask">the task to execute</param>
        /// <param name="data">the data to pass to the task</param>
        /// <returns>true if the task was queued</returns>
        void Queue(object lck, Action<object> asyncTask, object data);

    }

    public interface IUiThreadManager : IThreadManager
    {
    }

    public interface IAsyncThreadManager : IThreadManager
    {
    }

    /// <summary>
    /// The <see cref="IThreadManager"/> for WPF has to be constructed on the UI Thread.
    /// </summary>
    public class UiThreadManager : IUiThreadManager
    {
        private Dispatcher _dispatcher;
        public UiThreadManager()
        {
            _dispatcher = Dispatcher.CurrentDispatcher;
        }

        #region IThreadManager Members

        // only the thread where this manager was created is acceptable
        public void Verify()
        {
#if DEBUG
            if (Dispatcher.CurrentDispatcher != this._dispatcher)
                throw new InvalidOperationException("Call must be made on UI thread.");
#endif
        }

        [System.Diagnostics.DebuggerHidden()]
        public void Queue(object lck, Action uiTask)
        {
            Debug.Assert(lck == this, "always pass the UI thread manager to UI.Queue() calls");
            _dispatcher.BeginInvoke(DispatcherPriority.ApplicationIdle, new ThreadStart(uiTask));
        }

        [System.Diagnostics.DebuggerHidden()]
        public void Queue(object lck, Action<object> uiTask, object data)
        {
            Debug.Assert(lck == this, "always pass the UI thread manager to UI.Queue() calls");
            _dispatcher.BeginInvoke(DispatcherPriority.ApplicationIdle, new ThreadStart(() => uiTask(data)));
        }

        #endregion
    }

    public class AsyncThreadManager : IAsyncThreadManager
    {
        #region IThreadManager Members

        // every thread may be async, since doing stuff on the UI thread makes 
        // it only slower but has no potential race conditions
        public void Verify() { }

        // strange, the msdn ( http://msdn.microsoft.com/en-us/library/kbf0f1ct.aspx ) 
        // says that this always returns true, and throws exceptions else (when being "hosted"),
        // but dan crevier uses this simpler implementation 
        // ( http://blogs.msdn.com/dancre/archive/2006/07/26/679851.aspx )
        // I'll go with the simple implementation until we hit this scenario 

        [System.Diagnostics.DebuggerHidden()]
        public void Queue(object lck, Action asyncTask)
        {
            if (!ThreadPool.QueueUserWorkItem(new WaitCallback((data) =>
            {
                if (lck == null)
                {
                    asyncTask();
                }
                else
                {
                    lock (lck)
                    {
                        asyncTask();
                    }
                }
            }), null))
                throw new InvalidOperationException("Cannot queue task in background");
        }

        [System.Diagnostics.DebuggerHidden()]
        public void Queue(object lck, Action<object> asyncTask, object data)
        {
            if (!ThreadPool.QueueUserWorkItem(new WaitCallback((passed_data) =>
            {
                if (lck == null)
                {
                    asyncTask(passed_data);
                }
                else
                {
                    lock (lck)
                    {
                        asyncTask(passed_data);
                    }
                }
            }), data))
                throw new InvalidOperationException("Cannot queue task in background");
        }

        #endregion
    }

    /// <summary>
    /// A <see cref="IThreadManager"/> to execute all tasks synchronously
    /// </summary>
    public class SynchronousThreadManager : IUiThreadManager, IAsyncThreadManager
    {
        #region IThreadManager Members

        public void Verify() { }

        [System.Diagnostics.DebuggerHidden()]
        public void Queue(object ignored, Action asyncTask)
        {
            if (asyncTask != null)
            {
                asyncTask();
            }
        }

        [System.Diagnostics.DebuggerHidden()]
        public void Queue(object ignored, Action<object> asyncTask, object data)
        {
            if (asyncTask != null)
            {
                asyncTask(data);
            }
        }

        #endregion
    }
}