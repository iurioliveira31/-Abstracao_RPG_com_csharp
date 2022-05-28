using System;
using DOTNET_RON.src.Entities;

{
 class Program
    {
        static void Main(string[] args)
        {
            Arus hero = new Arus("Arus", 23, "Knigh");
            hero.name = "Arus";
            hero.Level = 2;
            hero.HeroType = "Knight";
        
            Console.Write(hero);
        }

    }
}