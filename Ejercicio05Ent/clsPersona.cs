namespace Ejercicio05Ent
{
    public class clsPersona
    {

        public String Nombre { get; set; }

        public String Apellidos { get; set; }

        public int Edad {  get; set; }

        public clsPersona(string nombre, string apellidos, int edad) 
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Edad = edad;
        }
    }
}
