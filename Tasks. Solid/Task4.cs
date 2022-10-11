namespace SoftServe_IT_Academy.Tasks._Solid
{
    public abstract class Invoice
    {
        public abstract double GetDiscount(double amount);
    }
    public class OrdinaryInvoice : Invoice
    {
        public override double GetDiscount(double amount) => amount - (amount * 1 / 100);
    }
    public class FinalInvoice : Invoice
    {
        public override double GetDiscount(double amount) => amount - (amount * 3 / 100);
    }
    public class ProposedInvoice : Invoice
    {
        public override double GetDiscount(double amount) => amount - (amount * 5 / 100);
    }
    public class RecurringInvoice : Invoice
    {
        public override double GetDiscount(double amount) => amount - (amount * 10 / 100);
    }
}
