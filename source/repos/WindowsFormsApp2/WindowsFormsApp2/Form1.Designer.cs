namespace WindowsFormsApp2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textOIB = new System.Windows.Forms.TextBox();
            this.textIme = new System.Windows.Forms.TextBox();
            this.textMjesto = new System.Windows.Forms.TextBox();
            this.textAdresa = new System.Windows.Forms.TextBox();
            this.textTelefon = new System.Windows.Forms.TextBox();
            this.textMail = new System.Windows.Forms.TextBox();
            this.sacuvaj = new System.Windows.Forms.Button();
            this.izmeni = new System.Windows.Forms.Button();
            this.brisanje = new System.Windows.Forms.Button();
            this.izlaz = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mjestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.osobaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mbanqDataSet = new WindowsFormsApp2.MbanqDataSet();
            this.osobaTableAdapter = new WindowsFormsApp2.MbanqDataSetTableAdapters.OsobaTableAdapter();
            this.Filterisanje = new System.Windows.Forms.Button();
            this.sortiranje = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.osobaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mbanqDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "OIB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mjesto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adresa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mail";
            // 
            // textOIB
            // 
            this.textOIB.Location = new System.Drawing.Point(114, 56);
            this.textOIB.Name = "textOIB";
            this.textOIB.Size = new System.Drawing.Size(100, 20);
            this.textOIB.TabIndex = 6;
            // 
            // textIme
            // 
            this.textIme.Location = new System.Drawing.Point(114, 82);
            this.textIme.Name = "textIme";
            this.textIme.Size = new System.Drawing.Size(100, 20);
            this.textIme.TabIndex = 7;
            // 
            // textMjesto
            // 
            this.textMjesto.Location = new System.Drawing.Point(114, 111);
            this.textMjesto.Name = "textMjesto";
            this.textMjesto.Size = new System.Drawing.Size(100, 20);
            this.textMjesto.TabIndex = 8;
            // 
            // textAdresa
            // 
            this.textAdresa.Location = new System.Drawing.Point(114, 138);
            this.textAdresa.Name = "textAdresa";
            this.textAdresa.Size = new System.Drawing.Size(100, 20);
            this.textAdresa.TabIndex = 9;
            // 
            // textTelefon
            // 
            this.textTelefon.Location = new System.Drawing.Point(114, 165);
            this.textTelefon.Name = "textTelefon";
            this.textTelefon.Size = new System.Drawing.Size(100, 20);
            this.textTelefon.TabIndex = 10;
            // 
            // textMail
            // 
            this.textMail.Location = new System.Drawing.Point(114, 192);
            this.textMail.Name = "textMail";
            this.textMail.Size = new System.Drawing.Size(100, 20);
            this.textMail.TabIndex = 11;
            // 
            // sacuvaj
            // 
            this.sacuvaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.sacuvaj.Location = new System.Drawing.Point(627, 28);
            this.sacuvaj.Name = "sacuvaj";
            this.sacuvaj.Size = new System.Drawing.Size(75, 24);
            this.sacuvaj.TabIndex = 12;
            this.sacuvaj.Text = "NovaOsoba";
            this.sacuvaj.UseVisualStyleBackColor = false;
            this.sacuvaj.Click += new System.EventHandler(this.sacuvaj_Click);
            // 
            // izmeni
            // 
            this.izmeni.BackColor = System.Drawing.Color.Yellow;
            this.izmeni.Location = new System.Drawing.Point(627, 72);
            this.izmeni.Name = "izmeni";
            this.izmeni.Size = new System.Drawing.Size(75, 23);
            this.izmeni.TabIndex = 13;
            this.izmeni.Text = "Izmjena";
            this.izmeni.UseVisualStyleBackColor = false;
            this.izmeni.Click += new System.EventHandler(this.izmeni_Click);
            // 
            // brisanje
            // 
            this.brisanje.Location = new System.Drawing.Point(627, 116);
            this.brisanje.Name = "brisanje";
            this.brisanje.Size = new System.Drawing.Size(75, 23);
            this.brisanje.TabIndex = 14;
            this.brisanje.Text = "Brisanje";
            this.brisanje.UseVisualStyleBackColor = true;
            this.brisanje.Click += new System.EventHandler(this.brisanje_Click);
            // 
            // izlaz
            // 
            this.izlaz.BackColor = System.Drawing.Color.Red;
            this.izlaz.Location = new System.Drawing.Point(627, 153);
            this.izlaz.Name = "izlaz";
            this.izlaz.Size = new System.Drawing.Size(75, 23);
            this.izlaz.TabIndex = 15;
            this.izlaz.Text = "IZLAZ";
            this.izlaz.UseVisualStyleBackColor = false;
            this.izlaz.Click += new System.EventHandler(this.izlaz_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Id";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(114, 28);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(100, 20);
            this.textId.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.oIBDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.mjestoDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.osobaBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(72, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(739, 185);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // oIBDataGridViewTextBoxColumn
            // 
            this.oIBDataGridViewTextBoxColumn.DataPropertyName = "OIB";
            this.oIBDataGridViewTextBoxColumn.HeaderText = "OIB";
            this.oIBDataGridViewTextBoxColumn.Name = "oIBDataGridViewTextBoxColumn";
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // mjestoDataGridViewTextBoxColumn
            // 
            this.mjestoDataGridViewTextBoxColumn.DataPropertyName = "Mjesto";
            this.mjestoDataGridViewTextBoxColumn.HeaderText = "Mjesto";
            this.mjestoDataGridViewTextBoxColumn.Name = "mjestoDataGridViewTextBoxColumn";
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // osobaBindingSource
            // 
            this.osobaBindingSource.DataMember = "Osoba";
            this.osobaBindingSource.DataSource = this.mbanqDataSet;
            // 
            // mbanqDataSet
            // 
            this.mbanqDataSet.DataSetName = "MbanqDataSet";
            this.mbanqDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // osobaTableAdapter
            // 
            this.osobaTableAdapter.ClearBeforeFill = true;
            // 
            // Filterisanje
            // 
            this.Filterisanje.BackColor = System.Drawing.Color.Aqua;
            this.Filterisanje.Location = new System.Drawing.Point(245, 415);
            this.Filterisanje.Name = "Filterisanje";
            this.Filterisanje.Size = new System.Drawing.Size(75, 23);
            this.Filterisanje.TabIndex = 19;
            this.Filterisanje.Text = "Filterisanje\r\n";
            this.Filterisanje.UseVisualStyleBackColor = false;
            this.Filterisanje.Click += new System.EventHandler(this.Filterisanje_Click);
            // 
            // sortiranje
            // 
            this.sortiranje.BackColor = System.Drawing.Color.Aqua;
            this.sortiranje.Location = new System.Drawing.Point(568, 415);
            this.sortiranje.Name = "sortiranje";
            this.sortiranje.Size = new System.Drawing.Size(75, 23);
            this.sortiranje.TabIndex = 20;
            this.sortiranje.Text = "Sortiranje";
            this.sortiranje.UseVisualStyleBackColor = false;
            this.sortiranje.Click += new System.EventHandler(this.sortiranje_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(347, 418);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sortiranje);
            this.Controls.Add(this.Filterisanje);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.izlaz);
            this.Controls.Add(this.brisanje);
            this.Controls.Add(this.izmeni);
            this.Controls.Add(this.sacuvaj);
            this.Controls.Add(this.textMail);
            this.Controls.Add(this.textTelefon);
            this.Controls.Add(this.textAdresa);
            this.Controls.Add(this.textMjesto);
            this.Controls.Add(this.textIme);
            this.Controls.Add(this.textOIB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Filterisanje";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.osobaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mbanqDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textOIB;
        private System.Windows.Forms.TextBox textIme;
        private System.Windows.Forms.TextBox textMjesto;
        private System.Windows.Forms.TextBox textAdresa;
        private System.Windows.Forms.TextBox textTelefon;
        private System.Windows.Forms.TextBox textMail;
        private System.Windows.Forms.Button sacuvaj;
        private System.Windows.Forms.Button izmeni;
        private System.Windows.Forms.Button brisanje;
        private System.Windows.Forms.Button izlaz;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MbanqDataSet mbanqDataSet;
        private System.Windows.Forms.BindingSource osobaBindingSource;
        private MbanqDataSetTableAdapters.OsobaTableAdapter osobaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mjestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Filterisanje;
        private System.Windows.Forms.Button sortiranje;
        private System.Windows.Forms.TextBox textBox1;
    }
}

