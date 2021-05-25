using Server.Models;

namespace Server.ViewModels
{
    public class UserViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public UserViewModel(User user)
        {
            // TODO: what should we do here - copy model properties to viewModel
            Username = user.Username;
            Password = user.Password;
            FirstName = user.FirstName;
            LastName = user.LastName;
        }
    }
}