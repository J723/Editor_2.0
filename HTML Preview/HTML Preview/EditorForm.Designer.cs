namespace HTML_Preview
{
    partial class EditorForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.Wb_Preview = new System.Windows.Forms.WebBrowser();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.apriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuovoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiudiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creaCollegamentoCssToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strumentiMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.TemiMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.chiaroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scuroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_continue = new System.Windows.Forms.Button();
            this.rTxt_HTML = new System.Windows.Forms.RichTextBox();
            this.rTxt_CSS = new System.Windows.Forms.RichTextBox();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Wb_Preview
            // 
            this.Wb_Preview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Wb_Preview.Location = new System.Drawing.Point(194, 34);
            this.Wb_Preview.MinimumSize = new System.Drawing.Size(20, 20);
            this.Wb_Preview.Name = "Wb_Preview";
            this.Wb_Preview.Size = new System.Drawing.Size(89, 20);
            this.Wb_Preview.TabIndex = 2;
            this.Wb_Preview.TabStop = false;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuStrip,
            this.strumentiMenuStrip,
            this.TemiMenuStrip});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(161, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileMenuStrip
            // 
            this.fileMenuStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apriToolStripMenuItem,
            this.nuovoToolStripMenuItem,
            this.salvaToolStripMenuItem,
            this.chiudiToolStripMenuItem,
            this.creaCollegamentoCssToolStripMenuItem});
            this.fileMenuStrip.Name = "fileMenuStrip";
            this.fileMenuStrip.Size = new System.Drawing.Size(37, 20);
            this.fileMenuStrip.Text = "File";
            // 
            // apriToolStripMenuItem
            // 
            this.apriToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.apriToolStripMenuItem.Name = "apriToolStripMenuItem";
            this.apriToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.apriToolStripMenuItem.Text = "Apri";
            this.apriToolStripMenuItem.Click += new System.EventHandler(this.menu_File_Click);
            // 
            // nuovoToolStripMenuItem
            // 
            this.nuovoToolStripMenuItem.Name = "nuovoToolStripMenuItem";
            this.nuovoToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.nuovoToolStripMenuItem.Text = "Nuovo";
            this.nuovoToolStripMenuItem.Click += new System.EventHandler(this.menu_File_Click);
            // 
            // salvaToolStripMenuItem
            // 
            this.salvaToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.salvaToolStripMenuItem.Name = "salvaToolStripMenuItem";
            this.salvaToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.salvaToolStripMenuItem.Text = "Salva";
            this.salvaToolStripMenuItem.Click += new System.EventHandler(this.menu_File_Click);
            // 
            // chiudiToolStripMenuItem
            // 
            this.chiudiToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.chiudiToolStripMenuItem.Name = "chiudiToolStripMenuItem";
            this.chiudiToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.chiudiToolStripMenuItem.Text = "Chiudi";
            this.chiudiToolStripMenuItem.Click += new System.EventHandler(this.menu_File_Click);
            // 
            // creaCollegamentoCssToolStripMenuItem
            // 
            this.creaCollegamentoCssToolStripMenuItem.Name = "creaCollegamentoCssToolStripMenuItem";
            this.creaCollegamentoCssToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.creaCollegamentoCssToolStripMenuItem.Text = "Collega CSS";
            this.creaCollegamentoCssToolStripMenuItem.Click += new System.EventHandler(this.creaCollegamentoCssToolStripMenuItem_Click);
            // 
            // strumentiMenuStrip
            // 
            this.strumentiMenuStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.strumentiMenuStrip.Name = "strumentiMenuStrip";
            this.strumentiMenuStrip.Size = new System.Drawing.Size(71, 20);
            this.strumentiMenuStrip.Text = "Strumenti";
            // 
            // TemiMenuStrip
            // 
            this.TemiMenuStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TemiMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chiaroToolStripMenuItem,
            this.scuroToolStripMenuItem,
            this.personalizzaToolStripMenuItem});
            this.TemiMenuStrip.Name = "TemiMenuStrip";
            this.TemiMenuStrip.Size = new System.Drawing.Size(45, 20);
            this.TemiMenuStrip.Text = "Temi";
            // 
            // chiaroToolStripMenuItem
            // 
            this.chiaroToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.chiaroToolStripMenuItem.Name = "chiaroToolStripMenuItem";
            this.chiaroToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.chiaroToolStripMenuItem.Text = "Chiaro";
            this.chiaroToolStripMenuItem.Click += new System.EventHandler(this.chiaroToolStripMenuItem_Click);
            // 
            // scuroToolStripMenuItem
            // 
            this.scuroToolStripMenuItem.AutoToolTip = true;
            this.scuroToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.scuroToolStripMenuItem.Name = "scuroToolStripMenuItem";
            this.scuroToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.scuroToolStripMenuItem.Text = "Scuro";
            this.scuroToolStripMenuItem.Click += new System.EventHandler(this.scuroToolStripMenuItem_Click);
            // 
            // personalizzaToolStripMenuItem
            // 
            this.personalizzaToolStripMenuItem.Name = "personalizzaToolStripMenuItem";
            this.personalizzaToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.personalizzaToolStripMenuItem.Text = "Personalizza";
            this.personalizzaToolStripMenuItem.Click += new System.EventHandler(this.personalizzaToolStripMenuItem_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(159, 305);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(107, 23);
            this.btn_new.TabIndex = 5;
            this.btn_new.Text = "Nuovo Progetto";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.Btn_NewProject_Click);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(286, 304);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 6;
            this.btn_load.Text = "Carica";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.Btn_LoadProject_Click);
            // 
            // btn_continue
            // 
            this.btn_continue.Location = new System.Drawing.Point(380, 305);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(75, 23);
            this.btn_continue.TabIndex = 7;
            this.btn_continue.Text = "Continua";
            this.btn_continue.UseVisualStyleBackColor = true;
            this.btn_continue.Click += new System.EventHandler(this.Btn_Continue_Click);
            // 
            // rTxt_HTML
            // 
            this.rTxt_HTML.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rTxt_HTML.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rTxt_HTML.Location = new System.Drawing.Point(2, 72);
            this.rTxt_HTML.Name = "rTxt_HTML";
            this.rTxt_HTML.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.rTxt_HTML.Size = new System.Drawing.Size(100, 96);
            this.rTxt_HTML.TabIndex = 8;
            this.rTxt_HTML.TabStop = false;
            this.rTxt_HTML.Text = "";
            this.rTxt_HTML.TextChanged += new System.EventHandler(this.txt_Zone_FileUpdate);
            // 
            // rTxt_CSS
            // 
            this.rTxt_CSS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rTxt_CSS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rTxt_CSS.Location = new System.Drawing.Point(117, 72);
            this.rTxt_CSS.Name = "rTxt_CSS";
            this.rTxt_CSS.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.rTxt_CSS.Size = new System.Drawing.Size(100, 96);
            this.rTxt_CSS.TabIndex = 9;
            this.rTxt_CSS.TabStop = false;
            this.rTxt_CSS.Text = "";
            this.rTxt_CSS.TextChanged += new System.EventHandler(this.txt_Zone_FileUpdate);
            // 
            // EditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 544);
            this.Controls.Add(this.rTxt_CSS);
            this.Controls.Add(this.rTxt_HTML);
            this.Controls.Add(this.btn_continue);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.Wb_Preview);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "EditorForm";
            this.Text = "HTML Preview";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditorForm_FormClosing);
            this.Load += new System.EventHandler(this.EditorForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.WebBrowser Wb_Preview;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem apriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chiudiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strumentiMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem TemiMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem chiaroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scuroToolStripMenuItem;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_continue;
        private System.Windows.Forms.ToolStripMenuItem personalizzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuovoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creaCollegamentoCssToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rTxt_HTML;
        private System.Windows.Forms.RichTextBox rTxt_CSS;
    }
}

