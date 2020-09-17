using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csharppractice.Classes;
using static Csharppractice.Classes.BankAccount;

namespace Csharppractice
{
    class Program
    {

        static double numberTwo = 2;
        static void Main(string[] args)
        {
            //var huh = new SimpleMath();
            //huh.Add(2, 3);

            var bank = new BankAccount();
            bank.AddBalance(100);
            
            Console.WriteLine(bank.Balance);

            var child = new ChildBankAccount();
            child.AddBalance(10);
            Console.WriteLine(child.Balance);



        }
    }

    public class SimpleMath
    {
        public void Add(int number1, int number2)
        {
            if (number1 == number2)
            {
                Console.WriteLine("Nice!!!");
            }
            else
            {
                Console.WriteLine("Wrong!!");
            }
        }
    }
}
