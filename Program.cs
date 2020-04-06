using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kornerchop.Workers;
using Kornerchop.Products;

namespace Kornerchop
{
    class Program
    {
        static void Main(string[] args)
        {

            string var;

            string testname = "Jaime";
            string testlastname = "Fernandez";
            string testnationality = "Chile";
            string testrut = "201645735";
            string testbirthdate = "20/06/99";
            string testgender = "male";
            string testtype = "Manager";

            Worker anothermanager = new Worker(testtype, testname, testlastname, testnationality, testrut, testbirthdate, testgender);
            Worker thecashier = new Worker("Cashier", "John", "Smith", "USA", "201637856", "10/03/92", "male");


            while (true)
            {
                Console.WriteLine("\n Menu \n People / Products / ShoppingCart / Buy / Exit \n");
                var = Console.ReadLine();

                if (var == "People")
                {
                    Console.WriteLine("\n Info / ChangeProffesion / NewWorker \n");
                    var = Console.ReadLine();

                    if (var == "Info")
                    {
                        Console.WriteLine("Info Manager... \n");
                        anothermanager.PersonInfo(anothermanager.GetWage(), anothermanager.GetPosition(), anothermanager.GetWorkingHour());
                        thecashier.PersonInfo(thecashier.GetWage(), thecashier.GetPosition(), thecashier.GetWorkingHour());
                    }
                    if (var == "ChangeProffesion")
                    {
                        Console.WriteLine("ChangeProffesion... \n");
                        
                    }
                    if (var == "NewWorker")
                    {
                        Console.WriteLine("New Worker... \n");

                    }
                }

                if (var == "Exit")
                {
                    break;
                }
            }
        }
    }
}
