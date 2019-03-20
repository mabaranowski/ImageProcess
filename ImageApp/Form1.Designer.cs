namespace ImageApp
{
    partial class ImageProcessApp
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
            this.openButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.saveAsButton = new System.Windows.Forms.Button();
            this.openAsButton = new System.Windows.Forms.Button();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.vResTextBox = new System.Windows.Forms.TextBox();
            this.hResTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.colorsTextBox = new System.Windows.Forms.TextBox();
            this.detailsListBox = new System.Windows.Forms.ListBox();
            this.cropButton = new System.Windows.Forms.Button();
            this.cropWidthTextBox = new System.Windows.Forms.TextBox();
            this.cropHeightTextBox = new System.Windows.Forms.TextBox();
            this.cropPosX = new System.Windows.Forms.TextBox();
            this.cropPosY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.openUrlButton = new System.Windows.Forms.Button();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(22, 21);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(111, 42);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(22, 224);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(911, 802);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(139, 22);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(111, 42);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(256, 22);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(111, 42);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // saveAsButton
            // 
            this.saveAsButton.Location = new System.Drawing.Point(139, 69);
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Size = new System.Drawing.Size(111, 42);
            this.saveAsButton.TabIndex = 4;
            this.saveAsButton.Text = "Save As";
            this.saveAsButton.UseVisualStyleBackColor = true;
            this.saveAsButton.Click += new System.EventHandler(this.saveAsButton_Click);
            // 
            // openAsButton
            // 
            this.openAsButton.Location = new System.Drawing.Point(22, 69);
            this.openAsButton.Name = "openAsButton";
            this.openAsButton.Size = new System.Drawing.Size(111, 42);
            this.openAsButton.TabIndex = 5;
            this.openAsButton.Text = "Open As";
            this.openAsButton.UseVisualStyleBackColor = true;
            this.openAsButton.Click += new System.EventHandler(this.openAsButton_Click);
            // 
            // widthTextBox
            // 
            this.widthTextBox.Enabled = false;
            this.widthTextBox.Location = new System.Drawing.Point(715, 33);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(100, 20);
            this.widthTextBox.TabIndex = 6;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Enabled = false;
            this.heightTextBox.Location = new System.Drawing.Point(715, 81);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(100, 20);
            this.heightTextBox.TabIndex = 7;
            // 
            // vResTextBox
            // 
            this.vResTextBox.Enabled = false;
            this.vResTextBox.Location = new System.Drawing.Point(832, 81);
            this.vResTextBox.Name = "vResTextBox";
            this.vResTextBox.Size = new System.Drawing.Size(100, 20);
            this.vResTextBox.TabIndex = 8;
            // 
            // hResTextBox
            // 
            this.hResTextBox.Enabled = false;
            this.hResTextBox.Location = new System.Drawing.Point(832, 33);
            this.hResTextBox.Name = "hResTextBox";
            this.hResTextBox.Size = new System.Drawing.Size(100, 20);
            this.hResTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(749, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(746, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(843, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = " Vertical Res";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(843, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Horizontal Res";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(805, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Colors";
            // 
            // colorsTextBox
            // 
            this.colorsTextBox.Enabled = false;
            this.colorsTextBox.Location = new System.Drawing.Point(773, 126);
            this.colorsTextBox.Name = "colorsTextBox";
            this.colorsTextBox.Size = new System.Drawing.Size(100, 20);
            this.colorsTextBox.TabIndex = 15;
            // 
            // detailsListBox
            // 
            this.detailsListBox.FormattingEnabled = true;
            this.detailsListBox.Location = new System.Drawing.Point(373, 21);
            this.detailsListBox.Name = "detailsListBox";
            this.detailsListBox.Size = new System.Drawing.Size(323, 134);
            this.detailsListBox.TabIndex = 16;
            // 
            // cropButton
            // 
            this.cropButton.Location = new System.Drawing.Point(373, 161);
            this.cropButton.Name = "cropButton";
            this.cropButton.Size = new System.Drawing.Size(100, 46);
            this.cropButton.TabIndex = 17;
            this.cropButton.Text = "Crop";
            this.cropButton.UseVisualStyleBackColor = true;
            this.cropButton.Click += new System.EventHandler(this.cropButton_Click);
            // 
            // cropWidthTextBox
            // 
            this.cropWidthTextBox.Location = new System.Drawing.Point(479, 187);
            this.cropWidthTextBox.Name = "cropWidthTextBox";
            this.cropWidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.cropWidthTextBox.TabIndex = 18;
            // 
            // cropHeightTextBox
            // 
            this.cropHeightTextBox.Location = new System.Drawing.Point(596, 187);
            this.cropHeightTextBox.Name = "cropHeightTextBox";
            this.cropHeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.cropHeightTextBox.TabIndex = 19;
            // 
            // cropPosX
            // 
            this.cropPosX.Location = new System.Drawing.Point(715, 187);
            this.cropPosX.Name = "cropPosX";
            this.cropPosX.Size = new System.Drawing.Size(100, 20);
            this.cropPosX.TabIndex = 20;
            // 
            // cropPosY
            // 
            this.cropPosY.Location = new System.Drawing.Point(833, 187);
            this.cropPosY.Name = "cropPosY";
            this.cropPosY.Size = new System.Drawing.Size(100, 20);
            this.cropPosY.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(625, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Height";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(511, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Width";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(748, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "PosX";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(865, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "PosY";
            // 
            // openUrlButton
            // 
            this.openUrlButton.Location = new System.Drawing.Point(256, 69);
            this.openUrlButton.Name = "openUrlButton";
            this.openUrlButton.Size = new System.Drawing.Size(111, 42);
            this.openUrlButton.TabIndex = 26;
            this.openUrlButton.Text = "Open URL";
            this.openUrlButton.UseVisualStyleBackColor = true;
            this.openUrlButton.Click += new System.EventHandler(this.openUrlButton_Click);
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(22, 135);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(345, 20);
            this.urlTextBox.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "URL";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1904, 1041);
            this.shapeContainer1.TabIndex = 30;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 951;
            this.lineShape1.X2 = 950;
            this.lineShape1.Y1 = 22;
            this.lineShape1.Y2 = 1025;
            // 
            // ImageProcessApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.openUrlButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cropPosY);
            this.Controls.Add(this.cropPosX);
            this.Controls.Add(this.cropHeightTextBox);
            this.Controls.Add(this.cropWidthTextBox);
            this.Controls.Add(this.cropButton);
            this.Controls.Add(this.detailsListBox);
            this.Controls.Add(this.colorsTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hResTextBox);
            this.Controls.Add(this.vResTextBox);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.openAsButton);
            this.Controls.Add(this.saveAsButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "ImageProcessApp";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button saveAsButton;
        private System.Windows.Forms.Button openAsButton;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox vResTextBox;
        private System.Windows.Forms.TextBox hResTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox colorsTextBox;
        private System.Windows.Forms.ListBox detailsListBox;
        private System.Windows.Forms.Button cropButton;
        private System.Windows.Forms.TextBox cropWidthTextBox;
        private System.Windows.Forms.TextBox cropHeightTextBox;
        private System.Windows.Forms.TextBox cropPosX;
        private System.Windows.Forms.TextBox cropPosY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button openUrlButton;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Label label11;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}

