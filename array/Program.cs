using System;
namespace ArrayDemo;

class Program
{
    public static void Main(String[] args)
    {
        Employee emp1 = new Employee() { Id = 30, Name = "Rajesh" };
        Employee emp2 = new Employee() { Id = 40, Name = "Rajesh" };
        Employee emp3 = new Employee() { Id = 50, Name = "Rajesh" };
        Employee emp4 = new Employee() { Id = 60, Name = "Rajesh" };
        Employee emp5 = new Employee() { Id = 70, Name = "Rajesh" };

        Employee[] employeeList = new Employee[5];
        employeeList[0] = emp1;
        employeeList[1] = emp2;
        employeeList[2] = emp3;
        employeeList[3] = emp4;
        employeeList[4] = emp5;

        Console.WriteLine("Before Sorting ");
        foreach (Employee e in employeeList)
        {
            Console.WriteLine(e);
        }
        Array.Sort(employeeList);

        Console.WriteLine("After Sorting ");
        foreach (Employee e in employeeList)
        {
            Console.WriteLine(e);
        }


        Console.WriteLine("\n\n\n");


        int[] arr = new int[6] { 50, 20, 40, 30, 10, 60 };




        // Console.WriteLine($"Arr is fixed {arr.IsFixedSize}");
        // Console.WriteLine($"Arr is ReadOnly {arr.IsReadOnly}");
        // Console.WriteLine($"Arr's Rank {arr.Rank}");
        // Console.WriteLine($"\n\n\n");
        // Console.WriteLine($"Before Sorting:");
        // for (int i = 0; i < arr.Length; i++)
        // {

        //     Console.Write(arr[i] + " ");
        // }

        // Console.WriteLine($"After Sorting:");

        // Array.Sort(arr);//
        // for (int i = 0; i < arr.Length; i++)
        // {
        //     Console.Write(arr[i] + " ");
        // }
        // Console.WriteLine();
        // Console.WriteLine($"\n\n\n");





        // Console.WriteLine($"Before Reversing:");
        // for (int i = 0; i < arr.Length; i++)
        // {

        //     Console.Write(arr[i] + " ");
        // }
        // Console.WriteLine($"After Reversing:");
        // Array.Reverse(arr);//

        // for (int i = 0; i < arr.Length; i++)
        // {

        //     Console.Write(arr[i] + " ");
        // }






        Program pg = new Program();
        Employee emp = new Employee
        {
            Id = 90,
            Name = "Manu"
        };
        pg.PassObject(emp);

        Employee emp6 = pg.ReturnObject();
        Console.WriteLine(emp6);

        pg.PassArrayObject(employeeList);


    }
    public void PassObject(Employee employee)
    {
        Console.WriteLine(employee);
    }

    public Employee ReturnObject()
    {
        Employee employee = new Employee
        {
            Id = 20,
            Name = "kundan"
        };

        return employee;
    }


    public void PassArrayObject(Employee[] employee)
    {
        foreach (Employee e in employee)
        {
            Console.WriteLine(e);
        }
    }




    // Program obj = new Program();
    // Other obj2 = new Other();
    // obj2.Func();
    // int[] krr = obj.ReturnArr(4);
    // for (int i = 0; i < krr.Length; i++)
    // {
    //     Console.WriteLine($"Element at index:{i} is {krr[i]}");
    // }


    // int[] brr = obj.Program3();
    // for(int i = 0; i < brr.Length; i++)
    // {
    //     Console.WriteLine($"element at index {i} is: {brr[i]}");
    // }

    // obj.Problem8();






    // int[] arr = new int[6]; // declaration + initialization
    // arr = new int[] {10, 20, 30, 40, 50, 60};
    // int length = arr.Length;                 // property need no parentheesis
    // int length = arr.GetLength(0);
    // Console.WriteLine($"Length of array is: {length}");

    // foreach(int i in arr)
    // {
    //     Console.WriteLine($"Element is {i}");
    // }

    // reading input
    // int[] brr;
    // Console.WriteLine($"Enter size of brr");
    // int len = int.Parse(Console.ReadLine());
    // brr = new int[len];

    // for (int i = 0; i < brr.Length; i++)
    // {
    //     Console.WriteLine($"Enter element at index:{i}");
    //     brr[i] = int.Parse(Console.ReadLine());
    // }

    // foreach (int i in brr)
    // {
    //     Console.WriteLine($"Element is {i}");
    // }


    // character array
    // char[] ch = { 'a', 'e', 'i', 'o', 'u', '\0' }; // brute

    // char[] bh = new char[5];
    // for(int i = 0; i < bh.Length; i++)
    // {
    //     Console.WriteLine($"Enter element at index:{i}");
    //     bh[i] = Convert.ToChar(Console.ReadLine());
    // }

    // foreach(char i in bh)
    // {
    //     Console.WriteLine($"Element is {i}");
    // }


    // string[] empName = new string[3];
    // Console.WriteLine($"Enter Employee Details:");

    // for(int i = 0; i < empName.Length; i++)
    // {
    //     empName[i] = Console.ReadLine();
    // }

    // Console.WriteLine("Employees names are:");
    // foreach(var i in empName)
    // {
    //     Console.WriteLine(i);








    //     public int[] ReturnArr(int length)
    // {
    //     int[] arr = new int[length];
    //     Console.WriteLine($"Enter {length} number of elements");
    //     for(int i = 0; i < arr.Length; i++)
    //     {
    //         arr[i] = int.Parse(Console.ReadLine());
    //     }
    //     return arr;
    // }




    // 2d Array
    //     public void Print2DArray(){ 
    //     int[,] arr = new int[3,3];

