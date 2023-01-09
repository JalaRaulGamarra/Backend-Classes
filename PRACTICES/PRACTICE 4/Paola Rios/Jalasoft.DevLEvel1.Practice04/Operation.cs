namespace Jalasoft.DevLEvel1.Practice04
{
    public class Operation
    {
        public double InitialBalance { get; set; }
        public double EndBalance { get; set; }
        public double Amount { get; set; }
        public OperationType TransactionType { get; set; }

        internal void Show()
        {
            Console.WriteLine("The {0} is :{1}", TransactionType, Amount);
        }
    }
}