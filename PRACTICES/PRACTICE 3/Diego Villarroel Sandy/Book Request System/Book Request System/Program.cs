using Book_Request_System;
using System.ComponentModel;

BookManager<Books> bookstotest = new BookManager<Books>();
Novel UnderTheDome = new Novel() ;
Novel Mist = new Novel();
bookstotest.AddBook(UnderTheDome);
bookstotest.AddBook(Mist);
bookstotest.PrintNovels();

bookstotest.LendBook(Mist, "Diego");

bookstotest.LendBook(Mist,"Diego");
