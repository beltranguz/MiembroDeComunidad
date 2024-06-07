
namespace MiembroDeComunidad.Class
{
    public class Docente : Empleado

    {
        public string? TiempoLaboral {  get; set; }
        public string? Tipo { get; set; }

        public Docente(string TiempoLaboral, string Tipo) : base (TiempoLaboral, Tipo) 
        {

            this.TiempoLaboral = TiempoLaboral;
            this.Tipo = Tipo; 
        }

        public void InformacionDocente()

        {
            InformacionEmpleado();
            Console.WriteLine("Tiempo Laboral: " + TiempoLaboral);
            Console.WriteLine("Tipo: " + Tipo);

        }
    }
}
