using System.ComponentModel.Design;
using System.Data;

namespace LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sorted input
            string[] titles = new string[100];
            string[] ISBN = new string[100];
            bool[] bookAvailiabilityStatus = new bool[100];
            String[] borrowNames = new string[100];
            String[] bookAuthers = new string[100];
            int LastBookIndexTreacker = 0;


            //seed input

            titles[LastBookIndexTreacker] = "Math";
            ISBN[LastBookIndexTreacker] = "1111";
            bookAvailiabilityStatus[LastBookIndexTreacker] = true;
            borrowNames[LastBookIndexTreacker] = null;
            bookAuthers[LastBookIndexTreacker] = "Ali";
            LastBookIndexTreacker++;


            titles[LastBookIndexTreacker] = "English";
            ISBN[LastBookIndexTreacker] = "2222";
            bookAvailiabilityStatus[LastBookIndexTreacker] = false;
            borrowNames[LastBookIndexTreacker] = "Ahmed";
            bookAuthers[LastBookIndexTreacker] = "Fatma";
            LastBookIndexTreacker++;



            bool exit = false;
            while (exit == false)
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
                        LastBookIndexTreacker++;

                        Console.Write("Title: ");
                        titles[LastBookIndexTreacker] = Console.ReadLine();
                        Console.Write("Author: ");
                        bookAuthers[LastBookIndexTreacker] = Console.ReadLine();
                        Console.Write("ISBN: ");
                        ISBN[LastBookIndexTreacker] = Console.ReadLine();
                        bookAvailiabilityStatus[LastBookIndexTreacker] = true;
                        borrowNames[LastBookIndexTreacker] = "";
                        Console.WriteLine("Book added");








                        break;



                    case 2:
                        //Borrow book

                        Console.Write("Enter ISBN or Title: ");
                        string Input = Console.ReadLine();
                        
                        
                        
                        bool Found = false;
                        for (int i = 0; i <= LastBookIndexTreacker; i++)
                        {
                            if (titles[i] == Input || ISBN[i] == Input)
                            {
                              
                                Found = true;
                                if (bookAvailiabilityStatus[i] == true)
                                {
                                    Console.Write("Borrower name: ");
                                    borrowNames[i] = Console.ReadLine();
                                    bookAvailiabilityStatus[i] = false;
                                    Console.WriteLine("Book borrowed successfully");
                                }
                                else
                                {
                                    Console.WriteLine("Book already borrowed");
                                }
                                break;
                            }
                        }
                        if (Found == false)
                        {
                            Console.WriteLine("Book not found");
                        }

                        break;

                    case 3:
                        //Return book
                        Console.Write("Enter ISBN or Title: ");
                        string input = Console.ReadLine();
                        bool found = false;
                        for (int i = 0; i <= LastBookIndexTreacker; i++)
                        {
                            if (titles[i] == input || ISBN[i] == input)
                            {
                                //book is found in system
                                found = true;
                                borrowNames[i] = "";
                                bookAvailiabilityStatus[i] = true;
                                Console.WriteLine("Book returned successfully");

                                break;
                            }
                        }
                        if (found == false)
                        {
                            Console.WriteLine("Book not found");
                        }

                        break;
                    case 4:
                        //Search book
                        Console.Write("Enter ISBN or Title: ");
                        string INPUT = Console.ReadLine();
                        bool FOUND = false;
                        for (int i = 0; i <= LastBookIndexTreacker; i++)
                        {
                            if (titles[i] == INPUT || ISBN[i] == INPUT)
                            {
                                //book is found in system
                                FOUND = true;
                                Console.WriteLine("Book title: " + titles[i] + ", Book Author:" + bookAuthers[i] + ", Book ISBN:" + ISBN[i] + ", Book availability:" + bookAvailiabilityStatus[i]);
                                break;
                            }
                        }
                        if (FOUND == false)
                        {
                            Console.WriteLine("Book not found");
                        }


                        break;

                    case 5:
                        //List all available books

                        Console.WriteLine("Available Books:");
                        for (int i = 0; i <= LastBookIndexTreacker; i++)
                        {
                            if (bookAvailiabilityStatus[i] == true)
                            {
                                Console.WriteLine("Title: " + titles[i] + " Author: " + bookAuthers[i] + " ISBN: " + ISBN[i]);
                            }
                        }

                        break;
                    
                    case 6:
                        //transfer book operation
                        Console.Write("Enter first borrower name:");
                        string firstBorrower = Console.ReadLine();
                        Console.Write("Enter second borrower name:");
                        string secondBorrower = Console.ReadLine();
                        bool firstBorrowerFound = false;
                        int firstBorrowerIndex = 0;
                        for (int i = 0; i <= LastBookIndexTreacker; i++)
                        {
                            if (firstBorrower == borrowNames[i])
                            {
                                firstBorrowerIndex = i; 
                                firstBorrowerFound = true;
                                break;
                            }
                        }
                        if (firstBorrowerFound == false)
                        {
                            Console.WriteLine("current borrower name not found");
                        }
                        else
                        {
                            bool secondBorrowerFound = false;
                            int secondBorrowerIndex = 0;
                            for (int i = 0; i < 100; i++)
                            {
                                if (secondBorrower == borrowNames[i])
                                {
                                    secondBorrowerIndex = i;
                                    secondBorrowerFound = true;
                                    break;
                                }
                            }
                            if (secondBorrowerFound == false)
                            {
                                Console.WriteLine("New borrower name not found");
                            }
                            else
                            {
                                string temp = "";
                                temp = borrowNames[firstBorrowerIndex];
                                borrowNames[firstBorrowerIndex] = borrowNames[secondBorrowerIndex];
                                borrowNames[secondBorrowerIndex] = temp;
                            }
                        }


                        break;



                    case 7:
                        Console.WriteLine("Exiting program...");
                        Console.WriteLine("-----------------------------");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                Console.WriteLine("Thank you for using the Library System, press any key");
                Console.ReadLine();
                Console.Clear();

            }
        }


    }
}
