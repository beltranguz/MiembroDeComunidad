

namespace MiembroDeComunidad.Class
{
    public class Estudiante : MiembroDeComunidad
    {
        public string? Matricula {  get; set; }
        public string? Anios { get; set; }

        public Estudiante(string matricula, string anios) : base (matricula, anios)
        {
            this.Matricula = matricula;
            this.Anios = anios;
        }

        public void InformacionEstudiantes()
        {
            Informacion();
            Console.WriteLine("Matricula: " + Matricula);
            Console.WriteLine("Anios: " + Anios);

        }
    }

  
}
