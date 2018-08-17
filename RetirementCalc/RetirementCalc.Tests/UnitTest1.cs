using NUnit.Framework;
using RetirementCalc.Service;


namespace Tests
{
    public class Tests
    {
    [Test]
        public void CalculatorReturns_Int()
        {
            var client = new Client
                {
                    currentAge = 47,
                    targetRetirementAge = 65,
                    netWorth = 500000,
                    desiredMonthlySpending = 2500,
                    yearlySavingContribution = 22000,
                    yearlyExpenses = 55000
                };
            var calculator = new Calculator(new NoExpensePlanned());
            var output = calculator.RetirementYears(client);
            Assert.That(output, Is.TypeOf<int>());
        }

        [Test]
        public void SimpleClientReturns_CorrectYears()
        {
            var client = new Client
                {
                    currentAge = 65,
                    targetRetirementAge = 65,
                    netWorth = 500000,
                    desiredMonthlySpending = 2500,
                    yearlySavingContribution = 0,
                    yearlyExpenses = 0
                };
            var calculator = new Calculator(new NoExpensePlanned());
            var output = calculator.RetirementYears(client);
            var expected = 16;
            Assert.AreEqual(expected, output);
        }
        [Test]
        public void ComplicatedClientReturns_CorrectYears()
        {
            var client = new Client
                {
                    currentAge = 23,
                    targetRetirementAge = 65,
                    netWorth = 20000,
                    desiredMonthlySpending = 3500,
                    yearlySavingContribution = 20000,
                    yearlyExpenses = 40000
                };
            var calculator = new Calculator(new NoExpensePlanned());
            var output = calculator.RetirementYears(client);
            var expected = 20;
            Assert.AreEqual(expected, output);
        }
        [Test]
        public void NotEnoughForRetirementReturns_Zero()
        {
            var client = new Client
                {
                    currentAge = 60,
                    targetRetirementAge = 65,
                    netWorth = 1000,
                    desiredMonthlySpending = 2500,
                    yearlySavingContribution = 500,
                    yearlyExpenses = 40000
                };
            var calculator = new Calculator(new NoExpensePlanned());
            var output = calculator.RetirementYears(client);
            var expected = 0;
            Assert.AreEqual(expected, output);
        }
        [Test]
        public void AddExpenseReturns_CorrectYears()
        {
                    
            var client = new Client
                {
                    currentAge = 23,
                    targetRetirementAge = 65,
                    netWorth = 20000,
                    desiredMonthlySpending = 3500,
                    yearlySavingContribution = 20000,
                    yearlyExpenses = 40000
                };
            var calculator = new Calculator(new EducationExpense{amount = 40000, numberofYears = 4});
            var output = calculator.RetirementYears(client);
            var expected = 16;
            Assert.AreEqual(expected, output);
        
        } 
    
    }
}