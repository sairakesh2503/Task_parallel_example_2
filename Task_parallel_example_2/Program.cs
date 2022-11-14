using System;
using System.Threading;
using System.Threading.Tasks;
namespace namespace1
{
    class program
    {
        static void Main(string[] args)
        {
            Task t1 = Task.Factory.StartNew(() => dowork(1, 2000)).ContinueWith((prev)=>otherwork(1,2000));
            Task t2 = Task.Factory.StartNew(() => dowork(2, 2500));
            Task t3 = Task.Factory.StartNew(() => dowork(3, 1500));


            Console.WriteLine("Press any key to exit");
            Console.ReadLine();

        }
        static void dowork(int id, int sleep)
        {
            Console.WriteLine("Task {0} is beginning..", id);
            Thread.Sleep(sleep);
            Console.WriteLine("Task {0} is completed..", id);
        }
        static void otherwork(int id,int sleep)
        {
            Console.WriteLine("other task {0} has started", id);
            Thread.Sleep((int)sleep);
            Console.WriteLine("other task {0} is completed", id);
        }
        

    }
}
