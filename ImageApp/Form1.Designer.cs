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
            this.label10 = new System.Windows.Forms.Label();
            this.urlTextBox2 = new System.Windows.Forms.TextBox();
            this.openUrlButton2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cropPosY2 = new System.Windows.Forms.TextBox();
            this.cropPosX2 = new System.Windows.Forms.TextBox();
            this.cropHeightTextBox2 = new System.Windows.Forms.TextBox();
            this.cropWidthTextBox2 = new System.Windows.Forms.TextBox();
            this.cropButton2 = new System.Windows.Forms.Button();
            this.detailsListBox2 = new System.Windows.Forms.ListBox();
            this.colorsTextBox2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.hResTextBox2 = new System.Windows.Forms.TextBox();
            this.vResTextBox2 = new System.Windows.Forms.TextBox();
            this.heightTextBox2 = new System.Windows.Forms.TextBox();
            this.widthTextBox2 = new System.Windows.Forms.TextBox();
            this.openAsButton2 = new System.Windows.Forms.Button();
            this.saveAsButton2 = new System.Windows.Forms.Button();
            this.clearButton2 = new System.Windows.Forms.Button();
            this.buttonSave2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openButton2 = new System.Windows.Forms.Button();
            this.flipX = new System.Windows.Forms.Button();
            this.flipY = new System.Windows.Forms.Button();
            this.trackBarX = new System.Windows.Forms.TrackBar();
            this.rotateBox = new System.Windows.Forms.TextBox();
            this.zoomBox = new System.Windows.Forms.TextBox();
            this.trackBarZoom = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoom)).BeginInit();
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
            this.pictureBox.Size = new System.Drawing.Size(911, 611);
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1537, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 59;
            this.label10.Text = "URL";
            // 
            // urlTextBox2
            // 
            this.urlTextBox2.Location = new System.Drawing.Point(1540, 131);
            this.urlTextBox2.Name = "urlTextBox2";
            this.urlTextBox2.Size = new System.Drawing.Size(345, 20);
            this.urlTextBox2.TabIndex = 58;
            // 
            // openUrlButton2
            // 
            this.openUrlButton2.Location = new System.Drawing.Point(1774, 65);
            this.openUrlButton2.Name = "openUrlButton2";
            this.openUrlButton2.Size = new System.Drawing.Size(111, 42);
            this.openUrlButton2.TabIndex = 57;
            this.openUrlButton2.Text = "Open URL";
            this.openUrlButton2.UseVisualStyleBackColor = true;
            this.openUrlButton2.Click += new System.EventHandler(this.openUrlButton2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1354, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 56;
            this.label12.Text = "PosY";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1237, 171);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 55;
            this.label13.Text = "PosX";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1000, 171);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 54;
            this.label14.Text = "Width";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1114, 171);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 53;
            this.label15.Text = "Height";
            // 
            // cropPosY2
            // 
            this.cropPosY2.Location = new System.Drawing.Point(1322, 187);
            this.cropPosY2.Name = "cropPosY2";
            this.cropPosY2.Size = new System.Drawing.Size(100, 20);
            this.cropPosY2.TabIndex = 52;
            // 
            // cropPosX2
            // 
            this.cropPosX2.Location = new System.Drawing.Point(1204, 187);
            this.cropPosX2.Name = "cropPosX2";
            this.cropPosX2.Size = new System.Drawing.Size(100, 20);
            this.cropPosX2.TabIndex = 51;
            // 
            // cropHeightTextBox2
            // 
            this.cropHeightTextBox2.Location = new System.Drawing.Point(1085, 187);
            this.cropHeightTextBox2.Name = "cropHeightTextBox2";
            this.cropHeightTextBox2.Size = new System.Drawing.Size(100, 20);
            this.cropHeightTextBox2.TabIndex = 50;
            // 
            // cropWidthTextBox2
            // 
            this.cropWidthTextBox2.Location = new System.Drawing.Point(968, 187);
            this.cropWidthTextBox2.Name = "cropWidthTextBox2";
            this.cropWidthTextBox2.Size = new System.Drawing.Size(100, 20);
            this.cropWidthTextBox2.TabIndex = 49;
            // 
            // cropButton2
            // 
            this.cropButton2.Location = new System.Drawing.Point(1434, 161);
            this.cropButton2.Name = "cropButton2";
            this.cropButton2.Size = new System.Drawing.Size(100, 46);
            this.cropButton2.TabIndex = 48;
            this.cropButton2.Text = "Crop";
            this.cropButton2.UseVisualStyleBackColor = true;
            this.cropButton2.Click += new System.EventHandler(this.cropButton2_Click);
            // 
            // detailsListBox2
            // 
            this.detailsListBox2.FormattingEnabled = true;
            this.detailsListBox2.Location = new System.Drawing.Point(1204, 17);
            this.detailsListBox2.Name = "detailsListBox2";
            this.detailsListBox2.Size = new System.Drawing.Size(330, 134);
            this.detailsListBox2.TabIndex = 47;
            // 
            // colorsTextBox2
            // 
            this.colorsTextBox2.Enabled = false;
            this.colorsTextBox2.Location = new System.Drawing.Point(1026, 126);
            this.colorsTextBox2.Name = "colorsTextBox2";
            this.colorsTextBox2.Size = new System.Drawing.Size(100, 20);
            this.colorsTextBox2.TabIndex = 46;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1058, 110);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 13);
            this.label16.TabIndex = 45;
            this.label16.Text = "Colors";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1096, 65);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 13);
            this.label17.TabIndex = 44;
            this.label17.Text = "Horizontal Res";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1096, 17);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 13);
            this.label18.TabIndex = 43;
            this.label18.Text = " Vertical Res";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(999, 65);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 13);
            this.label19.TabIndex = 42;
            this.label19.Text = "Height";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(1002, 17);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 13);
            this.label20.TabIndex = 41;
            this.label20.Text = "Width";
            // 
            // hResTextBox2
            // 
            this.hResTextBox2.Enabled = false;
            this.hResTextBox2.Location = new System.Drawing.Point(1085, 33);
            this.hResTextBox2.Name = "hResTextBox2";
            this.hResTextBox2.Size = new System.Drawing.Size(100, 20);
            this.hResTextBox2.TabIndex = 40;
            // 
            // vResTextBox2
            // 
            this.vResTextBox2.Enabled = false;
            this.vResTextBox2.Location = new System.Drawing.Point(1085, 81);
            this.vResTextBox2.Name = "vResTextBox2";
            this.vResTextBox2.Size = new System.Drawing.Size(100, 20);
            this.vResTextBox2.TabIndex = 39;
            // 
            // heightTextBox2
            // 
            this.heightTextBox2.Enabled = false;
            this.heightTextBox2.Location = new System.Drawing.Point(968, 81);
            this.heightTextBox2.Name = "heightTextBox2";
            this.heightTextBox2.Size = new System.Drawing.Size(100, 20);
            this.heightTextBox2.TabIndex = 38;
            // 
            // widthTextBox2
            // 
            this.widthTextBox2.Enabled = false;
            this.widthTextBox2.Location = new System.Drawing.Point(968, 33);
            this.widthTextBox2.Name = "widthTextBox2";
            this.widthTextBox2.Size = new System.Drawing.Size(100, 20);
            this.widthTextBox2.TabIndex = 37;
            // 
            // openAsButton2
            // 
            this.openAsButton2.Location = new System.Drawing.Point(1540, 65);
            this.openAsButton2.Name = "openAsButton2";
            this.openAsButton2.Size = new System.Drawing.Size(111, 42);
            this.openAsButton2.TabIndex = 36;
            this.openAsButton2.Text = "Open As";
            this.openAsButton2.UseVisualStyleBackColor = true;
            this.openAsButton2.Click += new System.EventHandler(this.openAsButton2_Click);
            // 
            // saveAsButton2
            // 
            this.saveAsButton2.Location = new System.Drawing.Point(1657, 65);
            this.saveAsButton2.Name = "saveAsButton2";
            this.saveAsButton2.Size = new System.Drawing.Size(111, 42);
            this.saveAsButton2.TabIndex = 35;
            this.saveAsButton2.Text = "Save As";
            this.saveAsButton2.UseVisualStyleBackColor = true;
            this.saveAsButton2.Click += new System.EventHandler(this.saveAsButton2_Click);
            // 
            // clearButton2
            // 
            this.clearButton2.Location = new System.Drawing.Point(1774, 18);
            this.clearButton2.Name = "clearButton2";
            this.clearButton2.Size = new System.Drawing.Size(111, 42);
            this.clearButton2.TabIndex = 34;
            this.clearButton2.Text = "Clear";
            this.clearButton2.UseVisualStyleBackColor = true;
            this.clearButton2.Click += new System.EventHandler(this.clearButton2_Click);
            // 
            // buttonSave2
            // 
            this.buttonSave2.Location = new System.Drawing.Point(1657, 18);
            this.buttonSave2.Name = "buttonSave2";
            this.buttonSave2.Size = new System.Drawing.Size(111, 42);
            this.buttonSave2.TabIndex = 33;
            this.buttonSave2.Text = "Save";
            this.buttonSave2.UseVisualStyleBackColor = true;
            this.buttonSave2.Click += new System.EventHandler(this.saveButton2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(968, 224);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(917, 611);
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // openButton2
            // 
            this.openButton2.Location = new System.Drawing.Point(1540, 17);
            this.openButton2.Name = "openButton2";
            this.openButton2.Size = new System.Drawing.Size(111, 42);
            this.openButton2.TabIndex = 31;
            this.openButton2.Text = "Open";
            this.openButton2.UseVisualStyleBackColor = true;
            this.openButton2.Click += new System.EventHandler(this.openButton2_Click);
            // 
            // flipX
            // 
            this.flipX.Location = new System.Drawing.Point(22, 850);
            this.flipX.Name = "flipX";
            this.flipX.Size = new System.Drawing.Size(100, 46);
            this.flipX.TabIndex = 60;
            this.flipX.Text = "Flip X";
            this.flipX.UseVisualStyleBackColor = true;
            this.flipX.Click += new System.EventHandler(this.flipX_Click);
            // 
            // flipY
            // 
            this.flipY.Location = new System.Drawing.Point(22, 902);
            this.flipY.Name = "flipY";
            this.flipY.Size = new System.Drawing.Size(100, 46);
            this.flipY.TabIndex = 61;
            this.flipY.Text = "Flip Y";
            this.flipY.UseVisualStyleBackColor = true;
            this.flipY.Click += new System.EventHandler(this.flipY_Click);
            // 
            // trackBarX
            // 
            this.trackBarX.Location = new System.Drawing.Point(216, 864);
            this.trackBarX.Maximum = 360;
            this.trackBarX.Name = "trackBarX";
            this.trackBarX.Size = new System.Drawing.Size(716, 45);
            this.trackBarX.TabIndex = 62;
            this.trackBarX.Scroll += new System.EventHandler(this.trackBarX_Scroll);
            // 
            // rotateBox
            // 
            this.rotateBox.Location = new System.Drawing.Point(139, 864);
            this.rotateBox.Name = "rotateBox";
            this.rotateBox.Size = new System.Drawing.Size(60, 20);
            this.rotateBox.TabIndex = 63;
            // 
            // zoomBox
            // 
            this.zoomBox.Location = new System.Drawing.Point(139, 916);
            this.zoomBox.Name = "zoomBox";
            this.zoomBox.Size = new System.Drawing.Size(60, 20);
            this.zoomBox.TabIndex = 64;
            // 
            // trackBarZoom
            // 
            this.trackBarZoom.Location = new System.Drawing.Point(216, 915);
            this.trackBarZoom.Minimum = 1;
            this.trackBarZoom.Name = "trackBarZoom";
            this.trackBarZoom.Size = new System.Drawing.Size(716, 45);
            this.trackBarZoom.TabIndex = 65;
            this.trackBarZoom.Value = 1;
            this.trackBarZoom.Scroll += new System.EventHandler(this.trackBarZoom_Scroll);
            // 
            // ImageProcessApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.trackBarZoom);
            this.Controls.Add(this.zoomBox);
            this.Controls.Add(this.rotateBox);
            this.Controls.Add(this.trackBarX);
            this.Controls.Add(this.flipY);
            this.Controls.Add(this.flipX);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.urlTextBox2);
            this.Controls.Add(this.openUrlButton2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cropPosY2);
            this.Controls.Add(this.cropPosX2);
            this.Controls.Add(this.cropHeightTextBox2);
            this.Controls.Add(this.cropWidthTextBox2);
            this.Controls.Add(this.cropButton2);
            this.Controls.Add(this.detailsListBox2);
            this.Controls.Add(this.colorsTextBox2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.hResTextBox2);
            this.Controls.Add(this.vResTextBox2);
            this.Controls.Add(this.heightTextBox2);
            this.Controls.Add(this.widthTextBox2);
            this.Controls.Add(this.openAsButton2);
            this.Controls.Add(this.saveAsButton2);
            this.Controls.Add(this.clearButton2);
            this.Controls.Add(this.buttonSave2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.openButton2);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoom)).EndInit();
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox urlTextBox2;
        private System.Windows.Forms.Button openUrlButton2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox cropPosY2;
        private System.Windows.Forms.TextBox cropPosX2;
        private System.Windows.Forms.TextBox cropHeightTextBox2;
        private System.Windows.Forms.TextBox cropWidthTextBox2;
        private System.Windows.Forms.Button cropButton2;
        private System.Windows.Forms.ListBox detailsListBox2;
        private System.Windows.Forms.TextBox colorsTextBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox hResTextBox2;
        private System.Windows.Forms.TextBox vResTextBox2;
        private System.Windows.Forms.TextBox heightTextBox2;
        private System.Windows.Forms.TextBox widthTextBox2;
        private System.Windows.Forms.Button openAsButton2;
        private System.Windows.Forms.Button saveAsButton2;
        private System.Windows.Forms.Button clearButton2;
        private System.Windows.Forms.Button buttonSave2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button openButton2;
        private System.Windows.Forms.Button flipX;
        private System.Windows.Forms.Button flipY;
        private System.Windows.Forms.TrackBar trackBarX;
        private System.Windows.Forms.TextBox rotateBox;
        private System.Windows.Forms.TextBox zoomBox;
        private System.Windows.Forms.TrackBar trackBarZoom;
    }
}

