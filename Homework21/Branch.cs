using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework21
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Branch
    {
        public int Id { get; set; }
        public string Bname { get; set; }
        public List<Student> Students = new List<Student>();


    }
    public class Loan
    {
        public String Name { get; set; }
        public double Amount { get; set; }

    }
    public class Customer
    {
        public string Name { get; set; }
        public List<Loan> loans = new List<Loan>();

    }

    public class Account
    {
        public string Name { get; set; }
        public List<Customer> Customers = new List<Customer>();

    }
}