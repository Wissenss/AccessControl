namespace AccessControl
{
    partial class Monitor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Monitor));
            this.dataSet = new System.Data.DataSet();
            this.TbUsuarios = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.RtbSerialMonitor = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblPuertoFrecuencia = new System.Windows.Forms.Label();
            this.LblPuertoNombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LblSistemStatus = new System.Windows.Forms.Label();
            this.PbSistemStatus = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnConsultarAccesos = new System.Windows.Forms.Button();
            this.BtnAddAcceso = new System.Windows.Forms.Button();
            this.BtnAlarma = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnAbrir = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.LblEstadoSolicitud = new System.Windows.Forms.Label();
            this.LblUIDIndicator = new System.Windows.Forms.Label();
            this.LblUID = new System.Windows.Forms.Label();
            this.LblNombreIndicator = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbUsuarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbSistemStatus)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "NewDataSet";
            this.dataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.TbUsuarios});
            // 
            // TbUsuarios
            // 
            this.TbUsuarios.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2});
            this.TbUsuarios.TableName = "Usuarios";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Nombre";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Clave";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Door_Close.png");
            this.imageList.Images.SetKeyName(1, "Door_Open.png");
            // 
            // RtbSerialMonitor
            // 
            this.RtbSerialMonitor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtbSerialMonitor.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtbSerialMonitor.Location = new System.Drawing.Point(6, 19);
            this.RtbSerialMonitor.Name = "RtbSerialMonitor";
            this.RtbSerialMonitor.ReadOnly = true;
            this.RtbSerialMonitor.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RtbSerialMonitor.Size = new System.Drawing.Size(764, 184);
            this.RtbSerialMonitor.TabIndex = 0;
            this.RtbSerialMonitor.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RtbSerialMonitor);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 209);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Puerto Serial";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LblPuertoFrecuencia);
            this.groupBox2.Controls.Add(this.LblPuertoNombre);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 211);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configuraciones";
            // 
            // LblPuertoFrecuencia
            // 
            this.LblPuertoFrecuencia.AutoSize = true;
            this.LblPuertoFrecuencia.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPuertoFrecuencia.Location = new System.Drawing.Point(78, 53);
            this.LblPuertoFrecuencia.Name = "LblPuertoFrecuencia";
            this.LblPuertoFrecuencia.Size = new System.Drawing.Size(61, 13);
            this.LblPuertoFrecuencia.TabIndex = 3;
            this.LblPuertoFrecuencia.Text = "9600 baud";
            // 
            // LblPuertoNombre
            // 
            this.LblPuertoNombre.AutoSize = true;
            this.LblPuertoNombre.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPuertoNombre.Location = new System.Drawing.Point(78, 27);
            this.LblPuertoNombre.Name = "LblPuertoNombre";
            this.LblPuertoNombre.Size = new System.Drawing.Size(37, 13);
            this.LblPuertoNombre.TabIndex = 2;
            this.LblPuertoNombre.Text = "COM 6";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Frecuencia: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Puerto: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LblSistemStatus);
            this.groupBox3.Controls.Add(this.PbSistemStatus);
            this.groupBox3.Location = new System.Drawing.Point(186, 227);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(428, 105);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Estado del Sistema";
            // 
            // LblSistemStatus
            // 
            this.LblSistemStatus.AutoSize = true;
            this.LblSistemStatus.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSistemStatus.Location = new System.Drawing.Point(44, 23);
            this.LblSistemStatus.Name = "LblSistemStatus";
            this.LblSistemStatus.Size = new System.Drawing.Size(94, 24);
            this.LblSistemStatus.TabIndex = 1;
            this.LblSistemStatus.Text = "Cerrado";
            // 
            // PbSistemStatus
            // 
            this.PbSistemStatus.Image = ((System.Drawing.Image)(resources.GetObject("PbSistemStatus.Image")));
            this.PbSistemStatus.Location = new System.Drawing.Point(6, 19);
            this.PbSistemStatus.Name = "PbSistemStatus";
            this.PbSistemStatus.Size = new System.Drawing.Size(32, 32);
            this.PbSistemStatus.TabIndex = 0;
            this.PbSistemStatus.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnConsultarAccesos);
            this.groupBox4.Controls.Add(this.BtnAddAcceso);
            this.groupBox4.Controls.Add(this.BtnAlarma);
            this.groupBox4.Controls.Add(this.BtnCerrar);
            this.groupBox4.Controls.Add(this.BtnAbrir);
            this.groupBox4.Location = new System.Drawing.Point(620, 227);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(168, 211);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Controles";
            // 
            // BtnConsultarAccesos
            // 
            this.BtnConsultarAccesos.Location = new System.Drawing.Point(6, 177);
            this.BtnConsultarAccesos.Name = "BtnConsultarAccesos";
            this.BtnConsultarAccesos.Size = new System.Drawing.Size(156, 28);
            this.BtnConsultarAccesos.TabIndex = 4;
            this.BtnConsultarAccesos.Text = "Consultar Accesos";
            this.BtnConsultarAccesos.UseVisualStyleBackColor = true;
            this.BtnConsultarAccesos.Click += new System.EventHandler(this.BtnConsultarAccesos_Click);
            // 
            // BtnAddAcceso
            // 
            this.BtnAddAcceso.Location = new System.Drawing.Point(6, 143);
            this.BtnAddAcceso.Name = "BtnAddAcceso";
            this.BtnAddAcceso.Size = new System.Drawing.Size(156, 28);
            this.BtnAddAcceso.TabIndex = 3;
            this.BtnAddAcceso.Text = "Añadir Acceso";
            this.BtnAddAcceso.UseVisualStyleBackColor = true;
            this.BtnAddAcceso.Click += new System.EventHandler(this.BtnAddAcceso_Click);
            // 
            // BtnAlarma
            // 
            this.BtnAlarma.Location = new System.Drawing.Point(6, 87);
            this.BtnAlarma.Name = "BtnAlarma";
            this.BtnAlarma.Size = new System.Drawing.Size(156, 28);
            this.BtnAlarma.TabIndex = 2;
            this.BtnAlarma.Text = "Probar Alarma";
            this.BtnAlarma.UseVisualStyleBackColor = true;
            this.BtnAlarma.Click += new System.EventHandler(this.BtnAlarma_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(6, 53);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(156, 28);
            this.BtnCerrar.TabIndex = 1;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnAbrir
            // 
            this.BtnAbrir.Location = new System.Drawing.Point(6, 19);
            this.BtnAbrir.Name = "BtnAbrir";
            this.BtnAbrir.Size = new System.Drawing.Size(156, 28);
            this.BtnAbrir.TabIndex = 0;
            this.BtnAbrir.Text = "Abrir";
            this.BtnAbrir.UseVisualStyleBackColor = true;
            this.BtnAbrir.Click += new System.EventHandler(this.BtnAbrir_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.LblNombre);
            this.groupBox5.Controls.Add(this.LblNombreIndicator);
            this.groupBox5.Controls.Add(this.LblUID);
            this.groupBox5.Controls.Add(this.LblUIDIndicator);
            this.groupBox5.Controls.Add(this.LblEstadoSolicitud);
            this.groupBox5.Location = new System.Drawing.Point(186, 333);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(428, 105);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Último Acceso";
            // 
            // LblEstadoSolicitud
            // 
            this.LblEstadoSolicitud.AutoSize = true;
            this.LblEstadoSolicitud.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstadoSolicitud.Location = new System.Drawing.Point(6, 16);
            this.LblEstadoSolicitud.Name = "LblEstadoSolicitud";
            this.LblEstadoSolicitud.Size = new System.Drawing.Size(0, 24);
            this.LblEstadoSolicitud.TabIndex = 2;
            // 
            // LblUIDIndicator
            // 
            this.LblUIDIndicator.AutoSize = true;
            this.LblUIDIndicator.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUIDIndicator.Location = new System.Drawing.Point(7, 52);
            this.LblUIDIndicator.Name = "LblUIDIndicator";
            this.LblUIDIndicator.Size = new System.Drawing.Size(37, 13);
            this.LblUIDIndicator.TabIndex = 3;
            this.LblUIDIndicator.Text = "UID: ";
            // 
            // LblUID
            // 
            this.LblUID.AutoSize = true;
            this.LblUID.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUID.Location = new System.Drawing.Point(68, 52);
            this.LblUID.Name = "LblUID";
            this.LblUID.Size = new System.Drawing.Size(43, 13);
            this.LblUID.TabIndex = 4;
            this.LblUID.Text = "ABC123";
            // 
            // LblNombreIndicator
            // 
            this.LblNombreIndicator.AutoSize = true;
            this.LblNombreIndicator.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreIndicator.Location = new System.Drawing.Point(7, 71);
            this.LblNombreIndicator.Name = "LblNombreIndicator";
            this.LblNombreIndicator.Size = new System.Drawing.Size(55, 13);
            this.LblNombreIndicator.TabIndex = 5;
            this.LblNombreIndicator.Text = "Nombre: ";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(68, 71);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(49, 13);
            this.LblNombre.TabIndex = 6;
            this.LblNombre.Text = "wissens";
            // 
            // Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Monitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbUsuarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbSistemStatus)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dataSet;
        private System.Data.DataTable TbUsuarios;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.RichTextBox RtbSerialMonitor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnAddAcceso;
        private System.Windows.Forms.Button BtnAlarma;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnAbrir;
        private System.Windows.Forms.PictureBox PbSistemStatus;
        private System.Windows.Forms.Label LblSistemStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblPuertoFrecuencia;
        private System.Windows.Forms.Label LblPuertoNombre;
        private System.Windows.Forms.Button BtnConsultarAccesos;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label LblEstadoSolicitud;
        private System.Windows.Forms.Label LblUIDIndicator;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblNombreIndicator;
        private System.Windows.Forms.Label LblUID;
    }
}

