
namespace DomainPrimitives
{

    public class LastName
    {
        private string lastName;

        public LastName(string lastName)
        {
            IsLastNameValid(lastName);
            this.lastName = lastName;
        }

        public string GetValue()
        {
            if(lastName == null)
            {
                throw new ArgumentException("age cannot be null");
            }
            return lastName;
        }


        private void IsLastNameValid(string lastName)
        {
            if (lastName.Length > 20 || lastName.Length < 3)
            {
                throw new ArgumentException("last name must be between 3 and 20 characters");
            }
        }

    }
}