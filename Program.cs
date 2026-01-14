using Microsoft.VisualBasic;
using System.ComponentModel.Design;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            string[] borrowNames = new string[100];
            string[] bookAuthers = new string[100];
            string[] bookCategories = new string[100];
            int[] borrowCount =new int [100];
            DateOnly[] returndate = new DateOnly[100];
            double[] lateFees = new double[100];
            int LastBookIndexTreacker = 0;


            //seed input

            titles[LastBookIndexTreacker] = "Math";
            ISBN[LastBookIndexTreacker] = "1111";
            bookAvailiabilityStatus[LastBookIndexTreacker] = true;
            borrowNames[LastBookIndexTreacker] = null;
            bookAuthers[LastBookIndexTreacker] = "Ali";
            bookCategories[LastBookIndexTreacker] = "Science";
            borrowCount[LastBookIndexTreacker] = 0;
            
            LastBookIndexTreacker++;


            titles[LastBookIndexTreacker] = "network";
            ISBN[LastBookIndexTreacker] = "2222";
            bookAvailiabilityStatus[LastBookIndexTreacker] = false;
            borrowNames[LastBookIndexTreacker] = "Ahmed";
            bookAuthers[LastBookIndexTreacker] = "Fatma";
            bookCategories[LastBookIndexTreacker] = "computer";
            borrowCount[LastBookIndexTreacker] = 2;
            
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
                Console.WriteLine("7. Search Books by Category");
                Console.WriteLine("8. View Most Popular Books");
                Console.WriteLine("9. calculating late fees ");
                Console.WriteLine("`10. Exit");
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
                        Console.Write("bookCategories: ");
                        bookCategories[LastBookIndexTreacker] = Console.ReadLine();

                        Console.WriteLine("Book added");









                        break;



                    case 2:
                        //Borrow book

                        Console.Write("Enter ISBN or Title: ");
                        string borrowInput = Console.ReadLine();

                        bool borrowFound = false;

                        for (int i = 0; i <= LastBookIndexTreacker; i++)
                        {
                            if (titles[i] == borrowInput ||ISBN[i] == borrowInput)
                            {
                                borrowFound = true;

                                if (bookAvailiabilityStatus[i] == true)
                                {
                                    Console.Write("Borrower name: ");
                                    borrowNames[i] = Console.ReadLine();
                                    bookAvailiabilityStatus[i] = false;
                                    borrowCount[i]++; 
                                    lateFees[i] = 0;

                                    Console.WriteLine("Book borrowed successfully!");
                                    Console.WriteLine("This book has been borrowed " + borrowCount[i] + " times"); 
                                }
                                else
                                {
                                    
                                    Console.WriteLine("Book already borrowed by: " + borrowNames[i]);
                                }

                                break;
                            }
                        }

                        if (borrowFound == false)
                        {
                            Console.WriteLine("Book not found");
                        }
                        break;

                    case 3:
                        //Return book
                        Console.Write("Enter ISBN or Title: ");
                        string returnInput = Console.ReadLine();

                        bool returnFound = false;
                        //for search book with following requiements
                        for (int i = 0; i <= LastBookIndexTreacker; i++)
                        {
                            if (titles[i] == returnInput || ISBN[i] == returnInput)
                            {
                                returnFound = true;
                                //if book borrowed

                                if (bookAvailiabilityStatus[i] == false) 
                                {
                                   
                                    Console.Write("Is the book returned late? (yes/no): "); 
                                    string isLate = Console.ReadLine();
                                    //if book not return on time
                                    if (isLate == "yes")
                                    {
                                        Console.Write("Enter number of days late: "); 
                                        int daysLate = int.Parse(Console.ReadLine());
                                        double feePerDay = 0.5;
                                        lateFees[i] = daysLate * feePerDay; 

                                        Console.WriteLine("Late fee calculated: " + lateFees[i] + " OMR"); 
                                    }
                                    else
                                    {
                                        Console.WriteLine("Book returned on time"); 
                                        lateFees[i] = 0;
                                    }

                                    borrowNames[i] = "";
                                    bookAvailiabilityStatus[i] = true;
                                    Console.WriteLine("Book returned successfully!");
                                }
                                else
                                {
                                    Console.WriteLine("This book was not borrowed");
                                }

                                break;
                            }
                        }

                        if (returnFound == false)
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
                                
                                FOUND = true;
                                Console.WriteLine("Book title: " + titles[i] + ", Book Author:" + bookAuthers[i] + ", Book ISBN:" + ISBN[i] + ", Book availability:" + bookAvailiabilityStatus[i] + ", bookCategories:" + bookCategories[LastBookIndexTreacker] );
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
                                //print all avaiable books with thier details
                                Console.WriteLine("Title: " + titles[i] + " Author: " + bookAuthers[i] + " ISBN: " + ISBN[i] + "bookCategories: " + bookCategories[LastBookIndexTreacker] );
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
                                Console.WriteLine("Transfer books done successfully" + "  " + "Frist borrow name:  " + borrowNames[secondBorrowerIndex] + " " + "Second borrow name:  " + borrowNames[firstBorrowerIndex]);
                            }
                        }


                        break;

                    case 7:
                        //Search Books by Category
                        Console.WriteLine("enter what book category you want:");
                        string Category = Console.ReadLine();

                        bool FOUND2 = false;
                        for (int i = 0; i <= LastBookIndexTreacker; i++)
                        {

                            if (bookCategories[i] == Category)
                            {

                                FOUND2 = true;
                                Console.WriteLine("Title: " + titles[i] + " ,Author: " + bookAuthers[i] + ", ISBN: " + ISBN[i] + ", Book availability:" + bookAvailiabilityStatus[i]);

                            }
                        }

                        if (FOUND2 == false)
                        {
                            Console.WriteLine("Category not found");
                        }


                        break;

                    case 8:
                        //View Most Popular Books
                        Console.WriteLine("Most Popular Books (by borrow count):");
                        

                       //for strat from highest borrow count 
                        for (int count = 100; count >= 0; count--) 
                        {
                            for (int i = 0; i <= LastBookIndexTreacker; i++)
                            {
                                if (borrowCount[i] == count)
                                {
                                    Console.WriteLine("ISBN: " + ISBN[i] + " | Title: " + titles[i] + " | Author: " + bookAuthers[i] + " | Category: " + bookCategories[i] + " | Times Borrowed: " + borrowCount[i]);
                                }
                            }
                        }

                        break;


                       
                    case 9:
                        //calculate late fees 
                        Console.WriteLine("Late Fees Report:");
                        Console.WriteLine("1. System-wide total");
                        Console.WriteLine("2. Individual borrower");
                        Console.Write("Choose option: ");
                        int feeOption = int.Parse(Console.ReadLine());

                        if (feeOption == 1)
                        {
                           //for sysyem option
                            double totalFees = 0;

                            for (int i = 0; i <= LastBookIndexTreacker; i++)
                            {
                                totalFees += lateFees[i];
                            }

                           
                            Console.WriteLine("Total late fees collected: " + totalFees + " OMR");
                        }
                        else if (feeOption == 2)
                        {
                            //for indiviual option
                            Console.Write("Enter borrower name: ");
                            string borrowerName = Console.ReadLine();

                            double borrowerFees = 0;
                            bool borrowerFoundForFees = false;

                            for (int i = 0; i <= LastBookIndexTreacker; i++)
                            {
                                if (borrowNames[i] == borrowerName || (borrowNames[i] == "" && lateFees[i] > 0))
                                {
                                    // for checking if this borrower had late fees
                                    borrowerFees += lateFees[i];
                                    borrowerFoundForFees = true;
                                }
                            }

                            
                            if (borrowerFoundForFees == true)
                            {
                                Console.WriteLine("Late fees for " + borrowerName + ": " + borrowerFees + " OMR");
                            }
                            else
                            {
                                Console.WriteLine("No late fees found for this borrower");
                            }
                        }

                        break;

                    case 10:
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
