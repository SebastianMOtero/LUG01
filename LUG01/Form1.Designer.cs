namespace LUG01
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAbrirBD = new System.Windows.Forms.Button();
            this.btnCerrarBD = new System.Windows.Forms.Button();
            this.txtIDPais = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(437, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(199, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnAbrirBD
            // 
            this.btnAbrirBD.Location = new System.Drawing.Point(564, 158);
            this.btnAbrirBD.Name = "btnAbrirBD";
            this.btnAbrirBD.Size = new System.Drawing.Size(99, 58);
            this.btnAbrirBD.TabIndex = 2;
            this.btnAbrirBD.Text = "Abrir Base de Datos";
            this.btnAbrirBD.UseVisualStyleBackColor = true;
            this.btnAbrirBD.Click += new System.EventHandler(this.btnAbrirBD_Click);
            // 
            // btnCerrarBD
            // 
            this.btnCerrarBD.Location = new System.Drawing.Point(564, 241);
            this.btnCerrarBD.Name = "btnCerrarBD";
            this.btnCerrarBD.Size = new System.Drawing.Size(99, 58);
            this.btnCerrarBD.TabIndex = 3;
            this.btnCerrarBD.Text = "Cerrar Base de Datos";
            this.btnCerrarBD.UseVisualStyleBackColor = true;
            this.btnCerrarBD.Click += new System.EventHandler(this.btnCerrarBD_Click);
            // 
            // txtIDPais
            // 
            this.txtIDPais.Location = new System.Drawing.Point(153, 47);
            this.txtIDPais.Name = "txtIDPais";
            this.txtIDPais.Size = new System.Drawing.Size(100, 26);
            this.txtIDPais.TabIndex = 4;
            this.txtIDPais.TextChanged += new System.EventHandler(this.txtIDPais_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(153, 92);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 26);
            this.txtNombre.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(272, 47);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 58);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIDPais);
            this.Controls.Add(this.btnCerrarBD);
            this.Controls.Add(this.btnAbrirBD);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAbrirBD;
        private System.Windows.Forms.Button btnCerrarBD;
        private System.Windows.Forms.TextBox txtIDPais;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
    }
}

