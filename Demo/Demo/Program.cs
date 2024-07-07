using System;

namespace Demo
{
    class Program
    {
        // public static void PrintShape(int count = 10, string Pattern ) // not valid , you must put the default values in the last parameters not in the first to avoid errors occurred in calling functions
        //public static void PrintShape(int count= 10, string Pattern="*_*")
        //{
        //    for (int i =0 ; i< count ; i++)
        //    {
        //        Console.WriteLine(Pattern);
        //    }
        //}

        //public static void Swap(ref int X, ref int Y)
        //{
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}

        //public static int ArraySum(params int[] Arr) // params is the last paramaters // params are resting elements in parameter
        //{
        //    int Sum = 0;
        //    if (Arr != null)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //            Sum += Arr[i];
        //    }
        //    return Sum;
        //}

        //public static void SumMul(int X, int Y, ref  int Sum ,ref  int Mul)
        //{
        //    Sum = X + Y;
        //    Mul = X * Y;
        //}
        static void Main(string[] args)
        {
            #region Boxing & UnBoxing Casting
            //// Boxing => from Value Type to Reference Type
            //object Obj1;
            //Obj1 = "Somaya"; // Casting ==> from reference type to reference type
            //Obj1 = 1; // Boxing Casting ==> from Reference Type to Value Type
            //Obj1 = 'A'; // Boxing Casting ==> from Reference Type to Value Type 
            //Obj1 = new Point(); // Casting ==> from reference type to reference type

            //int X = 10;
            //object NewObj = X; // Boxing (Value Type To Reference Type)   ==> Safe Casting equals this line ( object NewObj = new object(10); )
            //                   // child => Parent 
            //                   // int --> Child  , object --> Parent , there is no problem:  Child(int) is a Parent(object) 
            //                   // Assign Operator works from right to left 
            //                   // Child has a reference from Parent --> Boxing


            //object NewObj2 = 10;
            //int Y = (int) NewObj2; // UnBoxing Casting (Unsafe Casting), we need to cast it Explicitly 
            //// new object(10) --> 10 // from heap to Stack (reference to Value only) UnBoxing
            //// (Child) Parent => Child  (Parent is a child) 
            //// Parent has a reference from Child ,in Condition that Parent Must be a Child

            //Object strObj = "Somaya";
            //int Z = (int)strObj;
            //Console.WriteLine(Z);   // it throw an invalid Exception when it casting convert it implicitly 


            //// When To Use Boxing & UnBoxing Casting
            //// We Use Boxing when we use Object Class As a Generic
            //Object o = 5; // Boxing : Value Type --> Referenece Type
            //              // After Using Generic Templates, we avoid Using Boxing & UnBoxing because of High time and memory used during Casting

            //// Using Generic, The memory used can't be allocated before assigning value , according value assigned to Generic, the Memory will be allocated for this type
            //// Using Object, The Memory Allocated as a Reference for this Object Before Assigning, then after assigning, Boxing  or unboxing will be occurred so it take more time and more memory
            //// So we Avoid Using These Types Of Casting when using DataBase
            #endregion

            #region Nullable Type [Value Type C# 2.0]
            //// data type can be null
            //// Null as a value is valid only for Reference Type 
            //// int X = null; invalid [X can only has integer values not null]
            //int? X = null; // valid as Nullable Type can hold int + null
            //X = 3; // valid 

            //int? A = null;
            //int B = 10;
            ////int? C = A; // valid
            ////int? C = B; //valid // Synatx Sugar for Nullable Type
            ////int? C = Nullable<int> C; // Generic Struct for Nullable Types 

            ////decimal Num1 = 1.1M;
            ////decimal? Num2 = Num1; // valid Nullable --> decimal + Null

            ////decimal? Num1;
            ////decimal Num2 = Num1; // invalid [decimal only allows decimal not null]

            ////int x = 5;
            ////int? y = /* (int?) */ x; // valid implicit casting [safe casting]

            ////int? x = null;
            ////int y = (int)x; // invalid without explicit casting [unsafe casting]  , it can throw exception
            ////                // we can solve the warning for this type of casting if value = null
            ////                // using project properties , we can change <Nullable> Disable </Nullable> to delete this warning from .net 8
            ////                // Throw Exception when x = null
            ////                // so we must check the value of x before casting using the following lines:


            ////1.
            //int? k = null;
            //int l;
            ////l = (int) k; // invalid
            //if (k != null)
            //    l = (int)k; // Casting
            //else
            //    l = 0; 


            ////2. 
            //// Nullable type has propereties .hasvalue (true , false) , .value --> return nullable type value [for only nullable type]
            //if(k.HasValue)
            //    l = k.Value; // not Casting
            //else
            //    l = 0;


            ////3. Using Ternary Operator
            //l = (k.HasValue) ? k.Value : 0;
            //l = (k!= null ) ? (int)k: 0;

            #endregion

            #region Nullable Type [Reference Type] Compiler Enhancement
            ////// Null is default type of reference type
            //////string Message; // = string Message = null; == string Message = default; but with warning because string is nonNullable 
            ////// to delete null use null forginveness operator
            //////Message = null! ;
            ////// but we can use Nullable String
            ////string? Message = null; // valid without warning

            //// Using User Defined Class
            //Employee E1 = new Employee(); // FName = "" , LName = null;
            //// the difference between NonNullable String and Nullable string 
            //// NonNullable String accept null (Reference Type) with warning so , use Null Forgiveness String (!) to delete this warning
            //// Nullable String accept null without Warning
            //string NotNull = "hello";
            //string? Nullable = default; // = Null
            //// Nullable = NotNull; // Valid
            //// NotNull = Nullable! ;  // Valid with Warning // use Null Forgiveness Operator

            #endregion

            #region Null Propagation Operator [?]

            //int x = default; // x = 0 as it value type
            //int[] numbers = default;   // null [reference type]

            //// to print elements in array
            //foreach (int num in numbers) // throw Exception [NullReference Exception] , as this array may be have no elements, it is still reference to Null
            //    Console.WriteLine(num);  // the same for for loop as foreach loop

            //// how to handle this Exception --> 
            //// 1. use 2 conditions in for loop ( numbers != null) && (i < numbers.length)
            //// use Logical Operator && not Bitwise Operator because in Logical operator if the first condition is false it will break without check the second condition
            //// but in Bitwise Operator, it will continue if the first condition is Null so there will be warning

            //for (int i = 0; ((numbers != null) && (i < numbers.Length)); i++)
            //    Console.WriteLine(numbers[i]);

            //// 2. Using Null Propagation Operator
            //// i < numbers?.length  --> if numbers is null --> numbers?.length = null , else numbers?.length = length 
            //// it will not throw exception but this condition will be checked each time in loop

            //for (int i = 0; i < numbers?.Length; i++)
            //    Console.WriteLine(numbers[i]);

            //// so we will check before loop
            //if (numbers != null) // it's better than using Null Propagation Operator
            //{
            //    for (int i = 0; i < numbers.Length; i++)
            //        Console.WriteLine(numbers[i]);
            //}

            //// ? Null Propagating Operator , if the result is null-> it will not propagate to get the next value

            //// ?? Null Coleasing Opeartor , if the result is null -> it will propagate to get the next value to replace the old value with the next value

            //// 3. Using Null Coleasing Operator ??
            //int Length = numbers?.Length ?? 0;

            //// when it's better to use Null Propagartion Operator only
            //// 1. with the data from Database (with relations)
            //Employee Em = new Employee();
            //// Fname ="" , Lname = null , Department = null
            //// print the name of department
            //// if Em is null , if Department is null to avoid to avoid null reference Exception
            //if (Em != null)
            //{
            //    if(Em.Department != null)
            //    {
            //        Console.WriteLine(Em.Department.Name);
            //    }
            //}
            //// Or Use ?
            //Console.WriteLine(Em?.Department?.Name ?? "Department not Found");

            //Em.Department = new Departments();
            //// code = , name = null
            //Em.Department.Name = "it"; // not null 
            //Console.WriteLine(Em?.Department?.Name ?? "Department not Found"); // using it better without looping, but in looping it's better to use if condtions

            #endregion

            #region Functions
            //// in NameSpace, we can write Class, Interface, Enum, Struct [each of them can contain functions]
            //// 1. Class Member Function [static Function] --> calling by it class name
            //// 2. Object Member Function [Non Static Function] --> must have object from class to call it
            ////PrintShape(10, "*_*");
            ////PrintShape(Pattern: "*_*", count: 10);
            ////PrintShape(); // valid as there is default value
            ////Console.WriteLine("Hello To Route \n Welcome \tSomaya");
            //// \n ==>newline
            //// \t ==> tab space

            //// print path
            //// string Path = @"E:\Route Backend .net\02 - C# Basics\Session 05 (2-7-2024)\Session 05";
            ////string Path = @"E:\\Route Backend .net\\02 - C# Basics\\Session 05 (2-7-2024)\\Session 05";
            //// Skip ==> \\ or @ before string
            //// @ ==> Skip any reserved characters /n /t 

            //PrintShape(Pattern: @"/*\", count: 10);

            #endregion

            #region Passing Parameters

            #region Value Type Parameters
            //int a = 10, b = 20;
            ////Console.WriteLine("a: " + a+ " b: " + b);
            ////Swap(a, b); // by value // a,b act as input parameters only
            ////Console.WriteLine("a: " + a+ " b: " + b); // Swapping isn't Occurred (a,b are passed by value not reference , the values of X, Y in Function itself will be swapped not a,b
            //Console.WriteLine("a: " + a+ " b: " + b);
            //Swap(ref a , ref b); // br ref // a,b acts as input and output paramters
            //Console.WriteLine("a: " + a+ " b: " + b);
            #endregion

            #region Reference Type Parameters
            #region Passing by Value

            ////int[] Numbers = { 1, 2, 3 };
            //int[] Numbers = null;
            ////Console.WriteLine(Numbers[0]); // 1
            //int Total = ArraySum(Numbers); // By Value
            //Console.WriteLine(Total);
            ////Console.WriteLine(Numbers[0]); // 100 as array is refernce type the argument that passed to the function in calling is the Variable itself
            #endregion
            #region Passing By ref
            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(Numbers[0]);
            //int Total = ArraySum(ref Numbers); // Passing by ref , Array itself will be passed
            //Console.WriteLine(Total);
            //Console.WriteLine(Numbers[0]);
            #endregion

            #region Diff Between Passing By ref & Value

            //By Value
            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(Numbers[0]);
            //int Result = ArraySum(Numbers); // by value
            //                                // Address of Numbers
            //                                // Numbers = Arr
            //Console.WriteLine(Result);
            //Console.WriteLine(Numbers[0]); // the new Object of Arr only Changed not the Numbers 

            // By Ref
            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(Numbers[0]);
            //int Result = ArraySum(ref Numbers); // by ref
            //                                // Array itself
            //Console.WriteLine(Result);
            //Console.WriteLine(Numbers[0]); // the change occurred to the array itself as it's passed itself by different name so they are the same thing 


            // the Diff if we create new object and change in the parameter
            // by value --> it will not change
            // by Reference --> it will be change

            #endregion
            #endregion

            #region Out Parameters
            //int A = 10, B = 20,  SRes=0,  MRes=0;
            ////SumMul(10, 20, out SRes, out MRes); //  by value
            //SumMul(10, 20, ref  SRes, ref  MRes); //  by ref ==> must be initialized
            //// out ==> output Parameters
            //// Ref --> output & input Parameters
            //Console.WriteLine(SRes);
            //Console.WriteLine(MRes);
            #endregion

            #region passing Params
            //int total = ArraySum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            //Console.WriteLine(total);
            #endregion
            #endregion



            Console.ReadKey();

        }
    }
}