namespace AccessControl.Catalogos
{
    partial class FDatosGrupoPuertas
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
            this.BtnAddAll = new System.Windows.Forms.Button();
            this.BtnRemoveSelected = new System.Windows.Forms.Button();
            this.BtnAddSelected = new System.Windows.Forms.Button();
            this.BtnRemoveAll = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPuertas = new System.Windows.Forms.ListBox();
            this.lbMiembros = new System.Windows.Forms.ListBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAddAll
            // 
            this.BtnAddAll.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAddAll.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnAddAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddAll.Location = new System.Drawing.Point(198, 135);
            this.BtnAddAll.Name = "BtnAddAll";
            this.BtnAddAll.Size = new System.Drawing.Size(35, 23);
            this.BtnAddAll.TabIndex = 45;
            this.BtnAddAll.Text = ">>";
            this.BtnAddAll.UseVisualStyleBackColor = false;
            this.BtnAddAll.Click += new System.EventHandler(this.BtnAddAll_Click);
            // 
            // BtnRemoveSelected
            // 
            this.BtnRemoveSelected.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnRemoveSelected.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnRemoveSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemoveSelected.Location = new System.Drawing.Point(198, 224);
            this.BtnRemoveSelected.Name = "BtnRemoveSelected";
            this.BtnRemoveSelected.Size = new System.Drawing.Size(35, 23);
            this.BtnRemoveSelected.TabIndex = 44;
            this.BtnRemoveSelected.Text = "<";
            this.BtnRemoveSelected.UseVisualStyleBackColor = false;
            this.BtnRemoveSelected.Click += new System.EventHandler(this.BtnRemoveSelected_Click);
            // 
            // BtnAddSelected
            // 
            this.BtnAddSelected.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAddSelected.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnAddSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddSelected.Location = new System.Drawing.Point(198, 164);
            this.BtnAddSelected.Name = "BtnAddSelected";
            this.BtnAddSelected.Size = new System.Drawing.Size(35, 23);
            this.BtnAddSelected.TabIndex = 43;
            this.BtnAddSelected.Text = ">";
            this.BtnAddSelected.UseVisualStyleBackColor = false;
            this.BtnAddSelected.Click += new System.EventHandler(this.BtnAddSelected_Click);
            // 
            // BtnRemoveAll
            // 
            this.BtnRemoveAll.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnRemoveAll.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnRemoveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemoveAll.Location = new System.Drawing.Point(198, 253);
            this.BtnRemoveAll.Name = "BtnRemoveAll";
            this.BtnRemoveAll.Size = new System.Drawing.Size(35, 23);
            this.BtnRemoveAll.TabIndex = 42;
            this.BtnRemoveAll.Text = "<<";
            this.BtnRemoveAll.UseVisualStyleBackColor = false;
            this.BtnRemoveAll.Click += new System.EventHandler(this.BtnRemoveAll_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbNombre.Location = new System.Drawing.Point(68, 12);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(352, 21);
            this.tbNombre.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(10, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Nombre";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(264, 351);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 38;
            this.button5.Text = "Aceptar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button6.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(345, 351);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 39;
            this.button6.Text = "Cancelar";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(236, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Miembros";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(9, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Puertas";
            // 
            // lbPuertas
            // 
            this.lbPuertas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPuertas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbPuertas.FormattingEnabled = true;
            this.lbPuertas.Location = new System.Drawing.Point(12, 99);
            this.lbPuertas.Name = "lbPuertas";
            this.lbPuertas.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbPuertas.Size = new System.Drawing.Size(180, 238);
            this.lbPuertas.TabIndex = 35;
            this.lbPuertas.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.DrawItemSelected);
            this.lbPuertas.SelectedIndexChanged += new System.EventHandler(this.On_SelectionChanged);
            // 
            // lbMiembros
            // 
            this.lbMiembros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMiembros.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbMiembros.FormattingEnabled = true;
            this.lbMiembros.Location = new System.Drawing.Point(239, 99);
            this.lbMiembros.Name = "lbMiembros";
            this.lbMiembros.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbMiembros.Size = new System.Drawing.Size(180, 238);
            this.lbMiembros.TabIndex = 34;
            this.lbMiembros.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.DrawItemSelected);
            this.lbMiembros.SelectedIndexChanged += new System.EventHandler(this.On_SelectionChanged);
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbDescripcion.Location = new System.Drawing.Point(68, 41);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(352, 21);
            this.tbDescripcion.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(10, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Descripcion";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FDatosGrupoPuertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 386);
            this.ControlBox = false;
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnAddAll);
            this.Controls.Add(this.BtnRemoveSelected);
            this.Controls.Add(this.BtnAddSelected);
            this.Controls.Add(this.BtnRemoveAll);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPuertas);
            this.Controls.Add(this.lbMiembros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FDatosGrupoPuertas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Datos Gupo de Puertas";
            this.Load += new System.EventHandler(this.FDatosGrupoPuertas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAddAll;
        private System.Windows.Forms.Button BtnRemoveSelected;
        private System.Windows.Forms.Button BtnAddSelected;
        private System.Windows.Forms.Button BtnRemoveAll;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbPuertas;
        private System.Windows.Forms.ListBox lbMiembros;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label label4;
    }
}