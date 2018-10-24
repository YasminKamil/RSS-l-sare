namespace RSS_läsare
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
			this.listView1 = new System.Windows.Forms.ListView();
			this.KolumnAvsnitt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.KolumnNamn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.KolumnFrekvens = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.KolumnKategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lblKategorier = new System.Windows.Forms.Label();
			this.lvKategori = new System.Windows.Forms.ListView();
			this.txtKategori = new System.Windows.Forms.TextBox();
			this.btnNyKategori = new System.Windows.Forms.Button();
			this.btnSparaKategori = new System.Windows.Forms.Button();
			this.btnTaBortKateogri = new System.Windows.Forms.Button();
			this.listaPoddcastInfo = new System.Windows.Forms.RichTextBox();
			this.cBKategori = new System.Windows.Forms.ComboBox();
			this.cBUppdateraTid = new System.Windows.Forms.ComboBox();
			this.txtUrl = new System.Windows.Forms.TextBox();
			this.lblUrl = new System.Windows.Forms.Label();
			this.lblFrekvens = new System.Windows.Forms.Label();
			this.lblKategori = new System.Windows.Forms.Label();
			this.btnNyUrl = new System.Windows.Forms.Button();
			this.btnSparaUrl = new System.Windows.Forms.Button();
			this.btnTaBortUrl = new System.Windows.Forms.Button();
			this.listaAvsnitt = new System.Windows.Forms.ListView();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.KolumnAvsnitt,
            this.KolumnNamn,
            this.KolumnFrekvens,
            this.KolumnKategori});
			this.listView1.Location = new System.Drawing.Point(29, 21);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(490, 138);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
			// 
			// KolumnAvsnitt
			// 
			this.KolumnAvsnitt.Text = "Avsnitt";
			// 
			// KolumnNamn
			// 
			this.KolumnNamn.Text = "Namn";
			this.KolumnNamn.Width = 213;
			// 
			// KolumnFrekvens
			// 
			this.KolumnFrekvens.Text = "Frekvens";
			this.KolumnFrekvens.Width = 146;
			// 
			// KolumnKategori
			// 
			this.KolumnKategori.Text = "Kategori";
			this.KolumnKategori.Width = 86;
			// 
			// lblKategorier
			// 
			this.lblKategorier.AutoSize = true;
			this.lblKategorier.Location = new System.Drawing.Point(562, 9);
			this.lblKategorier.Name = "lblKategorier";
			this.lblKategorier.Size = new System.Drawing.Size(74, 17);
			this.lblKategorier.TabIndex = 1;
			this.lblKategorier.Text = "Kategorier";
			// 
			// lvKategori
			// 
			this.lvKategori.Location = new System.Drawing.Point(565, 30);
			this.lvKategori.Name = "lvKategori";
			this.lvKategori.Size = new System.Drawing.Size(380, 138);
			this.lvKategori.TabIndex = 2;
			this.lvKategori.UseCompatibleStateImageBehavior = false;
			// 
			// txtKategori
			// 
			this.txtKategori.Location = new System.Drawing.Point(565, 174);
			this.txtKategori.Name = "txtKategori";
			this.txtKategori.Size = new System.Drawing.Size(380, 22);
			this.txtKategori.TabIndex = 3;
			// 
			// btnNyKategori
			// 
			this.btnNyKategori.Location = new System.Drawing.Point(565, 210);
			this.btnNyKategori.Name = "btnNyKategori";
			this.btnNyKategori.Size = new System.Drawing.Size(102, 30);
			this.btnNyKategori.TabIndex = 4;
			this.btnNyKategori.Text = "Lägg till";
			this.btnNyKategori.UseVisualStyleBackColor = true;
			// 
			// btnSparaKategori
			// 
			this.btnSparaKategori.Location = new System.Drawing.Point(693, 210);
			this.btnSparaKategori.Name = "btnSparaKategori";
			this.btnSparaKategori.Size = new System.Drawing.Size(108, 31);
			this.btnSparaKategori.TabIndex = 5;
			this.btnSparaKategori.Text = "Spara";
			this.btnSparaKategori.UseVisualStyleBackColor = true;
			// 
			// btnTaBortKateogri
			// 
			this.btnTaBortKateogri.Location = new System.Drawing.Point(822, 209);
			this.btnTaBortKateogri.Name = "btnTaBortKateogri";
			this.btnTaBortKateogri.Size = new System.Drawing.Size(123, 31);
			this.btnTaBortKateogri.TabIndex = 6;
			this.btnTaBortKateogri.Text = "Ta bort";
			this.btnTaBortKateogri.UseVisualStyleBackColor = true;
			// 
			// listaPoddcastInfo
			// 
			this.listaPoddcastInfo.Location = new System.Drawing.Point(565, 289);
			this.listaPoddcastInfo.Name = "listaPoddcastInfo";
			this.listaPoddcastInfo.Size = new System.Drawing.Size(380, 165);
			this.listaPoddcastInfo.TabIndex = 7;
			this.listaPoddcastInfo.Text = "";
			// 
			// cBKategori
			// 
			this.cBKategori.FormattingEnabled = true;
			this.cBKategori.Location = new System.Drawing.Point(393, 182);
			this.cBKategori.Name = "cBKategori";
			this.cBKategori.Size = new System.Drawing.Size(124, 24);
			this.cBKategori.TabIndex = 8;
			// 
			// cBUppdateraTid
			// 
			this.cBUppdateraTid.FormattingEnabled = true;
			this.cBUppdateraTid.Location = new System.Drawing.Point(239, 182);
			this.cBUppdateraTid.Name = "cBUppdateraTid";
			this.cBUppdateraTid.Size = new System.Drawing.Size(148, 24);
			this.cBUppdateraTid.TabIndex = 9;
			// 
			// txtUrl
			// 
			this.txtUrl.Location = new System.Drawing.Point(29, 182);
			this.txtUrl.Name = "txtUrl";
			this.txtUrl.Size = new System.Drawing.Size(204, 22);
			this.txtUrl.TabIndex = 10;
			// 
			// lblUrl
			// 
			this.lblUrl.AutoSize = true;
			this.lblUrl.Location = new System.Drawing.Point(26, 162);
			this.lblUrl.Name = "lblUrl";
			this.lblUrl.Size = new System.Drawing.Size(40, 17);
			this.lblUrl.TabIndex = 11;
			this.lblUrl.Text = "URL:";
			// 
			// lblFrekvens
			// 
			this.lblFrekvens.AutoSize = true;
			this.lblFrekvens.Location = new System.Drawing.Point(236, 162);
			this.lblFrekvens.Name = "lblFrekvens";
			this.lblFrekvens.Size = new System.Drawing.Size(151, 17);
			this.lblFrekvens.TabIndex = 12;
			this.lblFrekvens.Text = "Uppdateringsfrekvens:";
			// 
			// lblKategori
			// 
			this.lblKategori.AutoSize = true;
			this.lblKategori.Location = new System.Drawing.Point(392, 162);
			this.lblKategori.Name = "lblKategori";
			this.lblKategori.Size = new System.Drawing.Size(65, 17);
			this.lblKategori.TabIndex = 13;
			this.lblKategori.Text = "Kategori:";
			// 
			// btnNyUrl
			// 
			this.btnNyUrl.Location = new System.Drawing.Point(29, 210);
			this.btnNyUrl.Name = "btnNyUrl";
			this.btnNyUrl.Size = new System.Drawing.Size(117, 30);
			this.btnNyUrl.TabIndex = 14;
			this.btnNyUrl.Text = "Lägg till";
			this.btnNyUrl.UseVisualStyleBackColor = true;
			// 
			// btnSparaUrl
			// 
			this.btnSparaUrl.Location = new System.Drawing.Point(152, 210);
			this.btnSparaUrl.Name = "btnSparaUrl";
			this.btnSparaUrl.Size = new System.Drawing.Size(132, 30);
			this.btnSparaUrl.TabIndex = 15;
			this.btnSparaUrl.Text = "Spara";
			this.btnSparaUrl.UseVisualStyleBackColor = true;
			// 
			// btnTaBortUrl
			// 
			this.btnTaBortUrl.Location = new System.Drawing.Point(290, 210);
			this.btnTaBortUrl.Name = "btnTaBortUrl";
			this.btnTaBortUrl.Size = new System.Drawing.Size(120, 30);
			this.btnTaBortUrl.TabIndex = 16;
			this.btnTaBortUrl.Text = "Ta bort";
			this.btnTaBortUrl.UseVisualStyleBackColor = true;
			// 
			// listaAvsnitt
			// 
			this.listaAvsnitt.Location = new System.Drawing.Point(29, 289);
			this.listaAvsnitt.Name = "listaAvsnitt";
			this.listaAvsnitt.Size = new System.Drawing.Size(490, 165);
			this.listaAvsnitt.TabIndex = 17;
			this.listaAvsnitt.UseCompatibleStateImageBehavior = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(28, 257);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 17);
			this.label1.TabIndex = 18;
			this.label1.Text = "label1";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(970, 509);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listaAvsnitt);
			this.Controls.Add(this.btnTaBortUrl);
			this.Controls.Add(this.btnSparaUrl);
			this.Controls.Add(this.btnNyUrl);
			this.Controls.Add(this.lblKategori);
			this.Controls.Add(this.lblFrekvens);
			this.Controls.Add(this.lblUrl);
			this.Controls.Add(this.txtUrl);
			this.Controls.Add(this.cBUppdateraTid);
			this.Controls.Add(this.cBKategori);
			this.Controls.Add(this.listaPoddcastInfo);
			this.Controls.Add(this.btnTaBortKateogri);
			this.Controls.Add(this.btnSparaKategori);
			this.Controls.Add(this.btnNyKategori);
			this.Controls.Add(this.txtKategori);
			this.Controls.Add(this.lvKategori);
			this.Controls.Add(this.lblKategorier);
			this.Controls.Add(this.listView1);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader KolumnAvsnitt;
		private System.Windows.Forms.ColumnHeader KolumnNamn;
		private System.Windows.Forms.ColumnHeader KolumnFrekvens;
		private System.Windows.Forms.ColumnHeader KolumnKategori;
		private System.Windows.Forms.Label lblKategorier;
		private System.Windows.Forms.ListView lvKategori;
		private System.Windows.Forms.TextBox txtKategori;
		private System.Windows.Forms.Button btnNyKategori;
		private System.Windows.Forms.Button btnSparaKategori;
		private System.Windows.Forms.Button btnTaBortKateogri;
		private System.Windows.Forms.RichTextBox listaPoddcastInfo;
		private System.Windows.Forms.ComboBox cBKategori;
		private System.Windows.Forms.ComboBox cBUppdateraTid;
		private System.Windows.Forms.TextBox txtUrl;
		private System.Windows.Forms.Label lblUrl;
		private System.Windows.Forms.Label lblFrekvens;
		private System.Windows.Forms.Label lblKategori;
		private System.Windows.Forms.Button btnNyUrl;
		private System.Windows.Forms.Button btnSparaUrl;
		private System.Windows.Forms.Button btnTaBortUrl;
		private System.Windows.Forms.ListView listaAvsnitt;
		private System.Windows.Forms.Label label1;
	}
}

