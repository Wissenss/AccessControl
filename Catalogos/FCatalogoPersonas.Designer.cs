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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gvListadoPersonas = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new System.Data.DataSet();
            this.dtPersonas = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.tbSearchText = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
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
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(76)))), ((int)(((byte)(151)))));
            this.gvListadoPersonas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvListadoPersonas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvListadoPersonas.AutoGenerateColumns = false;
            this.gvListadoPersonas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvListadoPersonas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gvListadoPersonas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvListadoPersonas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvListadoPersonas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvListadoPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListadoPersonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNombre,
            this.colRol,
            this.colImagen});
            this.gvListadoPersonas.DataSource = this.bindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(76)))), ((int)(((byte)(151)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvListadoPersonas.DefaultCellStyle = dataGridViewCellStyle3;
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
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "ID";
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
            // tbSearchText
            // 
            this.tbSearchText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearchText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbSearchText.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbSearchText.Location = new System.Drawing.Point(96, 50);
            this.tbSearchText.Name = "tbSearchText";
            this.tbSearchText.Size = new System.Drawing.Size(376, 21);
            this.tbSearchText.TabIndex = 2;
            this.tbSearchText.Text = " Ingrese el texto a buscar...";
            this.tbSearchText.TextChanged += new System.EventHandler(this.tbSearchText_TextChanged);
            this.tbSearchText.Enter += new System.EventHandler(this.tbSearchText_Enter);
            this.tbSearchText.Leave += new System.EventHandler(this.tbSearchText_Leave);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Añadir";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.EjecutarAccion);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Control;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.Location = new System.Drawing.Point(93, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.EjecutarAccion);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.BtnSelect.BackColor = System.Drawing.SystemColors.Control;
            this.BtnSelect.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSelect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnSelect.Location = new System.Drawing.Point(397, 12);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(75, 23);
            this.BtnSelect.TabIndex = 7;
            this.BtnSelect.Text = "Seleccionar";
            this.BtnSelect.UseVisualStyleBackColor = false;
            this.BtnSelect.Visible = false;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.Location = new System.Drawing.Point(397, 346);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cerrar";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.BackColor = System.Drawing.SystemColors.Control;
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccept.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAccept.Location = new System.Drawing.Point(316, 346);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 8;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Visible = false;
            // 
            // FCatalogoPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 384);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbSearchText);
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
        private System.Windows.Forms.TextBox tbSearchText;
        private System.Data.DataTable dtPersonas;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRol;
        private System.Windows.Forms.DataGridViewImageColumn colImagen;
    }
}