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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.HorarioSemanasTipo = new System.Windows.Forms.DataGridView();
            this.DiaLunes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaMartes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaMiercoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaJueves = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaViernes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaSabado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaDomingo = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.textBox1.Size = new System.Drawing.Size(328, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Agregar acceso";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(352, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "Editar Acceso";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(518, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 33);
            this.button3.TabIndex = 5;
            this.button3.Text = "Eliminar acceso";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(176, 63);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 33);
            this.button4.TabIndex = 6;
            this.button4.Text = "Consultar Acceso";
            this.button4.UseVisualStyleBackColor = true;
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
            // FDatosItinerario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 384);
            this.Controls.Add(this.HorarioSemanasTipo);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "FDatosItinerario";
            this.Text = "FDatosItinerario";
            this.Load += new System.EventHandler(this.FDatosItinerario_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.HorarioSemanasTipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView HorarioSemanasTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaLunes;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaMartes;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaMiercoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaJueves;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaViernes;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaSabado;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaDomingo;
    }
}