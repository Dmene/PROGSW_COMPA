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
        private float fltporcIva;
        private float fltVrDscto;
        private float fltTotAPag;
        private float fltVrIVA;
        private string strError;
        #endregion
        #region "Constructor"
        public clsFacturar()
        {
            fltVrdoc = 0;
            fltporcIva = 0;
            intCant = 0;
            fltSubtot =0;
            fltVrDscto=0;
            fltTotAPag=0;
            fltVrIVA=0;
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
            
        }
        #endregion
        #region "Metodos Privados"
            private bool Validar()
        {
            if(fltVrdoc <= 0)
            {
                strError = "Error Valor de la docena no valido";
                return false;
            }
            if (intCant <= 0)
            {
                strError = "la cantidad de las unidades no es valida";
                return false;
            }
            if (fltporcIva < 0 || fltporcIva > 25)
            {
                strError = "el porcentaje no es valido";
                return false;
            }
            return true;
        }
        #endregion
        #region "Metodos Publicos"
        public bool facturar() 
        {
            //subtotal, valor descuentootorgado ,valor iva y total a pagar
            float vrUnit = fltVrdoc / 12;
            float fltPDesc;
            try
            {
                if ( ! Validar() )
                    return false;

                fltSubtot = intCant * vrUnit;
                fltPDesc = (intCant <= 12) ? 0 : (intCant <= 24) ? 10 : (intCant <= 36) ? 15: 20;
                fltVrDscto = fltSubtot * fltPDesc / 100;
                fltVrIVA = (fltSubtot - fltVrDscto) * fltporcIva / 100;
                fltTotAPag = fltSubtot - fltVrDscto + fltVrIVA;
                return true;
                
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
           
            }
        }
        #endregion
    }
}
