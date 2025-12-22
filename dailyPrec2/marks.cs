using System;

public class Marks
{
     public void Addition(int sub1, int sub2, out int result, out int carry3, out int carry4)
    {
        carry3 = sub1;
        carry4 = sub2;
        result = sub1 + sub2;

    }
}