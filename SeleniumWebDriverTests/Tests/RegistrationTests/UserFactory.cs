namespace SeleniumWebDriverTests
{
    public static class UserFactory 
    {
        public static RegistrationUser CreateValidUser()
        {
            return new RegistrationUser
            {
                FirstName = "Mimi",
                LastName = "Rrrr",
                Gender = "Female",
                Password = "mimi12",
                Date = "20",
                Month = "6",
                Year = "1985",
                RealFirstName = "Mimi",
                RealLastName = "Rrrr",
                Address = "Ruse",
                City = "Ruse",
                State = "Alabama",
                PostCode = "35004",
                Phone = "+359898888888", 
                Alias = "sgdlf"
            };
        }
    }
}
