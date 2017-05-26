using _5._1.DataAccess.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _5._1.DataAccess.Entity
{
    [Table("RespuestaContacto")]
    public class RespuestaContacto : EntityGeneric
    {
        #region properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CodigoRespuestaContacto { get; set; }
        public int CodigoContacto { get; set; }
        public int CodigoUsuario { get; set; }
        public string Email { get; set; }
        public string MensajeRespuesta { get; set; }
        public char Estado { get; set; }
        public DateTime FechaRespuesta { get; set; }

        #endregion

        #region parents

        [ForeignKey("CodigoUsuario")]
        public virtual Usuario parentUsuario { get; set; }

        [ForeignKey("CodigoContacto")]
        public virtual Contacto parentContacto { get; set; }

        #endregion

        #region childs

        #endregion
    }
}
