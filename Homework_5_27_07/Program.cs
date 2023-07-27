namespace Homework_5_27_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, enter string : ");

            string enterStr = Console.ReadLine();
            string repeatedWord = "";
            string helpWord = "";

            int repeatCount = 1;
            int maxRepeat = 1;

            for (int i = 0; i<enterStr.Length; i++)
            {
                for(int j = 1; j<enterStr.Length-i+1; j++)
                {
                    for (int k = 0; k<enterStr.Length-j; k++)
                    {
                        if (enterStr.Substring(i, j) == enterStr.Substring(k, j))
                        {
                            repeatCount++;
                        }

                    }

                    if( repeatedWord.Length < enterStr.Substring(i,j).Length)
                    {
                        maxRepeat = repeatCount;
                        repeatedWord = enterStr.Substring(i, j);
                    }

                    repeatCount=0;
                }
            }

            Console.WriteLine(maxRepeat);
            Console.WriteLine(repeatedWord);
        }
    }
}