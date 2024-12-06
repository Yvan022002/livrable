using livrable.model;

namespace livrable
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
          UserRepository  userRepository = new UserRepository();

            //user par defaut
            userRepository.addUser(new User { Name = "yvan", Email = "yvan@gmail.com", Password = "12345" });

            Application.Run(new SignInForm(userRepository));
        }
    }
}