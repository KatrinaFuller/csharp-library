using System;
using System.Collections.Generic;

namespace csharp_library.Models
{
  public class Library
  {
    public string Location { get; set; }
    public string Name { get; set; }
    private List<Book> Books { get; set; }


    public void PrintBooks()
    {
      for (int i = 0; i < Books.Count; i++)
      {
        Console.WriteLine($"{i + 1} {Books[i].Title} - {Books[i].Author}");
      }
    }

    public void AddBook(Book book) //adds one
    {
      Books.Add(book);
    }


    public void AddBook(Book[] books) //adds multiple
    {
      Books.AddRange(books);
    }



    public Library(string location, string name)
    {
      Location = location;
      Name = name;
      Books = new List<Book>();
    }
  }
}