using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesConsoleApp
{
    internal class SimpleDelegateExample
    {
        public void Recieve(string message)
        {
            Console.WriteLine(message);
        }

        public void AnotherRecieve(string message)
        {
            Console.WriteLine($"AnotherRecieve: {message}");
        }

        // Delegate understanding
        // function/method wrapper as a type 
        // enabling us pass methods around as function/method parameters
        // use for callback method implementation
        public delegate void OnReceiveDelegate(string message);

        internal void Run()
        {
            var callbacks = new OnReceiveDelegate(Recieve);
            callbacks += AnotherRecieve;

            callbacks.Invoke("from callback 1");
            callbacks("from callback 2");
        }
    }
}
