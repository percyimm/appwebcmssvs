using _5._1.DataAccess.Generic;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _5._1.DataAccess.Entity
{
    [Table("Publicacion")]
    public class Publicacion : EntityGeneric
    {
        #region properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CodigoPublicacion { get; set; }
        public int CodigoUsuario { get; set; }
        public string Titulo { get; set; }
        public string Cuerpo { get; set; }
        public string Categoria { get; set; }
        public char Estado { get; set; }

        #endregion

        #region parents

        [ForeignKey("CodigoUsuario")]
        public virtual Usuario parentUsuario { get; set; }

        #endregion

        #region childs

        [ForeignKey("CodigoPublicacion")]
        public List<Archivo> childArchivo { get; set; }

        [ForeignKey("CodigoPublicacion")]
        public List<Comentario> childComentario { get; set; }

        #endregion
    }
}
