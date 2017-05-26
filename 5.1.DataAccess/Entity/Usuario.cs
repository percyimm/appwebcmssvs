using _5._1.DataAccess.Generic;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _5._1.DataAccess.Entity
{
    [Table("Usuario")]
    public class Usuario : EntityGeneric
    {
        #region properties        

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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

        #endregion

        #region childs

        [ForeignKey("CodigoUsuario")]
        public List<Comentario> childComentario { get; set; }

        [ForeignKey("CodigoUsuario")]
        public List<Publicacion> childPublicacion { get; set; }

        [ForeignKey("CodigoUsuario")]
        public List<RespuestaContacto> childRespuestaContacto { get; set; }

        #endregion
    }
}
