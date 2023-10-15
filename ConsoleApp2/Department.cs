using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Department
    {
        public string Name { get; set; }


        Worker[] workers=new Worker[0];


        public void AddWorker(Worker worker)
        {
            Array.Resize(ref workers,workers.Length+1);
            workers[workers.Length-1]=worker;
        }


        public void SearchWorker(string name)
        {
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].Name.ToLower() == name.ToLower())
                    Console.WriteLine($"Worker name : {workers[i].Name} - Worker surname : {workers[i].SurName} - Worker experience : {workers[i].Experience}");
            }
            
        }


       public void SearchWorker(byte minExperience, int maxExperience)
        {
            string SearchedWorkers = "";
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].Experience <= maxExperience && workers[i].Experience >= minExperience)
                    Console.WriteLine($"Worker name : {workers[i].Name} - Worker surname : {workers[i].SurName} - Worker experience : {workers[i].Experience}");

            }
            
        }


        public void ShowAllWorkers()
        {
            for (int i = 0; i < workers.Length; i++)
            {
                Console.WriteLine($"Worker name : {workers[i].Name} - Worker surname : {workers[i].SurName} - Worker experience : {workers[i].Experience}");
            }
        }

    }
}
