using _1._1.DataTransferObject.Generic;

namespace _1._1.DataTransferObject.Object
{
    public class DtoComentario : DtoGeneric
    {
        #region properties

        public int CodigoComentario { get; set; }
        public int CodigoPublicacion { get; set; }
        public int CodigoUsuario { get; set; }
        public string Cuerpo { get; set; }

        #endregion

        #region parents

        public virtual DtoPublicacion parentPublicacion { get; set; }
        public virtual DtoUsuario parentUsuario { get; set; }

        #endregion

        #region childs

        #endregion
    }
}
