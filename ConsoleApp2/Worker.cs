using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Worker
    {
        public Worker(string name,string surname,byte experience)
        {
            Name = name;
            SurName = surname;
            Experience = experience;

        }
        private byte _experience;
        private string _workerCode;
        public string Name { get; set; }
        public string SurName { get; set; }
        public string WorkerCode {
            get=>_workerCode;
            set
            {
                Name.Trim();
                SurName.Trim();
                _workerCode = Name[0].ToString().ToUpper() + SurName[0].ToString().ToUpper();
            }
        }
        public byte Experience { get=>_experience; set { if (value > 0) _experience = value; } }

    }
}
