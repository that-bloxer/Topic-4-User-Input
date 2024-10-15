int age;
double price;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Enter Your Age: ");
Console.WriteLine(Int32.TryParse(Console.ReadLine(), out age));
Console.WriteLine("Your age is " + age);
Console.ReadLine();
Console.WriteLine("What is the price?");