    //     arr[0, 0] = 1;
    //     arr[0, 1] = 2;
    //     arr[0, 2] = 3;

    //     arr[1, 0] = 4;
    //     arr[1, 1] = 5;
    //     arr[1, 2] = 6;

    //     arr[2, 0] = 7;
    //     arr[2, 1] = 8;
    //     arr[2, 2] = 9;

    //   for(int i = 0; i < arr.GetLength(0); i++)
    //         {
    //             for(int j = 0; j < arr.GetLength(1); j++)
    //             {
    //                 Console.WriteLine($"Value at index: {i},{j} is: {arr[i,j]}");
    //             }
    //         }

    //     }




    //      public void Print2DArray2()
    //     {
    //         int row =0;
    //         int col =0;

    //         Console.WriteLine($"Enter number of rows");
    //         row = int.Parse(Console.ReadLine());

    //         Console.WriteLine($"Enter number of columns");
    //         col = int.Parse(Console.ReadLine());

    //         int [,] arr = new int[row,col];

    //         for(int i = 0; i < row; i++)
    //         {
    //             for(int j=0; j<col; j++)
    //             {
    //                 arr[i,j] = int.Parse(Console.ReadLine());
    //             }
    //         }
    //         // Console.ReadLine();

    //         Console.WriteLine($"Array elements are:");

    //         for(int i = 0; i < row; i++)
    //         {
    //             for(int j = 0; j < col; j++)
    //             {
    //                 Console.WriteLine($"Elements of {i},{j} is: {arr[i,j]}");
    //             }
    //         }



    // }


    // public void Program2()
    //     {
    //         int num;
    //         Console.WriteLine($"Enter size of array");
    //         num = int.Parse(Console.ReadLine());
    //         int[] arr = new int[num];

    //         Console.WriteLine($"Enter array elements:");
    //         for(int i = arr.Length-1; i >= 0; i--)
    //         {

    //             arr[i] = int.Parse(Console.ReadLine());
    //         }
    //         Console.WriteLine($"Reversed array:");
    //         for(int i = 0; i < arr.Length; i++)
    //         {
    //             Console.WriteLine($"Element at index: {i} is: {arr[i]}");
    //         }
    //     }








    public int[] Program3()
    {
        int num;
        Console.WriteLine($"Enter size of array");
        num = int.Parse(Console.ReadLine());
        int[] arr = new int[num];

        Console.WriteLine($"Enter array elements:");
        for (int i = 0; i < arr.Length; i++)
        {

            arr[i] = int.Parse(Console.ReadLine());
        }
        return arr;


    }

    public void Progam4()
    {
        int num;
        Console.WriteLine($"Enter size of array:");
        num = int.Parse(Console.ReadLine());
        int[] arr = new int[num];

        Console.WriteLine($"Enter array elements:");
        for (int i = 0; i < arr.Length; i++)
        {

            arr[i] = int.Parse(Console.ReadLine());
        }
        int freq = 0;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    freq++;
                }
            }

        }

        Console.WriteLine($"No of Dublicates are:{freq}");
    }



    public void Progam5()
    {
        int num;
        Console.WriteLine($"Enter size of array:");
        num = int.Parse(Console.ReadLine());
        int[] arr = new int[num];

        Console.WriteLine($"Enter array elements:");
        for (int i = 0; i < arr.Length; i++)
        {

            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"Unique Elements are:");
        bool flag = false;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                if (i != j && arr[i] == arr[j]) // dublicate
                {
                    flag = true; // flag change 
                    break;
                }
            }
            if (flag == false)
            {
                Console.Write($"{arr[i]} ");
            }
            flag = false;

        }


    }





    public void Progam7()
    {
        int num1;
        Console.WriteLine($"Enter size of array:");
        num1 = int.Parse(Console.ReadLine());
        int[] arr = new int[num1];

        Console.WriteLine($"Enter array elements:");
        for (int i = 0; i < arr.Length; i++)
        {

            arr[i] = int.Parse(Console.ReadLine());
        }




        int num2;
        Console.WriteLine($"Enter size of array:");
        num2 = int.Parse(Console.ReadLine());
        int[] brr = new int[num2];

        Console.WriteLine($"Enter array elements:");
        for (int z = 0; z < brr.Length; z++)
        {

            brr[z] = int.Parse(Console.ReadLine());
        }

        int i1 = 0, j1 = 0, k = 0;
        int len = arr.Length + brr.Length;
        int[] crr = new int[len];
        while (i1 < arr.Length && j1 < brr.Length)
        {
            if (arr[i1] >= brr[j1])
            {
                crr[k++] = arr[i1++];

            }
            else if (arr[i1] <= brr[j1])
            {
                crr[k++] = brr[j1++];

            }
        }

        while (i1 < arr.Length)
            crr[k++] = arr[i1++];

        while (j1 < brr.Length)
            crr[k++] = brr[j1++];

        Console.WriteLine("Output after merging:");
        for (int m = 0; m < crr.Length; m++)
        {
            Console.WriteLine(crr[m]);
        }

    }


    public void Problem8()
    {
        int num1;
        Console.WriteLine($"Enter size of array:");
        num1 = int.Parse(Console.ReadLine());
        int[] arr = new int[num1];

        Console.WriteLine($"Enter array elements:");
        for (int i = 0; i < arr.Length; i++)
        {

            arr[i] = int.Parse(Console.ReadLine());
        }

        bool[] visited = new bool[num1];
        for (int i = 0; i < arr.Length; i++)
        {
            if (visited[i])  // important !! 
                continue;

            int freq = 1;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    freq++;
                    visited[j] = true;
                }
            }
            Console.WriteLine($"Frequency of {arr[i]} is: {freq}");
        }
    }











}
