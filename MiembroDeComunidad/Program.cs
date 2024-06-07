

using MiembroDeComunidad.Class;

static void main(string[] args)
{
    Empleado empleado = new Empleado()
    {
        Nombre = "Nelson",
        Direccion = "Arroyo Hondo",
        Cargo = "Supervisor",
        Sueldo = 5000
    };

    empleado.Informacion();
    empleado.InformacionEmpleado();

}