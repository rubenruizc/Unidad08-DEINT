using Ejercicio05DAL;
using Ejercicio05Ent;
namespace Ejercicio05UI
{
    public partial class MainPage : ContentPage
    {
        public List<clsPersona> lista;

        public MainPage()
        {

            InitializeComponent();

            lista = clsListaPersonas.listaPersonas();

            listaView.ItemsSource = lista;
        }

    }

}