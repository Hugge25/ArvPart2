using ArvPart2;


static void TG(string text)
{
    foreach(char c in text)
    {
        Console.Write(c);
        Thread.Sleep(50);
    }
    Console.WriteLine();
}

static void TGS(string text)
{
    foreach(char c in text)
    {
        Console.Write(c);
        Thread.Sleep(200);
    }
    Console.WriteLine();
}

TG("Hej, vad vill du ha för form? 1 eller 2");
Console.WriteLine("1. Rektangle");
Thread.Sleep(500);
Console.WriteLine("2. Triangle");
string Num = Console.ReadLine();
Shape shape =  null;
    switch(Num)
    {
        case "1":
            Console.WriteLine("Rektangle");
            TG("Ange den höjd och bredd du vill ha");
            shape = new Rectangle(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
 
            break;
        
        case "2":
            Console.WriteLine("Triangle");
            TG("Ange den höjd och bredd du vill ha");
            shape = new Triangle(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

            break;

        default:
            TGS("Ange 1 eller 2");
            break;
        
    }

    Console.WriteLine("Area: " + shape.Area());
    Console.WriteLine("Omkrets: " + shape.Circumferance());