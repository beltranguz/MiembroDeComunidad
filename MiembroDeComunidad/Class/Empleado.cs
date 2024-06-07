
namespace MiembroDeComunidad.Class
{
    public class Empleado : MiembroDeComunidad
    {
        public string? Cargo { get; set; }
        public Int16? Sueldo { get; set; }

        public Empleado(string cargo, string sueldo) : base (cargo, sueldo)

        {
            this.Cargo = Cargo;
            this.Sueldo = Sueldo;
        }

        public void InformacionEmpleado()
        {
            Informacion();
            Console.WriteLine("Cargo: " + Cargo);
            Console.WriteLine("Sueldo: " + Sueldo);

        }
    }
}
