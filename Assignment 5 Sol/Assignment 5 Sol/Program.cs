using System;
using System.Text;

namespace Assignment_5_Sol
{
    class Program
    {
        public static void Swap(ref int X, ref int Y)
        {
            int Temp = X;
            X = Y;
            Y = Temp;
        }

        public static int ArraySum(ref int [] Arr)
        {
            int Sum = 0;
            Arr = new int[] { 4, 5, 6 };
            if(Arr != null)
            { 
                for (int i = 0; i < Arr.Length; i++)
                    Sum += Arr[i];
            }
            return Sum;
        }

        public static void SumAndSub(int X, int Y, int Z , int K , out int Sum , out int Sub )
        {
            Sum = X + Y;
            Sub = Z - K;
        }

        public static int DigitsSum(int Num)
        {
            int Digit, Sum = 0;
            while(Num > 0)
            {
                Digit = Num % 10;
                Sum += Digit;
                Num /= 10;
            }
            return Sum;
        }

        public static bool PrimeNum(int Num)
        {
            for (int i = 2; i< Num; i++)
            {
                if (Num % i == 0)
                    return false; 
            }
            return true;
        }

        public static void MinMaxArray(ref int[] Arr, ref int Min, ref int Max)
        {
             Min = Arr[0];
             Max = Arr[0];

            foreach(int element in Arr)
            {
                if (element < Min)
                    Min = element;
                if (element > Max)
                    Max = element; 
            }
        }

        public static int Factorial(int Num)
        {
            int Fact = 1;
            while (Num > 0)
            {
                Fact *= Num;
                Num--;
            }
            return Fact;
        }

        public static void ChangeChar(ref string STR, ref int pos , ref char CHR)
        {
            string ss = new string("");
            for(int i = 0; i < STR.Length; i++)
            {
                if (i + 1 == pos)
                    ss += CHR;
                else
                    ss += STR[i];
            }
            STR = ss;
        }
        static void Main(string[] args)
        {
            #region Q1 - Value Type parameters
            //int a = 10, b = 20;
            ////Console.WriteLine("a: " + a + " b: " + b);

            ////Swap(a, b); // by value // a,b act as input parameters only 

            ////Console.WriteLine("a: " + a + " b: " + b); // Swapping isn't Occurred (a,b are passed by value not reference , the values of X, Y in Function itself will be swapped not a,b as a,b values only were passed to the function not the object itself


            //Console.WriteLine("a: " + a + " b: " + b);
            //Swap(ref a, ref b); // br ref // a,b acts as input and output paramters, as a,b itself were passed to the function so a,b are the same of x,y but with different name
            //Console.WriteLine("a: " + a + " b: " + b);
            #endregion

            #region Q2 - Reference Type parameters
            //By Value
            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(Numbers[0]);
            //int Result = ArraySum(Numbers); // by value
            //                                // Address of Numbers
            //                                // Numbers = Arr
            //Console.WriteLine(Result);
            //Console.WriteLine(Numbers[0]); // the new Object of Arr only Changed not the Numbers 

            ////By Ref
            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(Numbers[0]);
            //int Result = ArraySum(ref Numbers); // by ref
            //                                    // Array itself
            //Console.WriteLine(Result);
            //Console.WriteLine(Numbers[0]); // the change occurred to the array itself as it's passed itself by different name so they are the same thing 


            //the Diff if we create new object and change in the parameter
            // by value --> it will not change
            // by Reference-- > it will be change
            #endregion

            #region Q3 - Summation & Subtraction
            //Console.Write("Please Enter A: ");
            //int A, B, C, D , SUM, SUB;
            //int.TryParse(Console.ReadLine(),out A);

            //Console.Write("Please Enter B: ");
            //int.TryParse(Console.ReadLine(), out B);

            //Console.Write("Please Enter C: ");
            //int.TryParse(Console.ReadLine(), out C);

            //Console.Write("Please Enter D: ");
            //int.TryParse(Console.ReadLine(), out D);

            //SumAndSub(A, B, C, D, out SUM, out SUB);

            //Console.WriteLine($"The Sum = {SUM}");
            //Console.WriteLine($"The Sub = {SUB}");


            #endregion

            #region Q4 - Sum Of Numbers Digits
            //Console.Write("Please Enter a Number: ");
            //int Num;
            //int.TryParse(Console.ReadLine(), out Num);

            //int Res = DigitsSum(Num);
            //Console.WriteLine($"The Sum of Digits = {Res}");
            #endregion

            #region Q5 - Prime or Not
            //Console.Write("Please Enter a Number: ");
            //int Num;
            //int.TryParse(Console.ReadLine(), out Num);

            //bool flag = PrimeNum(Num);
            //if (flag)
            //    Console.WriteLine($"The {Num} is Prime.");
            //else
            //    Console.WriteLine($"The {Num} is not Prime.");
            #endregion

            #region Q6 - MinMaxArray
            //int Size;
            //Console.Write("Please Enter The Size of Array: ");
            //int.TryParse(Console.ReadLine(), out Size);
            //int[] Array = new int[Size];
            //for(int i = 0; i < Size; i++ )
            //{
            //    Console.Write($"Enter the {i + 1} element: ");
            //    int.TryParse(Console.ReadLine(), out Array[i]);
            //}
            //int MIN = 0, MAX = 0;
            //MinMaxArray(ref Array, ref MIN, ref MAX);
            //Console.WriteLine($"The Minimum Element in Array: {MIN}");
            //Console.WriteLine($"The Maximum Element in Array: {MAX}");

            #endregion

            #region Q7 - Factorial
            //Console.Write("Please Enter a Number: ");
            //int Num;
            //int.TryParse(Console.ReadLine(), out Num);
            //int Res = Factorial(Num);
            //Console.WriteLine($"The Factorial of Number {Num} = {Res}");
            #endregion

            #region Q8 - Change Char
            //Console.Write("Please Enter a string: ");
            //string Str;
            //Str = Console.ReadLine();

            //Console.Write("Please Enter a Char Position to be Changed: ");
            //int Pos;
            //int.TryParse(Console.ReadLine(), out Pos);

            //Console.Write("Please Enter a Char to replace with: ");
            //char chr;
            //char.TryParse(Console.ReadLine(), out chr);

            //ChangeChar(ref Str, ref Pos, ref chr);

            //Console.WriteLine($"The String After Changing Char at pos {Pos} : {Str}");

            #endregion
            Console.ReadKey();
        }

    }
}
