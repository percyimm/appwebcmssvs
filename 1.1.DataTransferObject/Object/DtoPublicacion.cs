using _1._1.DataTransferObject.Generic;
using System.Collections.Generic;

namespace _1._1.DataTransferObject.Object
{
    public class DtoPublicacion : DtoGeneric
    {
        #region properties

        public int CodigoPublicacion { get; set; }
        public int CodigoUsuario { get; set; }
        public string Titulo { get; set; }
        public string Cuerpo { get; set; }
        public string Categoria { get; set; }
        public char Estado { get; set; }

        #endregion

        #region parents

        public virtual DtoUsuario parentUsuario { get; set; }

        #endregion

        #region childs

        public List<DtoArchivo> childArchivo { get; set; }

        public List<DtoComentario> childComentario { get; set; }

        #endregion
    }
}
