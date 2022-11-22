namespace Browser
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Back = new System.Windows.Forms.ToolStripButton();
            this.btn_GoForward = new System.Windows.Forms.ToolStripButton();
            this.btn_Refresh = new System.Windows.Forms.ToolStripButton();
            this.btn_Cancel = new System.Windows.Forms.ToolStripButton();
            this.btn_Home = new System.Windows.Forms.ToolStripButton();
            this.Url = new System.Windows.Forms.ToolStripTextBox();
            this.btn_Go = new System.Windows.Forms.ToolStripButton();
            this.cmb_Favorites = new System.Windows.Forms.ToolStripComboBox();
            this.btn_Favorites = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Back,
            this.btn_GoForward,
            this.btn_Refresh,
            this.btn_Cancel,
            this.btn_Home,
            this.Url,
            this.btn_Go,
            this.cmb_Favorites,
            this.btn_Favorites});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(978, 46);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "Stop";
            // 
            // btn_Back
            // 
            this.btn_Back.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Back.Image = ((System.Drawing.Image)(resources.GetObject("btn_Back.Image")));
            this.btn_Back.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(23, 43);
            this.btn_Back.Text = "Back";
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_GoForward
            // 
            this.btn_GoForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_GoForward.Image = ((System.Drawing.Image)(resources.GetObject("btn_GoForward.Image")));
            this.btn_GoForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_GoForward.Name = "btn_GoForward";
            this.btn_GoForward.Size = new System.Drawing.Size(23, 43);
            this.btn_GoForward.Text = "Forward";
            this.btn_GoForward.Click += new System.EventHandler(this.btn_GoForward_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_Refresh.Image")));
            this.btn_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(23, 43);
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancel.Image")));
            this.btn_Cancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(23, 43);
            this.btn_Cancel.Text = "toolStripButton3";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Home.Image = ((System.Drawing.Image)(resources.GetObject("btn_Home.Image")));
            this.btn_Home.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(23, 43);
            this.btn_Home.Text = "Home";
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // Url
            // 
            this.Url.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.Url.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Url.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Url.ForeColor = System.Drawing.Color.White;
            this.Url.Name = "Url";
            this.Url.Size = new System.Drawing.Size(680, 46);
            // 
            // btn_Go
            // 
            this.btn_Go.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Go.Image = ((System.Drawing.Image)(resources.GetObject("btn_Go.Image")));
            this.btn_Go.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Go.Name = "btn_Go";
            this.btn_Go.Size = new System.Drawing.Size(23, 43);
            this.btn_Go.Text = "Go";
            this.btn_Go.Click += new System.EventHandler(this.btn_Go_Click);
            // 
            // cmb_Favorites
            // 
            this.cmb_Favorites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.cmb_Favorites.ForeColor = System.Drawing.Color.White;
            this.cmb_Favorites.Name = "cmb_Favorites";
            this.cmb_Favorites.Size = new System.Drawing.Size(121, 46);
            this.cmb_Favorites.Text = "Favorites";
            this.cmb_Favorites.SelectedIndexChanged += new System.EventHandler(this.cmb_Favorites_SelectedIndexChanged);
            // 
            // btn_Favorites
            // 
            this.btn_Favorites.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Favorites.Image = ((System.Drawing.Image)(resources.GetObject("btn_Favorites.Image")));
            this.btn_Favorites.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Favorites.Name = "btn_Favorites";
            this.btn_Favorites.Size = new System.Drawing.Size(23, 43);
            this.btn_Favorites.Text = "Favorites";
            this.btn_Favorites.Click += new System.EventHandler(this.btn_Favorites_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 46);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.webBrowser1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(978, 458);
            this.panel2.TabIndex = 3;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(978, 458);
            this.webBrowser1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 504);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Browser Farx";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Back;
        private System.Windows.Forms.ToolStripButton btn_GoForward;
        private System.Windows.Forms.ToolStripButton btn_Refresh;
        private System.Windows.Forms.ToolStripButton btn_Cancel;
        private System.Windows.Forms.ToolStripButton btn_Home;
        private System.Windows.Forms.ToolStripTextBox Url;
        private System.Windows.Forms.ToolStripButton btn_Go;
        private System.Windows.Forms.ToolStripComboBox cmb_Favorites;
        private System.Windows.Forms.ToolStripButton btn_Favorites;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

