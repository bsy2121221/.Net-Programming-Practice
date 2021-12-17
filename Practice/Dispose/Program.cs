using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dispose
{
    class Program :IDisposable
    {
        static void Main()
        {
        }
        bool disposed = false;
        public void Dispose()
        {
            Dispose(true);

        }
        protected virtual void Dispose(Boolean disposing)
        {
            if (disposed)
                return;
            if (disposing)
            {
                Console.WriteLine("Freeing managed resources:");
            }
            Console.WriteLine("Freeing unmanaged resources:");
            disposed = true;

        }
    }
}
