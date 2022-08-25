using System;

namespace SoftServe
{
    public class Employee
    {
        internal string name;
        private DateTime hiringDate;

        public Employee(string name, DateTime hiringDate)
        {
            this.name = name;
            this.hiringDate = hiringDate;
        }

        public int Experience()
        {
            DateTime dt = DateTime.Now;
            int yearsOfService = dt.Year - hiringDate.Year;
            if (hiringDate > dt.AddYears(-yearsOfService))
            {
                yearsOfService--;
            }
            return yearsOfService;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"{name} has {Experience()} years of experience");
        }
    }

    public class Developer : Employee
    {
        private string programmingLanguage;

        public Developer(string name, DateTime hiringDate, string programmingLanguage) : base(name, hiringDate)
        {
            this.programmingLanguage = programmingLanguage;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"{name} is {programmingLanguage} programmer");
        }
    }

    public class Tester : Employee
    {
        private bool isAuthomation;

        public Tester(string name, DateTime hiringDate, bool isAuthomation) : base(name, hiringDate)
        {
            this.isAuthomation = isAuthomation;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"{name} is {(isAuthomation ? "authomated" : "manual")} tester and has<Experience> year(s)of experience");
        }
    }
}
