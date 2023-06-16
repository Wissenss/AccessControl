namespace AccessControl
{
    partial class FDatosGrupoPersonas
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
            this.lbMiembros = new System.Windows.Forms.ListBox();
            this.lbPersonas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.BtnRemoveAll = new System.Windows.Forms.Button();
            this.BtnAddSelected = new System.Windows.Forms.Button();
            this.BtnRemoveSelected = new System.Windows.Forms.Button();
            this.BtnAddAll = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbMiembros
            // 
            this.lbMiembros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMiembros.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbMiembros.FormattingEnabled = true;
            this.lbMiembros.Location = new System.Drawing.Point(239, 64);
            this.lbMiembros.Name = "lbMiembros";
            this.lbMiembros.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbMiembros.Size = new System.Drawing.Size(180, 251);
            this.lbMiembros.TabIndex = 1;
            this.lbMiembros.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.DrawItemSelected);
            this.lbMiembros.SelectedIndexChanged += new System.EventHandler(this.On_SelectionChanged);
            // 
            // lbPersonas
            // 
            this.lbPersonas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPersonas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbPersonas.FormattingEnabled = true;
            this.lbPersonas.Location = new System.Drawing.Point(12, 64);
            this.lbPersonas.Name = "lbPersonas";
            this.lbPersonas.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbPersonas.Size = new System.Drawing.Size(180, 251);
            this.lbPersonas.TabIndex = 2;
            this.lbPersonas.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.DrawItemSelected);
            this.lbPersonas.SelectedIndexChanged += new System.EventHandler(this.On_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(9, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Personas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(236, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Miembros";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(27)))), ((int)(((byte)(146)))));
            this.btnAceptar.Location = new System.Drawing.Point(263, 391);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 26;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button6.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button6.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(27)))), ((int)(((byte)(146)))));
            this.button6.Location = new System.Drawing.Point(344, 391);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 27;
            this.button6.Text = "Cancelar";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(9, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Nombre";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbNombre
            // 
            this.tbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbNombre.Location = new System.Drawing.Point(67, 12);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(352, 21);
            this.tbNombre.TabIndex = 29;
            // 
            // BtnRemoveAll
            // 
            this.BtnRemoveAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnRemoveAll.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnRemoveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemoveAll.Image = global::AccessControl.Properties.Resources.doblearrow_L;
            this.BtnRemoveAll.Location = new System.Drawing.Point(198, 227);
            this.BtnRemoveAll.Name = "BtnRemoveAll";
            this.BtnRemoveAll.Size = new System.Drawing.Size(35, 23);
            this.BtnRemoveAll.TabIndex = 30;
            this.BtnRemoveAll.UseVisualStyleBackColor = false;
            this.BtnRemoveAll.Click += new System.EventHandler(this.BtnRemoveAll_Click);
            // 
            // BtnAddSelected
            // 
            this.BtnAddSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnAddSelected.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnAddSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddSelected.Image = global::AccessControl.Properties.Resources.purplearrow_24_32;
            this.BtnAddSelected.Location = new System.Drawing.Point(198, 138);
            this.BtnAddSelected.Name = "BtnAddSelected";
            this.BtnAddSelected.Size = new System.Drawing.Size(35, 23);
            this.BtnAddSelected.TabIndex = 31;
            this.BtnAddSelected.UseVisualStyleBackColor = false;
            this.BtnAddSelected.Click += new System.EventHandler(this.BtnAddSelected_Click);
            // 
            // BtnRemoveSelected
            // 
            this.BtnRemoveSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnRemoveSelected.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnRemoveSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemoveSelected.Image = global::AccessControl.Properties.Resources.purplearrow2_24_32;
            this.BtnRemoveSelected.Location = new System.Drawing.Point(198, 198);
            this.BtnRemoveSelected.Name = "BtnRemoveSelected";
            this.BtnRemoveSelected.Size = new System.Drawing.Size(35, 23);
            this.BtnRemoveSelected.TabIndex = 32;
            this.BtnRemoveSelected.UseVisualStyleBackColor = false;
            this.BtnRemoveSelected.Click += new System.EventHandler(this.BtnRemoveSelected_Click);
            // 
            // BtnAddAll
            // 
            this.BtnAddAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnAddAll.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnAddAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddAll.Image = global::AccessControl.Properties.Resources.doblearrow_R;
            this.BtnAddAll.Location = new System.Drawing.Point(198, 107);
            this.BtnAddAll.Name = "BtnAddAll";
            this.BtnAddAll.Size = new System.Drawing.Size(35, 23);
            this.BtnAddAll.TabIndex = 33;
            this.BtnAddAll.UseVisualStyleBackColor = false;
            this.BtnAddAll.Click += new System.EventHandler(this.BtnAddAll_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(9, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Descripción";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbDescripcion.Location = new System.Drawing.Point(12, 337);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(407, 48);
            this.tbDescripcion.TabIndex = 36;
            // 
            // FDatosGrupoPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(431, 426);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.BtnAddAll);
            this.Controls.Add(this.BtnRemoveSelected);
            this.Controls.Add(this.BtnAddSelected);
            this.Controls.Add(this.BtnRemoveAll);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPersonas);
            this.Controls.Add(this.lbMiembros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FDatosGrupoPersonas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Datos del Grupo de Personas";
            this.Load += new System.EventHandler(this.FDatosGrupoPersonas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbMiembros;
        private System.Windows.Forms.ListBox lbPersonas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button BtnRemoveAll;
        private System.Windows.Forms.Button BtnAddSelected;
        private System.Windows.Forms.Button BtnRemoveSelected;
        private System.Windows.Forms.Button BtnAddAll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDescripcion;
    }
}