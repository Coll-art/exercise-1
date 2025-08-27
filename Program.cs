/* ~~~~~~~~~~~ Exercise 1: Swapping Variables ~~~~~~~~~~~ */
int a = 1;
int b = 2;
Console.WriteLine($"a:{a}b:{b}");
int temp = a;
 a = b;
 b = temp;
Console.WriteLine($"a:{a}b:{b}");
var name = "Daryle";
var age = 10;
var hometown = "smithfield";
string intro = $"{name} is from {hometown} and is {age} years old";
Console.WriteLine($"intro:{intro}");
double celsius = 50.4;
double fahr = 122.72;
string tempconvertion = $"{celsius} degrees Celsius is equivalent to {fahr} degrees Fahrenheit.";
Console.WriteLine($"tempconvertion:{tempconvertion}");
double width = 19.1;
double height = 18.2;
double perimeter = 74.6;
double area = 347.62;
string Rectangle = $"The Rectangle is width {width} and height {height}. its perimeter is {perimeter} and the area is {area}.";
Console.WriteLine($"Rectangle:{Rectangle}");
int num = 1;
double num2 = 1.1;
char letter = 'a';
bool trueorfalse = true;
string text = "text";
Console.WriteLine($"num value {num} type {num.GetType()}");
Console.WriteLine($"num2 value {num2} type {num2.GetType()}");
Console.WriteLine($"letter value {letter} type {letter.GetType()}");
Console.WriteLine($"trueorfalse value {trueorfalse} type {trueorfalse.GetType()}");
Console.WriteLine($"text value {text} type {text.GetType()}");


