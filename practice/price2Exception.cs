using System ;

class InvalidQuantityException : SystemException
{
    public InvalidQuantityException() :
        base ("Error : Quantity Must Be Greater Than Zero... !!")
    {
        
    }

    public InvalidQuantityException (string message) :
        base (message)
    {
        
    }
}