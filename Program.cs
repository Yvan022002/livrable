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
            categories Categories = new categories();
            DepensesRepository depenses= new DepensesRepository();
            Application.Run(new Form1(Categories,depenses));
        }
    }
}