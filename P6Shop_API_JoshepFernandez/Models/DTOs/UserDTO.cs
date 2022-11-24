namespace P6Shop_API_JoshepFernandez.Models.DTOs
{
    public class UserDTO
    {
        //Un DTO (Data Transfer Object) es el metodo mas usado
        //para pasar estructuras entre un API y una APP (o cualquier otro UI)
        //Se hace principalmente por dos rozones:
        //1. Para que el equpo de desarrollo del UI (o posibles ingenierias inversas)
        //no entiendan la estructura de los models en el API.
        //2. Simplificar objetos muy complejos, ya qie es mas rapido pasar la minima data
        //requerida por los objetos jso entre el app y el API.
        //3. Si es nesesario volver a generar los modelos con el scaffold -f (porque hubo un
        //cambio en la estructura de una tabla por ejemplo) no es necesario cambiar nada en el
        //controller si la estructura del modelo cambio y ademas habiamos hecho en el
        //modelo generado automaticamente

        //NOTA: para efectos de ejemplificar el uso del DTO, se manejaran los
        //nombres en español de las propiedades.


        public int IdUsuario { get; set; }
        public string Nombre { get; set; } = null!;
        public string CorreoElectronico { get; set; } = null!;
        public string Contrasennia { get; set; } = null!;
        public string CorreoRespaldo { get; set; } = null!;
        public string NumeroTelefono { get; set; } = null!;
        public int IDRol { get; set; }
        public int IDPais { get; set; }
        public string RolDescripcion { get; set; } = null!;
        public string PaisNombre { get; set; } = null;


        //No es necesario en todos los casos escribir las composiciones, este es uno.
    }
}
