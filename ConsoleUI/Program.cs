using Business.Concrete;
using DataAccess.Concrete.InMemory;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkManager workManager = new WorkManager(new EfWorkDal());
            foreach (var work in workManager.GetAllByState("%0"))
            {
                Console.WriteLine(work.WorkName + " " +work.State + " " + work.WorkId);
            }
        }
    }
}
