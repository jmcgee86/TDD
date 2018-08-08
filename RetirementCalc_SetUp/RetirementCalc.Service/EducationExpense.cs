namespace RetirementCalc.Service
{
    public class EducationExpense : IExpense
    {
    public int amount {get; set;}
    public int numberofYears { get; set; }
    public int totalExpense()
    {
        return amount*numberofYears;
    }
    }
}