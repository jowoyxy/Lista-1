using System;

class Program
{
    static void Main()
    {
        int xpA, xpInimigo1, derrotados1, xpInimigos2, derrotados2, constante, xpTotal, level;

        Console.WriteLine("Quanto de Xp você tem acumulado?");
        int.TryParse(Console.ReadLine(), out xpA);
        System.Console.WriteLine("Quanto é o Xp do inimigo?");
        int.TryParse(Console.ReadLine(), out xpInimigo1);
        System.Console.WriteLine("Quantos foram derrotados?");
        int.TryParse(Console.ReadLine(), out derrotados1);

        System.Console.WriteLine("Quanto é o Xp dos segundos inimigos derrotados?");
        int.TryParse(Console.ReadLine(), out xpInimigos2);
        System.Console.WriteLine("Quantos foram derrotados?");
        int.TryParse(Console.ReadLine(), out derrotados2);
        System.Console.WriteLine("Qual a constante de Nível?");
        int.TryParse(Console.ReadLine(), out constante);

        xpTotal = xpA + (xpInimigo1 * derrotados1) + (xpInimigos2 * derrotados2);
        level = xpTotal / constante ;

        Console.Clear();
        

        System.Console.WriteLine("Seu XP total é: " + xpTotal + "\n" +
        "Seu nível é: " + level);

        System.Console.WriteLine("Aperte ENTER para fechar");
        Console.ReadLine();
    }
}