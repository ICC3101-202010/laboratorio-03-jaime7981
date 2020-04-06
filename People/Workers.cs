using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kornerchop.Workers
{
    class Worker : Person
    {
        private int wage;
        private string workinghour;
        private string typeofworker;

        private string[] WorkerType = { "Manager", "Cashier", "Maintenance", "Supervisor" };

        public Worker()
        {
            this.wage = 0;
            this.workinghour = "9 AM - 8PM";
            this.typeofworker = "No worker";
    }

        public Worker(string typeofworker, string fisrtname, string lastname, string nationality, string rut, string birthdate, string gender, int personid) 
               : base(fisrtname, lastname, nationality, rut, birthdate, gender, personid)
        {
            this.SetPosition(typeofworker);
        }

        public void SetPosition(string workertype)
        {
            for (int i = 0; i < WorkerType.Length; i++)
            {
                if (WorkerType[i] == workertype)
                {
                    if (workertype == "Manager")
                    {
                        wage = 2000000;
                        workinghour = "Art. 22: no working schedule";
                        typeofworker = "Manager";
                    }
                    if (workertype == "Cashier")
                    {
                        wage = 400000;
                        workinghour = "8 AM - 8PM";
                        typeofworker = "Cashier";
                    }
                    if (workertype == "Maintenance")
                    {
                        wage = 340000;
                        workinghour = "8 AM - 8PM";
                        typeofworker = "Manager";
                    }
                    if (workertype == "Supervisor")
                    {
                        wage = 620000;
                        workinghour = "11 AM - 4PM";
                        typeofworker = "Manager";
                    }
                    else
                    {
                        Console.WriteLine("This is not a working position");
                    }
                }
            }
        }

        public int GetWage()
        {
            return wage;
        }

        public string GetPosition()
        {
            return typeofworker;
        }

        public string GetWorkingHour()
        {
            return workinghour;
        }
    }
}
