
namespace Pro_code_editor
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.UPpanel = new System.Windows.Forms.Panel();
            this.buttonQuestion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMinimizet = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panelHome = new System.Windows.Forms.Panel();
            this.panelHomeUp = new System.Windows.Forms.Panel();
            this.pictureBoxHome = new System.Windows.Forms.PictureBox();
            this.labelHome = new System.Windows.Forms.Label();
            this.buttonEncryption = new System.Windows.Forms.Button();
            this.panelEncryption = new System.Windows.Forms.Panel();
            this.buttonSaveToGallery = new System.Windows.Forms.Button();
            this.labelHelpImputData = new System.Windows.Forms.Label();
            this.richTextBoxInputText = new System.Windows.Forms.RichTextBox();
            this.checkBoxAvtoSave = new System.Windows.Forms.CheckBox();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelEncryptionUp = new System.Windows.Forms.Panel();
            this.pictureBoxEncryption = new System.Windows.Forms.PictureBox();
            this.labelEncryption = new System.Windows.Forms.Label();
            this.panelQRcreationError = new System.Windows.Forms.Panel();
            this.ClosePanelQRcreationError = new System.Windows.Forms.Label();
            this.labelQRcreationError = new System.Windows.Forms.Label();
            this.GarbageCollection = new System.Windows.Forms.Timer(this.components);
            this.buttonDecryption = new System.Windows.Forms.Button();
            this.panelDecryption = new System.Windows.Forms.Panel();
            this.buttonCopuOutputText = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelHelpOutputData = new System.Windows.Forms.Label();
            this.richTextBoxOutputText = new System.Windows.Forms.RichTextBox();
            this.buttonPrintScreenDecr = new System.Windows.Forms.Button();
            this.buttonLoadDecr = new System.Windows.Forms.Button();
            this.buttonOpenToEnecr = new System.Windows.Forms.Button();
            this.buttonSaveToGalleryDecr = new System.Windows.Forms.Button();
            this.buttonPrintDecr = new System.Windows.Forms.Button();
            this.buttonClearDecr = new System.Windows.Forms.Button();
            this.buttonSaveDecr = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelDecryptionUp = new System.Windows.Forms.Panel();
            this.pictureBoxDecryption = new System.Windows.Forms.PictureBox();
            this.labelDecryption = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.InfoErrorPanelQRcreationError = new System.Windows.Forms.Label();
            this.timerShowQRErrorPanel = new System.Windows.Forms.Timer(this.components);
            this.UPpanel.SuspendLayout();
            this.panelHome.SuspendLayout();
            this.panelHomeUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).BeginInit();
            this.panelEncryption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelEncryptionUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEncryption)).BeginInit();
            this.panelQRcreationError.SuspendLayout();
            this.panelDecryption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelDecryptionUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDecryption)).BeginInit();
            this.SuspendLayout();
            // 
            // UPpanel
            // 
            this.UPpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(100)))));
            this.UPpanel.Controls.Add(this.buttonQuestion);
            this.UPpanel.Controls.Add(this.label1);
            this.UPpanel.Controls.Add(this.buttonMinimizet);
            this.UPpanel.Controls.Add(this.buttonClose);
            this.UPpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UPpanel.Location = new System.Drawing.Point(0, 0);
            this.UPpanel.Name = "UPpanel";
            this.UPpanel.Size = new System.Drawing.Size(639, 50);
            this.UPpanel.TabIndex = 0;
            this.UPpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.UPpanel_Paint);
            this.UPpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UPpanel_MouseDown);
            this.UPpanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UPpanel_MouseMove);
            // 
            // buttonQuestion
            // 
            this.buttonQuestion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(100)))));
            this.buttonQuestion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonQuestion.FlatAppearance.BorderSize = 3;
            this.buttonQuestion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.buttonQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonQuestion.ForeColor = System.Drawing.Color.White;
            this.buttonQuestion.Location = new System.Drawing.Point(502, 5);
            this.buttonQuestion.Name = "buttonQuestion";
            this.buttonQuestion.Size = new System.Drawing.Size(40, 40);
            this.buttonQuestion.TabIndex = 6;
            this.buttonQuestion.Text = "?";
            this.buttonQuestion.UseVisualStyleBackColor = false;
            this.buttonQuestion.Click += new System.EventHandler(this.buttonQuestion_Click);
            this.buttonQuestion.MouseEnter += new System.EventHandler(this.buttonQuestion_MouseEnter);
            this.buttonQuestion.MouseLeave += new System.EventHandler(this.buttonQuestion_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pro code editor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // buttonMinimizet
            // 
            this.buttonMinimizet.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonMinimizet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(100)))));
            this.buttonMinimizet.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonMinimizet.FlatAppearance.BorderSize = 3;
            this.buttonMinimizet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.buttonMinimizet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimizet.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMinimizet.ForeColor = System.Drawing.Color.White;
            this.buttonMinimizet.Location = new System.Drawing.Point(548, 5);
            this.buttonMinimizet.Name = "buttonMinimizet";
            this.buttonMinimizet.Size = new System.Drawing.Size(40, 40);
            this.buttonMinimizet.TabIndex = 4;
            this.buttonMinimizet.Text = "-";
            this.buttonMinimizet.UseVisualStyleBackColor = false;
            this.buttonMinimizet.Click += new System.EventHandler(this.buttonMinimizet_Click);
            this.buttonMinimizet.MouseEnter += new System.EventHandler(this.buttonMinimizet_MouseEnter);
            this.buttonMinimizet.MouseLeave += new System.EventHandler(this.buttonMinimizet_MouseLeave);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(100)))));
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonClose.FlatAppearance.BorderSize = 2;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(594, 5);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(40, 40);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "⛌";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            this.buttonClose.MouseEnter += new System.EventHandler(this.buttonClose_MouseEnter);
            this.buttonClose.MouseLeave += new System.EventHandler(this.buttonClose_MouseLeave);
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(143)))));
            this.buttonHome.FlatAppearance.BorderSize = 2;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Location = new System.Drawing.Point(6, 56);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(140, 35);
            this.buttonHome.TabIndex = 1;
            this.buttonHome.Text = "Главная";
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // panelHome
            // 
            this.panelHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(184)))));
            this.panelHome.Controls.Add(this.panelHomeUp);
            this.panelHome.Location = new System.Drawing.Point(152, 55);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(482, 415);
            this.panelHome.TabIndex = 2;
            this.panelHome.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHome_Paint);
            // 
            // panelHomeUp
            // 
            this.panelHomeUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(143)))));
            this.panelHomeUp.Controls.Add(this.pictureBoxHome);
            this.panelHomeUp.Controls.Add(this.labelHome);
            this.panelHomeUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHomeUp.Location = new System.Drawing.Point(0, 0);
            this.panelHomeUp.Name = "panelHomeUp";
            this.panelHomeUp.Size = new System.Drawing.Size(482, 35);
            this.panelHomeUp.TabIndex = 7;
            this.panelHomeUp.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHomeUp_Paint);
            // 
            // pictureBoxHome
            // 
            this.pictureBoxHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(143)))));
            this.pictureBoxHome.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHome.Image")));
            this.pictureBoxHome.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxHome.Name = "pictureBoxHome";
            this.pictureBoxHome.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHome.TabIndex = 5;
            this.pictureBoxHome.TabStop = false;
            this.pictureBoxHome.Click += new System.EventHandler(this.pictureBoxHome_Click);
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelHome.Location = new System.Drawing.Point(36, 4);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(94, 24);
            this.labelHome.TabIndex = 6;
            this.labelHome.Text = "Главная";
            // 
            // buttonEncryption
            // 
            this.buttonEncryption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(143)))));
            this.buttonEncryption.FlatAppearance.BorderSize = 2;
            this.buttonEncryption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEncryption.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEncryption.ForeColor = System.Drawing.Color.White;
            this.buttonEncryption.Location = new System.Drawing.Point(6, 97);
            this.buttonEncryption.Name = "buttonEncryption";
            this.buttonEncryption.Size = new System.Drawing.Size(140, 35);
            this.buttonEncryption.TabIndex = 3;
            this.buttonEncryption.Text = "Зашифровать";
            this.buttonEncryption.UseVisualStyleBackColor = false;
            this.buttonEncryption.Click += new System.EventHandler(this.buttonEncryption_Click);
            // 
            // panelEncryption
            // 
            this.panelEncryption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelEncryption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(184)))));
            this.panelEncryption.Controls.Add(this.buttonSaveToGallery);
            this.panelEncryption.Controls.Add(this.labelHelpImputData);
            this.panelEncryption.Controls.Add(this.richTextBoxInputText);
            this.panelEncryption.Controls.Add(this.checkBoxAvtoSave);
            this.panelEncryption.Controls.Add(this.buttonPrint);
            this.panelEncryption.Controls.Add(this.comboBox1);
            this.panelEncryption.Controls.Add(this.buttonClear);
            this.panelEncryption.Controls.Add(this.buttonSave);
            this.panelEncryption.Controls.Add(this.pictureBox1);
            this.panelEncryption.Controls.Add(this.panelEncryptionUp);
            this.panelEncryption.Location = new System.Drawing.Point(152, 55);
            this.panelEncryption.Name = "panelEncryption";
            this.panelEncryption.Size = new System.Drawing.Size(482, 415);
            this.panelEncryption.TabIndex = 4;
            this.panelEncryption.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEncryption_Paint);
            // 
            // buttonSaveToGallery
            // 
            this.buttonSaveToGallery.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSaveToGallery.FlatAppearance.BorderSize = 0;
            this.buttonSaveToGallery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveToGallery.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveToGallery.ForeColor = System.Drawing.Color.White;
            this.buttonSaveToGallery.Location = new System.Drawing.Point(312, 72);
            this.buttonSaveToGallery.Name = "buttonSaveToGallery";
            this.buttonSaveToGallery.Size = new System.Drawing.Size(163, 26);
            this.buttonSaveToGallery.TabIndex = 16;
            this.buttonSaveToGallery.Text = "Сохранить в галерею";
            this.buttonSaveToGallery.UseVisualStyleBackColor = false;
            this.buttonSaveToGallery.Click += new System.EventHandler(this.buttonSaveToGallery_Click);
            // 
            // labelHelpImputData
            // 
            this.labelHelpImputData.AutoSize = true;
            this.labelHelpImputData.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelHelpImputData.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.labelHelpImputData.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelHelpImputData.Location = new System.Drawing.Point(6, 347);
            this.labelHelpImputData.Name = "labelHelpImputData";
            this.labelHelpImputData.Size = new System.Drawing.Size(234, 19);
            this.labelHelpImputData.TabIndex = 15;
            this.labelHelpImputData.Text = "Введите текст или числа :";
            this.labelHelpImputData.Click += new System.EventHandler(this.labelHelpImputData_Click);
            // 
            // richTextBoxInputText
            // 
            this.richTextBoxInputText.BackColor = System.Drawing.SystemColors.Highlight;
            this.richTextBoxInputText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxInputText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxInputText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBoxInputText.Location = new System.Drawing.Point(5, 346);
            this.richTextBoxInputText.Name = "richTextBoxInputText";
            this.richTextBoxInputText.Size = new System.Drawing.Size(472, 63);
            this.richTextBoxInputText.TabIndex = 14;
            this.richTextBoxInputText.Text = "";
            this.richTextBoxInputText.Click += new System.EventHandler(this.richTextBoxInputText_Click);
            this.richTextBoxInputText.TextChanged += new System.EventHandler(this.richTextBoxInputText_TextChanged);
            // 
            // checkBoxAvtoSave
            // 
            this.checkBoxAvtoSave.AutoSize = true;
            this.checkBoxAvtoSave.Checked = true;
            this.checkBoxAvtoSave.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAvtoSave.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.checkBoxAvtoSave.ForeColor = System.Drawing.Color.White;
            this.checkBoxAvtoSave.Location = new System.Drawing.Point(312, 197);
            this.checkBoxAvtoSave.Name = "checkBoxAvtoSave";
            this.checkBoxAvtoSave.Size = new System.Drawing.Size(159, 19);
            this.checkBoxAvtoSave.TabIndex = 13;
            this.checkBoxAvtoSave.Text = "Сохранять в галерею";
            this.checkBoxAvtoSave.UseVisualStyleBackColor = true;
            this.checkBoxAvtoSave.CheckedChanged += new System.EventHandler(this.checkBoxAvtoSave_CheckedChanged);
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonPrint.FlatAppearance.BorderSize = 0;
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrint.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPrint.ForeColor = System.Drawing.Color.White;
            this.buttonPrint.Location = new System.Drawing.Point(312, 104);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(163, 26);
            this.buttonPrint.TabIndex = 12;
            this.buttonPrint.Text = "Печать";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox1.Items.AddRange(new object[] {
            "QR",
            "AZTEC",
            "CODABAR(только числа)",
            "CODE_39",
            "CODE_93",
            "CODE_128",
            "DATA_MATRIX",
            "ITF",
            "PDF_417",
            "MSI"});
            this.comboBox1.Location = new System.Drawing.Point(312, 168);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 23);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(312, 136);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(163, 26);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(312, 40);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(163, 26);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelEncryptionUp
            // 
            this.panelEncryptionUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(143)))));
            this.panelEncryptionUp.Controls.Add(this.pictureBoxEncryption);
            this.panelEncryptionUp.Controls.Add(this.labelEncryption);
            this.panelEncryptionUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEncryptionUp.Location = new System.Drawing.Point(0, 0);
            this.panelEncryptionUp.Name = "panelEncryptionUp";
            this.panelEncryptionUp.Size = new System.Drawing.Size(482, 35);
            this.panelEncryptionUp.TabIndex = 7;
            this.panelEncryptionUp.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEncryptionUp_Paint);
            // 
            // pictureBoxEncryption
            // 
            this.pictureBoxEncryption.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEncryption.Image")));
            this.pictureBoxEncryption.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxEncryption.Name = "pictureBoxEncryption";
            this.pictureBoxEncryption.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxEncryption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEncryption.TabIndex = 8;
            this.pictureBoxEncryption.TabStop = false;
            this.pictureBoxEncryption.Click += new System.EventHandler(this.pictureBoxEncryption_Click);
            // 
            // labelEncryption
            // 
            this.labelEncryption.AutoSize = true;
            this.labelEncryption.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEncryption.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelEncryption.Location = new System.Drawing.Point(36, 4);
            this.labelEncryption.Name = "labelEncryption";
            this.labelEncryption.Size = new System.Drawing.Size(130, 24);
            this.labelEncryption.TabIndex = 6;
            this.labelEncryption.Text = "Зашифровка";
            // 
            // panelQRcreationError
            // 
            this.panelQRcreationError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(117)))), ((int)(((byte)(0)))));
            this.panelQRcreationError.Controls.Add(this.InfoErrorPanelQRcreationError);
            this.panelQRcreationError.Controls.Add(this.ClosePanelQRcreationError);
            this.panelQRcreationError.Controls.Add(this.labelQRcreationError);
            this.panelQRcreationError.Location = new System.Drawing.Point(6, 418);
            this.panelQRcreationError.Name = "panelQRcreationError";
            this.panelQRcreationError.Size = new System.Drawing.Size(140, 52);
            this.panelQRcreationError.TabIndex = 5;
            this.panelQRcreationError.Paint += new System.Windows.Forms.PaintEventHandler(this.panelQRcreationError_Paint);
            // 
            // ClosePanelQRcreationError
            // 
            this.ClosePanelQRcreationError.AutoSize = true;
            this.ClosePanelQRcreationError.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClosePanelQRcreationError.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ClosePanelQRcreationError.Location = new System.Drawing.Point(117, 1);
            this.ClosePanelQRcreationError.Name = "ClosePanelQRcreationError";
            this.ClosePanelQRcreationError.Size = new System.Drawing.Size(26, 22);
            this.ClosePanelQRcreationError.TabIndex = 1;
            this.ClosePanelQRcreationError.Text = "⛌";
            this.ClosePanelQRcreationError.Click += new System.EventHandler(this.ClosePanelQRcreationError_Click);
            this.ClosePanelQRcreationError.MouseEnter += new System.EventHandler(this.ClosePanelQRcreationError_MouseEnter);
            this.ClosePanelQRcreationError.MouseLeave += new System.EventHandler(this.ClosePanelQRcreationError_MouseLeave);
            // 
            // labelQRcreationError
            // 
            this.labelQRcreationError.AutoSize = true;
            this.labelQRcreationError.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelQRcreationError.Location = new System.Drawing.Point(-1, 19);
            this.labelQRcreationError.Name = "labelQRcreationError";
            this.labelQRcreationError.Size = new System.Drawing.Size(49, 15);
            this.labelQRcreationError.TabIndex = 0;
            this.labelQRcreationError.Text = "Ошибка";
            this.labelQRcreationError.Click += new System.EventHandler(this.labelQRcreationError_Click);
            // 
            // GarbageCollection
            // 
            this.GarbageCollection.Enabled = true;
            this.GarbageCollection.Interval = 4000;
            this.GarbageCollection.Tick += new System.EventHandler(this.GarbageCollection_Tick);
            // 
            // buttonDecryption
            // 
            this.buttonDecryption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(143)))));
            this.buttonDecryption.FlatAppearance.BorderSize = 2;
            this.buttonDecryption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDecryption.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDecryption.ForeColor = System.Drawing.Color.White;
            this.buttonDecryption.Location = new System.Drawing.Point(6, 138);
            this.buttonDecryption.Name = "buttonDecryption";
            this.buttonDecryption.Size = new System.Drawing.Size(140, 35);
            this.buttonDecryption.TabIndex = 6;
            this.buttonDecryption.Text = "Расшифровать";
            this.buttonDecryption.UseVisualStyleBackColor = false;
            this.buttonDecryption.Click += new System.EventHandler(this.buttonDecryption_Click);
            // 
            // panelDecryption
            // 
            this.panelDecryption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(184)))));
            this.panelDecryption.Controls.Add(this.buttonCopuOutputText);
            this.panelDecryption.Controls.Add(this.button1);
            this.panelDecryption.Controls.Add(this.labelHelpOutputData);
            this.panelDecryption.Controls.Add(this.richTextBoxOutputText);
            this.panelDecryption.Controls.Add(this.buttonPrintScreenDecr);
            this.panelDecryption.Controls.Add(this.buttonLoadDecr);
            this.panelDecryption.Controls.Add(this.buttonOpenToEnecr);
            this.panelDecryption.Controls.Add(this.buttonSaveToGalleryDecr);
            this.panelDecryption.Controls.Add(this.buttonPrintDecr);
            this.panelDecryption.Controls.Add(this.buttonClearDecr);
            this.panelDecryption.Controls.Add(this.buttonSaveDecr);
            this.panelDecryption.Controls.Add(this.pictureBox2);
            this.panelDecryption.Controls.Add(this.panelDecryptionUp);
            this.panelDecryption.Location = new System.Drawing.Point(152, 55);
            this.panelDecryption.Name = "panelDecryption";
            this.panelDecryption.Size = new System.Drawing.Size(482, 415);
            this.panelDecryption.TabIndex = 17;
            this.panelDecryption.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDecryption_Paint);
            // 
            // buttonCopuOutputText
            // 
            this.buttonCopuOutputText.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonCopuOutputText.FlatAppearance.BorderSize = 0;
            this.buttonCopuOutputText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCopuOutputText.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCopuOutputText.ForeColor = System.Drawing.Color.White;
            this.buttonCopuOutputText.Location = new System.Drawing.Point(312, 296);
            this.buttonCopuOutputText.Name = "buttonCopuOutputText";
            this.buttonCopuOutputText.Size = new System.Drawing.Size(163, 26);
            this.buttonCopuOutputText.TabIndex = 27;
            this.buttonCopuOutputText.Text = "Копировать текст";
            this.buttonCopuOutputText.UseVisualStyleBackColor = false;
            this.buttonCopuOutputText.Click += new System.EventHandler(this.buttonCopuOutputText_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(312, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 26);
            this.button1.TabIndex = 26;
            this.button1.Text = "Расшифровать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelHelpOutputData
            // 
            this.labelHelpOutputData.AutoSize = true;
            this.labelHelpOutputData.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelHelpOutputData.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.labelHelpOutputData.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelHelpOutputData.Location = new System.Drawing.Point(6, 347);
            this.labelHelpOutputData.Name = "labelHelpOutputData";
            this.labelHelpOutputData.Size = new System.Drawing.Size(108, 19);
            this.labelHelpOutputData.TabIndex = 25;
            this.labelHelpOutputData.Text = "Результат :";
            this.labelHelpOutputData.Click += new System.EventHandler(this.labelHelpOutputData_Click);
            // 
            // richTextBoxOutputText
            // 
            this.richTextBoxOutputText.BackColor = System.Drawing.SystemColors.Highlight;
            this.richTextBoxOutputText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxOutputText.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBoxOutputText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxOutputText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBoxOutputText.Location = new System.Drawing.Point(5, 346);
            this.richTextBoxOutputText.Name = "richTextBoxOutputText";
            this.richTextBoxOutputText.Size = new System.Drawing.Size(472, 63);
            this.richTextBoxOutputText.TabIndex = 24;
            this.richTextBoxOutputText.Text = "";
            this.richTextBoxOutputText.TextChanged += new System.EventHandler(this.richTextBoxOutputText_TextChanged);
            // 
            // buttonPrintScreenDecr
            // 
            this.buttonPrintScreenDecr.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonPrintScreenDecr.FlatAppearance.BorderSize = 0;
            this.buttonPrintScreenDecr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrintScreenDecr.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPrintScreenDecr.ForeColor = System.Drawing.Color.White;
            this.buttonPrintScreenDecr.Location = new System.Drawing.Point(312, 72);
            this.buttonPrintScreenDecr.Name = "buttonPrintScreenDecr";
            this.buttonPrintScreenDecr.Size = new System.Drawing.Size(163, 26);
            this.buttonPrintScreenDecr.TabIndex = 23;
            this.buttonPrintScreenDecr.Text = "Снимок экрана";
            this.buttonPrintScreenDecr.UseVisualStyleBackColor = false;
            this.buttonPrintScreenDecr.Click += new System.EventHandler(this.buttonPrintScreenDecr_Click);
            // 
            // buttonLoadDecr
            // 
            this.buttonLoadDecr.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonLoadDecr.FlatAppearance.BorderSize = 0;
            this.buttonLoadDecr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadDecr.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoadDecr.ForeColor = System.Drawing.Color.White;
            this.buttonLoadDecr.Location = new System.Drawing.Point(312, 41);
            this.buttonLoadDecr.Name = "buttonLoadDecr";
            this.buttonLoadDecr.Size = new System.Drawing.Size(163, 26);
            this.buttonLoadDecr.TabIndex = 22;
            this.buttonLoadDecr.Text = "Загрузить";
            this.buttonLoadDecr.UseVisualStyleBackColor = false;
            this.buttonLoadDecr.Click += new System.EventHandler(this.buttonLoadDecr_Click);
            // 
            // buttonOpenToEnecr
            // 
            this.buttonOpenToEnecr.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonOpenToEnecr.FlatAppearance.BorderSize = 0;
            this.buttonOpenToEnecr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenToEnecr.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenToEnecr.ForeColor = System.Drawing.Color.White;
            this.buttonOpenToEnecr.Location = new System.Drawing.Point(312, 264);
            this.buttonOpenToEnecr.Name = "buttonOpenToEnecr";
            this.buttonOpenToEnecr.Size = new System.Drawing.Size(163, 26);
            this.buttonOpenToEnecr.TabIndex = 21;
            this.buttonOpenToEnecr.Text = "Открыть в зашифровке";
            this.buttonOpenToEnecr.UseVisualStyleBackColor = false;
            this.buttonOpenToEnecr.Click += new System.EventHandler(this.buttonOpenToEnecr_Click);
            // 
            // buttonSaveToGalleryDecr
            // 
            this.buttonSaveToGalleryDecr.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSaveToGalleryDecr.FlatAppearance.BorderSize = 0;
            this.buttonSaveToGalleryDecr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveToGalleryDecr.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveToGalleryDecr.ForeColor = System.Drawing.Color.White;
            this.buttonSaveToGalleryDecr.Location = new System.Drawing.Point(312, 168);
            this.buttonSaveToGalleryDecr.Name = "buttonSaveToGalleryDecr";
            this.buttonSaveToGalleryDecr.Size = new System.Drawing.Size(163, 26);
            this.buttonSaveToGalleryDecr.TabIndex = 20;
            this.buttonSaveToGalleryDecr.Text = "Сохранить в галерею";
            this.buttonSaveToGalleryDecr.UseVisualStyleBackColor = false;
            this.buttonSaveToGalleryDecr.Click += new System.EventHandler(this.buttonSaveToGalleryDecr_Click);
            // 
            // buttonPrintDecr
            // 
            this.buttonPrintDecr.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonPrintDecr.FlatAppearance.BorderSize = 0;
            this.buttonPrintDecr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrintDecr.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPrintDecr.ForeColor = System.Drawing.Color.White;
            this.buttonPrintDecr.Location = new System.Drawing.Point(312, 200);
            this.buttonPrintDecr.Name = "buttonPrintDecr";
            this.buttonPrintDecr.Size = new System.Drawing.Size(163, 26);
            this.buttonPrintDecr.TabIndex = 19;
            this.buttonPrintDecr.Text = "Печать";
            this.buttonPrintDecr.UseVisualStyleBackColor = false;
            this.buttonPrintDecr.Click += new System.EventHandler(this.buttonPrintDecr_Click);
            // 
            // buttonClearDecr
            // 
            this.buttonClearDecr.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonClearDecr.FlatAppearance.BorderSize = 0;
            this.buttonClearDecr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearDecr.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClearDecr.ForeColor = System.Drawing.Color.White;
            this.buttonClearDecr.Location = new System.Drawing.Point(312, 232);
            this.buttonClearDecr.Name = "buttonClearDecr";
            this.buttonClearDecr.Size = new System.Drawing.Size(163, 26);
            this.buttonClearDecr.TabIndex = 18;
            this.buttonClearDecr.Text = "Очистить";
            this.buttonClearDecr.UseVisualStyleBackColor = false;
            this.buttonClearDecr.Click += new System.EventHandler(this.buttonClearDecr_Click);
            // 
            // buttonSaveDecr
            // 
            this.buttonSaveDecr.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSaveDecr.FlatAppearance.BorderSize = 0;
            this.buttonSaveDecr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveDecr.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveDecr.ForeColor = System.Drawing.Color.White;
            this.buttonSaveDecr.Location = new System.Drawing.Point(312, 136);
            this.buttonSaveDecr.Name = "buttonSaveDecr";
            this.buttonSaveDecr.Size = new System.Drawing.Size(163, 26);
            this.buttonSaveDecr.TabIndex = 17;
            this.buttonSaveDecr.Text = "Сохранить";
            this.buttonSaveDecr.UseVisualStyleBackColor = false;
            this.buttonSaveDecr.Click += new System.EventHandler(this.buttonSaveDecr_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(5, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 300);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panelDecryptionUp
            // 
            this.panelDecryptionUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(143)))));
            this.panelDecryptionUp.Controls.Add(this.pictureBoxDecryption);
            this.panelDecryptionUp.Controls.Add(this.labelDecryption);
            this.panelDecryptionUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDecryptionUp.Location = new System.Drawing.Point(0, 0);
            this.panelDecryptionUp.Name = "panelDecryptionUp";
            this.panelDecryptionUp.Size = new System.Drawing.Size(482, 35);
            this.panelDecryptionUp.TabIndex = 8;
            this.panelDecryptionUp.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDecryptionUp_Paint);
            // 
            // pictureBoxDecryption
            // 
            this.pictureBoxDecryption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(143)))));
            this.pictureBoxDecryption.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDecryption.Image")));
            this.pictureBoxDecryption.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxDecryption.Name = "pictureBoxDecryption";
            this.pictureBoxDecryption.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxDecryption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDecryption.TabIndex = 5;
            this.pictureBoxDecryption.TabStop = false;
            this.pictureBoxDecryption.Click += new System.EventHandler(this.pictureBoxDecryption_Click);
            // 
            // labelDecryption
            // 
            this.labelDecryption.AutoSize = true;
            this.labelDecryption.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDecryption.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelDecryption.Location = new System.Drawing.Point(36, 4);
            this.labelDecryption.Name = "labelDecryption";
            this.labelDecryption.Size = new System.Drawing.Size(142, 24);
            this.labelDecryption.TabIndex = 6;
            this.labelDecryption.Text = "Расшифровка";
            this.labelDecryption.Click += new System.EventHandler(this.labelDecryption_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Загрузить изображение для расшифровки";
            // 
            // InfoErrorPanelQRcreationError
            // 
            this.InfoErrorPanelQRcreationError.AutoSize = true;
            this.InfoErrorPanelQRcreationError.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoErrorPanelQRcreationError.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.InfoErrorPanelQRcreationError.Location = new System.Drawing.Point(97, 0);
            this.InfoErrorPanelQRcreationError.Name = "InfoErrorPanelQRcreationError";
            this.InfoErrorPanelQRcreationError.Size = new System.Drawing.Size(20, 22);
            this.InfoErrorPanelQRcreationError.TabIndex = 2;
            this.InfoErrorPanelQRcreationError.Text = "?";
            this.InfoErrorPanelQRcreationError.Click += new System.EventHandler(this.InfoErrorPanelQRcreationError_Click);
            this.InfoErrorPanelQRcreationError.MouseEnter += new System.EventHandler(this.InfoErrorPanelQRcreationError_MouseEnter);
            this.InfoErrorPanelQRcreationError.MouseLeave += new System.EventHandler(this.InfoErrorPanelQRcreationError_MouseLeave);
            // 
            // timerShowQRErrorPanel
            // 
            this.timerShowQRErrorPanel.Interval = 1;
            this.timerShowQRErrorPanel.Tick += new System.EventHandler(this.timerShowQRErrorPanel_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(639, 477);
            this.Controls.Add(this.buttonDecryption);
            this.Controls.Add(this.panelQRcreationError);
            this.Controls.Add(this.buttonEncryption);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.UPpanel);
            this.Controls.Add(this.panelDecryption);
            this.Controls.Add(this.panelEncryption);
            this.Controls.Add(this.panelHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Pro code editor";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.UPpanel.ResumeLayout(false);
            this.UPpanel.PerformLayout();
            this.panelHome.ResumeLayout(false);
            this.panelHomeUp.ResumeLayout(false);
            this.panelHomeUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).EndInit();
            this.panelEncryption.ResumeLayout(false);
            this.panelEncryption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelEncryptionUp.ResumeLayout(false);
            this.panelEncryptionUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEncryption)).EndInit();
            this.panelQRcreationError.ResumeLayout(false);
            this.panelQRcreationError.PerformLayout();
            this.panelDecryption.ResumeLayout(false);
            this.panelDecryption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelDecryptionUp.ResumeLayout(false);
            this.panelDecryptionUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDecryption)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UPpanel;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonMinimizet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonQuestion;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Button buttonEncryption;
        private System.Windows.Forms.Label labelHome;
        private System.Windows.Forms.Panel panelEncryption;
        private System.Windows.Forms.Label labelEncryption;
        private System.Windows.Forms.PictureBox pictureBoxHome;
        private System.Windows.Forms.Panel panelHomeUp;
        private System.Windows.Forms.Panel panelEncryptionUp;
        private System.Windows.Forms.PictureBox pictureBoxEncryption;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.CheckBox checkBoxAvtoSave;
        private System.Windows.Forms.RichTextBox richTextBoxInputText;
        private System.Windows.Forms.Panel panelQRcreationError;
        private System.Windows.Forms.Label labelQRcreationError;
        private System.Windows.Forms.Label ClosePanelQRcreationError;
        private System.Windows.Forms.Label labelHelpImputData;
        private System.Windows.Forms.Timer GarbageCollection;
        private System.Windows.Forms.Button buttonSaveToGallery;
        private System.Windows.Forms.Button buttonDecryption;
        private System.Windows.Forms.Panel panelDecryption;
        private System.Windows.Forms.Panel panelDecryptionUp;
        private System.Windows.Forms.PictureBox pictureBoxDecryption;
        private System.Windows.Forms.Label labelDecryption;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonOpenToEnecr;
        private System.Windows.Forms.Button buttonSaveToGalleryDecr;
        private System.Windows.Forms.Button buttonPrintDecr;
        private System.Windows.Forms.Button buttonClearDecr;
        private System.Windows.Forms.Button buttonSaveDecr;
        private System.Windows.Forms.Button buttonLoadDecr;
        private System.Windows.Forms.Button buttonPrintScreenDecr;
        private System.Windows.Forms.Label labelHelpOutputData;
        private System.Windows.Forms.RichTextBox richTextBoxOutputText;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonCopuOutputText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label InfoErrorPanelQRcreationError;
        private System.Windows.Forms.Timer timerShowQRErrorPanel;
    }
}

