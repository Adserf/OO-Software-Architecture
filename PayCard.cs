using System;

namespace Object_Oriented_Design_Project
{
    public class ByCard : PayMethod
    {
        public void InitiatePayment(double amount)
        {
            Console.WriteLine($"Payment of {amount} made by card");
        }
    }
}
