using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appPractica1
//referenciar y usar
{
    using libPinaterialo;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void Btnterminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btnlimpiar_Click(object sender, EventArgs e)
        {
            this.txtVrDocena.Text = string.Empty;
            this.Txtcantidad.Text = string.Empty;
            this.TxtvalorIVA.Text = string.Empty;
            this.GrbApagar.Visible = false;
            this.txtVrDocena.Focus();

        }

        private void BtnFacturar_Click(object sender, EventArgs e)
        {
            int intC;
            float fltvrDoc, fltPIva;

            try
            { // captura de la info de entrada
                fltvrDoc =Convert.ToSingle (this.txtVrDocena.Text);
                fltPIva = Convert.ToSingle(this.TxtvalorIVA.Text);
                intC = Convert.ToInt32(this.Txtcantidad.Text);
              // crear la instancia de clase
                clsFacturar of = new clsFacturar();
                //envio de info a la clase 
                
                //invocacion del metodo y tratamiento del error

                //mostrar info



            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
