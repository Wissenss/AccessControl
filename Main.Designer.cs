namespace AccessControl
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TCMonitor = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnPersonas = new System.Windows.Forms.Button();
            this.BtnGPersonas = new System.Windows.Forms.Button();
            this.BtnPuertas = new System.Windows.Forms.Button();
            this.BtnGPuertas = new System.Windows.Forms.Button();
            this.BtnItinerario = new System.Windows.Forms.Button();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.tbCelular = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbObservaciones = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnSelectPersona = new System.Windows.Forms.Button();
            this.BtnSelectPuerta = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.TCMonitor.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.TCMonitor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 392);
            this.panel1.TabIndex = 2;
            // 
            // TCMonitor
            // 
            this.TCMonitor.Controls.Add(this.tabPage1);
            this.TCMonitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCMonitor.Location = new System.Drawing.Point(0, 0);
            this.TCMonitor.Margin = new System.Windows.Forms.Padding(0);
            this.TCMonitor.Name = "TCMonitor";
            this.TCMonitor.Padding = new System.Drawing.Point(0, 0);
            this.TCMonitor.SelectedIndex = 0;
            this.TCMonitor.Size = new System.Drawing.Size(841, 392);
            this.TCMonitor.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(833, 366);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Piso 1";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(833, 366);
            this.label1.TabIndex = 0;
            this.label1.Tag = "";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Salmon;
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 395);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(841, 110);
            this.panel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanel1.Controls.Add(this.BtnPersonas);
            this.flowLayoutPanel1.Controls.Add(this.BtnGPersonas);
            this.flowLayoutPanel1.Controls.Add(this.BtnPuertas);
            this.flowLayoutPanel1.Controls.Add(this.BtnGPuertas);
            this.flowLayoutPanel1.Controls.Add(this.BtnItinerario);
            this.flowLayoutPanel1.Controls.Add(this.BtnAbout);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(841, 110);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // BtnPersonas
            // 
            this.BtnPersonas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPersonas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(27)))), ((int)(((byte)(146)))));
            this.BtnPersonas.FlatAppearance.BorderSize = 0;
            this.BtnPersonas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPersonas.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnPersonas.Image = global::AccessControl.Properties.Resources.user_64;
            this.BtnPersonas.Location = new System.Drawing.Point(3, 3);
            this.BtnPersonas.MinimumSize = new System.Drawing.Size(104, 104);
            this.BtnPersonas.Name = "BtnPersonas";
            this.BtnPersonas.Size = new System.Drawing.Size(104, 104);
            this.BtnPersonas.TabIndex = 1;
            this.BtnPersonas.Text = "Personas";
            this.BtnPersonas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPersonas.UseVisualStyleBackColor = false;
            this.BtnPersonas.Click += new System.EventHandler(this.BtnPersonas_Click);
            // 
            // BtnGPersonas
            // 
            this.BtnGPersonas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGPersonas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(27)))), ((int)(((byte)(146)))));
            this.BtnGPersonas.FlatAppearance.BorderSize = 0;
            this.BtnGPersonas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGPersonas.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnGPersonas.Image = global::AccessControl.Properties.Resources.group_64;
            this.BtnGPersonas.Location = new System.Drawing.Point(113, 3);
            this.BtnGPersonas.Name = "BtnGPersonas";
            this.BtnGPersonas.Size = new System.Drawing.Size(104, 104);
            this.BtnGPersonas.TabIndex = 3;
            this.BtnGPersonas.Text = "Grup. Personas";
            this.BtnGPersonas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGPersonas.UseVisualStyleBackColor = false;
            this.BtnGPersonas.Click += new System.EventHandler(this.BtnGPersonas_Click);
            // 
            // BtnPuertas
            // 
            this.BtnPuertas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPuertas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(27)))), ((int)(((byte)(146)))));
            this.BtnPuertas.FlatAppearance.BorderSize = 0;
            this.BtnPuertas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPuertas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPuertas.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnPuertas.Image = global::AccessControl.Properties.Resources.door_6_64;
            this.BtnPuertas.Location = new System.Drawing.Point(223, 3);
            this.BtnPuertas.Name = "BtnPuertas";
            this.BtnPuertas.Size = new System.Drawing.Size(104, 104);
            this.BtnPuertas.TabIndex = 2;
            this.BtnPuertas.Text = "Puertas";
            this.BtnPuertas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPuertas.UseVisualStyleBackColor = false;
            this.BtnPuertas.Click += new System.EventHandler(this.BtnPuertas_Click);
            // 
            // BtnGPuertas
            // 
            this.BtnGPuertas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGPuertas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(27)))), ((int)(((byte)(146)))));
            this.BtnGPuertas.FlatAppearance.BorderSize = 0;
            this.BtnGPuertas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGPuertas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGPuertas.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnGPuertas.Image = global::AccessControl.Properties.Resources.door_group_64;
            this.BtnGPuertas.Location = new System.Drawing.Point(333, 3);
            this.BtnGPuertas.Name = "BtnGPuertas";
            this.BtnGPuertas.Size = new System.Drawing.Size(104, 104);
            this.BtnGPuertas.TabIndex = 4;
            this.BtnGPuertas.Text = "Grup. Puertas";
            this.BtnGPuertas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGPuertas.UseVisualStyleBackColor = false;
            this.BtnGPuertas.Click += new System.EventHandler(this.BtnGPuertas_Click);
            // 
            // BtnItinerario
            // 
            this.BtnItinerario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnItinerario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(27)))), ((int)(((byte)(146)))));
            this.BtnItinerario.FlatAppearance.BorderSize = 0;
            this.BtnItinerario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnItinerario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnItinerario.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnItinerario.Image = global::AccessControl.Properties.Resources.today_64;
            this.BtnItinerario.Location = new System.Drawing.Point(443, 3);
            this.BtnItinerario.Name = "BtnItinerario";
            this.BtnItinerario.Size = new System.Drawing.Size(104, 104);
            this.BtnItinerario.TabIndex = 0;
            this.BtnItinerario.Text = "Itinerario";
            this.BtnItinerario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnItinerario.UseVisualStyleBackColor = false;
            this.BtnItinerario.Click += new System.EventHandler(this.BtnItinerario_Click);
            // 
            // BtnAbout
            // 
            this.BtnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(27)))), ((int)(((byte)(146)))));
            this.BtnAbout.FlatAppearance.BorderSize = 0;
            this.BtnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbout.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnAbout.Image = global::AccessControl.Properties.Resources.info_64;
            this.BtnAbout.Location = new System.Drawing.Point(553, 3);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(104, 104);
            this.BtnAbout.TabIndex = 5;
            this.BtnAbout.Text = "Acerca de";
            this.BtnAbout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAbout.UseVisualStyleBackColor = false;
            this.BtnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(148, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Celular";
            // 
            // tbCelular
            // 
            this.tbCelular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCelular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbCelular.Location = new System.Drawing.Point(198, 156);
            this.tbCelular.Name = "tbCelular";
            this.tbCelular.Size = new System.Drawing.Size(203, 21);
            this.tbCelular.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(147, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Correo";
            // 
            // tbCorreo
            // 
            this.tbCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbCorreo.Location = new System.Drawing.Point(198, 129);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(203, 21);
            this.tbCorreo.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(147, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Apellidos";
            // 
            // tbApellidos
            // 
            this.tbApellidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbApellidos.Location = new System.Drawing.Point(198, 76);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(203, 21);
            this.tbApellidos.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nombre";
            // 
            // tbNombre
            // 
            this.tbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbNombre.Location = new System.Drawing.Point(198, 49);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(203, 21);
            this.tbNombre.TabIndex = 26;
            // 
            // pbImagen
            // 
            this.pbImagen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbImagen.Location = new System.Drawing.Point(9, 20);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(136, 158);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 25;
            this.pbImagen.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Observaciones";
            // 
            // tbObservaciones
            // 
            this.tbObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbObservaciones.Location = new System.Drawing.Point(90, 76);
            this.tbObservaciones.Name = "tbObservaciones";
            this.tbObservaciones.Size = new System.Drawing.Size(311, 21);
            this.tbObservaciones.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Descripcion";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbDescripcion.Location = new System.Drawing.Point(90, 49);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(311, 21);
            this.tbDescripcion.TabIndex = 34;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnSelectPersona);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Controls.Add(this.pbImagen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbApellidos);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbCorreo);
            this.groupBox1.Controls.Add(this.tbCelular);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(8, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 189);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Persona";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.BtnSelectPuerta);
            this.groupBox2.Controls.Add(this.tbDescripcion);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbObservaciones);
            this.groupBox2.Location = new System.Drawing.Point(421, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 109);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Puerta";
            // 
            // BtnSelectPersona
            // 
            this.BtnSelectPersona.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSelectPersona.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSelectPersona.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnSelectPersona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSelectPersona.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnSelectPersona.Location = new System.Drawing.Point(326, 20);
            this.BtnSelectPersona.Name = "BtnSelectPersona";
            this.BtnSelectPersona.Size = new System.Drawing.Size(75, 23);
            this.BtnSelectPersona.TabIndex = 34;
            this.BtnSelectPersona.Text = "Seleccionar";
            this.BtnSelectPersona.UseVisualStyleBackColor = false;
            // 
            // BtnSelectPuerta
            // 
            this.BtnSelectPuerta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSelectPuerta.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSelectPuerta.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnSelectPuerta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSelectPuerta.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnSelectPuerta.Location = new System.Drawing.Point(326, 19);
            this.BtnSelectPuerta.Name = "BtnSelectPuerta";
            this.BtnSelectPuerta.Size = new System.Drawing.Size(75, 23);
            this.BtnSelectPuerta.TabIndex = 38;
            this.BtnSelectPuerta.Text = "Seleccionar";
            this.BtnSelectPuerta.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Location = new System.Drawing.Point(421, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(407, 74);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Horario";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button3.Location = new System.Drawing.Point(8, 208);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(820, 155);
            this.button3.TabIndex = 43;
            this.button3.Text = "Probar Acceso";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(90, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(311, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Fecha Hora";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(841, 505);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(857, 520);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccessControl";
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.panel1.ResumeLayout(false);
            this.TCMonitor.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnItinerario;
        private System.Windows.Forms.Button BtnPersonas;
        private System.Windows.Forms.Button BtnPuertas;
        private System.Windows.Forms.Button BtnGPersonas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnGPuertas;
        private System.Windows.Forms.Button BtnAbout;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl TCMonitor;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCelular;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbObservaciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnSelectPuerta;
        private System.Windows.Forms.Button BtnSelectPersona;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}