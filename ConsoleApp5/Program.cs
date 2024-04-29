using ConsoleApp5.Entities;

Circle circle = new Circle();
Console.WriteLine(circle.CalculateArea());


Person person = new Person("Farid", "Ahadov", 25);
Console.WriteLine($"{person.name}, {person.surname}, {person.age}");

Car car = new Car("Mercedes", "CLS63", 2024);
Console.WriteLine($"{car.marka}, {car.model}, {car.istehsalIli}");

Book book = new Book("Chees", "Stefan Zweig", 98);
Console.WriteLine($"{book.name}, {book.writer}, {book.page}");