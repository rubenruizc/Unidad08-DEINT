using System.Collections.ObjectModel;
namespace Ejercicio05UI
{

    public partial class MainPage : ContentPage
    {
        public class Fruit
        {
            public string FruitName { get; set; }
        }
        List<Fruit> fruits = new List<Fruit>();
        public List<Fruit> Fruits { get { return fruits; } }
        public MainPage()
        {
            InitializeComponent();
            fruits.Add(new Fruit() { FruitName = "Apple" });
            fruits.Add(new Fruit() { FruitName = "Orange" });
            fruits.Add(new Fruit() { FruitName = "Banana" });
            fruits.Add(new Fruit() { FruitName = "Grape" });
            fruits.Add(new Fruit() { FruitName = "Mango" });
            FruitListView.ItemsSource = fruits;
        }
    }

}
