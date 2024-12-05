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
            int[] numbers = new int[5];

            FillArray(numbers);
            BubbleSort(numbers);
            PrintArray(numbers);
            SearchNum(numbers);
        }
        public static void FillArray(int[] arr)
        {
            const string MsgInputArray = "Introdueix el valor de la array de la posició ";
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(MsgInputArray + i);
                arr[i] = ReadUserInput();
            }
        }
        public static void BubbleSort(int[] arr)
        {
            for (int i = 0;i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int aux = arr[i];
                        arr[i] = arr[j];
                        arr[j] = aux;
                    }
                }
            }
        }
        public static void PrintArray(int[] arr)
        {
            const string Separation = " ";
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + Separation);
            }
            Console.WriteLine();
        }
        public static void SearchNum(int[] arr)
        {
            const string MsgInpSerchNum = "Introdueix el nombre a buscar:";
            const string MsgIsInArray = "El valor és dins de l'array";
            const string MsgIsNotInArray = "El valor NO és dins de l'array";

            Console.WriteLine(MsgInpSerchNum);
            int num = ReadUserInput();
            bool isInArray = IsInArray(arr, num);

            if (isInArray)
            {
                Console.WriteLine(MsgIsInArray);
            } else
            {
                Console.WriteLine(MsgIsNotInArray);
            }
        }
        public static bool IsInArray(int[] arr, int num)
        {
            return arr.Contains(num);
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