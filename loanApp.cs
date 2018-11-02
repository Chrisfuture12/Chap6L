using System;

namespace chap6L
{
    class loanApp{
        

        public static double getInput(string item)
        {
            string input;
            Console.WriteLine("Enter "+item);
            input = Console.ReadLine();
            double userInput = double.Parse(input);
            return userInput;
        }

        public static void Main()
        {
            double rate = 0;
            double years = 0;
            double loanAmount = 0;
            rate = getInput("The interest rate");
            years = getInput("The year length");
            loanAmount = getInput("The loan value");

            double numPayments = 0;
            double term = 0;
            double paymentAmount= 0; 
            double monthInterest=0;
            double principal=0;
            double balance=0;
            double totalInterestPAid=0;

            balance = loanAmount;
            while(balance > 0){
                numPayments = years * 12;
                term = Math.Pow(1 + rate / 12.0, numPayments);
                paymentAmount = loanAmount * rate / 12 * term/(term-1.0);
                monthInterest = rate / 12 * balance;
                principal = paymentAmount - monthInterest;
                balance = balance - principal;
                totalInterestPAid = totalInterestPAid + monthInterest;
                Console.WriteLine("Balance: "+balance+"\tPrincipal: "+principal+"\tMonthly interest: "+monthInterest);
            }
            Console.ReadKey();
        }
    }
}