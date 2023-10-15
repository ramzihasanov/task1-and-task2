namespace ConsoleApp1
{
    internal class Program
    {

        static (int, int) SumOfTheOddAndEven(int[] array)
        {
            int SumEven = 0, SumOdd = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    SumEven += array[i];
                }
                else
                {
                    SumOdd += array[i];
                }
            }
            return (SumEven, SumOdd);
        }


        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            (int sumEven, int sumOdd)tuple = SumOfTheOddAndEven(numbers);

            Console.WriteLine("Cut ededlerin cemi : " + tuple.sumEven);
            Console.WriteLine("Tek ededlerin cemi : " +tuple.sumOdd);

        }
    }



}