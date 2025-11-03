namespace DomainPrimitives
{
    class Person
    {
        FirstName firstName;
        LastName lastName;
        CPR cpr;
        Age age;

        public string GetFirstName()
        {
            return firstName.GetValue();
        }
        public string GetLastName()
        {
            return lastName.GetValue();
        }
        public string GetCPR()
        {
            return cpr.GetValue();
        }
        public int GetAge()
        {
            return age.GetValue();
        }

        public Person(string firstName, string lastName, string cpr, int age)
        {
            this.firstName = new FirstName(firstName);
            this.lastName = new LastName(lastName);
            this.cpr = new CPR(cpr);
            this.age = new Age(age);
        }

    }
}