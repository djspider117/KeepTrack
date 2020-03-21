using GhostCore.MVVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Text;

namespace GhostCore.Collections
{
    public class ViewModelCollection<T, K> : ObservableCollection<T> where T : ViewModelBase<K>
    {
        private IList<K> _modelCollection;

        public ViewModelCollection()
        {
            _modelCollection = new List<K>();
        }

        public ViewModelCollection(IList<K> modelCollection)
        {
            _modelCollection = modelCollection;
        }

        public ViewModelCollection(IList<K> modelCollection, IEnumerable<T> col) : base(col)
        {
            _modelCollection = modelCollection;
        }

        public ViewModelCollection(IList<K> modelCollection, List<T> list) : base(list)
        {
            _modelCollection = modelCollection;
        }

        public static ViewModelCollection<TViewModel, TModel> CreateInitializedCollection<TViewModel, TModel>(IList<TModel> src) where TViewModel : ViewModelBase<TModel>
        {
            if (src == null)
            {
                return new ViewModelCollection<TViewModel, TModel>();
            }

            var lst = new List<TViewModel>();
            var type = typeof(TViewModel);
            var ctor = type.GetConstructor(new Type[] { typeof(TModel) });

            foreach (var item in src)
            {
                var obj = ctor.Invoke(new object[] { item });
                lst.Add(obj as TViewModel);
            }
            return new ViewModelCollection<TViewModel, TModel>(src, lst);
        }

        protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            base.OnCollectionChanged(e);
            
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (T x in e.NewItems)
                    {
                        _modelCollection.Add(x.Model);
                    }
                    break;
                case NotifyCollectionChangedAction.Move:
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach (T x in e.OldItems)
                    {
                        _modelCollection.Remove(x.Model);
                    }
                    break;
                case NotifyCollectionChangedAction.Replace:
                    break;
                case NotifyCollectionChangedAction.Reset:
                    break;
                default:
                    break;
            }
        }
    }
}
