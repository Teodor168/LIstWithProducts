namespace ListWithProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> shoppingList = new LinkedList<string>();
            int choice = 0; 

            do
            {
                Console.WriteLine("1.Dobavqne na nov produkt ");
                Console.WriteLine("2.Iztrivane na purviq produkt ");
                Console.WriteLine("3.Vseki produkt s nomera mu ");
                Console.WriteLine("4.Tursene ne produkt ");
                Console.WriteLine("5.Zamqna na produkt ");
                Console.WriteLine("6.Krai na rabota ");
                Console.Write("Opciq: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddProduct(shoppingList);
                        break;
                    case 2:
                        RemoveProduct(shoppingList);
                        break;
                    case 3:
                        Print(shoppingList);
                        break;
                    case 4:
                        SearchProduct(shoppingList);
                        break;
                    case 5:
                        ReplaceProduct(shoppingList);
                        break;
                    case 6:
                        Console.WriteLine("Programata svurshi ");
                        break;
                    default:
                        Console.WriteLine("Izberi pak ");
                        break;
                }
            } while (choice != 6);
        }
        //1
        static void AddProduct(LinkedList<string> shoppingList)
        {
            Console.Write("Dai product: ");
            shoppingList.AddLast(Console.ReadLine());
        }
        //2
        static void RemoveProduct(LinkedList<string> shoppingList)
        {
            if (shoppingList.Count > 0)
            {
                Console.WriteLine($"Premahnat produkt- {shoppingList.First.Value}");
                shoppingList.RemoveFirst();
            }
            else
            {
                Console.WriteLine("Spisukut e prazen");
            }
        }
        //3
        static void Print(LinkedList<string> shoppingList)
        {
            if (shoppingList.Count > 0)
            {
                int index = 1;
                foreach (string product in shoppingList)
                {
                    Console.WriteLine($"{index++}- {product}");
                }
            }
            else
            {
                Console.WriteLine("Nqma nishto v spisuka");
            }
        }
        //4
        static void SearchProduct(LinkedList<string> shoppingList)
        {
            Console.Write("Koi produkt tursish: ");
            string search = Console.ReadLine();
            int index = 1;
            foreach (string product in shoppingList)
            {
                if (product == search)
                {
                    Console.WriteLine($"Poziciq na produkta- {index}");
                    return;
                }
                index++;
            }
            Console.WriteLine($"Nqma produkt {search}");
        }
        //5
        static void ReplaceProduct(LinkedList<string> shoppingList)
        {
            Console.Write("Koi produkt da smenin: ");
            string oldProduct = Console.ReadLine();
            Console.Write("Nov produkt: ");
            string newProduct = Console.ReadLine();
            LinkedListNode<string> node = shoppingList.First;

            while (node != null)
            {
                if (node.Value == oldProduct)
                {
                    node.Value = newProduct;
                    return;
                }
                node = node.Next;
            }
            Console.WriteLine($"Nqma produkt {oldProduct}");
        }
    }
}