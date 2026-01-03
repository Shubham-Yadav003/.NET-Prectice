using System;

class Practice
{
    string[] str = new string[5];



    public void Func()
    {
        Console.WriteLine("Enter strings:");
        while (true)
        {

            for (int i = 0; i < 5; i++)
            {
                str[i] = Console.ReadLine();
            }


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Value at idx {i} is: {str[i]}");
            }
            return;

        }


    }

    public void matrix()
    {
        // 2*2 matrix

        int[,] matrix = new int[2, 2];

        Console.WriteLine("Enter matrix elements:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());

            }


        }


        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.WriteLine($"Element at idx {i}{j} is: {matrix[i, j]}");

            }


        }
    }

    public void AddMatrix()
    {
        int[,] mat1 = new int[2, 2];
        int[,] mat2 = new int[2, 2];
        int[,] sumMat = new int[2, 2];

        mat1[0, 0] = 1;
        mat1[0, 1] = 2;
        mat1[1, 0] = 3;
        mat1[1, 1] = 4;

        mat2[0, 0] = 1;
        mat2[0, 1] = 2;
        mat2[1, 0] = 3;
        mat2[1, 1] = 4;

        for (int i = 0; i < mat1.GetLength(0); i++)
        {
            for (int j = 0; j < mat1.GetLength(1); j++)
            {
                sumMat[i, j] = mat1[i, j] + mat2[i, j];

            }


        }

        Console.WriteLine("After summation:");
        for (int i = 0; i < mat1.GetLength(0); i++)
        {
            for (int j = 0; j < mat1.GetLength(1); j++)
            {

                Console.WriteLine($"Element at idx {i}{j} is: {sumMat[i, j]}");
            }


        }


    }

    // matrix multiplication 2 by 2 
    public void matMul()
    {
        int[,] mat1 = new int[2, 2];
        int[,] mat2 = new int[2, 2];
        int[,] mulMat = new int[2, 2];

        mat1[0, 0] = 1;
        mat1[0, 1] = 2;
        mat1[1, 0] = 3;
        mat1[1, 1] = 4;

        mat2[0, 0] = 1;
        mat2[0, 1] = 2;
        mat2[1, 0] = 3;
        mat2[1, 1] = 4;

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                mulMat[i, j] = 0;
                for (int k = 0; k < 2; k++)
                {
                    mulMat[i, j] += mat1[i, k] * mat2[k, j];
                }
            }
        }



        Console.WriteLine("After Multiplication:");
        for (int i = 0; i < mat1.GetLength(0); i++)
        {
            for (int j = 0; j < mat1.GetLength(1); j++)
            {
                Console.WriteLine($"Value at index: {i}{j} is {mulMat[i, j]}");

            }


        }
    }

    // transpose of a matrix
    public void transpose()
    {
        int[,] mat =
    {
    {1, 2, 3},
    {4, 5, 6},
    {7,8,9}
};  
        int rows = mat.GetLength(0);
        

        Console.WriteLine("Value after transpose");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                Console.WriteLine($"Value at index: {i}{j} is {mat[i, j]}");

            }


        }

         // n*n
        // int cols = mat.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = i + 1; j < rows; j++)
            {
                int temp = mat[i, j];
                mat[i, j] = mat[j, i];
                mat[j, i] = temp;
            }
        }

        Console.WriteLine("Value after transpose");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                Console.WriteLine($"Value at index: {i}{j} is {mat[i, j]}");

            }


        }
    }



   public void ReverseString(){
     string input = "Hello World";

      
        char[] arr = input.ToCharArray();

        
        Array.Reverse(arr);

       
        string reversed = new string(arr);

        Console.WriteLine("Reversed string: " + reversed);
   }

   static string ReverseString(string str)
{
    char[] result = new char[str.Length];
    int j = 0;

    for (int i = str.Length - 1; i >= 0; i--)
    {
        result[j++] = str[i];
    }

    return new string(result);
}


static string ToggleCase(string str)
{
    char[] arr = str.ToCharArray();

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 'a' && arr[i] <= 'z')
            arr[i] = (char)(arr[i] - 32);
        else if (arr[i] >= 'A' && arr[i] <= 'Z')
            arr[i] = (char)(arr[i] + 32);
    }

    return new string(arr);
}


static string ToUpperCase(string str)
{
    char[] arr = str.ToCharArray();

    for (int i = 0; i < arr.Length; i++)
        if (arr[i] >= 'a' && arr[i] <= 'z')
            arr[i] = (char)(arr[i] - 32);

    return new string(arr);
}

static string ToLowerCase(string str)
{
    char[] arr = str.ToCharArray();

    for (int i = 0; i < arr.Length; i++)
        if (arr[i] >= 'A' && arr[i] <= 'Z')
            arr[i] = (char)(arr[i] + 32);

    return new string(arr);
}


static void CompareStringsLib(string s1, string s2)
{
    if (string.Compare(s1, s2) == 0)
        Console.WriteLine("Strings are equal");
    else
        Console.WriteLine("Strings are not equal");
}


static bool CompareStrings(string s1, string s2)
{
    if (s1.Length != s2.Length)
        return false;

    for (int i = 0; i < s1.Length; i++)
        if (s1[i] != s2[i])
            return false;

    return true;
}


static string ConcatUsingLib(string s1, string s2)
{
    return string.Concat(s1, s2);
}


static string ConcatWithoutLib(string s1, string s2)
{
    char[] result = new char[s1.Length + s2.Length];
    int k = 0;

    for (int i = 0; i < s1.Length; i++)
        result[k++] = s1[i];

    for (int i = 0; i < s2.Length; i++)
        result[k++] = s2[i];

    return new string(result);
}


}