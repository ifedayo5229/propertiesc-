using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            // student ife = new student();
            // ife.Id = -2;
            // Console.WriteLine(Sarah.Id);
            // ife.setId(-2);
            // ife.setName(null);
            // ife.passMark = 100;
            // Console.WriteLine("student details " + ife.getName() );
            Employee one = new Employee();
            one.Id = 1;
            one.FirstName = "John";
            one.LastName = "paul";
            one.TotalPay = 6000;
           one.employeDetails();

        }
    }
}
