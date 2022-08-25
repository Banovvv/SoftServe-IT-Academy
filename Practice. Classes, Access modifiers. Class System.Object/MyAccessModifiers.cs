using System;

namespace AccediaTest
{
    public class MyAccessModifiers
    {
        private int birthYear;
        protected string personalInfo;
        private protected string IdNumber;
        static byte averageMiddleAge = 50;

        public MyAccessModifiers(int birthYear, string IdNumber, string personalInfo)
        {
            this.birthYear = birthYear;
            this.IdNumber = IdNumber;
            this.personalInfo = personalInfo;
        }

        public int Age => DateTime.Now.Year - birthYear;

        internal string Name { get; set; }
        public string NickName { get; internal set; }

        protected internal void HasLivedHalfOfLife()
        {

        }

        public static bool operator ==(MyAccessModifiers one, MyAccessModifiers two)
        {
            return one.Name == two.Name && one.Age == two.Age && one.personalInfo == two.personalInfo;
        }

        public static bool operator !=(MyAccessModifiers one, MyAccessModifiers two)
        {
            return !(one.Name == two.Name && one.Age == two.Age && one.personalInfo == two.personalInfo);
        }

        public override bool Equals(object two)
        {
            return this.Name == ((MyAccessModifiers)two).Name && this.Age == ((MyAccessModifiers)two).Age && this.personalInfo == ((MyAccessModifiers)two).personalInfo;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.Name, this.Age, this.IdNumber, this.personalInfo);
        }
    }
}
