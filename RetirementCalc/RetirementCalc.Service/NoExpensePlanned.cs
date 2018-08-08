namespace RetirementCalc.Service
{
    public class NoExpensePlanned : IExpense
    {
        public int amount {get; set;} = 0;
        public int numberofYears { get; set; } = 0;
       public int totalExpense()
        {
            return amount*numberofYears;
        }
    }
}