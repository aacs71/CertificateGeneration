using System;

namespace CertificateManager.Infrastructure
{
    public interface IPresenter
    {
        void OnViewReady();
        void OnViewSet();
    }

    public class Presenter<T> : IDisposable, IPresenter where T : IView
    {
        private T _view;

        public T View
        {
            get { return _view; }
            set
            {
                _view = value;
                OnViewSet();
            }
        }

        #region IDisposable Members

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion

        #region IPresenter Members

        public virtual void OnViewReady()
        {
        }

        public virtual void OnViewSet()
        {
        }

        #endregion

        public virtual bool CanClose()
        {
            return true;
        }

        ~Presenter()
        {
            Dispose(false);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
        }
    }
}