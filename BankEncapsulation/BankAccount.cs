using System;
using System.Collections.Generic;
namespace BankEncapsulation
{
	public class BankAccount
	{
		public BankAccount()
		{
		}


		private double balance = 0;

		public void Deposit(double amount)
		{
			balance = amount;
		}

		public string GetBalance()
		{
			return $"${balance}";
		}
		
	}
}

