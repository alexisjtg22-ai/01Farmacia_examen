namespace Farmacia
{
    partial class FrmMedicamentos
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
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.PanelContenido = new System.Windows.Forms.Panel();
            this.PanelLateral = new System.Windows.Forms.Panel();
            this.btnGuardarMedicamento = new System.Windows.Forms.Button();
            this.btnEditarMedicamento = new System.Windows.Forms.Button();
            this.btnEliminarMedicamento = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtpriac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtconce = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtlabo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtregis = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtrequiere = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PanelSuperior.SuspendLayout();
            this.PanelContenido.SuspendLayout();
            this.PanelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PanelSuperior.Controls.Add(this.lblTitulo);
            this.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(984, 70);
            this.PanelSuperior.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(20, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(184, 34);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Medicamentos";
            // 
            // PanelContenido
            // 
            this.PanelContenido.AutoScroll = true;
            this.PanelContenido.BackColor = System.Drawing.Color.White;
            this.PanelContenido.Controls.Add(this.dataGridView1);
            this.PanelContenido.Controls.Add(this.PanelLateral);
            this.PanelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenido.Location = new System.Drawing.Point(0, 70);
            this.PanelContenido.Name = "PanelContenido";
            this.PanelContenido.Size = new System.Drawing.Size(984, 541);
            this.PanelContenido.TabIndex = 1;
            // 
            // PanelLateral
            // 
            this.PanelLateral.BackColor = System.Drawing.Color.LightGray;
            this.PanelLateral.Controls.Add(this.txtrequiere);
            this.PanelLateral.Controls.Add(this.label7);
            this.PanelLateral.Controls.Add(this.txtregis);
            this.PanelLateral.Controls.Add(this.label6);
            this.PanelLateral.Controls.Add(this.txtlabo);
            this.PanelLateral.Controls.Add(this.label5);
            this.PanelLateral.Controls.Add(this.txtpre);
            this.PanelLateral.Controls.Add(this.label4);
            this.PanelLateral.Controls.Add(this.txtconce);
            this.PanelLateral.Controls.Add(this.label3);
            this.PanelLateral.Controls.Add(this.txtpriac);
            this.PanelLateral.Controls.Add(this.label2);
            this.PanelLateral.Controls.Add(this.txtnombre);
            this.PanelLateral.Controls.Add(this.label1);
            this.PanelLateral.Controls.Add(this.btnGuardarMedicamento);
            this.PanelLateral.Controls.Add(this.btnEditarMedicamento);
            this.PanelLateral.Controls.Add(this.btnEliminarMedicamento);
            this.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLateral.Location = new System.Drawing.Point(0, 0);
            this.PanelLateral.Name = "PanelLateral";
            this.PanelLateral.Size = new System.Drawing.Size(250, 541);
            this.PanelLateral.TabIndex = 0;
            // 
            // btnGuardarMedicamento
            // 
            this.btnGuardarMedicamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarMedicamento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarMedicamento.Location = new System.Drawing.Point(51, 395);
            this.btnGuardarMedicamento.Name = "btnGuardarMedicamento";
            this.btnGuardarMedicamento.Size = new System.Drawing.Size(180, 40);
            this.btnGuardarMedicamento.TabIndex = 4;
            this.btnGuardarMedicamento.Text = "Guardar";
            this.btnGuardarMedicamento.UseVisualStyleBackColor = true;
            this.btnGuardarMedicamento.Click += new System.EventHandler(this.btnGuardarMedicamento_Click);
            // 
            // btnEditarMedicamento
            // 
            this.btnEditarMedicamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarMedicamento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarMedicamento.Location = new System.Drawing.Point(51, 441);
            this.btnEditarMedicamento.Name = "btnEditarMedicamento";
            this.btnEditarMedicamento.Size = new System.Drawing.Size(180, 40);
            this.btnEditarMedicamento.TabIndex = 3;
            this.btnEditarMedicamento.Text = "Editar";
            this.btnEditarMedicamento.UseVisualStyleBackColor = true;
            this.btnEditarMedicamento.Click += new System.EventHandler(this.btnEditarMedicamento_Click);
            // 
            // btnEliminarMedicamento
            // 
            this.btnEliminarMedicamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarMedicamento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMedicamento.Location = new System.Drawing.Point(51, 489);
            this.btnEliminarMedicamento.Name = "btnEliminarMedicamento";
            this.btnEliminarMedicamento.Size = new System.Drawing.Size(180, 40);
            this.btnEliminarMedicamento.TabIndex = 1;
            this.btnEliminarMedicamento.Text = "Eliminar";
            this.btnEliminarMedicamento.UseVisualStyleBackColor = true;
            this.btnEliminarMedicamento.Click += new System.EventHandler(this.btnEliminarMedicamento_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(250, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(734, 541);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(20, 39);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 6;
            // 
            // txtpriac
            // 
            this.txtpriac.Location = new System.Drawing.Point(20, 78);
            this.txtpriac.Name = "txtpriac";
            this.txtpriac.Size = new System.Drawing.Size(100, 20);
            this.txtpriac.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Principio activo";
            // 
            // txtconce
            // 
            this.txtconce.Location = new System.Drawing.Point(20, 117);
            this.txtconce.Name = "txtconce";
            this.txtconce.Size = new System.Drawing.Size(100, 20);
            this.txtconce.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Concentracion";
            // 
            // txtpre
            // 
            this.txtpre.Location = new System.Drawing.Point(20, 160);
            this.txtpre.Name = "txtpre";
            this.txtpre.Size = new System.Drawing.Size(100, 20);
            this.txtpre.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Presentacion";
            // 
            // txtlabo
            // 
            this.txtlabo.Location = new System.Drawing.Point(20, 199);
            this.txtlabo.Name = "txtlabo";
            this.txtlabo.Size = new System.Drawing.Size(100, 20);
            this.txtlabo.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Laboratorio";
            // 
            // txtregis
            // 
            this.txtregis.Location = new System.Drawing.Point(20, 241);
            this.txtregis.Name = "txtregis";
            this.txtregis.Size = new System.Drawing.Size(100, 20);
            this.txtregis.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Registro sanitario";
            // 
            // txtrequiere
            // 
            this.txtrequiere.Location = new System.Drawing.Point(20, 284);
            this.txtrequiere.Name = "txtrequiere";
            this.txtrequiere.Size = new System.Drawing.Size(100, 20);
            this.txtrequiere.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Requiere receta";
            // 
            // FrmMedicamentos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.PanelContenido);
            this.Controls.Add(this.PanelSuperior);
            this.Name = "FrmMedicamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMedicamentos";
            this.Load += new System.EventHandler(this.FrmMedicamentos_Load);
            this.PanelSuperior.ResumeLayout(false);
            this.PanelSuperior.PerformLayout();
            this.PanelContenido.ResumeLayout(false);
            this.PanelLateral.ResumeLayout(false);
            this.PanelLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel PanelContenido;
        private System.Windows.Forms.Panel PanelLateral;
        private System.Windows.Forms.Button btnGuardarMedicamento;
        private System.Windows.Forms.Button btnEditarMedicamento;
        private System.Windows.Forms.Button btnEliminarMedicamento;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtrequiere;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtregis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtlabo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtconce;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpriac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label1;
    }
}