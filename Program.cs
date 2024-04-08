using System;
using System.Collections.Generic;

namespace Lesson9Ex3
{
    public class Book
    {
        public string Title { get; set; }
        public int Pages { get; set; }
        public int TimesRead { get; set; }
        public Book (string title, int pages, int timesRead)
        {
            Title = title;
            Pages = pages;
            TimesRead = timesRead;
        }
        public Book()
        {
            this.Title = string.Empty;
            this.Pages = 0;
            this.TimesRead = 0;
        }

        //Create a unary overloaded operator (+, -, !, ~, ++, – –)
        public static Book operator ++ (Book obj)
        {
            obj.TimesRead++;
            return obj;
        }
        //Create a comparison overloaded operator (==, !=, =, >, <) 
        public static bool operator > (Book obj1, Book obj2)
        {
            bool result = false;
            if (obj1.Pages > obj2.Pages)
                result = true;
            return result;
        }
        public static bool operator <(Book obj1, Book obj2)
        {
            bool result = false;
            if (obj1.Pages < obj2.Pages)
                result = true;
            return result;
        }
        //Create a binary overloaded operator (+, -, *, /, %) 
        public static Book operator + (Book obj1, Book obj2)
        {
            Book obj3 = new Book();
            obj3.TimesRead = obj1.TimesRead + obj2.TimesRead;
            return obj3;
        }

        //Your Main method should create at least 2 objects.
        static void Main(string[] args)
        {
            Book book1 = new Book("Stardust", 250, 2);
            Book book2 = new Book("When Women Were Dragons", 367, 1);

            Console.WriteLine("Starting stats for the book collection: \n");
            Console.WriteLine($"---Book 1---\nTitle: {book1.Title}; Page Count: {book1.Pages}; Times Read: {book1.TimesRead}");
            Console.WriteLine();
            Console.WriteLine($"---Book 2---\nTitle: {book2.Title}; Page Count: {book2.Pages}; Times Read: {book2.TimesRead}");
            Console.WriteLine();
            book1++;
            Console.WriteLine($"Increasing the amount {book1.Title} has been read...{book1.TimesRead}");
            Console.WriteLine($"{book1.Title} has now been read {book1.TimesRead} times.");

            Console.WriteLine($"True/False: Does {book1.Title} have more pages than {book2.Title}? {book1.Pages > book2.Pages}");
            Console.WriteLine($"The total number of readthroughs for all books is: {book1.TimesRead + book2.TimesRead}");
        }
        
    } //end class Book
} //end namespace