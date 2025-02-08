
using System;
using System.Threading;

Menu();

static void Menu(){
    Console.Clear();
    Console.WriteLine("S = Segundos => 10s = 10 segundos");
    Console.WriteLine("M = Minutos => 1M = 1 minuto");
    Console.WriteLine("0 = Sair");
    Console.WriteLine("Quanto tempo deseja contar?");

    string date = Console.ReadLine().ToLower();
    char type = char.Parse(date.Substring(date.Length - 1, 1));
    int time = int.Parse(date.Substring(0, date.Length - 1));
    int multiplier = 1;

    if(type == 'm')
        multiplier = 60;
    
    if(time == 0)
        System.Environment.Exit(0);

    PreStart(time * multiplier);
}

static void PreStart(int time){
    Console.WriteLine("Ready...");
    Thread.Sleep(1500);
    Console.WriteLine("Set...");
    Thread.Sleep(1500);
    Console.WriteLine("Go...");
    Thread.Sleep(1000);

    Start(time);
}

static void Start(int time)
{
    int currentTime = 0;

    while (currentTime != time)
    {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);

        Thread.Sleep(1000);
    }

    Console.Clear();
    Console.WriteLine("StopWatch finalizado");
    Thread.Sleep(2500);
    Menu();
}