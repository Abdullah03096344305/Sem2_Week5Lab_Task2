using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Week5LabTask2.BL;
using System.Threading.Tasks;

namespace Week5LabTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            AddBook(books);
            DisplayBooks(books);
            Console.ReadKey();
        }

        static void AddBook(List<Book> books)
        {
            Console.WriteLine("Enter Name of the BOOK");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter Author of the BOOK");
            string author = Console.ReadLine();
            Console.WriteLine("Enter Total Pages of the BOOK");
            int pages = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter BOOK MARK");
            int bookMark = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Price of the BOOK");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter No of the Chapter");
            string ChapterNo = Console.ReadLine();
            Book book = new Book(Name, author, pages, bookMark, price, ChapterNo);
            books.Add(book);
        }
        static void DisplayBooks(List<Book> books)
        {
            Console.Clear();
            for(int i = 0;i < books.Count;i++)
            {
                Console.WriteLine((i + 1) + "  " + books[i].Name + "  " + books[i].author + "  " + books[i].pages + "  " + books[i].bookMark + "  " + books[i].price + "  " + books[i].ChapterNo);
            }
        }
    }
}
