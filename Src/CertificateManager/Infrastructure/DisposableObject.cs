using System;

namespace CertificateManager.Infrastructure
{
    // http://msdn.microsoft.com/en-us/library/ms244737.aspx

    public abstract class DisposableObject : IDisposable
    {
        private bool _disposed;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~DisposableObject()
        {
            Dispose(false);
        }

        private void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    DisposeResources();
                }
                _disposed = true;
            }
        }

        protected abstract void DisposeResources();
    }
}