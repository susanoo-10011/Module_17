using Task_17._6._6;
using Task_17._6._6.Accounts;

OrdinaryAccount ordinaryAccount = new OrdinaryAccount();
SalaryAccount salaryAccount = new SalaryAccount();

ordinaryAccount.Balance = 100;
salaryAccount.Balance = 500;

Calculator.CalculateInterest(ordinaryAccount);
Calculator.CalculateInterest(salaryAccount);

Console.WriteLine($"Процент по обычному аккаунту: {ordinaryAccount.Interest}");
Console.WriteLine($"Процент по зарплатному аккаунту: {salaryAccount.Interest}");