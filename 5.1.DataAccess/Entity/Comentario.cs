using _5._1.DataAccess.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _5._1.DataAccess.Entity
{
    [Table("Comentario")]
    public class Comentario : EntityGeneric
    {
        #region properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CodigoComentario { get; set; }
        public int CodigoPublicacion { get; set; }
        public int CodigoUsuario { get; set; }
        public string Cuerpo { get; set; }

        #endregion

        #region parents

        [ForeignKey("CodigoPublicacion")]
        public virtual Publicacion parentPublicacion { get; set; }

        [ForeignKey("CodigoUsuario")]
        public virtual Usuario parentUsuario { get; set; }

        #endregion

        #region childs

        #endregion
    }
}
