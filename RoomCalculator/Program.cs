//Intro
Console.WriteLine("Welcome to the Room Detail Generator!");
Console.WriteLine();

//Get length
Console.WriteLine("What is the room length?");
double length = double.Parse(Console.ReadLine());

//Get width
Console.WriteLine("What is the room width?");
double width = double.Parse(Console.ReadLine());

//Get height
Console.WriteLine("What is the room height?");
double height = double.Parse(Console.ReadLine());
Console.WriteLine();

//Calculations
double area = length * width;
double perimeter = length + length + width + width;
double volume = length * width * height;
double surface = area * perimeter;

//Display area and perimiter
Console.WriteLine("The area of the room is: " + area);
Console.WriteLine("The perimeter of the room is: " + perimeter);
Console.WriteLine("The volume of the room is: " + volume);
Console.WriteLine("The surface area of the room is: " + surface);
Console.WriteLine();

//Classification
if (area <= 250) {
    Console.WriteLine("This house is small.");
}
else if (area > 250 && area < 650) {
    Console.WriteLine("This house is medium.");
}
else if (area >= 650) {
Console.WriteLine("This house is large.");
}