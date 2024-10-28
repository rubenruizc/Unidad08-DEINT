namespace Ejercicio05Ent
{
    public class clsPersona
    {
        #region Propiedades

        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public int Edad { get; set; }

        #endregion

        #region constructor

        public clsPersona(string nombre, string apellidos, int edad)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Edad = edad;
        }

        #endregion
    }
}