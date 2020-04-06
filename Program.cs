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
            workerList.Add(anothermanager);
            workercounter++;
            workerList.Add(thecashier);
            workercounter++;

            Client theclient = new Client("Roberto", "Perez", "Chile", "20874693k", "05/09/98", "male", 11223344);
            clientList.Add(theclient);
            clientcounter++;
            

            string testproductname = "Pisco";
            string testbrand = "Mistral";
            int testvalue = 5200;
            int teststock = 10;
            int testid = 102030;

            Product piscomistral = new Product(testproductname,testbrand, testvalue, teststock, testid);
            productList.Add(piscomistral);
            productcounter++;



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
                        Console.WriteLine("Workers info \n");
                        foreach (Worker subject in workerList)
                        {
                            subject.PersonInfo(subject.GetWage(), subject.GetPosition(), subject.GetWorkingHour());
                        }
                        Console.WriteLine("\n Clients info \n");
                        foreach (Client subject in clientList)
                        {
                            subject.PersonInfo();
                        }
                    }

                    if (var == "ChangeProffesion") //implement change position by id
                    {
                        workerList[0].SetPosition("Manager");
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
                        workercounter++;
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
                        clientList[clientcounter].PersonInfo();
                        clientcounter++;
                    }
                }

                if (var == "Products")
                {
                    Console.WriteLine("\n WatchProducts / CreateProducts \n");
                    var = Console.ReadLine();

                    if (var == "WatchProducts")
                    {
                        foreach (Product item in productList)
                        {
                            item.ProductInfo();
                        }
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
                        productList[productcounter].ProductInfo();
                        productcounter++;
                    }
                }

                if (var == "Client") //ask for id
                {
                    Console.WriteLine("\n ShopingCart / ClientInfo \n");
                    var = Console.ReadLine();

                    if (var == "Shoping Cart")
                    {
                        Console.WriteLine("\n ShowCart / AddProduct / Buy \n");
                        var = Console.ReadLine();

                        if (var == "ShowCart")
                        {  
                            piscomistral.ProductInfo();
                        }

                        if (var == "AddProduct")
                        {
                            Console.WriteLine("Adding Product...");
                        }

                        if (var == "Buy")
                        {
                            Console.WriteLine("Buying...");
                        }
                    }

                    if (var == "ClientInfo") //show info by id
                    {
                        Console.WriteLine("Client info...");
                        clientList[0].PersonInfo();
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
