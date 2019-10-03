using System;
using csharp_library.Models;

namespace csharp_library
{
  class Program
  {
    static void Main(string[] args)
    {

      Console.WriteLine("Welcome to the Boise Library! \n");
      Console.WriteLine("--- Available Books ---");

      //   Book myBook = new Book();
      //   myBook.Author = "Shel Silverstein";
      //   myBook.Title = "Where the Sidewalk Ends";
      Book whereTheSidewalkEnds = new Book("Where the Sidewalk Ends", "Shel Silverstein");
      Book theHobbitt = new Book("The Hobbitt", "J.R.R. Tolkien");
      Book lww = new Book("The Lion, The Witch, and the Wardrobe", "C.S. Lewis");
      Book hp = new Book("Harry Potter and the Sorcerer's Stone", "J.K. Rowling");

      Library myLibrary = new Library("Boise", "Boise Library");
      myLibrary.AddBook(new Book[] { whereTheSidewalkEnds, theHobbitt, lww, hp }); //adding all the books from my library

      myLibrary.PrintBooks();

      Console.WriteLine("\n Select a book number to checkout (Q)uit, or (R)eturn a book");
    }
  }
}

