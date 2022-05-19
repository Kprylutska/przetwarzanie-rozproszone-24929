namespace ExampleWebApp.Rest.Database.Entities
{
    public class PersonEntity
    {
        protected PersonEntity()
        {
            CreatedOn = DateTime.UtcNow;
        }
        public PersonEntity(string firstName, string lastName, string phoneNumber): this()
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }
        public int PersonId { get; set; }
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public string PhoneNumber { get; protected set; }
        public DateTime CreatedOn { get; protected set; }
    }
}