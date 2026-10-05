/*
* Name: Dalton Carr
* Course: CSCI 1250, Section 001
* Assignment: Lab 03, The Badge Office
* Date: September 30, 2026
* Description: Builds a student badge from a name, two random assignments,
* and the walking distance to a first class.
*/


Random rng =  new Random();




// Ask for the user's full name
Console.WriteLine("What is your Full Name?");
string fullname = Console.ReadLine() ?? "";

// convert the user's input 
fullname = fullname.Trim(); // Remove any leading or trailing whitespace

// Find the first space
int spaceposition = fullname.IndexOf(" ");

// Split the name
string firstname = fullname.Substring(0, spaceposition);
string lastname = fullname.Substring(spaceposition + 1);

// Generate student ID and locker
int studentID = rng.Next(100000, 999999);
int locker = rng.Next(1, 500);

// Walk Info
Console.Write("Dorm X: ");
double dormX = double.Parse(Console.ReadLine() ?? "0");

Console.Write("Dorm Y: ");
double dormY = double.Parse(Console.ReadLine() ?? "0");

Console.Write("Classroom X: ");
double classroomX = double.Parse(Console.ReadLine() ?? "0");

Console.Write("Classroom Y: ");
double classroomY = double.Parse(Console.ReadLine() ?? "0");

Console.Write("Walking speed (feet per second): ");
double walkingSpeed = double.Parse(Console.ReadLine() ?? "0");

double distance = Math.Sqrt(
    Math.Pow(classroomX - dormX, 2) + 
    Math.Pow(classroomY - dormY, 2)
); 

distance = Math.Round(distance, 1);

double totalSecondsDecimal = distance / walkingSpeed;
int totalSeconds = (int)totalSecondsDecimal;

int minutes = totalSeconds / 60;
int seconds = totalSeconds % 60;

// Create username and check digit
string username = (firstname.Substring(0, 1) + lastname).ToLower();
string displayname = (firstname + " " + lastname).ToUpper(); 
int checkDigit = studentID % 9;

// display the badge information
Console.WriteLine("=================================");
Console.WriteLine("       ETSU STUDENT BADGE");
Console.WriteLine("=================================");

Console.WriteLine($"{"NAME".PadRight(10)}{displayname}");
Console.WriteLine($"{"USERNAME".PadRight(10)}{username}");
Console.WriteLine($"{"ID".PadRight(10)}{studentID}-{checkDigit}");
Console.WriteLine($"{"LOCKER".PadRight(10)}{locker}");
Console.WriteLine($"{"WALK".PadRight(10)}{minutes} min {seconds} sec");

Console.WriteLine("=================================");
