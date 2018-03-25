namespace FenixEpguidesManager
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.gbEnterShow = new System.Windows.Forms.GroupBox();
            this.btnList = new System.Windows.Forms.Button();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.gbEpisodes = new System.Windows.Forms.GroupBox();
            this.lvEpisodes = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblPowered = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.gbEnterShow.SuspendLayout();
            this.gbEpisodes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.ErrorImage = null;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(553, 95);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // gbEnterShow
            // 
            this.gbEnterShow.Controls.Add(this.btnList);
            this.gbEnterShow.Controls.Add(this.txtShow);
            this.gbEnterShow.Location = new System.Drawing.Point(78, 101);
            this.gbEnterShow.Name = "gbEnterShow";
            this.gbEnterShow.Size = new System.Drawing.Size(388, 75);
            this.gbEnterShow.TabIndex = 1;
            this.gbEnterShow.TabStop = false;
            this.gbEnterShow.Text = "Enter Show";
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(293, 31);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // txtShow
            // 
            this.txtShow.Location = new System.Drawing.Point(19, 31);
            this.txtShow.Name = "txtShow";
            this.txtShow.Size = new System.Drawing.Size(268, 20);
            this.txtShow.TabIndex = 0;
            this.txtShow.Text = "gotham";
            // 
            // gbEpisodes
            // 
            this.gbEpisodes.Controls.Add(this.lvEpisodes);
            this.gbEpisodes.Location = new System.Drawing.Point(12, 182);
            this.gbEpisodes.Name = "gbEpisodes";
            this.gbEpisodes.Size = new System.Drawing.Size(530, 241);
            this.gbEpisodes.TabIndex = 2;
            this.gbEpisodes.TabStop = false;
            this.gbEpisodes.Text = "Episodes";
            // 
            // lvEpisodes
            // 
            this.lvEpisodes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvEpisodes.FullRowSelect = true;
            this.lvEpisodes.Location = new System.Drawing.Point(17, 29);
            this.lvEpisodes.Name = "lvEpisodes";
            this.lvEpisodes.Size = new System.Drawing.Size(499, 195);
            this.lvEpisodes.TabIndex = 0;
            this.lvEpisodes.UseCompatibleStateImageBehavior = false;
            this.lvEpisodes.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Number";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Episode";
            this.columnHeader2.Width = 58;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Air Date";
            this.columnHeader3.Width = 154;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Title";
            this.columnHeader4.Width = 223;
            // 
            // lblPowered
            // 
            this.lblPowered.AutoSize = true;
            this.lblPowered.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPowered.Location = new System.Drawing.Point(172, 448);
            this.lblPowered.Name = "lblPowered";
            this.lblPowered.Size = new System.Drawing.Size(216, 24);
            this.lblPowered.TabIndex = 3;
            this.lblPowered.Text = "Powered by Epguides";
            this.lblPowered.Click += new System.EventHandler(this.lblPowered_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 501);
            this.Controls.Add(this.lblPowered);
            this.Controls.Add(this.gbEpisodes);
            this.Controls.Add(this.gbEnterShow);
            this.Controls.Add(this.pbLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormHome";
            this.Text = "Fenix Epguides Manager 1.0 - © Ismael Heredia , Argentina , 2018";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormHome_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.gbEnterShow.ResumeLayout(false);
            this.gbEnterShow.PerformLayout();
            this.gbEpisodes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.GroupBox gbEnterShow;
        private System.Windows.Forms.TextBox txtShow;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.GroupBox gbEpisodes;
        private System.Windows.Forms.ListView lvEpisodes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lblPowered;
    }
}

