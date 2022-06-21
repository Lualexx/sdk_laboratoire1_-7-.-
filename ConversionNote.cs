namespace ConversionNote
{

    public class ConversionNote
    {

        public string Formateur(string str)
        {
            string strReturnValue = string.Empty;
            switch (str.ToLowerInvariant())
            {
                case "a";
                    strReturnValue = "LA";
                    break;
                case "b";
                    strReturnValue = "SI";
                    break;
                case "c";
                    strReturnValue = "DO";
                    break;
                case "d";
                    strReturnValue = "RE";
                    break;
                case "e";
                    strReturnValue = "MI";
                    break;
                case "f";
                    strReturnValue = "FA";
                    break;
                case "g"
                    strReturnValue = "SOL";
                    break;
            }

        }
    }

}




/*
String s = new String('C', 'Do');
Console.WriteLine("The initial string: '{0}'", s);
s = s.Replace('C', 'X').Replace('X', 'Y').Replace('Y', 'Do');
Console.WriteLine("The final string: '{0}'", s);





string Note = "C";
Console.WriteLine("Original: {0}", Note);
string remplacer = Note.Replace("C", "DO");
Console.WriteLine("Remplacer: {0}", remplacer);
// O caracteres


 
            Console.WriteLine(input);
            String str = "C";
            Console.WriteLine("Old String: " + str);

            // chain together
            str = str.Replace('C', 'Y').Replace('Y', 'Z').Replace('Z', 'D');
            Console.WriteLine("New string: " + str);
            Console.ReadLine(); 



 */