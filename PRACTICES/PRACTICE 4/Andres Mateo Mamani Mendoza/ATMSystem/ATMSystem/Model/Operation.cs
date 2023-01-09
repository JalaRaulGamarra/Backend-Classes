namespace ATMSystem.Model
{
    public class Operation
    {
        public OperationType Type { get; set; }
        public decimal Amount { get; set; }

        public Operation(OperationType type, decimal amount)
        {
            this.Type = type;
            this.Amount = amount;
        }
        public string GetDetails()
        {
            return $"{this.Type}-> {this.Amount}";
        }
    }
}