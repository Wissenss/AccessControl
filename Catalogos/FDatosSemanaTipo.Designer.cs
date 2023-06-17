using System.Data;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.editAccess = new System.Windows.Forms.Button();
            this.deleteAccess = new System.Windows.Forms.Button();
            this.queryAccess = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new System.Data.DataSet();
            this.dtAccesos = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.addAccess = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lunesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.martesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miercolesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.juevesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viernesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sábadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domingoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAccesos)).BeginInit();
            this.SuspendLayout();
            // 
            // editAccess
            // 
            this.editAccess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editAccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.editAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editAccess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(27)))), ((int)(((byte)(146)))));
            this.editAccess.Image = global::AccessControl.Properties.Resources.purple_pencil;
            this.editAccess.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editAccess.Location = new System.Drawing.Point(581, 24);
            this.editAccess.Name = "editAccess";
            this.editAccess.Size = new System.Drawing.Size(105, 23);
            this.editAccess.TabIndex = 4;
            this.editAccess.Text = "Editar    ";
            this.editAccess.UseVisualStyleBackColor = false;
            this.editAccess.Click += new System.EventHandler(this.editAccess_Click);
            // 
            // deleteAccess
            // 
            this.deleteAccess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteAccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.deleteAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteAccess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(27)))), ((int)(((byte)(146)))));
            this.deleteAccess.Image = global::AccessControl.Properties.Resources.purpledelete_16;
            this.deleteAccess.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteAccess.Location = new System.Drawing.Point(692, 24);
            this.deleteAccess.Name = "deleteAccess";
            this.deleteAccess.Size = new System.Drawing.Size(105, 23);
            this.deleteAccess.TabIndex = 5;
            this.deleteAccess.Text = "Eliminar    ";
            this.deleteAccess.UseVisualStyleBackColor = false;
            this.deleteAccess.Click += new System.EventHandler(this.DeleteAccess_Click);
            // 
            // queryAccess
            // 
            this.queryAccess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.queryAccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.queryAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.queryAccess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(27)))), ((int)(((byte)(146)))));
            this.queryAccess.Image = global::AccessControl.Properties.Resources.search_12_16;
            this.queryAccess.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.queryAccess.Location = new System.Drawing.Point(470, 24);
            this.queryAccess.Name = "queryAccess";
            this.queryAccess.Size = new System.Drawing.Size(105, 23);
            this.queryAccess.TabIndex = 6;
            this.queryAccess.Text = "Consultar    ";
            this.queryAccess.UseVisualStyleBackColor = false;
            this.queryAccess.Click += new System.EventHandler(this.editAccess_Click);
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(27)))), ((int)(((byte)(146)))));
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
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(27)))), ((int)(((byte)(146)))));
            this.button2.Location = new System.Drawing.Point(641, 454);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Aceptar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(76)))), ((int)(((byte)(151)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hora,
            this.horaDataGridViewTextBoxColumn,
            this.lunesDataGridViewTextBoxColumn,
            this.martesDataGridViewTextBoxColumn,
            this.miercolesDataGridViewTextBoxColumn,
            this.juevesDataGridViewTextBoxColumn,
            this.viernesDataGridViewTextBoxColumn,
            this.sábadoDataGridViewTextBoxColumn,
            this.domingoDataGridViewTextBoxColumn});
            this.dataGridView1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.dataSet, "dtAccesos.Hora", true));
            this.dataGridView1.DataSource = this.bindingSource1;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(76)))), ((int)(((byte)(151)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(15, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(782, 395);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8});
            this.dtAccesos.TableName = "dtAccesos";
            // 
            // dataColumn1
            // 
            this.dataColumn1.Caption = "Hora";
            this.dataColumn1.ColumnName = "Hora";
            // 
            // dataColumn2
            // 
            this.dataColumn2.Caption = "Lunes";
            this.dataColumn2.ColumnName = "Lunes";
            // 
            // dataColumn3
            // 
            this.dataColumn3.Caption = "Martes";
            this.dataColumn3.ColumnName = "Martes";
            // 
            // dataColumn4
            // 
            this.dataColumn4.Caption = "Miercoles";
            this.dataColumn4.ColumnName = "Miercoles";
            // 
            // dataColumn5
            // 
            this.dataColumn5.Caption = "Jueves";
            this.dataColumn5.ColumnName = "Jueves";
            // 
            // dataColumn6
            // 
            this.dataColumn6.Caption = "Viernes";
            this.dataColumn6.ColumnName = "Viernes";
            // 
            // dataColumn7
            // 
            this.dataColumn7.Caption = "Sábado";
            this.dataColumn7.ColumnName = "Sábado";
            // 
            // dataColumn8
            // 
            this.dataColumn8.Caption = "Domingo";
            this.dataColumn8.ColumnName = "Domingo";
            // 
            // addAccess
            // 
            this.addAccess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addAccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.addAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAccess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(27)))), ((int)(((byte)(146)))));
            this.addAccess.Image = global::AccessControl.Properties.Resources.purpleplus_3_16;
            this.addAccess.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addAccess.Location = new System.Drawing.Point(359, 24);
            this.addAccess.Name = "addAccess";
            this.addAccess.Size = new System.Drawing.Size(105, 23);
            this.addAccess.TabIndex = 3;
            this.addAccess.Text = "Agregar    ";
            this.addAccess.UseVisualStyleBackColor = false;
            this.addAccess.Click += new System.EventHandler(this.addAccess_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nombre";
            // 
            // tbNombre
            // 
            this.tbNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbNombre.Location = new System.Drawing.Point(62, 25);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(291, 21);
            this.tbNombre.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Accesos...";
            // 
            // Hora
            // 
            this.Hora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Hora.DataPropertyName = "Hora";
            this.Hora.FillWeight = 284.2639F;
            this.Hora.Frozen = true;
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            this.Hora.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Hora.Width = 70;
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "Hora";
            this.horaDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            this.horaDataGridViewTextBoxColumn.ReadOnly = true;
            this.horaDataGridViewTextBoxColumn.Visible = false;
            // 
            // lunesDataGridViewTextBoxColumn
            // 
            this.lunesDataGridViewTextBoxColumn.DataPropertyName = "Lunes";
            this.lunesDataGridViewTextBoxColumn.HeaderText = "Lunes";
            this.lunesDataGridViewTextBoxColumn.Name = "lunesDataGridViewTextBoxColumn";
            this.lunesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // martesDataGridViewTextBoxColumn
            // 
            this.martesDataGridViewTextBoxColumn.DataPropertyName = "Martes";
            this.martesDataGridViewTextBoxColumn.HeaderText = "Martes";
            this.martesDataGridViewTextBoxColumn.Name = "martesDataGridViewTextBoxColumn";
            this.martesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // miercolesDataGridViewTextBoxColumn
            // 
            this.miercolesDataGridViewTextBoxColumn.DataPropertyName = "Miercoles";
            this.miercolesDataGridViewTextBoxColumn.HeaderText = "Miercoles";
            this.miercolesDataGridViewTextBoxColumn.Name = "miercolesDataGridViewTextBoxColumn";
            this.miercolesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // juevesDataGridViewTextBoxColumn
            // 
            this.juevesDataGridViewTextBoxColumn.DataPropertyName = "Jueves";
            this.juevesDataGridViewTextBoxColumn.HeaderText = "Jueves";
            this.juevesDataGridViewTextBoxColumn.Name = "juevesDataGridViewTextBoxColumn";
            this.juevesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // viernesDataGridViewTextBoxColumn
            // 
            this.viernesDataGridViewTextBoxColumn.DataPropertyName = "Viernes";
            this.viernesDataGridViewTextBoxColumn.HeaderText = "Viernes";
            this.viernesDataGridViewTextBoxColumn.Name = "viernesDataGridViewTextBoxColumn";
            this.viernesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sábadoDataGridViewTextBoxColumn
            // 
            this.sábadoDataGridViewTextBoxColumn.DataPropertyName = "Sábado";
            this.sábadoDataGridViewTextBoxColumn.HeaderText = "Sábado";
            this.sábadoDataGridViewTextBoxColumn.Name = "sábadoDataGridViewTextBoxColumn";
            this.sábadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // domingoDataGridViewTextBoxColumn
            // 
            this.domingoDataGridViewTextBoxColumn.DataPropertyName = "Domingo";
            this.domingoDataGridViewTextBoxColumn.HeaderText = "Domingo";
            this.domingoDataGridViewTextBoxColumn.Name = "domingoDataGridViewTextBoxColumn";
            this.domingoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FDatosSemanaTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 489);
            this.Controls.Add(this.label1);
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
        private DataColumn dataColumn2;
        private DataColumn dataColumn3;
        private DataColumn dataColumn4;
        private DataColumn dataColumn5;
        private DataColumn dataColumn6;
        private DataColumn dataColumn7;
        private DataColumn dataColumn8;
        private System.Windows.Forms.Button addAccess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lunesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn martesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miercolesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn juevesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn viernesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sábadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domingoDataGridViewTextBoxColumn;
    }
}