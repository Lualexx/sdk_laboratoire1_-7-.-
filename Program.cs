using ConversionNote;

while (true)
{
    Console.Write("conversion a faire :");
    var input = Console.ReadLine();
    if (input?.ToUpperInvariant() == "NOTE")
    {
        while (true)
        {

            Console.Write("convertiseur de note:");
            ConsoleKeyInfo keyPress = Console.ReadKey(intercept: true);
            string strValeurPresser = keyPress.KeyChar.ToString();
            ConversionNote.ConversionNote cn = new ConversionNote.ConversionNote();
            string note = cn.Formateur(strValeurPresser);
            Console.WriteLine($"Note : {note}");

        }
    }




}



/*

namespace _1.SDK_Laboratoire1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\t\tConvertiseur alphabetique! ");
            Console.WriteLine("\n\t\t\t\t\t\t\t A = La ");
            Console.WriteLine("\n\t\t\t\t\t\t\t B = Si ");
            Console.WriteLine("\n\t\t\t\t\t\t\t C = Do ");
            Console.WriteLine("\n\t\t\t\t\t\t\t D = Re ");
            Console.WriteLine("\n\t\t\t\t\t\t\t E = Mi ");
            Console.WriteLine("\n\t\t\t\t\t\t\t F = Fa ");
            Console.WriteLine("\n\t\t\t\t\t\t\t G = Sol ");
            Console.Write("\n\t\t\t\t\t\tEcrire votre choix: ");
            string choix = Console.ReadLine();
            var input = Console.ReadLine();
            Console.WriteLine("\t\t\t\t\t\tTu as choisi: " + choix);



        }
    }
}