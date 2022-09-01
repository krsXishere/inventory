namespace InventoryApp.UserController
{
    partial class DataBarangRusakUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kode_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stok_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kondisi_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggal_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 320);
            this.panel1.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(240, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(160, 20);
            this.dateTimePicker1.TabIndex = 35;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(8, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(225, 20);
            this.txtSearch.TabIndex = 34;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(8, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Data Barang Rusak";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_barang,
            this.nama_user,
            this.kode_barang,
            this.nama_barang,
            this.status_barang,
            this.stok_barang,
            this.kondisi_barang,
            this.tanggal_barang});
            this.dataGridView1.Location = new System.Drawing.Point(0, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(737, 270);
            this.dataGridView1.TabIndex = 1;
            // 
            // id_barang
            // 
            this.id_barang.DataPropertyName = "id_barang";
            this.id_barang.HeaderText = "ID Barang";
            this.id_barang.Name = "id_barang";
            this.id_barang.Visible = false;
            // 
            // nama_user
            // 
            this.nama_user.DataPropertyName = "nama_user";
            this.nama_user.HeaderText = "Nama Pegawai";
            this.nama_user.Name = "nama_user";
            // 
            // kode_barang
            // 
            this.kode_barang.DataPropertyName = "kode_barang";
            this.kode_barang.HeaderText = "Kode Barang";
            this.kode_barang.Name = "kode_barang";
            // 
            // nama_barang
            // 
            this.nama_barang.DataPropertyName = "nama_barang";
            this.nama_barang.HeaderText = "Nama Barang";
            this.nama_barang.Name = "nama_barang";
            // 
            // status_barang
            // 
            this.status_barang.DataPropertyName = "status_barang";
            this.status_barang.HeaderText = "Status Barang";
            this.status_barang.Name = "status_barang";
            // 
            // stok_barang
            // 
            this.stok_barang.DataPropertyName = "stok_barang";
            this.stok_barang.HeaderText = "Stok Barang";
            this.stok_barang.Name = "stok_barang";
            // 
            // kondisi_barang
            // 
            this.kondisi_barang.DataPropertyName = "kondisi_barang";
            this.kondisi_barang.HeaderText = "Kondisi Barang";
            this.kondisi_barang.Name = "kondisi_barang";
            // 
            // tanggal_barang
            // 
            this.tanggal_barang.DataPropertyName = "tanggal_barang";
            this.tanggal_barang.HeaderText = "Tanggal Barang";
            this.tanggal_barang.Name = "tanggal_barang";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(174, 25);
            this.label12.TabIndex = 10;
            this.label12.Text = "Data Barang Rusak";
            // 
            // DataBarangRusakUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.Name = "DataBarangRusakUC";
            this.Size = new System.Drawing.Size(737, 447);
            this.Load += new System.EventHandler(this.DataBarangRusakUC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn kode_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn stok_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn kondisi_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggal_barang;
        private System.Windows.Forms.Label label12;
    }
}
