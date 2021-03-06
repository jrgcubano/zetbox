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
using System.Windows.Controls;
using System.Windows;
using Zetbox.Client.Presentables.DocumentManagement;
using Zetbox.Client.GUI;
using Zetbox.API.Utils;

namespace Zetbox.Client.WPF.View.DocumentManagement
{
    public abstract class PreviewEditor : UserControl, IHasViewModel<FileViewModel>
    {
        public PreviewEditor()
        {
        }

        public FileViewModel ViewModel
        {
            get { return (FileViewModel)DataContext; }
        }

        protected abstract ContentPresenter PreviewControl { get; }

        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
        {
            base.OnPropertyChanged(e);
            if (e.Property == DataContextProperty)
            {
                if (ViewModel != null)
                {
                    PreviewDocument();
                    ViewModel.Object.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(vmdl_PropertyChanged);
                }
            }
        }

        void vmdl_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Blob")
            {
                PreviewDocument();
            }
        }

        WPFPreviewControl vistaPreview;
        protected void PreviewDocument()
        {
            if (ViewModel.File.Blob != null)
            {
                if (vistaPreview == null)
                {
                    vistaPreview = new WPFPreviewControl();
                }
                PreviewControl.Content = vistaPreview;
                try
                {
                    vistaPreview.PreviewFilePath = ViewModel.File.Context.GetFileInfo(ViewModel.File.Blob.ID).FullName;
                }
                catch (Exception ex)
                {
                    Logging.Client.Error("Setting PreviewFilePath", ex);
                    PreviewControl.Content = new TextBlock() { Text = ex.Message };
                }
            }
            else
            {
                PreviewControl.Content = null;
            }
        }
    }
}
