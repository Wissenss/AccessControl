namespace AccessControl.Catalogos
{
    partial class FDatosPersona
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
            this.BtnSelectFile = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCelular = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbClaveConfirmacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbClave = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbUID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Imagen";
            // 
            // BtnSelectFile
            // 
            this.BtnSelectFile.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSelectFile.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSelectFile.Location = new System.Drawing.Point(34, 189);
            this.BtnSelectFile.Name = "BtnSelectFile";
            this.BtnSelectFile.Size = new System.Drawing.Size(114, 23);
            this.BtnSelectFile.TabIndex = 5;
            this.BtnSelectFile.Text = "Seleccionar Archivo";
            this.BtnSelectFile.UseVisualStyleBackColor = false;
            this.BtnSelectFile.Click += new System.EventHandler(this.BtnSelectFile_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(356, 201);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(437, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tbNombre
            // 
            this.tbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbNombre.Location = new System.Drawing.Point(203, 29);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(308, 21);
            this.tbNombre.TabIndex = 8;
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "jpg";
            this.openFileDialog.Filter = "Imagen|*.jpg;*.jpeg;*.png;*.gif|Todo|*.*";
            this.openFileDialog.FilterIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre";
            // 
            // pbImagen
            // 
            this.pbImagen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbImagen.Location = new System.Drawing.Point(12, 25);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(136, 158);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 0;
            this.pbImagen.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(153, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Apellidos";
            // 
            // tbApellidos
            // 
            this.tbApellidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbApellidos.Location = new System.Drawing.Point(203, 56);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(308, 21);
            this.tbApellidos.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(152, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Correo";
            // 
            // tbCorreo
            // 
            this.tbCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbCorreo.Location = new System.Drawing.Point(203, 137);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(308, 21);
            this.tbCorreo.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(153, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Celular";
            // 
            // tbCelular
            // 
            this.tbCelular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCelular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbCelular.Location = new System.Drawing.Point(203, 164);
            this.tbCelular.Name = "tbCelular";
            this.tbCelular.Size = new System.Drawing.Size(308, 21);
            this.tbCelular.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(330, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Confirmar";
            // 
            // tbClaveConfirmacion
            // 
            this.tbClaveConfirmacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbClaveConfirmacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbClaveConfirmacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbClaveConfirmacion.Location = new System.Drawing.Point(390, 110);
            this.tbClaveConfirmacion.Name = "tbClaveConfirmacion";
            this.tbClaveConfirmacion.PasswordChar = '*';
            this.tbClaveConfirmacion.Size = new System.Drawing.Size(121, 21);
            this.tbClaveConfirmacion.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Clave";
            // 
            // tbClave
            // 
            this.tbClave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbClave.Location = new System.Drawing.Point(203, 110);
            this.tbClave.Name = "tbClave";
            this.tbClave.PasswordChar = '*';
            this.tbClave.Size = new System.Drawing.Size(121, 21);
            this.tbClave.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "UID";
            // 
            // tbUID
            // 
            this.tbUID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbUID.Location = new System.Drawing.Point(204, 83);
            this.tbUID.Name = "tbUID";
            this.tbUID.Size = new System.Drawing.Size(308, 21);
            this.tbUID.TabIndex = 26;
            // 
            // FDatosPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 236);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbClaveConfirmacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbClave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbUID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbCelular);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbCorreo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.BtnSelectFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbImagen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FDatosPersona";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Datos de la Persona";
            this.Load += new System.EventHandler(this.FDatosPersona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSelectFile;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCelular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbClaveConfirmacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbClave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUID;
    }
}