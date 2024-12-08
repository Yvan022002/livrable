//using livrable.model;

//namespace livrable;

//using Categories2 = SortedSet<string>;
//using Depenses = SortedDictionary<Guid, Depense>;

//public partial class OverviewForm : Form, IObserver<Categories2>, IObserver<Depenses>
//{
//    CategoriesProvider categories_provider;
//    DepensesProvider depenses_provider;

//    public OverviewForm(CategoriesProvider categories_provider, DepensesProvider depenses_provider)
//    {
//        this.categories_provider = categories_provider;
//        this.depenses_provider = depenses_provider;
//        categories_provider.Subscribe(this);
//        depenses_provider.Subscribe(this);

//        InitializeComponent();
//        loadAllCategories();
//    }

//    public Categories GetCategories() { return cats; }

//    public DepensesProvider GetDepenses() { return depensesRepository; }

//    public void RefreshCategories()
//    {

//        foreach (Panel p in cats.GetAllCategories())
//        {
//            allCategoriesPanel.Controls.Add(p);
//        }
//    }

//    //determine d'ou vient la msie a jours
//    public void update(ISujet sujet)
//    {
//        if (sujet is DepensesProvider)
//        {
//            updateDepense(sujet);
//        }
//        else if (sujet is Categories)
//        {
//            updateCategorie(sujet);
//        }
//    }

//    //upadte le tableau des depenses
//    public void updateDepense(object depenses)
//    {

//        DepensesProvider des = (DepensesProvider)depenses;
//        foreach (Depense p in des.GetDepenses())
//        {
//            allTransaction.Rows.Add(p.Description, p.Category, p.Date, p.Prix, p.Entreprise);
//        }

//    }
//    //update la liste des categories
//    public void updateCategorie(object allCat)
//    {
//        allCategoriesPanel.Controls.Clear();
//        Categories Categories = (Categories)allCat;
//        foreach (Panel p in Categories.GetAllCategories())
//        {
//            allCategoriesPanel.Controls.Add(p);
//        }
//        allCategoriesPanel.Refresh();
//    }


//    private void Form1_Load(object sender, EventArgs e)
//    {

//    }


//    private void btn_openCategorieForm_Click(object sender, EventArgs e)
//    {
//        CategoryForm CategorieForm = new CategoryForm(this);
//        CategorieForm.Show();
//    }

//    private void btn_openTransactionForm_Click(object sender, EventArgs e)
//    {
//        TransactionForm transactionForm = new TransactionForm(this);
//        transactionForm.Show();
//    }
//}
