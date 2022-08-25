namespace SoftServe
{
    public abstract class Person
    {
        protected int yearOfBirth;
        protected string healthInfo;
        protected string name;

        public Person(int yearOfBirth, string name, string healthInfo)
        {
            this.yearOfBirth = yearOfBirth;
            this.name = name;
            this.healthInfo = healthInfo;
        }

        public virtual string GetHealthStatus()
        {
            return name + ": " + yearOfBirth + ". " + healthInfo;

        }
    }

    public class Child : Person
    {
        protected string childIDNumber;

        public Child(int yearOfBirth, string name, string healthInfo, string childIDNumber) : base(yearOfBirth, name, healthInfo)
        {
            this.childIDNumber = childIDNumber;
        }

        public override string ToString()
        {
            return $"{this.name} {this.childIDNumber}";
        }
    }

    public class Adult : Person
    {
        protected string passportNumber;

        public Adult(int yearOfBirth, string name, string healthInfo, string passportNumber) : base(yearOfBirth, name, healthInfo)
        {
            this.passportNumber = passportNumber;
        }

        public override string ToString()
        {
            return $"{this.name} {this.passportNumber}";
        }
    }
}
