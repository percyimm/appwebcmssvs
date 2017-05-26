using _5._1.DataAccess.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _5._1.DataAccess.Entity
{
    [Table("Archivo")]
    public class Archivo : EntityGeneric
    {
        #region properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CodigoArchivo { get; set; }
        public int CodigoPublicacion { get; set; }
        public string Nombre { get; set; }
        public string Extension { get; set; }
        public string Estado { get; set; }

        #endregion

        #region parents

        [ForeignKey("CodigoPublicacion")]
        public virtual Publicacion parentPublicacion { get; set; }

        #endregion

        #region childs

        #endregion
    }
}
