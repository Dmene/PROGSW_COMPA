using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libPinaterialo
{
    public class clsFacturar
    {
        #region "Atributos"
        private float fltVrdoc;
        private int intCant;
        private float fltSubtot;
        private string strError;
        #endregion
        #region "Constructor"
        public clsFacturar()
        {
            fltVrdoc = 0;
            intCant = 0;
            fltSubtot =0;
            strError = string.Empty;
    }
        #endregion
        #region "Propiedades"
        public float vrDocena
        {
            set { fltVrdoc = value; }
        }
        //salida
        public string Error
        {
            get { return strError; }
        #endregion
        #region "Metodos Privados"
            private bool Validar()
        {
            if(fltVrdoc <= 0)
            {
                strError = "Error Valor de la docena no valido";
                return false;
            }
            return true;
        }
        #endregion
        #region "Metodos Publicos"

        #endregion
    }
}
