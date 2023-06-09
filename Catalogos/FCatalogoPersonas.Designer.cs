namespace AccessControl
{
    partial class FCatalogoPersonas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gvListadoPersonas = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new System.Data.DataSet();
            this.dtPersonas = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImagen = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvListadoPersonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // gvListadoPersonas
            // 
            this.gvListadoPersonas.AllowUserToAddRows = false;
            this.gvListadoPersonas.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(76)))), ((int)(((byte)(151)))));
            this.gvListadoPersonas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gvListadoPersonas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvListadoPersonas.AutoGenerateColumns = false;
            this.gvListadoPersonas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvListadoPersonas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gvListadoPersonas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvListadoPersonas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvListadoPersonas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gvListadoPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListadoPersonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNombre,
            this.colRol,
            this.colImagen});
            this.gvListadoPersonas.DataSource = this.bindingSource1;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(76)))), ((int)(((byte)(151)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvListadoPersonas.DefaultCellStyle = dataGridViewCellStyle6;
            this.gvListadoPersonas.EnableHeadersVisualStyles = false;
            this.gvListadoPersonas.GridColor = System.Drawing.SystemColors.Control;
            this.gvListadoPersonas.Location = new System.Drawing.Point(12, 78);
            this.gvListadoPersonas.MultiSelect = false;
            this.gvListadoPersonas.Name = "gvListadoPersonas";
            this.gvListadoPersonas.ReadOnly = true;
            this.gvListadoPersonas.RowHeadersVisible = false;
            this.gvListadoPersonas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gvListadoPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvListadoPersonas.ShowEditingIcon = false;
            this.gvListadoPersonas.Size = new System.Drawing.Size(460, 262);
            this.gvListadoPersonas.TabIndex = 1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "dtPersonas";
            this.bindingSource1.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dtPersonas});
            // 
            // dtPersonas
            // 
            this.dtPersonas.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4});
            this.dtPersonas.TableName = "dtPersonas";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Id";
            this.dataColumn1.DataType = typeof(int);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Nombre";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Rol";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "Imagen";
            this.dataColumn4.DataType = typeof(byte[]);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBox1.Location = new System.Drawing.Point(96, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(295, 21);
            this.textBox1.TabIndex = 2;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSearch.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Location = new System.Drawing.Point(397, 49);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 3;
            this.BtnSearch.Text = "Buscar";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Añadir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.EjecutarAccion);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(93, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.EjecutarAccion);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Location = new System.Drawing.Point(174, 12);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 6;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnSelect
            // 
            this.BtnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSelect.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSelect.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSelect.Location = new System.Drawing.Point(397, 12);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(75, 23);
            this.BtnSelect.TabIndex = 7;
            this.BtnSelect.Text = "Seleccionar";
            this.BtnSelect.UseVisualStyleBackColor = false;
            this.BtnSelect.Visible = false;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(397, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(316, 346);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Aceptar";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colNombre
            // 
            this.colNombre.DataPropertyName = "Nombre";
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colRol
            // 
            this.colRol.DataPropertyName = "Rol";
            this.colRol.HeaderText = "Rol";
            this.colRol.Name = "colRol";
            this.colRol.ReadOnly = true;
            this.colRol.Visible = false;
            // 
            // colImagen
            // 
            this.colImagen.DataPropertyName = "Imagen";
            this.colImagen.HeaderText = "Imagen";
            this.colImagen.Name = "colImagen";
            this.colImagen.ReadOnly = true;
            this.colImagen.Visible = false;
            // 
            // FCatalogoPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 384);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gvListadoPersonas);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 400);
            this.Name = "FCatalogoPersonas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Personas";
            this.Load += new System.EventHandler(this.FCatalogoPersonas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvListadoPersonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvListadoPersonas;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Data.DataTable dtPersonas;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRol;
        private System.Windows.Forms.DataGridViewImageColumn colImagen;
    }
}