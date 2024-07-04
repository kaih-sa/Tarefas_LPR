// Ask for a help qith this one
// Do menor pro maior e não pode repetir tamanho, quando precisar muda de linha
using System;
using System.Collections.Generic;
class ex1
{
    static void Main()
    {
        int option;
        List<string> names = new();
        Console.Write("How many names will there be: ");
        option = int.Parse(Console.ReadLine());
        for (int p = 0; p < option; p++) 
        {
            Console.Write("Write the name: ");
            string name = Console.ReadLine();
            names.Add(name);
        }

        names.Sort();
        int i = 0;
        int k = i + 1;
        for (; i < option ;i++) 
        {
            if (k > option) k=0;
            int aa = names[i].Length;
            int bb = names[k].Length;
            if (aa > bb) 
            {
                names.Remove(names[k]);
                names.Add(names[k]);
            };
            Console.WriteLine(names[i]);

        }

    }
}