namespace LibrarieConversionNote
{
    public class ConversionAphabetiqueToNote
    {
        static void Main(string[] arg)

        {



            
            Console.WriteLine(input);
            String str = "C";
            Console.WriteLine("Old String: " + str);

            // chain together
            str = str.Replace('C', 'Y').Replace('Y', 'Z').Replace('Z', 'D');
            Console.WriteLine("New string: " + str);
            Console.ReadLine(); 





        }
    }
}










    /*
    String s = new String('C', 'Do');
    Console.WriteLine("The initial string: '{0}'", s);
    s = s.Replace('C', 'X').Replace('X', 'Y').Replace('Y', 'Do');
    Console.WriteLine("The final string: '{0}'", s);

    
    char note1 = "C";
    string changement = char.Parse(note1);
{
    Console.WriteLine("Ecris un note");
    String Note = Parse(Console.ReadLine());
    Console.WriteLine(Note1);




    string Note = "C";
    Console.WriteLine("Original: {0}", Note);
    string remplacer = Note.Replace("C", "DO");
    Console.WriteLine("Remplacer: {0}", remplacer);
// O caracteres

   


}
    }
}
     */