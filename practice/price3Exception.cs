using System ;

class InvalidPriceException : SystemException
{
    public InvalidPriceException() :
        base ("Error : Price Must Be Greater Than Zero... !!")
    {
        
    }

    public InvalidPriceException (string message) :
        base (message)
    {
        
    }
}