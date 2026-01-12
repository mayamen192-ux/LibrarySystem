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
                        Console.WriteLine("Enter title or ISDN of book:");
                        String keyBook2= Console.ReadLine();
                        Console.WriteLine("Enter return name of the book"); 
                        string returnBook = Console.ReadLine(); 
                        bool bookFound2 = false;

                        for (int i = 0; i < titles.Length; i++)
                        {
                            if (keyBook2 == titles[i] && !bookAvailiabilityStatus[i])
                            {
                                if (borrowNames[i] == returnBook)
                                {
                                    bookAvailiabilityStatus[i] = true;
                                    borrowNames[i] = null;
                                    bookFound2 = true;
                                    
                                }
                                else
                                {
                                    Console.WriteLine("his book was borrowed by someone else.");
                                }
                                break;
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
                        //transfer book operation
                        Console.WriteLine("Enter isbn of book for first person:");
                        String fISBN= Console.ReadLine();
                        Console.WriteLine("Enter isbn of book for second person");
                        String sISBN = Console.ReadLine();

                        bool firstFound = false;
                        int currentBorrow = -1;
                        string temp = " ";

                        for (int i = 0; i < 100; i++)
                        {
                            if (fISBN == ISDNs[i])
                            {
                                currentBorrow = i;
                                firstFound = true;
                                break;
                            }
                        }
                        if (firstFound == false)
                        {
                            Console.WriteLine("first book not found");
                        }
                        else
                        {
                            bool secondFound = false;
                            int secondBorrow = -1;
                            for (int i = 0; i < 100; i++)
                            {
                                if (sISBN == ISDNs[i])
                                {
                                    secondBorrow = i;
                                    secondFound = true;
                                    break;
                                }
                            }
                            if (secondFound == false)
                            {
                                Console.WriteLine("second book not found");
                            }
                            else
                            {
                                temp = ISDNs[currentBorrow]; 
                                ISDNs[currentBorrow] = ISDNs[secondBorrow]; 
                                ISDNs[secondBorrow] = temp;

                                Console.WriteLine(" transfer successfully  " + temp);
                            }
                           


                }
                        

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
