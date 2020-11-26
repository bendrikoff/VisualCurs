namespace VisualCurs
{
    partial class CollectionsForm
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
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.populationBox = new System.Windows.Forms.NumericUpDown();
            this.areaBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.centerBox = new System.Windows.Forms.TextBox();
            this.createBttn = new System.Windows.Forms.Button();
            this.cancelBttn = new System.Windows.Forms.Button();
            this.fedDistLabel = new System.Windows.Forms.Label();
            this.fedDistBox = new System.Windows.Forms.ComboBox();
            this.regionLabel = new System.Windows.Forms.Label();
            this.regionBox = new System.Windows.Forms.ComboBox();
            this.errorProviderType = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCenter = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderFedDist = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderRegion = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.populationBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFedDist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRegion)).BeginInit();
            this.SuspendLayout();
            // 
            // typeBox
            // 
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Items.AddRange(new object[] {
            "Федеративный округ",
            "Область",
            "Район"});
            this.typeBox.Location = new System.Drawing.Point(67, 87);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(182, 24);
            this.typeBox.TabIndex = 1;
            this.typeBox.SelectedIndexChanged += new System.EventHandler(this.typeBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите тип:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите название:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(67, 168);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(176, 22);
            this.nameBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введите население:";
            // 
            // populationBox
            // 
            this.populationBox.Location = new System.Drawing.Point(69, 254);
            this.populationBox.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.populationBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.populationBox.Name = "populationBox";
            this.populationBox.Size = new System.Drawing.Size(120, 22);
            this.populationBox.TabIndex = 6;
            this.populationBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // areaBox
            // 
            this.areaBox.Location = new System.Drawing.Point(71, 339);
            this.areaBox.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.areaBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.areaBox.Name = "areaBox";
            this.areaBox.Size = new System.Drawing.Size(120, 22);
            this.areaBox.TabIndex = 8;
            this.areaBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Введите площадь:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Введите название центра:";
            // 
            // centerBox
            // 
            this.centerBox.Location = new System.Drawing.Point(316, 89);
            this.centerBox.Name = "centerBox";
            this.centerBox.Size = new System.Drawing.Size(181, 22);
            this.centerBox.TabIndex = 10;
            // 
            // createBttn
            // 
            this.createBttn.Location = new System.Drawing.Point(71, 390);
            this.createBttn.Name = "createBttn";
            this.createBttn.Size = new System.Drawing.Size(172, 53);
            this.createBttn.TabIndex = 11;
            this.createBttn.Text = "Создать";
            this.createBttn.UseVisualStyleBackColor = true;
            this.createBttn.Click += new System.EventHandler(this.createBttn_Click);
            // 
            // cancelBttn
            // 
            this.cancelBttn.Location = new System.Drawing.Point(316, 390);
            this.cancelBttn.Name = "cancelBttn";
            this.cancelBttn.Size = new System.Drawing.Size(164, 53);
            this.cancelBttn.TabIndex = 12;
            this.cancelBttn.Text = "Отмена";
            this.cancelBttn.UseVisualStyleBackColor = true;
//            this.cancelBttn.Click += new System.EventHandler(this.cancelBttn_Click_1);
            // 
            // fedDistLabel
            // 
            this.fedDistLabel.AutoSize = true;
            this.fedDistLabel.Location = new System.Drawing.Point(313, 140);
            this.fedDistLabel.Name = "fedDistLabel";
            this.fedDistLabel.Size = new System.Drawing.Size(209, 17);
            this.fedDistLabel.TabIndex = 14;
            this.fedDistLabel.Text = "Выберите федеральный округ";
            // 
            // fedDistBox
            // 
            this.fedDistBox.FormattingEnabled = true;
            this.fedDistBox.Items.AddRange(new object[] {
            "Федеративный округ",
            "Область",
            "Район"});
            this.fedDistBox.Location = new System.Drawing.Point(316, 168);
            this.fedDistBox.Name = "fedDistBox";
            this.fedDistBox.Size = new System.Drawing.Size(206, 24);
            this.fedDistBox.TabIndex = 13;
            // 
            // regionLabel
            // 
            this.regionLabel.AutoSize = true;
            this.regionLabel.Location = new System.Drawing.Point(313, 226);
            this.regionLabel.Name = "regionLabel";
            this.regionLabel.Size = new System.Drawing.Size(131, 17);
            this.regionLabel.TabIndex = 16;
            this.regionLabel.Text = "Выберите область";
            // 
            // regionBox
            // 
            this.regionBox.FormattingEnabled = true;
            this.regionBox.Items.AddRange(new object[] {
            "Федеративный округ",
            "Область",
            "Район"});
            this.regionBox.Location = new System.Drawing.Point(316, 254);
            this.regionBox.Name = "regionBox";
            this.regionBox.Size = new System.Drawing.Size(206, 24);
            this.regionBox.TabIndex = 15;
            // 
            // errorProviderType
            // 
            this.errorProviderType.ContainerControl = this;
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // errorProviderCenter
            // 
            this.errorProviderCenter.ContainerControl = this;
            // 
            // errorProviderFedDist
            // 
            this.errorProviderFedDist.ContainerControl = this;
            // 
            // errorProviderRegion
            // 
            this.errorProviderRegion.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "чел.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(197, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "кв. км.";
            // 
            // CollectionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 486);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.regionLabel);
            this.Controls.Add(this.regionBox);
            this.Controls.Add(this.fedDistLabel);
            this.Controls.Add(this.fedDistBox);
            this.Controls.Add(this.cancelBttn);
            this.Controls.Add(this.createBttn);
            this.Controls.Add(this.centerBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.areaBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.populationBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typeBox);
            this.Name = "CollectionsForm";
            this.Text = "Collections";
            ((System.ComponentModel.ISupportInitialize)(this.populationBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFedDist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRegion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown populationBox;
        private System.Windows.Forms.NumericUpDown areaBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox centerBox;
        private System.Windows.Forms.Button createBttn;
        private System.Windows.Forms.Button cancelBttn;
        private System.Windows.Forms.Label fedDistLabel;
        private System.Windows.Forms.ComboBox fedDistBox;
        private System.Windows.Forms.Label regionLabel;
        private System.Windows.Forms.ComboBox regionBox;
        private System.Windows.Forms.ErrorProvider errorProviderType;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.ErrorProvider errorProviderCenter;
        private System.Windows.Forms.ErrorProvider errorProviderFedDist;
        private System.Windows.Forms.ErrorProvider errorProviderRegion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}