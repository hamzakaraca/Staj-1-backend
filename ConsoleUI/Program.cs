using Business.Concrete;
using DataAccess.Concrete.InMemory;
using DataAccess.Concrete.EntityFramework;
using System;
using Entities.Concrete;


namespace ConsoleUI
{ 
    class Program
    {
        static void Main(string[] args)
        {
            WorkTest();
            //Test2();
            //Test3();
            //AddingWorker();
        }

        private static void AddingWorker()
        {
            WorkerManager workerManager = new WorkerManager(new EfWorkerDal());
            workerManager.add(new Worker { FirstName = "Ha", LastName = "Palaska" });
            foreach (var worker in workerManager.GetAll())
            {
                Console.WriteLine(worker.FirstName);
            }
        }

        private static void Test3()
        {
            EfWorkerDal efWorkerDal = new EfWorkerDal();
            efWorkerDal.Add(new Worker { FirstName = "Nejat", LastName = "Çakal" });
        }

        private static void Test2()
        {
            EfWorkDal efWorkDal = new EfWorkDal();
            efWorkDal.Delete(new Work { WorkId = 2 });
        }

        private static void WorkTest()
        {
            WorkManager workManager = new WorkManager(new EfWorkDal());
            foreach (var work in workManager.GetWorkDetails())
            {
                Console.WriteLine(work.WorkName + " " + work.ProgressStatus + " " + work.WorkerName);
            }
        }
    }
}
