
namespace MiembroDeComunidad.Class
{
    public class MiembroDeComunidad
    {
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }

        

        public MiembroDeComunidad(string nombre, string direccion)
        
        {

            this.Nombre = Nombre;
            this.Direccion = Direccion;  
        }

        public void Informacion()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Direccion: " + Direccion);
            

        }

    }

}
