using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRabstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            String title = Console.ReadLine();
            String author = Console.ReadLine();
            int price = Int32.Parse(Console.ReadLine());
            Book new_novel = new MyBook(title, author, price);
            new_novel.display();
        }
    }
    abstract class Book
    {
        protected String title;
        protected  String author;
    
        public Book(String t,String a){
            title=t;
            author=a;
        }
        public abstract void display();


    }
    class MyBook : Book
    {
        private int price;
        //constructor
       public MyBook(string t, string a, int p): base(t,a){
            this.price = p;
        }

       public override void display()
       {
         Console.WriteLine("Title: "+this.title);
         Console.WriteLine("Author: "+this.author);
         Console.WriteLine("Price: " + this.price);
       }

    }
}
