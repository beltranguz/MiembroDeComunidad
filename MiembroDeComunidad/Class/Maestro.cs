
namespace MiembroDeComunidad.Class
{
    public class Maestro : Docente
    {
        public string? Asignatura { get; set; }
        public Int16? Nivel { get; set; }
        public string? Categoria { get; set; }

        public Maestro(string asignatura, string nivel, string categoria) : base(asignatura, nivel) 
        {
            Asignatura = Asignatura;
            Nivel = Nivel;
            Categoria = Categoria;
        }   

        public void InformacionMaestro()
        {
            InformacionDocente();
            Console.WriteLine("Asignatura: " + Asignatura);
            Console.WriteLine("Nivel: " +  Nivel);
            Console.WriteLine("Categoria: " + Categoria);

        }
    }
}
