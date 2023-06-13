using System;
namespace MainMethodAssignment
{
    public class MathMethod
    {
        
         public static int MathOps(int number)
            {
                return number + 45;  
            }

         public static int MathOps(Decimal number)
        {
            int newnum = Convert.ToInt32(number);
            return newnum - 3;
        }

         public static int MathOps(string number)
        {
            int newnum = Convert.ToInt32(number);
            return newnum % 5;
        }
    }
}
