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
            List<Product> productList = new List<Product> { };
            int productcounter = 0;
            List<Worker> workerList = new List<Worker> { };
            int workercounter = 0;
            List<Client> clientList = new List<Client> { };
            int clientcounter = 0;

            string var;

            string testname = "Jaime";
            string testlastname = "Fernandez";
            string testnationality = "Chile";
            string testrut = "201645735";
            string testbirthdate = "20/06/99";
            string testgender = "male";
            string testtype = "Manager";
            int testpersonid = 12345;

            Worker anothermanager = new Worker(testtype, testname, testlastname, testnationality, testrut, testbirthdate, testgender, testpersonid);
            Worker thecashier = new Worker("Cashier", "John", "Smith", "USA", "201637856", "10/03/92", "male", testpersonid);

            Client theclient = new Client("Roberto", "Perez", "Chile", "20874693k", "05/09/98", "male", 11223344);

            string testproductname = "Pisco";
            string testbrand = "Mistral";
            int testvalue = 5200;
            int teststock = 10;
            int testid = 102030;

            Product piscomistral = new Product(testproductname,testbrand, testvalue, teststock, testid);


            while (true)
            {
                Console.WriteLine("\n Menu \n People / Products / Client / Exit \n");
                var = Console.ReadLine();

                if (var == "People")
                {
                    Console.WriteLine("\n Info / ChangeProffesion / NewWorker / NewClient \n");
                    var = Console.ReadLine();

                    if (var == "Info")
                    {
                        Console.WriteLine("Info Manager... \n");
                        anothermanager.PersonInfo(anothermanager.GetWage(), anothermanager.GetPosition(), anothermanager.GetWorkingHour());
                        thecashier.PersonInfo(thecashier.GetWage(), thecashier.GetPosition(), thecashier.GetWorkingHour());
                    }
                    if (var == "ChangeProffesion")
                    {
                        thecashier.SetPosition("Manager");
                    }
                    if (var == "NewWorker")
                    {
                        Console.WriteLine("Working position: (Manager / Cashier / Maintenance / Supervisor");
                        Console.WriteLine("Name:");
                        Console.WriteLine("Lastname:");
                        Console.WriteLine("Nationality:");
                        Console.WriteLine("rut:");
                        Console.WriteLine("Birthdate:");
                        Console.WriteLine("Gender:");
                        Console.WriteLine("Id: (int) \n");
                        Worker addworker = new Worker(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), 
                                                      Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Int32.Parse(Console.ReadLine()));
                        workerList.Add(addworker);
                        workerList[workercounter].PersonInfo(addworker.GetWage(), addworker.GetPosition(), addworker.GetWorkingHour());
                    }
                    if (var == "NewClient")
                    {
                        Console.WriteLine("Name:");
                        Console.WriteLine("Lastname:");
                        Console.WriteLine("Nationality:");
                        Console.WriteLine("rut:");
                        Console.WriteLine("Birthdate:");
                        Console.WriteLine("Gender:");
                        Console.WriteLine("id: \n");
                        Client addclient = new Client(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(),
                                                      Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Int32.Parse(Console.ReadLine()));
                        clientList.Add(addclient);
                        workerList[clientcounter].PersonInfo();

                    }
                }

                if (var == "Products")
                {
                    Console.WriteLine("\n WatchProducts / CreateProducts \n");
                    var = Console.ReadLine();
                    if (var == "WatchProducts")
                    {
                        piscomistral.ProductInfo();
                    }
                    if (var == "CreateProducts")
                    {
                        Console.WriteLine("Name:");
                        Console.WriteLine("Brand:");
                        Console.WriteLine("Value: (int)");
                        Console.WriteLine("Stock: (int)");
                        Console.WriteLine("ID: (int)");
                        Product addproduct = new Product(Console.ReadLine(), Console.ReadLine(), Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()));
                        productList.Add(addproduct);
                        workerList[clientcounter].PersonInfo();
                    }
                }

                if (var == "Client") //ask for id
                {
                    Console.WriteLine("\n ShopingCart / AddProduct / ClientInfo \n");
                    var = Console.ReadLine();
                    if (var == "Shoping Cart")
                    {
                        Console.WriteLine("\n ShowCart / Buy \n");
                        var = Console.ReadLine();
                        if (var == "ShowCart")
                        {  
                            piscomistral.ProductInfo();
                        }
                        if (var == "Buy")
                        {
                            Console.WriteLine("Buying...");
                        }
                    }
                    if (var == "AddProduct")
                    {
                        Console.WriteLine("Adding Product...");
                    }
                    if (var == "ClientInfo")
                    {
                        Console.WriteLine("Client info...");
                        theclient.PersonInfo();
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
