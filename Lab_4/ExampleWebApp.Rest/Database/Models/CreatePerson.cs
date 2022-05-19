namespace ExampleWebApp.Rest.Database.Models
{
    public class CreatePerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        public bool Validate()
        {
            return !(string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(PhoneNumber));
        }
    }

}