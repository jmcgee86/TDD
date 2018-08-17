using System;

namespace RetirementCalc.Service
{
    public class Calculator
    {
         private IExpense _expense;

        public Calculator(IExpense expense)
        {
            _expense = expense;
        }

       public int RetirementYears(Client client)
       {
        
        var yearsToRetirement = client.targetRetirementAge - client.currentAge;
            if(yearsToRetirement<0)
                yearsToRetirement = 0;
        
        var projectedNetWorth = yearsToRetirement * client.yearlySavingContribution + client.netWorth - _expense.totalExpense();

          var yearsMoneyWillLast = Convert.ToInt32(projectedNetWorth/client.desiredMonthlySpending)/12;
           
           return yearsMoneyWillLast;
       }
    }
}
