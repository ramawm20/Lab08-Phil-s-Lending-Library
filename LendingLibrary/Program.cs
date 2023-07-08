namespace LendingLibrary
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            Library library = new Library();
            library.Add("Clean Code", "Robert C.", "Martin", 464);
            library.Add("Introduction to the Theory of Computation", "Michael", "Sipser", 504);
            library.Add("Effective Java", "Joshua", "Bloch",416);
            library.Add("Python Crash Course: A Hands-On, Project-Based Introduction to Programming", "Eric", "Matthes", 544);
            library.Add("Programming Pearls", "jon", "Bently", 256);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@"
╔═╗┬ ┬┬┬  ┌─┐  ╦  ┬┌┐ ┬─┐┌─┐┬─┐┬ ┬
╠═╝├─┤││  └─┐  ║  │├┴┐├┬┘├─┤├┬┘└┬┘
╩  ┴ ┴┴┴─┘└─┘  ╩═╝┴└─┘┴└─┴ ┴┴└─ ┴ 
");
            Console.WriteLine("Welcome to our Library we offer you Great books in programming");
            Console.WriteLine();

            Visual(library);

        }
        public static void Visual(Library library)
        {
 
            while (true)
            {
                

                Console.WriteLine("How Can I help you??");
                Console.WriteLine(); 
                Console.WriteLine("1. Show me all books in The Library");
                Console.WriteLine("2. I want to borrow a book");
                Console.WriteLine("3. I want to return a book");
                Console.WriteLine("4. Nothing Bye");

                Console.WriteLine();

                string input = Console.ReadLine();
                Console.WriteLine(new string('-', 30)); // Horizontal line


                switch (input)
                {
                    case "1":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("The books we have in the library");
                        Console.WriteLine(new string('-', 70)); // Horizontal line

                        Console.WriteLine("{0,-10} {1,-50} {2,-30}", "Number", "Title", "Author");
                        Console.WriteLine(new string('-', 70)); // Horizontal line

                        int i = 1;
                        foreach (Book book in library)
                        {
                            Console.WriteLine("{0,-10} {1,-50} {2,-30}", i, book.Title, book.Author);
                            i++;
                        }

                        Console.WriteLine(new string('-', 70)); // Horizontal line


                        break;
                    case "2":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Enter the name of the Book you want to Borrow");
                        string userInput= Console.ReadLine();
                        Book Borrowed= library.Borrow(userInput);

                        if( Borrowed != null)
                        {
                            Console.WriteLine($"{Borrowed.Title} Book has been Borrowed, Come and take it ");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, The title you entered is not found, Have a nice day");
                        }

                        break;
                    case "3":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter the Title of the book you want to return and the Author");
                        Console.Write("Title : ");
                        string title = Console.ReadLine();
                        Console.Write("Author name : ");
                        string Author = Console.ReadLine();
                        Book returnedBook = new Book(title, Author);
                        library.Return(returnedBook);
                        Console.WriteLine("The Book has been returned, Have a nice Day");
                        
                        break;
                    case "4":
                        Console.ForegroundColor = ConsoleColor.DarkGreen;

                        Console.WriteLine("Bye Bye Come again");

                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;

                }
                Console.WriteLine();
                Console.WriteLine(new string('-', 30)); // Horizontal line
            }

       
        }
    }
}