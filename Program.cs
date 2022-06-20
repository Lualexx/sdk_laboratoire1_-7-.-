
using System;
using ConversionAphabetiqueToNote;

while (true)
{
    Console.WriteLine("\t\t\t\t\t\tConvertiseur alphabetique! ");
    Console.WriteLine("\n\t\t\t\t\t\t\t A = La ");
    Console.WriteLine("\n\t\t\t\t\t\t\t B = Si ");
    Console.WriteLine("\n\t\t\t\t\t\t\t C = Do ");
    Console.WriteLine("\n\t\t\t\t\t\t\t D = Re ");
    Console.WriteLine("\n\t\t\t\t\t\t\t E = Mi ");
    Console.WriteLine("\n\t\t\t\t\t\t\t F = Fa ");
    Console.WriteLine("\n\t\t\t\t\t\t\t G = Sol ");
    Console.WriteLine("\n\t\t\t\t\t\tCliquer 'Enter' pour commencer");
    var imput = Console.ReadLine();
    if (imput?.ToUpperInvariant() == "Note");
    {
        while (true)
        {
            Console.Write("\n\t\t\t\t\t\tEcrivez votre choix: ");
            ConsoleKeyInfo keyPress = Console.ReadKey(intercept: true);
            string strValeurPress = keyPress.KeyChar.ToString();
            ConversionAphabetiqueToNote.ConversionAphabetiqueToNote catn = new ConversionAphabetiqueToNote.ConversionAphabetiqueToNote();
            string note = catn.Format(strValeurPress);
            Console.WriteLine($"\n\n\t\t\t\t\t\t\tNote: {note}");
            

        }

   
    }

}


