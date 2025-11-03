
namespace DomainPrimitives
{

    public class Age
    {
        private int age;

        public Age(int age)
        {
            IsAgeValid(age);
            this.age = age;
        }

        public int GetValue()
        {
            return age;
        }


        private void IsAgeValid(int age)
        {
            if (age > 99 || 18 > age)
            {
                throw new ArgumentException("age must be between 18 and 99");
            }
        }

    }
}