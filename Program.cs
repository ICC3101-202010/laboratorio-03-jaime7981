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

            List<string> names = new List<string> { "Pablo", "Jaime", "Diego", "Damian" };
            List<string> lastNames = new List<string> { "Perez", "Zurita", "Fernandez", "Bustos" };
            List<string> nacionality = new List<string> { "Peru", "Chile", "Usa", "Spain" };
            List<string> birthdate = new List<string> { "20/10/99", "02/03/82", "07/05/68", "30/11/03" };
            List<string> gender = new List<string> { "male", "female", "animal", "other" };
            List<string> rut = new List<string> { "2035646", "20646546", "1902656", "28920654" };
            List<string> roles = new List<string> { "Manager", "Cashier", "Maintenance", "Supervisor" };

        string var;

            int RandomNumber(int min, int max)
            {
                Random random = new Random();
                return random.Next(min, max);
            }

            for (int i = 0; i <= 15; i++) //Client
            {

            }

            for (int i = 0; i <= 7; i++) //Workers
            {

            }

            for (int i = 0; i <= 30; i++) //Products
            {

            }

            //start test subjects
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
            Client theclient2 = new Client("Robert", "Rez", "Chile", "20874693k", "05/09/98", "male", 1122);
            clientList.Add(theclient);
            clientList.Add(theclient2);
            clientcounter++;
            clientcounter++;


            string testproductname = "Pisco";
            string testbrand = "Mistral";
            int testvalue = 5200;
            int teststock = 10;
            int testid = 102030;
            //end test subjects

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

                    if (var == "ChangeProffesion")
                    {
                        int workeridholder = 0;
                        Console.WriteLine("\n Worker ID: \n");
                        var = Console.ReadLine();

                        foreach (Worker actualworker in workerList)
                        {
                            if (actualworker.GetPersonId() == Int32.Parse(var))
                            {
                                Console.WriteLine("\n New Working Position: ( Manager / Cashier / Maintenance / Supervisor )\n");
                                var = Console.ReadLine();

                                workerList[workeridholder].SetPosition(var);
                                break;
                            }
                            workeridholder++;
                        }
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

                if (var == "Client")
                {
                    int clientidholder = 0;
                    Console.WriteLine("\n Client ID: \n");
                    var = Console.ReadLine();

                    foreach (Client actualclient in clientList)
                    {
                        if (actualclient.GetPersonId() == Int32.Parse(var))
                        {
                            break;
                        }
                        clientidholder++;
                    }

                    if (clientidholder < clientcounter)
                    {
                        Console.WriteLine("\n ShoppingCart / ClientInfo \n");
                        var = Console.ReadLine();

                        if (var == "ShoppingCart")
                        {
                            Console.WriteLine("\n ShowCart / AddProduct / RemoveProduct / Buy \n");
                            var = Console.ReadLine();

                            if (var == "ShowCart")
                            {
                                foreach (Product a in productList)
                                {
                                    if (a.GetId() == clientList[clientidholder].ShowShopingCart())
                                    {
                                        a.ProductInfo();
                                    }
                                }
                            }

                            if (var == "AddProduct")
                            {
                                Console.WriteLine("Choose product id");
                                var = Console.ReadLine();
                                foreach (Product item in productList)
                                {
                                    if (Int32.Parse(var) == item.GetId())
                                    {
                                        clientList[clientidholder].AddToShopingCart(item.GetId());
                                    }
                                }
                            }

                            if (var == "RemoveProduct")
                            {
                                Console.WriteLine("Choose product id");
                                var = Console.ReadLine();
                                foreach (Product item in productList)
                                {
                                    if (Int32.Parse(var) == item.GetId())
                                    {
                                        clientList[clientidholder].RemoveFromShopingCart(item.GetId());
                                    }
                                }
                            }

                            if (var == "Buy")
                            {
                                int totalvalue = 0;
                                foreach (Product a in productList)
                                {
                                    if (a.GetId() == clientList[clientidholder].ShowShopingCart())
                                    {
                                        totalvalue = totalvalue + a.GetValue();
                                    }
                                }
                                clientList[clientidholder].PersonInfo();
                                Console.WriteLine("You have Spent: $" + totalvalue);
                            }
                        }

                        if (var == "ClientInfo")
                        {
                            clientList[clientidholder].PersonInfo();
                        }
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
