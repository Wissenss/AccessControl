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
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.TCMonitor.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(816, 371);
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
            this.TCMonitor.Size = new System.Drawing.Size(816, 371);
            this.TCMonitor.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(808, 345);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Piso 1";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(808, 345);
            this.label1.TabIndex = 0;
            this.label1.Tag = "";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Salmon;
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 371);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(816, 110);
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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(816, 110);
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
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(8, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(797, 28);
            this.label6.TabIndex = 12;
            this.label6.Text = "Probar Acceso";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(816, 481);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(831, 518);
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
        private System.Windows.Forms.Label label6;
    }
}