using Ejercicio05Ent;

namespace Ejercicio05DAL

{
    public class clsListaPersona
    {
        public List<clsPersona> listaPersona()
        {
            List<clsPersona> lista = new List<clsPersona> ();

            clsPersona p1 = new clsPersona("Rubén", "Ruiz", 18);
            clsPersona p2 = new clsPersona("Amaro", "Suarez", 50);
            clsPersona p3 = new clsPersona("Jenri", "Muñoz", 18);
            clsPersona p4 = new clsPersona("Lionel", "Messi", 18);
            clsPersona p5 = new clsPersona("Cristiano", "Ronaldo", 18);
            clsPersona p6 = new clsPersona("Neymar", "Da Silva", 18);
            clsPersona p7 = new clsPersona("Joaquin", "Sánchez", 18);
            clsPersona p8 = new clsPersona("Giovani", "Lo Celso", 18);
            clsPersona p9 = new clsPersona("Youssouf", "Sabaly", 18);
            clsPersona p10 = new clsPersona("Vitor", "Roque", 18);
            clsPersona p11 = new clsPersona("Aitor", "Ruibal", 18);
            clsPersona p12 = new clsPersona("Ez", "Abde", 18);
            clsPersona p13 = new clsPersona("Chimy", "Ávila", 18);
            clsPersona p14 = new clsPersona("Don Isco", "Alarcón", 18);



            lista.Add(p1);
            lista.Add(p2);
            lista.Add(p3);
            lista.Add(p4);
            lista.Add(p5);
            lista.Add(p6);
            lista.Add(p7);
            lista.Add(p8);
            lista.Add(p9);
            lista.Add(p10);
            lista.Add(p11);
            lista.Add(p12);
            lista.Add(p13);
            lista.Add(p14);

            return lista;

        }
    }
}
