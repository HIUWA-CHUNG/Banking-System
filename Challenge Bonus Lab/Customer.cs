using System;
using System.Security.Principal;

public class Customer
{
    public string name;
    public Account checkingAccount;
    public Account savingsAccount;
    public string[] accountHistorical;
    public Customer(string aName, Account aSavingsAccount, Account acheckingAccount)
    {
        this.name = aName;
        this.checkingAccount = acheckingAccount;
        this.savingsAccount = aSavingsAccount;
    }


    public void BalanceEnquiry¨¨
}
