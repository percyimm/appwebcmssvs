using _1._1.DataTransferObject.Generic;
using System.Collections.Generic;

namespace _1._1.DataTransferObject.Object
{
    public class DtoUsuario : DtoGeneric
    {
        #region properties        

        public int CodigoUsario { get; set; }
        public string Email { get; set; }
        public string Pasword { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Documento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public char Sexo { get; set; }
        public string Rol { get; set; }
        public char Estado { get; set; }

        #endregion

        #region parents

        public List<DtoComentario> childComentario { get; set; }

        public List<DtoPublicacion> childPublicacion { get; set; }

        public List<DtoRespuestaContacto> childRespuestaContacto { get; set; }

        #endregion

        #region childs

        #endregion
    }
}
