using _1._1.DataTransferObject.Generic;
using System;
using System.Collections.Generic;

namespace _1._1.DataTransferObject.Object
{
    public class DtoContacto : DtoGeneric
    {
        #region properties

        public int CodigoContacto { get; set; }
        public string NombreApellido { get; set; }
        public string Mensaje { get; set; }
        public string Email { get; set; }
        public DateTime FechaEnvio { get; set; }

        #endregion

        #region parents

        #endregion

        #region childs

        public List<DtoRespuestaContacto> childRespuestaContacto { get; set; }

        #endregion
    }
}
