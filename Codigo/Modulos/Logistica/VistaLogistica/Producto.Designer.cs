﻿
namespace VistaLogistica
{
    partial class Producto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtact = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCostoCompra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtMarca = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtTipo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtLinea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TxtDesc = new System.Windows.Forms.TextBox();
            this.TxtCodigoRef = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgProducto = new System.Windows.Forms.DataGridView();
            this.Medida = new System.Windows.Forms.Label();
            this.TxtMedida = new System.Windows.Forms.TextBox();
            this.navegador1 = new NavegadorVista.Navegador();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(174, 29);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(177, 20);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.Tag = "pk_codigo_producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo del Producto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtMedida);
            this.groupBox2.Controls.Add(this.Medida);
            this.groupBox2.Controls.Add(this.txtact);
            this.groupBox2.Controls.Add(this.txtBuscar);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.txtPrecioVenta);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtCostoCompra);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtExistencia);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TxtMarca);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TxtTipo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TxtLinea);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.TxtDesc);
            this.groupBox2.Controls.Add(this.TxtCodigoRef);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(76, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(462, 342);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // txtact
            // 
            this.txtact.Location = new System.Drawing.Point(431, 270);
            this.txtact.Name = "txtact";
            this.txtact.Size = new System.Drawing.Size(17, 20);
            this.txtact.TabIndex = 2;
            this.txtact.Tag = "estatus_producto";
            this.txtact.Visible = false;
            this.txtact.TextChanged += new System.EventHandler(this.txtact_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(372, 272);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Activo";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(174, 273);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(177, 20);
            this.txtPrecioVenta.TabIndex = 56;
            this.txtPrecioVenta.Tag = "precio_venta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label9.Location = new System.Drawing.Point(17, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 18);
            this.label9.TabIndex = 55;
            this.label9.Text = "Precio de Venta";
            // 
            // txtCostoCompra
            // 
            this.txtCostoCompra.Location = new System.Drawing.Point(174, 239);
            this.txtCostoCompra.Name = "txtCostoCompra";
            this.txtCostoCompra.Size = new System.Drawing.Size(177, 20);
            this.txtCostoCompra.TabIndex = 54;
            this.txtCostoCompra.Tag = "costo_compra";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label8.Location = new System.Drawing.Point(17, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 18);
            this.label8.TabIndex = 53;
            this.label8.Text = "Costo de Compra";
            // 
            // txtExistencia
            // 
            this.txtExistencia.Location = new System.Drawing.Point(174, 206);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(177, 20);
            this.txtExistencia.TabIndex = 52;
            this.txtExistencia.Tag = "existencia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label7.Location = new System.Drawing.Point(17, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 18);
            this.label7.TabIndex = 51;
            this.label7.Text = "Existencia";
            // 
            // TxtMarca
            // 
            this.TxtMarca.Location = new System.Drawing.Point(174, 175);
            this.TxtMarca.Name = "TxtMarca";
            this.TxtMarca.Size = new System.Drawing.Size(177, 20);
            this.TxtMarca.TabIndex = 50;
            this.TxtMarca.Tag = "fk_marca";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label6.Location = new System.Drawing.Point(17, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 18);
            this.label6.TabIndex = 49;
            this.label6.Text = "Tipo";
            // 
            // TxtTipo
            // 
            this.TxtTipo.Location = new System.Drawing.Point(174, 143);
            this.TxtTipo.Name = "TxtTipo";
            this.TxtTipo.Size = new System.Drawing.Size(177, 20);
            this.TxtTipo.TabIndex = 48;
            this.TxtTipo.Tag = "tipo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.Location = new System.Drawing.Point(17, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 47;
            this.label5.Text = "Descripcion";
            // 
            // TxtLinea
            // 
            this.TxtLinea.Location = new System.Drawing.Point(174, 115);
            this.TxtLinea.Name = "TxtLinea";
            this.TxtLinea.Size = new System.Drawing.Size(177, 20);
            this.TxtLinea.TabIndex = 46;
            this.TxtLinea.Tag = "fk_linea_inventario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(17, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 18);
            this.label3.TabIndex = 45;
            this.label3.Text = "Codigo de Referencia";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(361, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 24);
            this.button3.TabIndex = 44;
            this.button3.Text = "?";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(361, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 24);
            this.button2.TabIndex = 43;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TxtDesc
            // 
            this.TxtDesc.Location = new System.Drawing.Point(174, 89);
            this.TxtDesc.Name = "TxtDesc";
            this.TxtDesc.Size = new System.Drawing.Size(177, 20);
            this.TxtDesc.TabIndex = 42;
            this.TxtDesc.Tag = "descripcion";
            // 
            // TxtCodigoRef
            // 
            this.TxtCodigoRef.Location = new System.Drawing.Point(174, 56);
            this.TxtCodigoRef.Name = "TxtCodigoRef";
            this.TxtCodigoRef.Size = new System.Drawing.Size(177, 20);
            this.TxtCodigoRef.TabIndex = 39;
            this.TxtCodigoRef.Tag = "codigo_referencia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Linea de Inventario";
            // 
            // dtgProducto
            // 
            this.dtgProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProducto.Location = new System.Drawing.Point(11, 512);
            this.dtgProducto.Margin = new System.Windows.Forms.Padding(2);
            this.dtgProducto.Name = "dtgProducto";
            this.dtgProducto.RowHeadersWidth = 51;
            this.dtgProducto.RowTemplate.Height = 24;
            this.dtgProducto.Size = new System.Drawing.Size(582, 226);
            this.dtgProducto.TabIndex = 66;
            this.dtgProducto.Tag = "tbl_producto";
            // 
            // Medida
            // 
            this.Medida.AutoSize = true;
            this.Medida.Location = new System.Drawing.Point(19, 308);
            this.Medida.Name = "Medida";
            this.Medida.Size = new System.Drawing.Size(42, 13);
            this.Medida.TabIndex = 57;
            this.Medida.Text = "Medida";
            // 
            // TxtMedida
            // 
            this.TxtMedida.Location = new System.Drawing.Point(174, 308);
            this.TxtMedida.Name = "TxtMedida";
            this.TxtMedida.Size = new System.Drawing.Size(177, 20);
            this.TxtMedida.TabIndex = 58;
            this.TxtMedida.Tag = "medida";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(18, 7);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(574, 152);
            this.navegador1.TabIndex = 67;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 749);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.dtgProducto);
            this.Controls.Add(this.groupBox2);
            this.Name = "Producto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producto";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCostoCompra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtMarca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtTipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtLinea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TxtDesc;
        private System.Windows.Forms.TextBox TxtCodigoRef;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtact;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView dtgProducto;
        private System.Windows.Forms.TextBox TxtMedida;
        private System.Windows.Forms.Label Medida;
        private NavegadorVista.Navegador navegador1;
    }
}