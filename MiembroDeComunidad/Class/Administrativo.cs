
namespace MiembroDeComunidad.Class
{
    public class Administrativo : Empleado
    {
        public string? Departamento { get; set; }
        public Int32? TiempoLaboral { get; set; }

        public Administrativo(string departamento, string tiempolaboral) : base (departamento, tiempolaboral)

        {
            Departamento = Departamento;
            TiempoLaboral = TiempoLaboral;
        }

        public void InformacionAdministrativo()
        {
            InformacionEmpleado();
            Console.WriteLine("Departamento: " + Departamento);
            Console.WriteLine("Tiempo Laboral: " + TiempoLaboral);

        }
    }
}
