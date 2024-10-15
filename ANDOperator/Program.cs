//math >= 90; biology >= 90; chemestry >= 90;

int math, biology, chemistry;

Console.WriteLine("Enter you math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your biology result:");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your chemistry result:");
chemistry = Int32.Parse(Console.ReadLine());


if (math >= 90 && biology >= 90 && chemistry >= 90) 
{
    Console.WriteLine("Congratulations! You got accepted");
}
else
{
    Console.WriteLine("Your application cannot be approved.");
}
