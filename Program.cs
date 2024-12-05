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
            DepensesRepository depenses = new DepensesRepository();

            //initialiser des transactions par defaut
            depenses.addDepense(new Depense
            {
                description = "achat d'une television",
                categorie="immobilier",
                date = DateTime.Now,
                prix="$100000",
                entreprise="Best buy"
                
            });
            depenses.addDepense(new Depense
            {
                description = "viande de porc",
                categorie = "epicerie",
                date = DateTime.Now,
                prix = "$80",
                entreprise = "Maxi"

            });
            depenses.addDepense(new Depense
            {
                description = "facture d'electricite",
                categorie = "immobilier",
                date = DateTime.Now,
                prix = "$180",
                entreprise = "bailleur"

            });

            //initialiser des categorie par defaut
            Categories.addCategorie("epicerie", Properties.Resources.groceries);
            Categories.addCategorie("immobilier", Properties.Resources.immobilier);
            Application.Run(new Form1(Categories,depenses));
        }
    }
}