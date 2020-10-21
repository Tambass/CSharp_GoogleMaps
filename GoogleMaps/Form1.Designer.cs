namespace GoogleMaps
{
	partial class Maps
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.zipCodeLbl = new System.Windows.Forms.Label();
			this.stateLbl = new System.Windows.Forms.Label();
			this.cityLbl = new System.Windows.Forms.Label();
			this.streetLbl = new System.Windows.Forms.Label();
			this.btnSearch = new System.Windows.Forms.Button();
			this.textBoxZipCode = new System.Windows.Forms.TextBox();
			this.textBoxState = new System.Windows.Forms.TextBox();
			this.textBoxCity = new System.Windows.Forms.TextBox();
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.textBoxStreet = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.textBoxStreet);
			this.splitContainer1.Panel1.Controls.Add(this.zipCodeLbl);
			this.splitContainer1.Panel1.Controls.Add(this.stateLbl);
			this.splitContainer1.Panel1.Controls.Add(this.cityLbl);
			this.splitContainer1.Panel1.Controls.Add(this.streetLbl);
			this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
			this.splitContainer1.Panel1.Controls.Add(this.textBoxZipCode);
			this.splitContainer1.Panel1.Controls.Add(this.textBoxState);
			this.splitContainer1.Panel1.Controls.Add(this.textBoxCity);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
			this.splitContainer1.Size = new System.Drawing.Size(1296, 678);
			this.splitContainer1.SplitterDistance = 432;
			this.splitContainer1.TabIndex = 0;
			// 
			// zipCodeLbl
			// 
			this.zipCodeLbl.AutoSize = true;
			this.zipCodeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.zipCodeLbl.Location = new System.Drawing.Point(49, 428);
			this.zipCodeLbl.Name = "zipCodeLbl";
			this.zipCodeLbl.Size = new System.Drawing.Size(96, 24);
			this.zipCodeLbl.TabIndex = 8;
			this.zipCodeLbl.Text = "Zip Code";
			// 
			// stateLbl
			// 
			this.stateLbl.AutoSize = true;
			this.stateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.stateLbl.Location = new System.Drawing.Point(71, 331);
			this.stateLbl.Name = "stateLbl";
			this.stateLbl.Size = new System.Drawing.Size(56, 24);
			this.stateLbl.TabIndex = 7;
			this.stateLbl.Text = "State";
			// 
			// cityLbl
			// 
			this.cityLbl.AutoSize = true;
			this.cityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cityLbl.Location = new System.Drawing.Point(75, 240);
			this.cityLbl.Name = "cityLbl";
			this.cityLbl.Size = new System.Drawing.Size(42, 27);
			this.cityLbl.TabIndex = 6;
			this.cityLbl.Text = "City";
			this.cityLbl.UseCompatibleTextRendering = true;
			// 
			// streetLbl
			// 
			this.streetLbl.AutoSize = true;
			this.streetLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.streetLbl.Location = new System.Drawing.Point(71, 165);
			this.streetLbl.Name = "streetLbl";
			this.streetLbl.Size = new System.Drawing.Size(64, 24);
			this.streetLbl.TabIndex = 5;
			this.streetLbl.Text = "Street";
			this.streetLbl.UseMnemonic = false;
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
			this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.ForeColor = System.Drawing.Color.White;
			this.btnSearch.Location = new System.Drawing.Point(188, 503);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(150, 44);
			this.btnSearch.TabIndex = 4;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// textBoxZipCode
			// 
			this.textBoxZipCode.Location = new System.Drawing.Point(163, 409);
			this.textBoxZipCode.Multiline = true;
			this.textBoxZipCode.Name = "textBoxZipCode";
			this.textBoxZipCode.Size = new System.Drawing.Size(218, 43);
			this.textBoxZipCode.TabIndex = 3;
			// 
			// textBoxState
			// 
			this.textBoxState.Location = new System.Drawing.Point(163, 318);
			this.textBoxState.Multiline = true;
			this.textBoxState.Name = "textBoxState";
			this.textBoxState.Size = new System.Drawing.Size(218, 38);
			this.textBoxState.TabIndex = 2;
			// 
			// textBoxCity
			// 
			this.textBoxCity.Location = new System.Drawing.Point(163, 229);
			this.textBoxCity.Multiline = true;
			this.textBoxCity.Name = "textBoxCity";
			this.textBoxCity.Size = new System.Drawing.Size(218, 38);
			this.textBoxCity.TabIndex = 1;
			// 
			// webBrowser1
			// 
			this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser1.Location = new System.Drawing.Point(0, 0);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(860, 678);
			this.webBrowser1.TabIndex = 0;
			// 
			// textBoxStreet
			// 
			this.textBoxStreet.Location = new System.Drawing.Point(163, 152);
			this.textBoxStreet.Multiline = true;
			this.textBoxStreet.Name = "textBoxStreet";
			this.textBoxStreet.Size = new System.Drawing.Size(218, 37);
			this.textBoxStreet.TabIndex = 9;
			// 
			// Maps
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1296, 678);
			this.Controls.Add(this.splitContainer1);
			this.Name = "Maps";
			this.Text = "GoogleMaps";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Label zipCodeLbl;
		private System.Windows.Forms.Label stateLbl;
		private System.Windows.Forms.Label cityLbl;
		private System.Windows.Forms.Label streetLbl;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox textBoxZipCode;
		private System.Windows.Forms.TextBox textBoxState;
		private System.Windows.Forms.TextBox textBoxCity;
		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.TextBox textBoxStreet;
	}
}

