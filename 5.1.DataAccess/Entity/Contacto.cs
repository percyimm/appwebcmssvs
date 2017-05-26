using _5._1.DataAccess.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _5._1.DataAccess.Entity
{
    [Table("Contacto")]
    public class Contacto : EntityGeneric
    {
        #region properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CodigoContacto { get; set; }
        public string NombreApellido { get; set; }
        public string Mensaje { get; set; }
        public string Email { get; set; }
        public DateTime FechaEnvio { get; set; }

        #endregion

        #region parents

        #endregion

        #region childs

        [ForeignKey("CodigoContacto")]
        public List<RespuestaContacto> childRespuestaContacto { get; set; }

        #endregion
    }
}
