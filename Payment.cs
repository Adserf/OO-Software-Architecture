using System;

namespace Object_Oriented_Design_Project
{
    public class Payment
    {
        public Invoice Invoice { get; private set; }

        public Payment(Invoice invoice)
        {
            Invoice = invoice;
        }

        public Receipt GenerateReceipt()
        {
            return new Receipt(Invoice);
        }
    }
}
