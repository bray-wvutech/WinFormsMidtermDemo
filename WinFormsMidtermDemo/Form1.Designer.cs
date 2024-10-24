namespace WinFormsMidtermDemo;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        structAssignmentButton = new Button();
        paramTest1Button = new Button();
        paramTest2Button = new Button();
        paramTest3Button = new Button();
        paramTest4Button = new Button();
        paramTest5Button = new Button();
        dateTimeButton = new Button();
        cardsImageList = new ImageList(components);
        cardPictureBox = new PictureBox();
        mainOpenFileDialog = new OpenFileDialog();
        openButton = new Button();
        mainSaveFileDialog = new SaveFileDialog();
        personListBox = new ListBox();
        phoneLabel = new Label();
        phoneButton = new Button();
        dictTestButton = new Button();
        ((System.ComponentModel.ISupportInitialize)cardPictureBox).BeginInit();
        SuspendLayout();
        // 
        // structAssignmentButton
        // 
        structAssignmentButton.Location = new Point(131, 271);
        structAssignmentButton.Name = "structAssignmentButton";
        structAssignmentButton.Size = new Size(169, 29);
        structAssignmentButton.TabIndex = 0;
        structAssignmentButton.Text = "Struct Assignment";
        structAssignmentButton.UseVisualStyleBackColor = true;
        structAssignmentButton.Click += structAssignmentButton_Click;
        // 
        // paramTest1Button
        // 
        paramTest1Button.Location = new Point(131, 14);
        paramTest1Button.Name = "paramTest1Button";
        paramTest1Button.Size = new Size(173, 29);
        paramTest1Button.TabIndex = 1;
        paramTest1Button.Text = "Param Test 1";
        paramTest1Button.UseVisualStyleBackColor = true;
        paramTest1Button.Click += paramTest1Button_Click;
        // 
        // paramTest2Button
        // 
        paramTest2Button.Location = new Point(131, 63);
        paramTest2Button.Name = "paramTest2Button";
        paramTest2Button.Size = new Size(173, 29);
        paramTest2Button.TabIndex = 2;
        paramTest2Button.Text = "Param Test 2";
        paramTest2Button.UseVisualStyleBackColor = true;
        paramTest2Button.Click += paramTest2Button_Click;
        // 
        // paramTest3Button
        // 
        paramTest3Button.Location = new Point(131, 111);
        paramTest3Button.Name = "paramTest3Button";
        paramTest3Button.Size = new Size(173, 29);
        paramTest3Button.TabIndex = 3;
        paramTest3Button.Text = "Param Test 3";
        paramTest3Button.UseVisualStyleBackColor = true;
        paramTest3Button.Click += paramTest3Button_Click;
        // 
        // paramTest4Button
        // 
        paramTest4Button.Location = new Point(131, 162);
        paramTest4Button.Name = "paramTest4Button";
        paramTest4Button.Size = new Size(173, 29);
        paramTest4Button.TabIndex = 5;
        paramTest4Button.Text = "Param Test 4";
        paramTest4Button.UseVisualStyleBackColor = true;
        paramTest4Button.Click += paramTest4Button_Click;
        // 
        // paramTest5Button
        // 
        paramTest5Button.Location = new Point(131, 216);
        paramTest5Button.Name = "paramTest5Button";
        paramTest5Button.Size = new Size(173, 29);
        paramTest5Button.TabIndex = 6;
        paramTest5Button.Text = "Array Test";
        paramTest5Button.UseVisualStyleBackColor = true;
        paramTest5Button.Click += paramTest5Button_Click;
        // 
        // dateTimeButton
        // 
        dateTimeButton.Location = new Point(131, 324);
        dateTimeButton.Name = "dateTimeButton";
        dateTimeButton.Size = new Size(169, 29);
        dateTimeButton.TabIndex = 7;
        dateTimeButton.Text = "DateTime";
        dateTimeButton.UseVisualStyleBackColor = true;
        dateTimeButton.Click += dateTimeButton_Click;
        // 
        // cardsImageList
        // 
        cardsImageList.ColorDepth = ColorDepth.Depth32Bit;
        cardsImageList.ImageStream = (ImageListStreamer)resources.GetObject("cardsImageList.ImageStream");
        cardsImageList.TransparentColor = System.Drawing.Color.Transparent;
        cardsImageList.Images.SetKeyName(0, "p0.png");
        cardsImageList.Images.SetKeyName(1, "p1.png");
        cardsImageList.Images.SetKeyName(2, "p2.png");
        cardsImageList.Images.SetKeyName(3, "p3.png");
        cardsImageList.Images.SetKeyName(4, "p4.png");
        cardsImageList.Images.SetKeyName(5, "p5.png");
        cardsImageList.Images.SetKeyName(6, "p6.png");
        cardsImageList.Images.SetKeyName(7, "p7.png");
        cardsImageList.Images.SetKeyName(8, "p8.png");
        cardsImageList.Images.SetKeyName(9, "p9.png");
        cardsImageList.Images.SetKeyName(10, "p10.png");
        cardsImageList.Images.SetKeyName(11, "p11.png");
        cardsImageList.Images.SetKeyName(12, "p12.png");
        cardsImageList.Images.SetKeyName(13, "p13.png");
        cardsImageList.Images.SetKeyName(14, "p14.png");
        cardsImageList.Images.SetKeyName(15, "p15.png");
        cardsImageList.Images.SetKeyName(16, "p16.png");
        cardsImageList.Images.SetKeyName(17, "p17.png");
        cardsImageList.Images.SetKeyName(18, "p18.png");
        cardsImageList.Images.SetKeyName(19, "p19.png");
        cardsImageList.Images.SetKeyName(20, "p20.png");
        cardsImageList.Images.SetKeyName(21, "p21.png");
        cardsImageList.Images.SetKeyName(22, "p22.png");
        cardsImageList.Images.SetKeyName(23, "p23.png");
        cardsImageList.Images.SetKeyName(24, "p24.png");
        cardsImageList.Images.SetKeyName(25, "p25.png");
        cardsImageList.Images.SetKeyName(26, "p26.png");
        cardsImageList.Images.SetKeyName(27, "p27.png");
        cardsImageList.Images.SetKeyName(28, "p28.png");
        cardsImageList.Images.SetKeyName(29, "p29.png");
        cardsImageList.Images.SetKeyName(30, "p30.png");
        cardsImageList.Images.SetKeyName(31, "p31.png");
        cardsImageList.Images.SetKeyName(32, "p32.png");
        cardsImageList.Images.SetKeyName(33, "p33.png");
        cardsImageList.Images.SetKeyName(34, "p34.png");
        cardsImageList.Images.SetKeyName(35, "p35.png");
        cardsImageList.Images.SetKeyName(36, "p36.png");
        cardsImageList.Images.SetKeyName(37, "p37.png");
        cardsImageList.Images.SetKeyName(38, "p38.png");
        cardsImageList.Images.SetKeyName(39, "p39.png");
        cardsImageList.Images.SetKeyName(40, "p40.png");
        cardsImageList.Images.SetKeyName(41, "p41.png");
        cardsImageList.Images.SetKeyName(42, "p42.png");
        cardsImageList.Images.SetKeyName(43, "p43.png");
        cardsImageList.Images.SetKeyName(44, "p44.png");
        cardsImageList.Images.SetKeyName(45, "p45.png");
        cardsImageList.Images.SetKeyName(46, "p46.png");
        cardsImageList.Images.SetKeyName(47, "p47.png");
        cardsImageList.Images.SetKeyName(48, "p48.png");
        cardsImageList.Images.SetKeyName(49, "p49.png");
        cardsImageList.Images.SetKeyName(50, "p50.png");
        cardsImageList.Images.SetKeyName(51, "p51.png");
        // 
        // cardPictureBox
        // 
        cardPictureBox.Location = new Point(353, 63);
        cardPictureBox.Name = "cardPictureBox";
        cardPictureBox.Size = new Size(136, 218);
        cardPictureBox.TabIndex = 8;
        cardPictureBox.TabStop = false;
        // 
        // mainOpenFileDialog
        // 
        mainOpenFileDialog.FileName = "openFileDialog1";
        // 
        // openButton
        // 
        openButton.Location = new Point(353, 14);
        openButton.Name = "openButton";
        openButton.Size = new Size(136, 29);
        openButton.TabIndex = 9;
        openButton.Text = "Open File";
        openButton.UseVisualStyleBackColor = true;
        openButton.Click += openButton_Click;
        // 
        // personListBox
        // 
        personListBox.FormattingEnabled = true;
        personListBox.Location = new Point(535, 63);
        personListBox.Name = "personListBox";
        personListBox.Size = new Size(150, 244);
        personListBox.TabIndex = 10;
        personListBox.SelectedIndexChanged += personListBox_SelectedIndexChanged;
        // 
        // phoneLabel
        // 
        phoneLabel.BorderStyle = BorderStyle.FixedSingle;
        phoneLabel.Location = new Point(535, 328);
        phoneLabel.Name = "phoneLabel";
        phoneLabel.Size = new Size(149, 25);
        phoneLabel.TabIndex = 11;
        // 
        // phoneButton
        // 
        phoneButton.Location = new Point(535, 14);
        phoneButton.Name = "phoneButton";
        phoneButton.Size = new Size(150, 29);
        phoneButton.TabIndex = 12;
        phoneButton.Text = "Load Phone Book";
        phoneButton.UseVisualStyleBackColor = true;
        phoneButton.Click += phoneButton_Click;
        // 
        // dictTestButton
        // 
        dictTestButton.Location = new Point(743, 92);
        dictTestButton.Name = "dictTestButton";
        dictTestButton.Size = new Size(94, 29);
        dictTestButton.TabIndex = 13;
        dictTestButton.Text = "Dict Test";
        dictTestButton.UseVisualStyleBackColor = true;
        dictTestButton.Click += dictTestButton_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(883, 409);
        Controls.Add(dictTestButton);
        Controls.Add(phoneButton);
        Controls.Add(phoneLabel);
        Controls.Add(personListBox);
        Controls.Add(openButton);
        Controls.Add(cardPictureBox);
        Controls.Add(dateTimeButton);
        Controls.Add(paramTest5Button);
        Controls.Add(paramTest4Button);
        Controls.Add(paramTest3Button);
        Controls.Add(paramTest2Button);
        Controls.Add(paramTest1Button);
        Controls.Add(structAssignmentButton);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)cardPictureBox).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Button structAssignmentButton;
    private Button paramTest1Button;
    private Button paramTest2Button;
    private Button paramTest3Button;
    private Button paramTest4Button;
    private Button paramTest5Button;
    private Button dateTimeButton;
    private ImageList cardsImageList;
    private PictureBox cardPictureBox;
    private OpenFileDialog mainOpenFileDialog;
    private Button openButton;
    private SaveFileDialog mainSaveFileDialog;
    private ListBox personListBox;
    private Label phoneLabel;
    private Button phoneButton;
    private Button dictTestButton;
}
