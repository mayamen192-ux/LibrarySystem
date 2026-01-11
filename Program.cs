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
                        Console.WriteLine("Enter a book title:"); 
                        titles[LastBookIndexTreacker] = Console.ReadLine(); 
                        bookAvailiabilityStatus = true; 
                        Console.WriteLine("Availability of book: " + bookAvailiabilityStatus); 
                        ISDNs[LastBookIndexTreacker] = "123" + LastBookIndexTreacker; 
                        Console.WriteLine("Book added successfully"); 
                        Console.WriteLine("Book Number: " + ISDNs[LastBookIndexTreacker]); 
                        LastBookIndexTreacker++;







                        break;



                    case 2:
                        //Borrow book

                        Console.WriteLine("Enter title of book:");
                        String tiBook = Console.ReadLine();
                        Console.WriteLine("Enter borrow name of the book");
                        String BorrName = Console.ReadLine();

                        bool bookFound = false;

                        for (int i = 0; i < 100; i++)
                        {
                            if (tiBook == titles[i])
                            {
                                borrowNames[i] = BorrName;

                                bookFound = true;
                                break;
                            }

                        }
                        if (bookFound == false)
                        {
                            Console.WriteLine("account not found");
                        }
                        else
                        {
                            Console.WriteLine("Borrow succeefuly");
                        }

                        break;

                    case 3:
                        //Return book
                        Console.WriteLine("Enter title of the book");
                        String titBook2= Console.ReadLine();
                        Console.WriteLine("Enter return name of the book");
                        string returnBook = Console.ReadLine();

                        bool bookFound2 = true;

                        for (int i = 0; i < 100; i++)
                        {
                            if (titBook2 == titles[i])
                            {
                                ISDNs[i] += returnBook;

                                bookFound = true;
                                break;
                            }

                        }
                        if (bookFound2 == false)
                        {
                            Console.WriteLine("account not found");
                        }
                        else
                        {
                            Console.WriteLine("Retrun succeefuly");
                        }


                        break;

                    case 4:
                        //Search book

                        Console.WriteLine("Enter title of book");
                        String titBook3= Console.ReadLine();
                        bool accountFound4 = false;
                       String currentBook = "NO0";

                        for (int i = 0; i < 100; i++)
                        {
                            if (titBook3 == titles[i])
                            {
                                currentBook = ISDNs[i];
                                accountFound4 = true;

                                break;
                               
                            }

                        }

                        //output
                        if (accountFound4 == false)
                        {
                            Console.WriteLine("sorry account not found");
                        }

                        else
                        {


                            Console.WriteLine("Your book = " + currentBook + bookAvailiabilityStatus);

                        }

                        break;
                    case 5:
                        //List all avaiable books
                        for (int i = 0; i < 100; i++)
                        { 
                            Console.WriteLine("Enter book title:"); 
                            titles[i] = Console.ReadLine(); } 
                       for (int i = 0; i < 100; i++) 
                            { 
                            Console.WriteLine("Book " + (i+1) + " is " + titles[i]); 
                        }
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
