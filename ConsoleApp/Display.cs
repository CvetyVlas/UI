namespace ConsoleApp
{
    using System;
    using Business;
    using Data.Model;

    /// <summary>
    /// Console User Interface (UI)
    /// </summary>
    public class Display
    {
        private int closeOperationId = 6;

        private ProductBusiness productBusiness = new ProductBusiness();

        /// <summary>
        ///  Constructor
        /// </summary>
        public Display()
        {
            Input();
        }

        /// <summary>
        /// Menu UI
        /// </summary>
        private void ShowMenu()
        {
            Console.WriteLine(new string('!', 40));
            Console.WriteLine(new string(' ', 18) + "INVENTARY" + new string(' ', 18));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. List all entries");
            Console.WriteLine("2. Add new entry");
            Console.WriteLine("3. Update entry");
            Console.WriteLine("4. Fetch entry by ID");
            Console.WriteLine("5. Delete entry by ID");
            Console.WriteLine("6. Exit");
        }

        /// <summary>
        /// User Input
        /// </summary>
        private void Input()
        {
            var operation = -1;
            do
            {
                ShowMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        ListAll();
                        break;
                    case 2:
                        Add();
                        break;
                    case 3:
                        Update();
                        break;
                    case 4:
                        Fetch();
                        break;
                    case 5:
                        Delete();
                        break;
                    default:
                        break;
                }
            } while (operation != closeOperationId);
        }

        /// <summary>
        /// US for Deletion
        /// </summary>
        private void Delete()
        {
            Console.WriteLine("Enter ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            productBusiness.Delete(id);
            Console.WriteLine("Done.");
        }

        /// <summary>
        /// UI for getting a single product record from the database
        /// </summary>
        private void Fetch()
        {
            Console.WriteLine("Enter ID to fetch: ");
            int id = int.Parse(Console.ReadLine());
            Car product = productBusiness.Get(id);
            if (product != null)
            {
                Console.WriteLine(new string('-', 40));
                Console.WriteLine("ID: " + product.Id);
                Console.WriteLine("Category: " + product.Category);
                Console.WriteLine("Brand: " + product.Brand);
                Console.WriteLine("Model: " + product.Model);
                Console.WriteLine("Production year: " + product.ProductionYear);
                Console.WriteLine("Engine: " + product.Engine);
                Console.WriteLine("Gearbox: " + product.GearBox);
                Console.WriteLine("Power: " + product.Power);
                Console.WriteLine("Color: " + product.Color);
                Console.WriteLine("Price: " + product.Price);           
                
                Console.WriteLine(new string('-', 40));
            }
        }

        /// <summary>
        /// UI dor updating a single product record in the database.
        /// </summary>
        private void Update()
        {
            Console.WriteLine("Enter ID to update: ");
            int id = int.Parse(Console.ReadLine());
            Car product = productBusiness.Get(id);
            if (product != null)
            {
                Console.WriteLine("Enter category: ");
                product.Category = Console.ReadLine();
                Console.WriteLine("Enter brand: ");
                product.Brand = Console.ReadLine();
                Console.WriteLine("Enter model: ");
                product.Model = Console.ReadLine();
                Console.WriteLine("Enter year of production: ");
                product.ProductionYear = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter engine type: ");
                product.Engine = Console.ReadLine();
                Console.WriteLine("Enter gearbox: ");
                product.GearBox = Console.ReadLine();
                Console.WriteLine("Enter power: ");
                product.Power = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter color: ");
                product.Color = Console.ReadLine();
                Console.WriteLine("Enter price: ");
                product.Price = decimal.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Product not found!");
            }
        }

        /// <summary>
        /// UI for adding a single product record to the database.
        /// </summary>
        private void Add()
        {
            Car product = new Car();
            Console.WriteLine("Enter category: ");
            product.Category = Console.ReadLine();
            Console.WriteLine("Enter brand: ");
            product.Brand = Console.ReadLine();
            Console.WriteLine("Enter model: ");
            product.Model = Console.ReadLine();
            Console.WriteLine("Enter year of production: ");
            product.ProductionYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter engine type: ");
            product.Engine = Console.ReadLine();
            Console.WriteLine("Enter gearbox: ");
            product.GearBox = Console.ReadLine();
            Console.WriteLine("Enter power: ");
            product.Power = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter color: ");
            product.Color = Console.ReadLine();
            Console.WriteLine("Enter price: ");
            product.Price = decimal.Parse(Console.ReadLine());
            productBusiness.Add(product);
        }

        /// <summary>
        /// UI to list all the products.
        /// </summary>
        private void ListAll()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 16) + "PRODUCTS" + new string(' ', 16));
            Console.WriteLine(new string('-', 40));
            var products = productBusiness.GetAll();
            foreach (var item in products)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", item.Id, item.Category, item.Brand, item.Model, item.ProductionYear,
                    item.Engine, item.GearBox, item.Power, item.Color, item.Price);
            }
        }
    }
}
