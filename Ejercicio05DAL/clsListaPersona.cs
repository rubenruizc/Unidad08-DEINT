using Ejercicio05Ent;



namespace Ejercicio05DAL
{
    public class clsListaPersonas
    {

        /// <summary>
        /// Funcion que devuelve una lista con 10 objetos de tipo persona
        /// </summary>
        /// <returns>Listado de personas</returns>
        static public List<clsPersona> listaPersonas()
        {
            List<clsPersona> lista = new List<clsPersona>();

            clsPersona p1 = new clsPersona("Auri", "Ruiz Castaño", 19);
            clsPersona p2 = new clsPersona("Lionel Andrés", "Messi Cuccitini", 19);
            clsPersona p3 = new clsPersona("Jenri", "Muñoz Galloso", 19);
            clsPersona p4 = new clsPersona("Cristiano Ronaldo", "Dos Santos Aveiro", 23);
            clsPersona p5 = new clsPersona("Neymar", "da Silva Santos Júnior", 19);
            clsPersona p6 = new clsPersona("Nabil", "Fekir", 12);
            clsPersona p7 = new clsPersona("Francisco", "Alarcon", 20);
            clsPersona p8 = new clsPersona("Vitor", "Roque", 30);
           
            

            lista.Add(p1);
            lista.Add(p2);
            lista.Add(p3);
            lista.Add(p4);
            lista.Add(p5);
            lista.Add(p6);
            lista.Add(p7);
            lista.Add(p8);
            


            return lista;
        }
    }
}