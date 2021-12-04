
namespace Interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {

            IWorker[] workers = new IWorker[2] { new Robot(), new Worker()};
            foreach (var worker in workers)
            {
                worker.Work();
            }


            Console.ReadLine();
        }
    }
}