using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Kistl.App.GUI;
using Kistl.API;

namespace Kistl.Client.Presentables
{
    public interface ILabeledViewModel : INotifyPropertyChanged
    {
        string Label { get; }
        string ToolTip { get; }
        ControlKind RequestedKind { get; }
        ViewModel Model { get; }
    }

    // No Viewdescriptor, code only
    public class LabeledViewContainerViewModel : ViewModel, ILabeledViewModel
    {
        public new delegate LabeledViewContainerViewModel Factory(IKistlContext dataCtx, string label, string toolTip, ViewModel mdl);

        public LabeledViewContainerViewModel(IViewModelDependencies dependencies, IKistlContext dataCtx, string label, string toolTip, ViewModel mdl)
            : base(dependencies, dataCtx)
        {
            this._Label = label;
            this._ToolTip = toolTip;
            this.Model = mdl;
        }

        #region ILabeledViewModel Members

        private string _Label;
        public string Label
        {
            get { return _Label; }
            set { _Label = value; OnPropertyChanged("Label"); }
        }

        private string _ToolTip;
        public string ToolTip
        {
            get { return _ToolTip; }
            set { _ToolTip = value; OnPropertyChanged("ToolTip"); }
        }

        private ControlKind _RequestedKind;
        public ControlKind RequestedKind
        {
            get { return _RequestedKind; }
            set { _RequestedKind = value; OnPropertyChanged("ControlKind"); }
        }

        public ViewModel Model
        {
            get;
            private set;
        }

        #endregion

        public override string Name
        {
            get { return _Label; }
        }
    }
}
