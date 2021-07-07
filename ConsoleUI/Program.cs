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
            WorkerManager workerManager = new WorkerManager(new EfWorkerDal());
             
            foreach (var worker in workerManager.GetAll().Data)
            {
                Console.WriteLine(worker.FirstName);
            }
            //WorkTest();
            //Test2();
            //Test3();
            //AddingWorker();
            //DeleteWorker();
            WorkManager workManager = new WorkManager(new EfWorkDal());
            
            
            foreach (var work in workManager.GetAll().Data)
            {
                Console.WriteLine(work.FinalDate);
            }
        }

        private static void DeleteWorker() 
        {
            WorkerManager workerManager = new WorkerManager(new EfWorkerDal());
            workerManager.Delete(new Worker {WorkerId=2003 });
        }

        private static void AddingWorker()
        {
            WorkerManager workerManager = new WorkerManager(new EfWorkerDal());
            workerManager.Add(new Worker { FirstName = "Gülnur", LastName = "Karaca" });
            //foreach (var worker in workerManager.GetAll())
            //{
            //    Console.WriteLine(worker.FirstName);
            //}
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
            var result = workManager.GetWorkDetails();

            if (result.Success==true)
            {
                foreach (var work in result.Data)
                {
                    Console.WriteLine(work.WorkName + " " + work.ProgressStatus + " " + work.WorkerName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }
    }
}
