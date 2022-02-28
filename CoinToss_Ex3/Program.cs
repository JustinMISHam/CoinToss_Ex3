

string message;
string userPick;
double numCorrect = 0;
double numWrong = 0;
double numNA = 0;
double counter = 0;
double TotalPoint = 0;



for (;counter<10 ;counter++ )
{


    message = String.Format($"Q{counter+1} Take a guess Heads, Tails, or NA (H,T,N)? ");
    Console.Write(message);
    userPick = Console.ReadLine();

    Random rnd = new Random();
    int correctAnsw = rnd.Next(1, 3);
    //head: 1 tail:2

    if ((userPick.ToLower()=="heads" || userPick.ToLower()== "head" || userPick.ToLower()=="h") && correctAnsw==1)
    {
        TotalPoint = TotalPoint + 3;
        numCorrect++;
        Console.WriteLine("Correct!");
        Console.WriteLine("Correct answer: Heads");
    }
    else if ((userPick.ToLower() == "tails" || userPick.ToLower() == "tail" || userPick.ToLower() == "t") && correctAnsw == 2)
    {
        numCorrect++;
        TotalPoint = TotalPoint + 3;
        Console.WriteLine("Correct!");
        Console.WriteLine("Correct answer: Tails");
    }

    if ((userPick.ToLower() == "tails" || userPick.ToLower() == "tail" || userPick.ToLower() == "t") && correctAnsw == 1)
    {
        numWrong++;
        TotalPoint = TotalPoint - 5;
        Console.WriteLine("InCorrect!");
        Console.WriteLine("Correct answer: Heads");
    }
    else if ((userPick.ToLower() == "heads" || userPick.ToLower() == "head" || userPick.ToLower() == "h") && correctAnsw == 2)
    {
        numWrong++;
        TotalPoint = TotalPoint - 5;
        Console.WriteLine("InCorrect!");
        Console.WriteLine("Correct answer: Tails");
    }
    else if (userPick.ToLower() == "n" && correctAnsw == 1)
    {
        TotalPoint = TotalPoint - 1;
        numNA++;
        Console.WriteLine("Your answer: NA");
        Console.WriteLine("Correct answer: Heads");
    }
    else if (userPick.ToLower() == "n" && correctAnsw == 2)
    {
        TotalPoint = TotalPoint - 1;
        numNA++;
        Console.WriteLine("Your answer: NA");
        Console.WriteLine("Correct answer: Tails");
    }
}

message = String.Format($"Correct Percentage: {numCorrect / 10:P2}");
Console.WriteLine(message);
message = String.Format($"Incorrect Percentage: {numWrong/10:P2}");
Console.WriteLine(message);
message = String.Format($"No Answer Percentage: {numNA/10:P2}");
Console.WriteLine(message);

if (TotalPoint > 0)
{
    Console.WriteLine("Congratulations!");
    Console.WriteLine(TotalPoint);
}
else if (TotalPoint < 0)
{
    Console.WriteLine("Sorry! Better Luck Next Time!");
    message = String.Format($"Your Final Score: {TotalPoint}");
    Console.WriteLine(message);
}

