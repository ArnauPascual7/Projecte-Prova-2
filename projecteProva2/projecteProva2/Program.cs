namespace projecteProva2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public static bool ValidPaswordLenght(string pass)
        {
            return pass.Length >= 5 && pass.Length <= 12;
        }
        public static bool ValidPasswordCharacters(string pass)
        {
            string validChar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            bool badChar = false;

            for (int i = 0; i < pass.Length; i++)
            {
                if (!(validChar.Contains(pass[i])))
                {
                    badChar = true;
                }
            }
            return badChar;
        }
    }
}