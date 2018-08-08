namespace RetirementCalc.Service
{
    public interface IExpense
    {
        int amount {get; set;}
        int numberofYears { get; set; }
        int totalExpense();
    }
}