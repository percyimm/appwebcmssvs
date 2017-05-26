using _1._1.DataTransferObject.Generic;
using System;

namespace _1._1.DataTransferObject.Object
{
    public class DtoRespuestaContacto : DtoGeneric
    {
        #region properties

        public int CodigoRespuestaContacto { get; set; }
        public int CodigoContacto { get; set; }
        public int CodigoUsuario { get; set; }
        public string Email { get; set; }
        public string MensajeRespuesta { get; set; }
        public char Estado { get; set; }
        public DateTime FechaRespuesta { get; set; }

        #endregion

        #region parents

        public virtual DtoUsuario parentUsuario { get; set; }

        public virtual DtoContacto parentContacto { get; set; }

        #endregion

        #region childs

        #endregion
    }
}
