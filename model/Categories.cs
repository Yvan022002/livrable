//namespace livrable.model
//{
//    public class Categories : ISujet
//    {
//        private List<Panel> Allcategories;
//        private readonly List<IObserver> observers = new List<IObserver>();
//        private List<string> catOptions = new List<string>();
//        public Categories() { Allcategories = new List<Panel>(); }
//        public void addCategorie(string catName, Image catImage)
//        {
//            Panel categorieItem = new Panel();
//            PictureBox pictureBox11 = new PictureBox();
//            Label label8 = new Label();


//            //nom de la categorie
//            label8.AutoSize = true;
//            label8.BackColor = Color.White;
//            label8.Location = new Point(129, 10);
//            label8.Name = "label8";
//            label8.Size = new Size(76, 25);
//            label8.TabIndex = 1;
//            label8.Text = catName;

//            catOptions.Add(catName);

//            //image de la categories
//            pictureBox11.Image = catImage;
//            pictureBox11.Location = new Point(6, 3);
//            pictureBox11.Name = "pictureBox11";
//            pictureBox11.Size = new Size(52, 38);
//            pictureBox11.TabIndex = 0;
//            pictureBox11.TabStop = false;

//            //Panel qui contient le tout
//            categorieItem.BackColor = Color.FromArgb(245, 255, 255);
//            categorieItem.Controls.Add(label8);
//            categorieItem.Controls.Add(pictureBox11);
//            categorieItem.Location = new Point(0, 53);
//            categorieItem.Name = "categorieItem";
//            categorieItem.Size = new Size(240, 43);
//            categorieItem.TabIndex = 11;

//            Allcategories.Add(categorieItem);

//            notifyObserver();
//        }
//        public List<string> GetCatOptions() { return catOptions; }
//        public void removeCategorie(Panel cat) { Allcategories.Remove(cat); }
//        public List<Panel> GetAllCategories() { return Allcategories; }
//        public void attachObserver(IObserver observer) { observers.Add(observer); }
//        public void detachObserver(IObserver observer) { observers.Remove(observer); }
//        public void notifyObserver()
//        {
//            foreach (IObserver ob in observers)
//            {
//                ob.update(this);
//            }
//        }


//    }
//}
