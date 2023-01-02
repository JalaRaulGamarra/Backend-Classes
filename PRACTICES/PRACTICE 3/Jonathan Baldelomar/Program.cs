using JalasoftDevLevel1TerceraPractica;

BookManager<Book> bookManager = new BookManager<Book>();
Comic comic = new Comic("Chris Claremont", "X-Men: Days of Future Past", 321, "Fiction", "English", true, "", 75, 300);
bookManager.addBook(comic);

Essay essay = new Essay("Sun Tzu", "The Art of War", 213, "Self-help", "English", false, "Jonathan", 50, 200);
bookManager.addBook(comic);

Novel novel = new Novel("Stephenie Meyer", "Twilight", 123, "Fantasy", "English", true, "", 100, 100);
bookManager.addBook(comic);

bookManager.lendBook(comic, "Jonathan");
bookManager.lendBook(essay, "Jonathan");

bookManager.removeBook(novel);