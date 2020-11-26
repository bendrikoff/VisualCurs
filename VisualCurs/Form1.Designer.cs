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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createMenuBttn = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1253, 28);
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
            // filterBox
            // 
            this.filterBox.FormattingEnabled = true;
            this.filterBox.Items.AddRange(new object[] {
            "Население",
            "Площадь"});
            this.filterBox.Location = new System.Drawing.Point(25, 44);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(121, 24);
            this.filterBox.TabIndex = 3;
            this.filterBox.Tag = "";
            this.filterBox.Text = "Сортировка";
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
            this.fedDistLab.Location = new System.Drawing.Point(562, 124);
            this.fedDistLab.Name = "fedDistLab";
            this.fedDistLab.Size = new System.Drawing.Size(46, 17);
            this.fedDistLab.TabIndex = 10;
            this.fedDistLab.Text = "label1";
            // 
            // regionLab
            // 
            this.regionLab.AutoSize = true;
            this.regionLab.Location = new System.Drawing.Point(565, 156);
            this.regionLab.Name = "regionLab";
            this.regionLab.Size = new System.Drawing.Size(46, 17);
            this.regionLab.TabIndex = 11;
            this.regionLab.Text = "label1";
            // 
            // changeBttn
            // 
            this.changeBttn.Location = new System.Drawing.Point(442, 269);
            this.changeBttn.Name = "changeBttn";
            this.changeBttn.Size = new System.Drawing.Size(140, 47);
            this.changeBttn.TabIndex = 12;
            this.changeBttn.Text = "Редактировать";
            this.changeBttn.UseVisualStyleBackColor = true;
            // 
            // deleteBttn
            // 
            this.deleteBttn.Location = new System.Drawing.Point(598, 269);
            this.deleteBttn.Name = "deleteBttn";
            this.deleteBttn.Size = new System.Drawing.Size(140, 47);
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
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 416);
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
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}

