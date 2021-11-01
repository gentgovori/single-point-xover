// See https://aka.ms/new-console-template for more information

var P1 = "1234552";

var P2 = "1111987";

xover(P1, P2);

twopointxover(P1, P2);

uniformxover(P1, P2);

//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine("Generation " + i + " :");
//    //xover(P1, P2);
//    twopointxover(P1,P2);
//}

Console.ReadLine();

void xover (string p1, string p2)
{
    Console.WriteLine("----- One point cross-over -----\n");
    var rand = new Random();
    var randomPoint = rand.Next(0, Math.Max(p1.Length, p2.Length));

    Console.WriteLine("Parent P1 : " + p1);

    Console.WriteLine("Parent P2 : " + p2);

    Console.WriteLine("Crossover point is : " + randomPoint );

    var C1 = P1.Substring(0, randomPoint) + P2.Substring(randomPoint);

    var C2 = P2.Substring(0, randomPoint) + P1.Substring(randomPoint);

    Console.WriteLine("First child : "+C1 );
    Console.WriteLine("Second child : "+C2 +"\n");
}

void twopointxover (string p1, string p2)
    {

    Console.WriteLine("----- Two point cross-over -----\n");
    var rand = new Random();
    var j = rand.Next(1, Math.Max(p1.Length, p2.Length));
    var k = rand.Next(j, Math.Max(p1.Length, p2.Length));

    while (j==k)
    {
        if(j== Math.Max(p1.Length, p2.Length)-1)
        {
            j = rand.Next(1, Math.Max(p1.Length, p2.Length));
            k = rand.Next(j, Math.Max(p1.Length, p2.Length));
        }
        else
        {
            k = rand.Next(j, Math.Max(p1.Length, p2.Length));
        }
        
    }

    Console.WriteLine("Parent P1 : " + p1);

    Console.WriteLine("Parent P2 : " + p2);


    Console.WriteLine("First crossover point is : " + j);

    Console.WriteLine("Second crossover point is : " + k);

    var a = p1.Substring(0, j);
    var b = p2.Substring(j,k-j);
    var c = p1.Substring(k);

    var Child = a+b+c;

    Console.WriteLine("Generated child : "+Child+"\n");

}

void uniformxover( string p1,string p2)
{
    Console.WriteLine("----- Uniform cross-over -----\n");
    Console.WriteLine("Parent P1 : " + p1);

    Console.WriteLine("Parent P2 : " + p2);

    var p1Array = p1.ToArray();
    var p2Array = p2.ToArray();
    var rand = new Random();
    int [] randomArray  = new int [p1Array.Length];
    
    for (int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = rand.Next(1, 3);
    }
    char[] finalChild = new char[randomArray.Length];
    for (int i = 0; i < randomArray.Length; i++)
    {
        if (randomArray[i] == 1)
            finalChild[i] = p1Array[i];
        else
            finalChild[i] = p2Array[i];
    }
    Console.WriteLine("Random choices : [{0}]", String.Join(", ", randomArray));
    Console.WriteLine("Generated child : [{0}]",String.Join(", ", finalChild));

    //Array.ForEach(finalChild, Console.WriteLine);

}
