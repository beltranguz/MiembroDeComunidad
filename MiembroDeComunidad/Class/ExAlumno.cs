

namespace MiembroDeComunidad.Class
{
    public class ExAlumno : MiembroDeComunidad
    {
        public Int16? Periodo { get; set; }
        public string? Motivo { get; set; }

        public ExAlumno(string periodo, string motivo) : base(periodo, motivo)

        {
            Periodo = Periodo;
            Motivo = Motivo;

        }

        public void InformacionExAlumno()

        {
            Informacion();
            Console.WriteLine("Periodo: "+ Periodo);
            Console.WriteLine("Motivo: "+  Motivo);


        }
    }
}
