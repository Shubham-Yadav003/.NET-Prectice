using System;
class AddGeneric<T> // generic class
{
    T n1;
    T n2;
    T result;
    public AddGeneric(T m, T n)
    {
        this.n1 = m;
        this.n2 = n;
    }

    public T AddAllType(T num1, T num2)
    {
        dynamic x = num1;
        dynamic y = num2;
        result  = x+y;
        return result;
    }
}
