namespace ConversionAphabetiqueToNote
{
    public class ConversionAphabetiqueToNote
    {
        public string Format(string str)

        {
            string strReturnValue = string.Empty;
            switch (str.ToLowerInvariant())
            {
                case "a":
                    strReturnValue = "La";
                        break;
                case "b":
                    strReturnValue = "Si";
                        break;
                case "c":
                    strReturnValue = "Do";
                        break;
                case "d":
                    strReturnValue = "Re";
                        break;
                case "e":
                    strReturnValue = "Mi";
                        break;
                case "f":
                    strReturnValue = "Fa";
                        break;
                case "g":
                    strReturnValue = "Sol";
                        break;

            }
            return strReturnValue;
            
           
        }
        public string NoReturn(string str)
        {
            return "";
        }
    }
}




