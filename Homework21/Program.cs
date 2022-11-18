using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework21
{
    internal class Program
    {
        static void Main(string[] args)
        {
          List<Branch> branchList = new List<Branch>()
          {
             new Branch
             {
                Id = 10,
                Bname = "CS",
                Students =
                {
                  new Student{Id=1,Name="yogini"},
                  new Student{Id=2,Name="dhanu"},
                  new Student{Id=3,Name="saloni"},
                  new Student{Id=4,Name="pooja"},
                  new Student{Id=5,Name="asmita"},
                  new Student{Id=6,Name="sweksha"},
                }
             },
             new Branch
             {
                 Id = 20,
                 Bname = "IT",
                 Students =
                 {
                   new Student{Id=7,Name="aishwarya"},
                   new Student{Id=8,Name="kajal"},
                   new Student{Id=9,Name="neha"},
                 }
             }

          };
          foreach (Branch b in branchList)
          {
            Console.WriteLine(b.Id + " " + b.Bname);
            foreach (Student s in b.Students)
            {
              Console.WriteLine($"\t{s.Id} {s.Name}");
            }
          }
            
          List<Account> accountlist = new List<Account>()
          {
            new Account
            {
               Name="savings",
               Customers=
               {
                  new Customer
                  {
                    Name="yogini",
                    loans=
                    {
                       new Loan{Name="home loan",Amount=400000},
                       new Loan{Name="car loan",Amount=600000},
                    }
                  },
                  new Customer
                  {
                    Name="dhanu",
                    loans=
                    {
                       new Loan{Name="home loan",Amount=800000},
                    }
                  },
                  new Customer
                  {
                  Name="saloni",
                  loans=
                  {
                     new Loan{Name="car loan",Amount=900000},
                     new Loan{Name="persnal loan",Amount=3469000},
                  }
                },
               }
            },
            new Account
            {
              Name="current",
              Customers=
              {
                new Customer
                {
                  Name="neha",
                  loans=
                  {
                     new Loan{Name="persnal loan",Amount=3469000},
                  }
                },
                new Customer
                {
                  Name="pooja",
                  loans=
                  {

                    new Loan{Name="business loan",Amount=594000},
                  }
                },
              }
            }
          };
            foreach (Account a in accountlist)
            {
                Console.WriteLine(" " + a.Name);
                foreach (Customer c in a.Customers)
                {
                    Console.WriteLine("    " + c.Name);
                    foreach (Loan l in c.loans)
                    {
                        Console.WriteLine($"\t{l.Name} {l.Amount}");
                    }
                }
            }


        }

    }
}

