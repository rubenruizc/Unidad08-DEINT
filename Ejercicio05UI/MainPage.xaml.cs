using Ejercicio05Ent;
using System.Collections.ObjectModel;
namespace Ejercicio05UI
{

    public partial class MainPage : ContentPage
    {
        public List<clsPersona> lista;

        public MainPage()
        {
            InitializeComponent();

            lista = clsListaPersona.listaPersonas();

            ListaView.ItemSource = lista;
        }

    }
}
