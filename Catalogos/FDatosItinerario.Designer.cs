namespace AccessControl.Catalogos
{
    partial class FDatosItinerario
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addAccess = new System.Windows.Forms.Button();
            this.editAccess = new System.Windows.Forms.Button();
            this.deleteAccess = new System.Windows.Forms.Button();
            this.queryAccess = new System.Windows.Forms.Button();
            this.HorarioSemanasTipo = new System.Windows.Forms.DataGridView();
            this.DiaLunes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaMartes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaMiercoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaJueves = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaViernes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaSabado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaDomingo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.close = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HorarioSemanasTipo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Location = new System.Drawing.Point(80, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(342, 20);
            this.textBox1.TabIndex = 1;
            // 
            // addAccess
            // 
            this.addAccess.Location = new System.Drawing.Point(25, 63);
            this.addAccess.Name = "addAccess";
            this.addAccess.Size = new System.Drawing.Size(94, 33);
            this.addAccess.TabIndex = 3;
            this.addAccess.Text = "Agregar acceso";
            this.addAccess.UseVisualStyleBackColor = true;
            this.addAccess.Click += new System.EventHandler(this.addAccess_Click);
            // 
            // editAccess
            // 
            this.editAccess.Location = new System.Drawing.Point(352, 63);
            this.editAccess.Name = "editAccess";
            this.editAccess.Size = new System.Drawing.Size(96, 33);
            this.editAccess.TabIndex = 4;
            this.editAccess.Text = "Editar Acceso";
            this.editAccess.UseVisualStyleBackColor = true;
            this.editAccess.Click += new System.EventHandler(this.editAccess_Click);
            // 
            // deleteAccess
            // 
            this.deleteAccess.Location = new System.Drawing.Point(518, 63);
            this.deleteAccess.Name = "deleteAccess";
            this.deleteAccess.Size = new System.Drawing.Size(94, 33);
            this.deleteAccess.TabIndex = 5;
            this.deleteAccess.Text = "Eliminar acceso";
            this.deleteAccess.UseVisualStyleBackColor = true;
            // 
            // queryAccess
            // 
            this.queryAccess.Location = new System.Drawing.Point(182, 63);
            this.queryAccess.Name = "queryAccess";
            this.queryAccess.Size = new System.Drawing.Size(105, 33);
            this.queryAccess.TabIndex = 6;
            this.queryAccess.Text = "Consultar Acceso";
            this.queryAccess.UseVisualStyleBackColor = true;
            // 
            // HorarioSemanasTipo
            // 
            this.HorarioSemanasTipo.AllowUserToAddRows = false;
            this.HorarioSemanasTipo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HorarioSemanasTipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HorarioSemanasTipo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DiaLunes,
            this.DiaMartes,
            this.diaMiercoles,
            this.DiaJueves,
            this.DiaViernes,
            this.DiaSabado,
            this.DiaDomingo});
            this.HorarioSemanasTipo.Location = new System.Drawing.Point(25, 111);
            this.HorarioSemanasTipo.Name = "HorarioSemanasTipo";
            this.HorarioSemanasTipo.Size = new System.Drawing.Size(762, 249);
            this.HorarioSemanasTipo.TabIndex = 8;
            this.HorarioSemanasTipo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HorarioSemanasTipo_CellContentClick);
            // 
            // DiaLunes
            // 
            this.DiaLunes.HeaderText = "Lunes";
            this.DiaLunes.Name = "DiaLunes";
            // 
            // DiaMartes
            // 
            this.DiaMartes.HeaderText = "Martes";
            this.DiaMartes.Name = "DiaMartes";
            // 
            // diaMiercoles
            // 
            this.diaMiercoles.HeaderText = "Miercoles";
            this.diaMiercoles.Name = "diaMiercoles";
            // 
            // DiaJueves
            // 
            this.DiaJueves.HeaderText = "Jueves";
            this.DiaJueves.Name = "DiaJueves";
            // 
            // DiaViernes
            // 
            this.DiaViernes.HeaderText = "Viernes";
            this.DiaViernes.Name = "DiaViernes";
            // 
            // DiaSabado
            // 
            this.DiaSabado.HeaderText = "Sabado";
            this.DiaSabado.Name = "DiaSabado";
            // 
            // DiaDomingo
            // 
            this.DiaDomingo.HeaderText = "Domingo";
            this.DiaDomingo.Name = "DiaDomingo";
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(692, 375);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 10;
            this.close.Text = "Cerrar";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(591, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Aceptar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FDatosItinerario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 410);
            this.Controls.Add(this.close);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.HorarioSemanasTipo);
            this.Controls.Add(this.queryAccess);
            this.Controls.Add(this.deleteAccess);
            this.Controls.Add(this.editAccess);
            this.Controls.Add(this.addAccess);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "FDatosItinerario";
            this.Text = "Semanas Tipo";
            this.Load += new System.EventHandler(this.FDatosItinerario_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.HorarioSemanasTipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addAccess;
        private System.Windows.Forms.Button editAccess;
        private System.Windows.Forms.Button deleteAccess;
        private System.Windows.Forms.Button queryAccess;
        private System.Windows.Forms.DataGridView HorarioSemanasTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaLunes;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaMartes;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaMiercoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaJueves;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaViernes;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaSabado;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaDomingo;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button button2;
    }
}