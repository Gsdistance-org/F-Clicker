
namespace F_Clicker
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.repaet = new System.Windows.Forms.Timer(this.components);
            this.savetimertick = new System.Windows.Forms.Timer(this.components);
            this.upgrades = new System.Windows.Forms.DataGridView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.needswrite = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterwriter = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.psticker = new System.Windows.Forms.Timer(this.components);
            this.Mouse = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ManualFabricator = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Fonator = new System.Windows.Forms.DataGridViewButtonColumn();
            this.correcter = new System.Windows.Forms.Timer(this.components);
            this.playtime = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upgrades)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::F_Clicker.Properties.Resources.Flogo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(162, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "F\'s:0";
            // 
            // repaet
            // 
            this.repaet.Enabled = true;
            this.repaet.Interval = 1;
            this.repaet.Tick += new System.EventHandler(this.repaet_Tick);
            // 
            // savetimertick
            // 
            this.savetimertick.Interval = 1;
            // 
            // upgrades
            // 
            this.upgrades.AllowUserToOrderColumns = true;
            this.upgrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.upgrades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mouse,
            this.ManualFabricator,
            this.Fonator});
            this.upgrades.Location = new System.Drawing.Point(12, 363);
            this.upgrades.Name = "upgrades";
            this.upgrades.RowHeadersWidth = 51;
            this.upgrades.RowTemplate.Height = 24;
            this.upgrades.Size = new System.Drawing.Size(776, 75);
            this.upgrades.TabIndex = 2;
            this.upgrades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.upgrades_CellContentClick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 336);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(130, 21);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Show Upgrades";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // needswrite
            // 
            this.needswrite.Tick += new System.EventHandler(this.needswrite_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.autoSaveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // autoSaveToolStripMenuItem
            // 
            this.autoSaveToolStripMenuItem.Name = "autoSaveToolStripMenuItem";
            this.autoSaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.autoSaveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.autoSaveToolStripMenuItem.Text = "AutoSave";
            this.autoSaveToolStripMenuItem.Click += new System.EventHandler(this.autoSaveToolStripMenuItem_Click);
            // 
            // masterwriter
            // 
            this.masterwriter.Interval = 1;
            this.masterwriter.Tick += new System.EventHandler(this.masterwriter_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // psticker
            // 
            this.psticker.Enabled = true;
            this.psticker.Interval = 1000;
            this.psticker.Tick += new System.EventHandler(this.psticker_Tick);
            // 
            // Mouse
            // 
            this.Mouse.HeaderText = "Mouse";
            this.Mouse.MinimumWidth = 6;
            this.Mouse.Name = "Mouse";
            this.Mouse.Text = "";
            this.Mouse.Width = 125;
            // 
            // ManualFabricator
            // 
            this.ManualFabricator.HeaderText = "Manual Fabricator";
            this.ManualFabricator.MinimumWidth = 6;
            this.ManualFabricator.Name = "ManualFabricator";
            this.ManualFabricator.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ManualFabricator.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ManualFabricator.Width = 125;
            // 
            // Fonator
            // 
            this.Fonator.HeaderText = "F o nator";
            this.Fonator.MinimumWidth = 6;
            this.Fonator.Name = "Fonator";
            this.Fonator.Width = 125;
            // 
            // correcter
            // 
            this.correcter.Enabled = true;
            this.correcter.Interval = 1;
            this.correcter.Tick += new System.EventHandler(this.correcter_Tick);
            // 
            // playtime
            // 
            this.playtime.Enabled = true;
            this.playtime.Interval = 1;
            this.playtime.Tick += new System.EventHandler(this.playtime_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.upgrades);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "F clicker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upgrades)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer repaet;
        private System.Windows.Forms.Timer savetimertick;
        private System.Windows.Forms.DataGridView upgrades;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Timer needswrite;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoSaveToolStripMenuItem;
        private System.Windows.Forms.Timer masterwriter;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer psticker;
        private System.Windows.Forms.DataGridViewButtonColumn Mouse;
        private System.Windows.Forms.DataGridViewButtonColumn ManualFabricator;
        private System.Windows.Forms.DataGridViewButtonColumn Fonator;
        private System.Windows.Forms.Timer correcter;
        private System.Windows.Forms.Timer playtime;
    }
}

