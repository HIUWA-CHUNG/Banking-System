using System;

public class Account
{
	public double balance;

	public void Deposit(double amount)
	{
		this.balance += amount;
	}

	public void Withdraw(double amount)
	{
		this.balance -= amount;
	}
}


