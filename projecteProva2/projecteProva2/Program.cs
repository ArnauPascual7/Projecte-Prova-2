namespace projecteProva2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ProgramCore();
        }
        public static void ProgramCore()
        {
            int[] arr = { 10, -4, 6, 4, 8, 13, 2, -4 };
            bool inArray = SearchNum(arr);

            Console.WriteLine("Està a la array: " + inArray);
            PrintArray(arr);
        }
        public static bool SearchNum(int[] arr)
        {
            const string MsgInpSerchNum = "Introdueix el nombre a buscar:";

            Console.WriteLine(MsgInpSerchNum);
            int num = ReadUserInput();
            int arrPosition = 0;
            
            SortArray(arr);
            arrPosition = ex2_llibreries.SearchClass.BinarySearch(arr, 0, arr.Length-1, num);

            if (arrPosition == -1)
            {
                return false;
            } else if (num == arr[arrPosition])
            {
                return true;
            }
            return false;
        }
        public static void SortArray(int[] arr)
        {
            ex2_llibreries.SecondSort.Order(arr, 0, arr.Length - 1);
        }
        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public static int ReadUserInput()
        {
            const string ErrException = "ERROR INESPERAT: Valor mal introduït";

            int num = 0;

            try
            {
                num = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine(ErrException);
                num = 1;
            }
            return num;
        }
    }
}