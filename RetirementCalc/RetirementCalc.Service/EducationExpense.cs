namespace RetirementCalc.Service
{
    public class EducationExpense : IExpense
    {
        public int amount {get; set;}
        public int numberofYears { get; set; }
        public int totalExpense()
        {
            var total = amount*numberofYears;
            if(total<0)
                throw new ArgumentException("expense and length must be positive");
            return total;
        }
    }
}