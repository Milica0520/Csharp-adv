﻿using Exercise2.Models;

namespace Exercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>
            {
                new Book { Id = 1, Title = "1984", Author = "George Orwell", Year = 1949 },
                new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", Year = 1960 },
                new Book { Id = 3, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Year = 1925 },
                new Book { Id = 4, Title = "One Hundred Years of Solitude", Author = "Gabriel Garcia Marquez", Year = 1967 },
                new Book { Id = 5, Title = "Brave New World", Author = "Aldous Huxley", Year = 1932 },
                new Book { Id = 6, Title = "Moby-Dick", Author = "Herman Melville", Year = 1851 },
                new Book { Id = 7, Title = "War and Peace", Author = "Leo Tolstoy", Year = 1869 },
                new Book { Id = 8, Title = "Pride and Prejudice", Author = "Jane Austen", Year = 1813 },
                new Book { Id = 9, Title = "The Catcher in the Rye", Author = "J.D. Salinger", Year = 1951 },
                new Book { Id = 10, Title = "Crime and Punishment", Author = "Fyodor Dostoevsky", Year = 1866 }
            };
            //
            List<Book> bokksByGeorgeOrwell = books
                .Where(book => book.Author == "George Orwell")
                .ToList();

            foreach (Book item in bokksByGeorgeOrwell)
            {
                Console.WriteLine(item.GetBookInfo());
            }
            //
             Book moreRecentBook = books
                .OrderByDescending(book => book.Year)
                .FirstOrDefault();

            Console.WriteLine($"The most recent book is {moreRecentBook}");

            //
            List<Book> booksBydescending = books
                .OrderByDescending(book => book.Title)
                .ToList();

            foreach (Book item in booksBydescending)
            {
                Console.WriteLine(item.GetBookInfo());
            }
        }
    }
}
