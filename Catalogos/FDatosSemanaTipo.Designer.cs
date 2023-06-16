namespace AccessControl.Catalogos
{
    partial class FDatosSemanaTipo
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
            this.editAccess = new System.Windows.Forms.Button();
            this.deleteAccess = new System.Windows.Forms.Button();
            this.queryAccess = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lunes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Martes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miercoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jueves = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Viernes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sábado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domingo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new System.Data.DataSet();
            this.dtAccesos = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.addAccess = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAccesos)).BeginInit();
            this.SuspendLayout();
            // 
            // editAccess
            // 
            this.editAccess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editAccess.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.editAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editAccess.Location = new System.Drawing.Point(581, 11);
            this.editAccess.Name = "editAccess";
            this.editAccess.Size = new System.Drawing.Size(105, 23);
            this.editAccess.TabIndex = 4;
            this.editAccess.Text = "Editar Acceso";
            this.editAccess.UseVisualStyleBackColor = false;
            this.editAccess.Click += new System.EventHandler(this.editAccess_Click);
            // 
            // deleteAccess
            // 
            this.deleteAccess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteAccess.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteAccess.Location = new System.Drawing.Point(692, 11);
            this.deleteAccess.Name = "deleteAccess";
            this.deleteAccess.Size = new System.Drawing.Size(105, 23);
            this.deleteAccess.TabIndex = 5;
            this.deleteAccess.Text = "Eliminar acceso";
            this.deleteAccess.UseVisualStyleBackColor = false;
            // 
            // queryAccess
            // 
            this.queryAccess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.queryAccess.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.queryAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.queryAccess.Location = new System.Drawing.Point(470, 11);
            this.queryAccess.Name = "queryAccess";
            this.queryAccess.Size = new System.Drawing.Size(105, 23);
            this.queryAccess.TabIndex = 6;
            this.queryAccess.Text = "Consultar Acceso";
            this.queryAccess.UseVisualStyleBackColor = false;
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Location = new System.Drawing.Point(722, 454);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 10;
            this.close.Text = "Cerrar";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(641, 454);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Aceptar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(76)))), ((int)(((byte)(151)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hora,
            this.Lunes,
            this.Martes,
            this.Miercoles,
            this.Jueves,
            this.Viernes,
            this.Sábado,
            this.Domingo,
            this.horaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(76)))), ((int)(((byte)(151)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(15, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(782, 408);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Hora
            // 
            this.Hora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Hora.DataPropertyName = "Hora";
            this.Hora.FillWeight = 284.2639F;
            this.Hora.Frozen = true;
            this.Hora.HeaderText = "";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            this.Hora.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Hora.Width = 70;
            // 
            // Lunes
            // 
            this.Lunes.FillWeight = 73.67658F;
            this.Lunes.HeaderText = "Lunes";
            this.Lunes.Name = "Lunes";
            this.Lunes.ReadOnly = true;
            this.Lunes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Martes
            // 
            this.Martes.FillWeight = 73.67658F;
            this.Martes.HeaderText = "Martes";
            this.Martes.Name = "Martes";
            this.Martes.ReadOnly = true;
            this.Martes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Miercoles
            // 
            this.Miercoles.FillWeight = 73.67658F;
            this.Miercoles.HeaderText = "Miercoles";
            this.Miercoles.Name = "Miercoles";
            this.Miercoles.ReadOnly = true;
            this.Miercoles.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Jueves
            // 
            this.Jueves.FillWeight = 73.67658F;
            this.Jueves.HeaderText = "Jueves";
            this.Jueves.Name = "Jueves";
            this.Jueves.ReadOnly = true;
            this.Jueves.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Viernes
            // 
            this.Viernes.FillWeight = 73.67658F;
            this.Viernes.HeaderText = "Viernes";
            this.Viernes.Name = "Viernes";
            this.Viernes.ReadOnly = true;
            this.Viernes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Sábado
            // 
            this.Sábado.FillWeight = 73.67658F;
            this.Sábado.HeaderText = "Sábado";
            this.Sábado.Name = "Sábado";
            this.Sábado.ReadOnly = true;
            this.Sábado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Domingo
            // 
            this.Domingo.FillWeight = 73.67658F;
            this.Domingo.HeaderText = "Domingo";
            this.Domingo.Name = "Domingo";
            this.Domingo.ReadOnly = true;
            this.Domingo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "dtAccesos";
            this.bindingSource1.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "NewDataSet";
            this.dataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.dtAccesos});
            // 
            // dtAccesos
            // 
            this.dtAccesos.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1});
            this.dtAccesos.TableName = "dtAccesos";
            // 
            // dataColumn1
            // 
            this.dataColumn1.Caption = "Hora";
            this.dataColumn1.ColumnName = "Hora";
            // 
            // addAccess
            // 
            this.addAccess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addAccess.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAccess.Location = new System.Drawing.Point(359, 11);
            this.addAccess.Name = "addAccess";
            this.addAccess.Size = new System.Drawing.Size(105, 23);
            this.addAccess.TabIndex = 3;
            this.addAccess.Text = "Agregar acceso";
            this.addAccess.UseVisualStyleBackColor = false;
            this.addAccess.Click += new System.EventHandler(this.addAccess_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nombre";
            // 
            // tbNombre
            // 
            this.tbNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbNombre.Location = new System.Drawing.Point(62, 12);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(291, 21);
            this.tbNombre.TabIndex = 22;
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "Hora";
            this.horaDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            this.horaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FDatosSemanaTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 489);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.queryAccess);
            this.Controls.Add(this.deleteAccess);
            this.Controls.Add(this.editAccess);
            this.Controls.Add(this.addAccess);
            this.Name = "FDatosSemanaTipo";
            this.ShowIcon = false;
            this.Text = "Datos Semana Tipo";
            this.Load += new System.EventHandler(this.FDatosItinerario_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAccesos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button editAccess;
        private System.Windows.Forms.Button deleteAccess;
        private System.Windows.Forms.Button queryAccess;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Data.DataSet dataSet;
        private System.Data.DataTable dtAccesos;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Data.DataColumn dataColumn1;
        private System.Windows.Forms.Button addAccess;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lunes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Martes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miercoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jueves;
        private System.Windows.Forms.DataGridViewTextBoxColumn Viernes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sábado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domingo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
    }
}