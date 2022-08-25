using System;

namespace SoftServe
{
    public abstract class CloseableResource
    {
        public void Close()
        {
            Console.WriteLine("Closing resource");
        }
    }
    public class DisposePatternImplementer : CloseableResource, IDisposable
    {
        private bool IsDisposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!IsDisposed)
            {
                if (disposing)
                {
                    Console.WriteLine("Disposing by developer");
                }
                else
                {
                    Console.WriteLine("Disposing by GC");
                }

                Close();
                IsDisposed = true;
            }
        }
        ~DisposePatternImplementer()
        {
            Dispose(false);
        }
    }
}
