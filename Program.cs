namespace Practice_VirtualOverridingandNew_Hongfei
{
    internal class Program
    {
        //Practice_Virtual_Overriding_and New
        //Hongfei

        static void Main(string[] args)
        {
            Console.WriteLine("------------ Virtual Overriding and New-------------");

            List<BankAccount> accounts = new List<BankAccount>();
            
            BankAccount bankAccount = new BankAccount("Bank Account",500);
            accounts.Add(bankAccount);
            Console.WriteLine(bankAccount);

            CheckingAccount checking = new("Checking Account", 500, 50);
            accounts.Add(checking);
            Console.WriteLine(checking);

            SavingAccount saving = new("Saving Account", 500, 0.1);
            accounts.Add(saving);
            Console.WriteLine(saving);

            RetirementAccount retirementAccount = new("Retirement Account", 20000, 0.08);
            accounts.Add(retirementAccount);
            Console.WriteLine(retirementAccount);
            
            Console.WriteLine("----------------------- Deposit 500");
            //Deposit 500
            foreach (var account in accounts)
            {
                account.Deposit(500);
                Console.WriteLine(account);
            }

            Console.WriteLine("----------------------- Deposit -5000");
            //Deposit -5000
            foreach (var account in accounts)
            {
                account.Deposit(-5000);
                Console.WriteLine(account);
            }

            Console.WriteLine("-----------------------Withdraw 200");
            //Withdraw 200
            foreach (var account in accounts)
            {
                if (account.GetType() == typeof(RetirementAccount))
                {
                    Console.WriteLine(" Cannot withdraw from a retirement account");
                }
                else
                {
                    account.Withdraw(200);
                    Console.WriteLine(account);
                }
            }

            Console.WriteLine("----------------------- Withdraw -2000");
            //Withdraw -2000
            foreach (var account in accounts)
            {
                if (account.GetType() == typeof(RetirementAccount))
                {
                    Console.WriteLine(" Cannot withdraw from a retirement account");
                }
                else
                {
                    account.Withdraw(200);
                    Console.WriteLine(account);
                }


            }











        }
    }


}
