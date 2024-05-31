using System;

namespace Object_Oriented_Design_Project
{
    public class Receipt
    {
        public Invoice Invoice { get; private set; }

        public Receipt(Invoice invoice)
        {
            Invoice = invoice;
        }

        public void ReceiveUpdateFromPayment(string paymentStatus)
        {
            // Update based on payment status if needed
        }

        public void PrintReceipt()
        {
            Console.WriteLine($"Receipt for order: {string.Join(", ", Invoice.Order.MenuItems.Select(item => item.Name))}, Total: {Invoice.TotalCost}");
        }
    }
}
