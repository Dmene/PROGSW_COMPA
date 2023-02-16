
namespace appPractica1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.VlrDocena = new System.Windows.Forms.Label();
            this.Valdocena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txtcantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ValIVA = new System.Windows.Forms.TextBox();
            this.GrbApagar = new System.Windows.Forms.GroupBox();
            this.Txttotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtvalorIVA = new System.Windows.Forms.TextBox();
            this.Txtdescuentop = new System.Windows.Forms.TextBox();
            this.Txtsubtotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnFacturar = new System.Windows.Forms.Button();
            this.Btnlimpiar = new System.Windows.Forms.Button();
            this.Btnterminar = new System.Windows.Forms.Button();
            this.GrbApagar.SuspendLayout();
            this.SuspendLayout();
            // 
            // VlrDocena
            // 
            this.VlrDocena.AutoSize = true;
            this.VlrDocena.BackColor = System.Drawing.Color.Brown;
            this.VlrDocena.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.VlrDocena.Font = new System.Drawing.Font("Old English Text MT", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VlrDocena.Location = new System.Drawing.Point(59, 70);
            this.VlrDocena.Name = "VlrDocena";
            this.VlrDocena.Size = new System.Drawing.Size(145, 34);
            this.VlrDocena.TabIndex = 0;
            this.VlrDocena.Text = "VlrDocena";
            // 
            // Valdocena
            // 
            this.Valdocena.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Valdocena.Location = new System.Drawing.Point(287, 82);
            this.Valdocena.Name = "Valdocena";
            this.Valdocena.Size = new System.Drawing.Size(140, 20);
            this.Valdocena.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cantidad(Unidades)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Brown;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Old English Text MT", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(444, 53);
            this.label2.TabIndex = 3;
            this.label2.Text = "Piñateria el Ultimo palo";
            // 
            // Txtcantidad
            // 
            this.Txtcantidad.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Txtcantidad.Location = new System.Drawing.Point(287, 128);
            this.Txtcantidad.Name = "Txtcantidad";
            this.Txtcantidad.Size = new System.Drawing.Size(140, 20);
            this.Txtcantidad.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Old English Text MT", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "% iva:";
            // 
            // ValIVA
            // 
            this.ValIVA.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ValIVA.Location = new System.Drawing.Point(287, 171);
            this.ValIVA.MaxLength = 5;
            this.ValIVA.Name = "ValIVA";
            this.ValIVA.Size = new System.Drawing.Size(140, 20);
            this.ValIVA.TabIndex = 6;
            // 
            // GrbApagar
            // 
            this.GrbApagar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.GrbApagar.Controls.Add(this.Txttotal);
            this.GrbApagar.Controls.Add(this.label7);
            this.GrbApagar.Controls.Add(this.TxtvalorIVA);
            this.GrbApagar.Controls.Add(this.Txtdescuentop);
            this.GrbApagar.Controls.Add(this.Txtsubtotal);
            this.GrbApagar.Controls.Add(this.label6);
            this.GrbApagar.Controls.Add(this.label5);
            this.GrbApagar.Controls.Add(this.label4);
            this.GrbApagar.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbApagar.Location = new System.Drawing.Point(28, 276);
            this.GrbApagar.Name = "GrbApagar";
            this.GrbApagar.Size = new System.Drawing.Size(399, 164);
            this.GrbApagar.TabIndex = 7;
            this.GrbApagar.TabStop = false;
            this.GrbApagar.Text = "     A Pagar    ";
            this.GrbApagar.Visible = false;
            // 
            // Txttotal
            // 
            this.Txttotal.Location = new System.Drawing.Point(158, 124);
            this.Txttotal.Name = "Txttotal";
            this.Txttotal.Size = new System.Drawing.Size(174, 27);
            this.Txttotal.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Brown;
            this.label7.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total A Pagar";
            // 
            // TxtvalorIVA
            // 
            this.TxtvalorIVA.Location = new System.Drawing.Point(157, 91);
            this.TxtvalorIVA.Name = "TxtvalorIVA";
            this.TxtvalorIVA.Size = new System.Drawing.Size(175, 27);
            this.TxtvalorIVA.TabIndex = 5;
            // 
            // Txtdescuentop
            // 
            this.Txtdescuentop.Location = new System.Drawing.Point(157, 59);
            this.Txtdescuentop.Name = "Txtdescuentop";
            this.Txtdescuentop.Size = new System.Drawing.Size(175, 27);
            this.Txtdescuentop.TabIndex = 4;
            // 
            // Txtsubtotal
            // 
            this.Txtsubtotal.Location = new System.Drawing.Point(157, 26);
            this.Txtsubtotal.Name = "Txtsubtotal";
            this.Txtsubtotal.Size = new System.Drawing.Size(175, 27);
            this.Txtsubtotal.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Brown;
            this.label6.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Valor Iva";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Brown;
            this.label5.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Descuento";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Brown;
            this.label4.Font = new System.Drawing.Font("Old English Text MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Subtotal";

            // 
            // BtnFacturar
            // 
            this.BtnFacturar.BackColor = System.Drawing.Color.Brown;
            this.BtnFacturar.Font = new System.Drawing.Font("Old English Text MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFacturar.Location = new System.Drawing.Point(329, 223);
            this.BtnFacturar.Name = "BtnFacturar";
            this.BtnFacturar.Size = new System.Drawing.Size(98, 47);
            this.BtnFacturar.TabIndex = 8;
            this.BtnFacturar.Text = "Facturar";
            this.BtnFacturar.UseVisualStyleBackColor = false;
            // 
            // Btnlimpiar
            // 
            this.Btnlimpiar.BackColor = System.Drawing.Color.Brown;
            this.Btnlimpiar.Font = new System.Drawing.Font("Old English Text MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnlimpiar.Location = new System.Drawing.Point(26, 223);
            this.Btnlimpiar.Name = "Btnlimpiar";
            this.Btnlimpiar.Size = new System.Drawing.Size(107, 47);
            this.Btnlimpiar.TabIndex = 9;
            this.Btnlimpiar.Text = "Limpiar";
            this.Btnlimpiar.UseVisualStyleBackColor = false;
            // 
            // Btnterminar
            // 
            this.Btnterminar.BackColor = System.Drawing.Color.Brown;
            this.Btnterminar.Font = new System.Drawing.Font("Old English Text MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnterminar.Location = new System.Drawing.Point(187, 446);
            this.Btnterminar.Name = "Btnterminar";
            this.Btnterminar.Size = new System.Drawing.Size(100, 40);
            this.Btnterminar.TabIndex = 10;
            this.Btnterminar.Text = "Terminar";
            this.Btnterminar.UseVisualStyleBackColor = false;
            this.Btnterminar.Click += new System.EventHandler(this.Btnterminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(466, 488);
            this.ControlBox = false;
            this.Controls.Add(this.Btnterminar);
            this.Controls.Add(this.Btnlimpiar);
            this.Controls.Add(this.BtnFacturar);
            this.Controls.Add(this.GrbApagar);
            this.Controls.Add(this.ValIVA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txtcantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Valdocena);
            this.Controls.Add(this.VlrDocena);
            this.Name = "Form1";
            this.Text = "Practica#1";
            this.GrbApagar.ResumeLayout(false);
            this.GrbApagar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VlrDocena;
        private System.Windows.Forms.TextBox Valdocena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txtcantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ValIVA;
        private System.Windows.Forms.GroupBox GrbApagar;
        private System.Windows.Forms.TextBox Txtsubtotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnFacturar;
        private System.Windows.Forms.Button Btnlimpiar;
        private System.Windows.Forms.TextBox TxtvalorIVA;
        private System.Windows.Forms.TextBox Txtdescuentop;
        private System.Windows.Forms.TextBox Txttotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Btnterminar;
    }
}

