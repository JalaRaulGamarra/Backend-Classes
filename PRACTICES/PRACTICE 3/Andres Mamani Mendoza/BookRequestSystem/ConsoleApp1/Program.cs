// See https://aka.ms/new-console-template for more information
using System.Text;
using System;
using System.Collections.Generic;
using Controller;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello Mono World");
        
        LibraryManager lManager = new LibraryManager();

        


        bool conditional = true;
        while (conditional == true)
        {
            Console.WriteLine("*********Welcome to Library*********");
            Console.WriteLine("Por favor, digite una opcion)");
            Console.WriteLine("1. Aniadir Libro.\n2. Eliminar Libro. \n3. Rentar Libro. \n4. Devolver Libro. \n5. Listar Libros. \n0. salir");
            string opcion;
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    AddBook();
                    break;
                case "2":
                    RemoveBook();
                    break;
                case "3":
                    LendABook();
                    break;
                case "4":
                    PrintBook();
                    break;
                case "0":
                    Console.WriteLine("saliendo");
                    conditional = false;
                    break;
                    //default:
                    //    Console.WriteLine("opcion invalida");
                    //    continue;
            }
        };
        
        
        Book LoadBookAttributes(string genre) { 
            Book newBook = new();

            Console.WriteLine("Name");
            newBook.Name = Console.ReadLine();
            Console.WriteLine("Author");
            newBook.Author = Console.ReadLine();
            newBook.Genre = genre;
            newBook.Status = true;
            Console.WriteLine("libraryCode");
            int num;
            string stringInput;
            stringInput = Console.ReadLine();
            while (!int.TryParse(stringInput, out num))
            {
                Console.WriteLine("Try library code");
                stringInput = Console.ReadLine();
            }
            newBook.LibraryCode = num;
            Console.WriteLine("lenderName");
            newBook.LenderName = Console.ReadLine();
            Console.WriteLine("priceOfPurchase");

            double num1;
            string stringInput1;
            stringInput1 = Console.ReadLine();
            while (!double.TryParse(stringInput1, out num1))
            {
                Console.WriteLine("Try priceOfPurchase, solo puede contener numeros naturales o numeros con decimales separados por comas.");
                stringInput1 = Console.ReadLine();
            }

            newBook.PriceOfPurchase = num1;
            Console.WriteLine(newBook.PriceOfPurchase);
            Console.WriteLine("isbnNumber");
            newBook.ISBNNumber = Console.ReadLine();

            return newBook;
        }

        void AddBook(){ 
            Console.WriteLine("Seleccione una Categoria \n 1. Novels\n2. Essays\n3. Comics");
            bool conditional = true;
            while (conditional == true)
            {
                string input;
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Novels");
                        try
                        {
                            Book Novelbook = LoadBookAttributes("Novels");
                            lManager.AddBook(Novelbook);
                            Console.WriteLine($"Libro Creado satisfactoriamente");
                        }
                        catch(Exception ex)
                        { 
                            Console.WriteLine($"Libro ya existe {ex.Message}");
                        }
                        conditional = false;
                        break;
                    case "2":
                        Console.WriteLine("Essays");
                        try
                        {
                            Book essaylbook = LoadBookAttributes("Essays");
                            lManager.AddBook(essaylbook);
                            Console.WriteLine($"essay book Creado satisfactoriamente");

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"essay book ya existe {ex.Message}");
                        }
                        conditional = false;
                        break;

                    case "3":
                        Console.WriteLine("Comics");
                        try
                        {
                            Book Comicbook = LoadBookAttributes("Comics");
                            lManager.AddBook(Comicbook);
                            Console.WriteLine($"Comic book Creado satisfactoriamente");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Comic book ya existe {ex.Message}");
                        }
                        conditional = false;
                        break;

                    case "0":
                        Console.WriteLine("Saliendo");
                        conditional = false;
                        break;

                }
            }
        }


        void RemoveBook() {
            Console.WriteLine("Por favor escriba el numero ISBN de libro a eliminar.");

            string ISBNNumber;
            ISBNNumber = Console.ReadLine();

            conditional = true;
            while (conditional == true) {
                if (!lManager.VerifyBookIfExist(ISBNNumber))
                {
                    Console.WriteLine("Book not exist.");
                    break;
                };
                if (lManager.VerifyBookIfAvailable(ISBNNumber))
                {
                    lManager.RemoveBook(ISBNNumber);
                    Console.WriteLine("Book was eliminated");
                    
                    break;
                };
            }
        };

        void LendABook() {
            bool conditional2 = true;
            while (conditional2 == true)
            {
                Console.WriteLine("Por favor escriba el numero ISBN de libro que quiera prestarse.");

                Console.WriteLine("ISBN Number");
                string ISBNNumber;
                ISBNNumber = Console.ReadLine();

                bool conditional = true;
                while (conditional == true)
                {
                    if (!lManager.VerifyBookIfExist(ISBNNumber))
                    {
                        Console.WriteLine("Book not exist.");
                        break;
                    };
                    if (!lManager.VerifyBookIfAvailable(ISBNNumber))
                    {
                        Console.WriteLine("Book is not avaliable");
                        break;
                    }

                    Book book = lManager.GetBook(ISBNNumber);
                    double priceBook = book.PriceOfPurchase;

                    Console.WriteLine($"El precio para el prestamo es: {priceBook}");
                    string inputprice;
                    inputprice = Console.ReadLine();


                    if (inputprice != lManager.GetBook(ISBNNumber).PriceOfPurchase.ToString())
                    {

                        Console.WriteLine($"El precio de prestamo es {priceBook}, intente nuevamente.");
                    }
                    else
                    {
                        Console.WriteLine("Lender Name");
                        string lenderName;
                        lenderName = Console.ReadLine();
                        Book lendbook = new()
                        {
                            Status = false,
                            LenderName = lenderName
                        };
                        lManager.LendABook(lendbook);
                        Console.WriteLine("Prestamo exitoso.");
                        conditional = false;
                        conditional2 = false;
                        break;
                    };
                }

            }
        }


        void PrintBook() {
            //no se hizo el call a la funcion
            Console.WriteLine("Lista De libros");
        }
    }
}