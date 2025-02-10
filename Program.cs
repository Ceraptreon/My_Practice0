using System;
using System.Runtime.InteropServices;

//2
class BankAccount 
{
    private int _balance
    public BankAccount(int balance)
    {
        _balance = balance;
    }
    public void deposit(int amount)
    {
        Console.WriteLine($"Ваш депозит - {amount}");
    }
    public virtual void withdraw(int amount2)
    {
        Console.WriteLine($"Вы вывели - {amount2}");
    }
    public void GetBalance()
    {
        Console.WriteLine($"Ваш счет насчитывает - {_balance}");
    }
    class SavingAccount : BankAccount 
    { 
        public override void withdraw(int amount2) 
        {
            Console.WriteLine("Вы не можете вывести деньги");
        }
    }
    class CreditAccount : BankAccount
    {
        private int _credit;
        public CreditAccount(int credit)
        {
            _credit = credit;
        }
    }

}



//3
interface Discount
{
    public void Apply_Discount(int discount);
    

}

class Product : Discount
{

    public void Apply_Discount(int discount)
    {
        price = discount / 100 * price;
        Console.WriteLine(price);
    }

    public string name;
    public Product(string _name)
    {
        name = _name;
    }
    public double price;
    public Product(double _price)
    {
        price = _price;
    }


}
class FoodProduct : Product
{
    public double shelf_life;
    public FoodProduct(double _shelf_life)
    {
        shelf_life = _shelf_life;
    }
    class Electronics
    {
        public double warranty;
        public FoodProduct(double _warranty)
        {
            warranty = _warranty;
        }

    }


}
    





