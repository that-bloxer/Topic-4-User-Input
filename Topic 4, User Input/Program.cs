int age;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Enter Your Age: ");
Int32.TryParse(Console.ReadLine(), out age);
Console.WriteLine("Your age is " + age);
Console.ReadLine();
