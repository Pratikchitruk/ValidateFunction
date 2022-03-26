using System;

namespace LambdaValidate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to lambda function");
            CustomerInfo customerInfo = new CustomerInfo();
            customerInfo.IsValidByLamda(customerInfo);
            
        }
    }
}