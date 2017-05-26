using _1._1.DataTransferObject.Generic;

namespace _1._1.DataTransferObject.Object
{
    public class DtoArchivo : DtoGeneric
    {
        #region properties

        public int CodigoArchivo { get; set; }
        public int CodigoPublicacion { get; set; }
        public string Nombre { get; set; }
        public string Extension { get; set; }
        public string Estado { get; set; }

        #endregion

        #region parents

        public virtual DtoPublicacion parentPublicacion { get; set; }

        #endregion

        #region childs

        #endregion
    }
}
