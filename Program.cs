using System.Data;

namespace LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sorted input
            string[] titles = new string[100];
            string[] ISDNs = new string[100];
            bool[] bookAvailiabilityStatus = new bool[100];
            String[] borrowNames = new string[100];
            String[] bookAuthers = new string[100];
            int LastBookIndexTreacker = -1;

            //seed input

            titles[0] = "Math";
            ISDNs[0] = "1346";
            bookAvailiabilityStatus[0]= true;
            borrowNames[0] = "null";
            bookAuthers[0] = "Ali";
            LastBookIndexTreacker++;


            titles[1] = "English";
            ISDNs[1] = "3456";
            bookAvailiabilityStatus[1] = true;
            borrowNames[1] = "null";
            bookAuthers[1] = "Fatma";
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
                        bookAvailiabilityStatus[LastBookIndexTreacker] = true;
                       Console.WriteLine("Availability of book: " + bookAvailiabilityStatus[LastBookIndexTreacker]); 
                        ISDNs[LastBookIndexTreacker] = "123" + LastBookIndexTreacker; 
                        Console.WriteLine("Book added successfully"); 
                        Console.WriteLine("Book Number: " + ISDNs[LastBookIndexTreacker]);
                        LastBookIndexTreacker++;







                        break;



                    case 2:
                        //Borrow book

                        Console.WriteLine("Enter title  or ISDN of book:");
                        String keyBook = Console.ReadLine();
                       
                        
                        

                        bool bookFound = false;

                        for (int i = 0; i < 100; i++)
                        {
                            if (keyBook == titles[i] || keyBook== ISDNs[i] )
                            {
                                borrowNames[i] = keyBook;

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
                        Console.WriteLine("Enter title or ISDN of book:");
                        String keyBook2= Console.ReadLine();
                        Console.WriteLine("Enter return name of the book"); 
                        string returnBook = Console.ReadLine(); 
                        bool bookFound2 = false;

                        for (int i = 0; i < titles.Length; i++)
                        {
                            if (keyBook2 == ISDNs[i])
                            {
                                if (bookAvailiabilityStatus[i] = true)
                                {
                                    borrowNames[i] = returnBook;
                                    bookFound2 = true;
                                    break;
                                }



                                }

                            }

                            if (bookFound2 == false)
                            {
                                Console.WriteLine("book not found");
                            }
                            else
                            {
                                Console.WriteLine("Retrun succeefuly");
                            }

                        
                        break;
                    case 4:
                        //Search book
                        Console.WriteLine("Enter title of book");
                        String titBook2 = Console.ReadLine();
                        bool bookFound5 = false;
                         
                        
                        for (int i = 0; i < titles.Length; i++)
                        {
                            if (titBook2 == titles[i])
                            {
                               
                                bookFound5 =true;

                                Console.WriteLine("Your book deatils : " );
                                Console.WriteLine("Title of book : " + titles[i]);
                                Console.WriteLine("ISBN of book : " + ISDNs[i]);
                                Console.WriteLine("Auther of book : " + bookAuthers[i]);
                                Console.WriteLine("borrow names of book : " + borrowNames[i]);
                                if (bookAvailiabilityStatus[i])
                                {
                                    Console.WriteLine("book is avaiable ");
                                }
                                else
                                {
                                    Console.WriteLine("book is  not avaiable ");

                                }
                                    break;
                                

                                    
                            }

                        }
                        

                        //output
                        if (bookFound5 == false)
                        {
                            Console.WriteLine("sorry book not found");
                        }

                        else
                        {


                            Console.WriteLine("search succeefuly ");

                        }


                        break;

                    case 5:
                        //List all available books

                        Console.WriteLine("Enter Your name");
                        String name= Console.ReadLine();
                        bool bookF = false;
                       
                        String[] listOfBook =new string [100];

                        for (int i = 0; i < titles.Length; i++)
                        {
                            if (bookAvailiabilityStatus[i])
                            {
                                {
                                    listOfBook[i] = " Title "+" is " + titles[i] +"  "+ "ISBNs  is "  + ISDNs[i]+" " + "Borrow name is  " +  borrowNames[i]+" " + "avaiability is  "  + bookAvailiabilityStatus[i];
                                    Console.WriteLine("list of book: = " + listOfBook[i]);
                                    bookF = true;

                                    break;

                                }

                            }
                        }

                        //output
                        if (bookF == false)
                        {
                            Console.WriteLine("sorry book not found");
                        }

                        else
                        {


                            Console.WriteLine("Thank you ");

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
                Console.WriteLine("Thank you for using the Library System, press any key");
                Console.ReadLine();
                Console.Clear();

            }
        }


    }
}
