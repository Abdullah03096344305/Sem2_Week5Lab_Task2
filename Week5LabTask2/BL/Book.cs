using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5LabTask2.BL
{
    class Book
    {
        public string Name;
        public string author;
        public int pages;
        public int bookMark;
        public int price;
        public string ChapterNo;
        public string chapterName;

        public Book(string Name,string author,int pages,int bookMark,int price,string ChapterNo)
        {
            this.Name = Name;
            this.author = author;
            this.pages = pages;
            this.bookMark = bookMark;
            this.price = price;
            this.ChapterNo = ChapterNo;
        }
        public void getChapters(List<Book> books)
        {
            for(int i = 0; i < books.Count; i++)
            {
                Console.WriteLine("Enter Name of the Chapter");
                string 
            }
        }


    }
}
