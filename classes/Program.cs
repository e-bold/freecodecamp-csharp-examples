using classes_objects;

Book book1 = new Book("Harry Potter", "JK Rowling", 400);


Book book2 = new Book("Lord of The Rings", "Tolkein", 700);

book2.title ="Hobbit";

Book book3 = new Book();
book3.title = "Andrey Pushkin";

Console.WriteLine(book2.title);
Console.WriteLine(book2.author);
Console.WriteLine(book3.title);

