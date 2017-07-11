namespace Template.Data
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public User GetUser()
        {
            User user = new User();
            //Implementa a busca do usuario no banco de dados, por exemplo.

            return user;
        }
    }
}
