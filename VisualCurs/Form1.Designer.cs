namespace VisualCurs
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createMenuBttn = new System.Windows.Forms.ToolStripMenuItem();
            this.элементыУправленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тренажерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.системыСчисленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterBox = new System.Windows.Forms.ComboBox();
            this.nameLab = new System.Windows.Forms.Label();
            this.populationLab = new System.Windows.Forms.Label();
            this.areaLab = new System.Windows.Forms.Label();
            this.centerLab = new System.Windows.Forms.Label();
            this.fedDistLab = new System.Windows.Forms.Label();
            this.regionLab = new System.Windows.Forms.Label();
            this.changeBttn = new System.Windows.Forms.Button();
            this.deleteBttn = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.busket = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchBttn = new System.Windows.Forms.Button();
            this.clearSearch = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.элементыУправленияToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(735, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createMenuBttn});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.файлToolStripMenuItem.Text = "Коллекция";
            // 
            // createMenuBttn
            // 
            this.createMenuBttn.Name = "createMenuBttn";
            this.createMenuBttn.Size = new System.Drawing.Size(199, 26);
            this.createMenuBttn.Text = "Создать запись";
            this.createMenuBttn.Click += new System.EventHandler(this.createMenuBttn_Click);
            // 
            // элементыУправленияToolStripMenuItem
            // 
            this.элементыУправленияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.тренажерToolStripMenuItem,
            this.системыСчисленияToolStripMenuItem});
            this.элементыУправленияToolStripMenuItem.Name = "элементыУправленияToolStripMenuItem";
            this.элементыУправленияToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.элементыУправленияToolStripMenuItem.Text = "Элементы управления";
            // 
            // тренажерToolStripMenuItem
            // 
            this.тренажерToolStripMenuItem.Name = "тренажерToolStripMenuItem";
            this.тренажерToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.тренажерToolStripMenuItem.Text = "Тренажер ";
            this.тренажерToolStripMenuItem.Click += new System.EventHandler(this.тренажерToolStripMenuItem_Click);
            // 
            // системыСчисленияToolStripMenuItem
            // 
            this.системыСчисленияToolStripMenuItem.Name = "системыСчисленияToolStripMenuItem";
            this.системыСчисленияToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.системыСчисленияToolStripMenuItem.Text = "Системы счисления";
            this.системыСчисленияToolStripMenuItem.Click += new System.EventHandler(this.системыСчисленияToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // filterBox
            // 
            this.filterBox.FormattingEnabled = true;
            this.filterBox.Items.AddRange(new object[] {
            "Сортировка",
            "Население",
            "Площадь"});
            this.filterBox.Location = new System.Drawing.Point(25, 49);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(121, 24);
            this.filterBox.TabIndex = 3;
            this.filterBox.Tag = "";
            this.filterBox.Text = "Сортировка";
            this.filterBox.SelectedIndexChanged += new System.EventHandler(this.filterBox_SelectedIndexChanged);
            // 
            // nameLab
            // 
            this.nameLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLab.Location = new System.Drawing.Point(438, 90);
            this.nameLab.Name = "nameLab";
            this.nameLab.Size = new System.Drawing.Size(192, 33);
            this.nameLab.TabIndex = 6;
            this.nameLab.Text = "label1";
            // 
            // populationLab
            // 
            this.populationLab.AutoSize = true;
            this.populationLab.Location = new System.Drawing.Point(442, 156);
            this.populationLab.Name = "populationLab";
            this.populationLab.Size = new System.Drawing.Size(46, 17);
            this.populationLab.TabIndex = 7;
            this.populationLab.Text = "label1";
            // 
            // areaLab
            // 
            this.areaLab.AutoSize = true;
            this.areaLab.Location = new System.Drawing.Point(442, 125);
            this.areaLab.Name = "areaLab";
            this.areaLab.Size = new System.Drawing.Size(46, 17);
            this.areaLab.TabIndex = 8;
            this.areaLab.Text = "label1";
            // 
            // centerLab
            // 
            this.centerLab.AutoSize = true;
            this.centerLab.Location = new System.Drawing.Point(442, 187);
            this.centerLab.Name = "centerLab";
            this.centerLab.Size = new System.Drawing.Size(46, 17);
            this.centerLab.TabIndex = 9;
            this.centerLab.Text = "label1";
            // 
            // fedDistLab
            // 
            this.fedDistLab.AutoSize = true;
            this.fedDistLab.Location = new System.Drawing.Point(442, 217);
            this.fedDistLab.Name = "fedDistLab";
            this.fedDistLab.Size = new System.Drawing.Size(46, 17);
            this.fedDistLab.TabIndex = 10;
            this.fedDistLab.Text = "label1";
            // 
            // regionLab
            // 
            this.regionLab.AutoSize = true;
            this.regionLab.Location = new System.Drawing.Point(442, 249);
            this.regionLab.Name = "regionLab";
            this.regionLab.Size = new System.Drawing.Size(46, 17);
            this.regionLab.TabIndex = 11;
            this.regionLab.Text = "label1";
            // 
            // changeBttn
            // 
            this.changeBttn.Location = new System.Drawing.Point(25, 396);
            this.changeBttn.Name = "changeBttn";
            this.changeBttn.Size = new System.Drawing.Size(158, 47);
            this.changeBttn.TabIndex = 12;
            this.changeBttn.Text = "Редактировать";
            this.changeBttn.UseVisualStyleBackColor = true;
            this.changeBttn.Click += new System.EventHandler(this.changeBttn_Click);
            // 
            // deleteBttn
            // 
            this.deleteBttn.Location = new System.Drawing.Point(235, 396);
            this.deleteBttn.Name = "deleteBttn";
            this.deleteBttn.Size = new System.Drawing.Size(168, 47);
            this.deleteBttn.TabIndex = 13;
            this.deleteBttn.Text = "Удалить";
            this.deleteBttn.UseVisualStyleBackColor = true;
            this.deleteBttn.Click += new System.EventHandler(this.deleteBttn_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(25, 90);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(378, 288);
            this.treeView1.TabIndex = 14;
            this.treeView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView1_ItemDrag);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView1_DragEnter);
            // 
            // busket
            // 
            this.busket.AllowDrop = true;
            this.busket.BackColor = System.Drawing.SystemColors.Control;
            this.busket.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("busket.BackgroundImage")));
            this.busket.Location = new System.Drawing.Point(442, 350);
            this.busket.Name = "busket";
            this.busket.Size = new System.Drawing.Size(101, 93);
            this.busket.TabIndex = 17;
            this.busket.DragDrop += new System.Windows.Forms.DragEventHandler(this.buscket_DragDrop);
            this.busket.DragEnter += new System.Windows.Forms.DragEventHandler(this.buscket_DragEnter);
            this.busket.DragLeave += new System.EventHandler(this.buscket_DragLeave);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 458);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(735, 26);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(162, 49);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(100, 22);
            this.searchBox.TabIndex = 19;
            // 
            // searchBttn
            // 
            this.searchBttn.Location = new System.Drawing.Point(269, 47);
            this.searchBttn.Name = "searchBttn";
            this.searchBttn.Size = new System.Drawing.Size(85, 26);
            this.searchBttn.TabIndex = 20;
            this.searchBttn.Text = "Поиск";
            this.searchBttn.UseVisualStyleBackColor = true;
            this.searchBttn.Click += new System.EventHandler(this.searchBttn_Click);
            // 
            // clearSearch
            // 
            this.clearSearch.BackColor = System.Drawing.Color.Red;
            this.clearSearch.ForeColor = System.Drawing.Color.Transparent;
            this.clearSearch.Location = new System.Drawing.Point(237, 49);
            this.clearSearch.Name = "clearSearch";
            this.clearSearch.Size = new System.Drawing.Size(26, 24);
            this.clearSearch.TabIndex = 21;
            this.clearSearch.Text = "X";
            this.clearSearch.UseVisualStyleBackColor = false;
            this.clearSearch.Click += new System.EventHandler(this.clearSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 484);
            this.Controls.Add(this.clearSearch);
            this.Controls.Add(this.searchBttn);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.busket);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.deleteBttn);
            this.Controls.Add(this.changeBttn);
            this.Controls.Add(this.regionLab);
            this.Controls.Add(this.fedDistLab);
            this.Controls.Add(this.centerLab);
            this.Controls.Add(this.areaLab);
            this.Controls.Add(this.populationLab);
            this.Controls.Add(this.nameLab);
            this.Controls.Add(this.filterBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Иерархия";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createMenuBttn;
        private System.Windows.Forms.ComboBox filterBox;
        private System.Windows.Forms.Label nameLab;
        private System.Windows.Forms.Label populationLab;
        private System.Windows.Forms.Label areaLab;
        private System.Windows.Forms.Label centerLab;
        private System.Windows.Forms.Label fedDistLab;
        private System.Windows.Forms.Label regionLab;
        private System.Windows.Forms.Button changeBttn;
        private System.Windows.Forms.Button deleteBttn;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel busket;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem элементыУправленияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тренажерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem системыСчисленияToolStripMenuItem;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchBttn;
        private System.Windows.Forms.Button clearSearch;
    }
}

