
using System.ComponentModel;

namespace MiembroDeComunidad.Class
{
    public class Administrador : Docente
    {
        public string? Requerimiento { get; set; }
        public string? Requidad { get; set; }
      


        public Administrador(string requerimiento, string requidad) : base (requerimiento, requidad)
        {
            Requerimiento = Requerimiento;
            Requidad = Requidad;
        }

        public void InformacionAdministrador()
        {
            InformacionDocente();
            Console.WriteLine("Requerimiento: " + Requerimiento);
            Console.WriteLine("Requidad: " + Requidad);

        }
    }
}
