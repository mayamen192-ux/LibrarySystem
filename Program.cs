namespace LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sorted input
            string[] titles = new string[100];
            string[] ISDNs = new string[100];
            bool bookAvailiabilityStatus = bool.Parse("true");
            String[] borrowNames = new string[100];
            String[] bookAuthers = new string[100];
            int LastBookIndexTreacker = -1;

            //seed input

            titles[0] = "Math";
            ISDNs[0] = "1346";
            bookAvailiabilityStatus= true;
            borrowNames[0] = "null";
            bookAuthers[0] = "Ali";
            LastBookIndexTreacker++;


            titles[0] = "English";
            ISDNs[0] = "3456";
            bookAvailiabilityStatus = true;
            borrowNames[0] = "null";
            bookAuthers[0] = "Fatma";
            LastBookIndexTreacker++;



            bool exit = false;
            while (true)
            {
                Console.WriteLine("Welcome to the LibrarySystem");
                Console.WriteLine("1. Add New Book");
                Console.WriteLine("2. Borrow Book");
                Console.WriteLine("3. Return Book");
                Console.WriteLine("4. Search Book");
                Console.WriteLine("5. List All available Book");
                Console.WriteLine("6. Tranfer Book");
                Console.WriteLine("7. Exit");
                Console.Write("Please select an option: ");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        //Add new book
                        Console.WriteLine("Enter a title book :");
                        titles[LastBookIndexTreacker + 1] = Console.ReadLine();
                        bookAvailiabilityStatus = true;
                        Console.WriteLine("Availability of book:"+ bookAvailiabilityStatus);
                        ISDNs[LastBookIndexTreacker + 1] = "No" + (LastBookIndexTreacker + 1);

                        Console.WriteLine("Book Added  successfully!");
                        Console.WriteLine("book Number: " + ISDNs[LastBookIndexTreacker + 1]);

                        LastBookIndexTreacker++;







                        break;



                    case 2:
                       
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 5:
                        break;

                    case 6:
                        break;



                    case 7:
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invaild account number ");
                        break;
                }

                if (exit == true)
                {
                    break;
                }
                Console.WriteLine("Thank you for using the Bank System, press any key");
                Console.ReadLine();
                Console.Clear();

            }
        }


    }
}
