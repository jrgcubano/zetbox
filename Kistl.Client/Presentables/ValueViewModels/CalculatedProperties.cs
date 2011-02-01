using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kistl.Client.Models;
using Kistl.Client.Presentables;
using Kistl.API;

namespace Kistl.Client.Presentables.ValueViewModels
{
    public class CalculatedProperties : IDictionary<string, Kistl.Client.Presentables.ViewModel>
    {
        private interface ICalculatedProperty
        {
            Kistl.Client.Presentables.ViewModel ViewModel { get; set; }
            void UpdateValue();
        }

        private class CalculatedProperty<TModel> : ICalculatedProperty
        {
            public string Key { get; set; }
            public ValueModel<TModel> Model { get; set; }
            public Kistl.Client.Presentables.ViewModel ViewModel { get; set; }
            public Func<TModel> Calculate { get; set; }

            public void UpdateValue()
            {
                if (Model == null) throw new InvalidOperationException("Model is not set");
                if (Calculate == null) throw new InvalidOperationException("Calculate is not set");
                Model.Value = Calculate();
            }
        }

        private readonly IViewModelFactory _vmf;
        private readonly IKistlContext _ctx;

        public CalculatedProperties(IKistlContext ctx, IViewModelFactory vmf)
        {
            _vmf = vmf;
            _ctx = ctx;
        }

        private Dictionary<string, ICalculatedProperty> _properties = new Dictionary<string, ICalculatedProperty>();

        public void AddStruct<T>(string key, string label, string tooltip, Func<Nullable<T>> calc) where T : struct
        {
            if (string.IsNullOrEmpty(key)) throw new ArgumentNullException("key");
            if (string.IsNullOrEmpty(label)) throw new ArgumentNullException("label");
            if (calc == null) throw new ArgumentNullException("calc");

            CalculatedProperty<Nullable<T>> p = new CalculatedProperty<Nullable<T>>();
            p.Calculate = calc;
            p.Model = new NullableStructValueModel<T>(label, tooltip, true, true);
            p.ViewModel = _vmf.CreateViewModel<NullableStructValueViewModel<T>.Factory>().Invoke(_ctx, p.Model);

            p.UpdateValue();
            _properties[key] = p;
        }

        public void AddClass<T>(string key, string label, string tooltip, Func<T> calc) where T : class
        {
            if (string.IsNullOrEmpty(key)) throw new ArgumentNullException("key");
            if (string.IsNullOrEmpty(label)) throw new ArgumentNullException("label");
            if (calc == null) throw new ArgumentNullException("calc");

            CalculatedProperty<T> p = new CalculatedProperty<T>();
            p.Calculate = calc;
            p.Model = new ClassValueModel<T>(label, tooltip, true, true);
            p.ViewModel = _vmf.CreateViewModel<ClassValueViewModel<T>.Factory>().Invoke(_ctx, p.Model);

            p.UpdateValue();
            _properties[key] = p;
        }

        public void Update(string key)
        {
            if (string.IsNullOrEmpty(key)) throw new ArgumentNullException("key");
            _properties[key].UpdateValue();
        }

        public void UpdateAll()
        {
            _properties.Values.ForEach(i => i.UpdateValue());
        }

        #region IDictionary<string,ViewModel> Members

        public void Add(string key, Kistl.Client.Presentables.ViewModel value)
        {
            throw new NotSupportedException();
        }

        public bool ContainsKey(string key)
        {
            return _properties.ContainsKey(key);
        }

        public ICollection<string> Keys
        {
            get { return _properties.Keys; }
        }

        public bool Remove(string key)
        {
            throw new NotSupportedException();
        }

        public bool TryGetValue(string key, out Kistl.Client.Presentables.ViewModel value)
        {
            ICalculatedProperty p;
            if (_properties.TryGetValue(key, out p))
            {
                value = p.ViewModel;
                return true;
            }
            else
            {
                value = null;
                return false;
            }
        }

        public ICollection<Kistl.Client.Presentables.ViewModel> Values
        {
            get { return _properties.Values.Select(i => i.ViewModel).ToList(); }
        }

        public Kistl.Client.Presentables.ViewModel this[string key]
        {
            get
            {
                if (string.IsNullOrEmpty(key)) throw new ArgumentNullException("key");
                return _properties[key].ViewModel;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        #endregion

        #region ICollection<KeyValuePair<string,ViewModel>> Members

        public void Add(KeyValuePair<string, Kistl.Client.Presentables.ViewModel> item)
        {
            throw new NotSupportedException();
        }

        public void Clear()
        {
            throw new NotSupportedException();
        }

        public bool Contains(KeyValuePair<string, Kistl.Client.Presentables.ViewModel> item)
        {
            throw new NotSupportedException();
        }

        public void CopyTo(KeyValuePair<string, Kistl.Client.Presentables.ViewModel>[] array, int arrayIndex)
        {
            throw new NotSupportedException();
        }

        public int Count
        {
            get { return _properties.Count; }
        }

        public bool IsReadOnly
        {
            get { return true; }
        }

        public bool Remove(KeyValuePair<string, Kistl.Client.Presentables.ViewModel> item)
        {
            throw new NotSupportedException();
        }

        #endregion

        #region IEnumerable<KeyValuePair<string,ViewModel>> Members

        public IEnumerator<KeyValuePair<string, Kistl.Client.Presentables.ViewModel>> GetEnumerator()
        {
            throw new NotSupportedException();
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotSupportedException();
        }

        #endregion
    }
}