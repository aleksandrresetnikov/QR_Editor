using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.IO;

using ZXing;

namespace Pro_code_editor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            this.CenterToScreen();
            InitializeComponent();
            FileMenager.fileStartTest();

            updatePaneSelection();
            Start();
        }
        private void Start()
        {
            richTextBoxOutputText.ReadOnly = true;
            comboBox1.SelectedItem = "QR";
            checkBoxAvtoSave.Checked = FileMenager.autosaveToGalleryStatus;
            ClosePanelQRcreationErrorMissing();
            startMessagePanel();
        }

        private void UPpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonClose_MouseEnter(object sender, EventArgs e)
        {

        }
        private void buttonClose_MouseLeave(object sender, EventArgs e)
        {

        }

        private void buttonMinimizet_Click(object sender, EventArgs e)
        {
            buttonClose.FlatAppearance.BorderSize = 3;
            buttonMinimizet.FlatAppearance.BorderSize = 2;
            buttonMinimizet.ForeColor = Color.White;
            this.WindowState = FormWindowState.Minimized;
        }
        private void buttonMinimizet_MouseEnter(object sender, EventArgs e)
        {
            buttonMinimizet.ForeColor = Color.Black;
        }
        private void buttonMinimizet_MouseLeave(object sender, EventArgs e)
        {
            buttonMinimizet.ForeColor = Color.White;
        }

        private void buttonQuestion_Click(object sender, EventArgs e)
        {

        }
        private void buttonQuestion_MouseEnter(object sender, EventArgs e)
        {
            buttonQuestion.ForeColor = Color.Black;
        }
        private void buttonQuestion_MouseLeave(object sender, EventArgs e)
        {
            buttonQuestion.ForeColor = Color.White;
        }

        Point lastPoint;
        private void UPpanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left = this.Left + e.X - lastPoint.X;
                this.Top = this.Top + e.Y - lastPoint.Y;
            }
        }
        private void UPpanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left = this.Left + e.X - lastPoint.X;
                this.Top = this.Top + e.Y - lastPoint.Y;
            }
        }
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left = this.Left + e.X - lastPoint.X;
                this.Top = this.Top + e.Y - lastPoint.Y;
            }
        }
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void label1_Click(object sender, EventArgs e)
        {
            ErrorMessage("QR decryption error", new System.FormatException());
        }

        SelectPanelList selectPanelListVivo = SelectPanelList.selectHome;
        private void updatePaneSelection()
        {
            ClosePanelQRcreationErrorMissing();
            switch (selectPanelListVivo)
            {
                case SelectPanelList.selectHome:
                    buttonHome_redet(true);
                    buttonEncryption_redet(false);
                    buttonDecryption_redet(false);
                    break;
                case SelectPanelList.selectEncryption:
                    buttonHome_redet(false);
                    buttonEncryption_redet(true);
                    buttonDecryption_redet(false);
                    break;
                case SelectPanelList.selectDecryption:
                    buttonHome_redet(false);
                    buttonEncryption_redet(false);
                    buttonDecryption_redet(true);
                    break;
                default:
                    selectPanelListVivo = SelectPanelList.selectHome;
                    updatePaneSelection();
                    break;
            }
        }
        void buttonHome_redet(bool selectVivo)
        {
            panelHome.Visible = selectVivo;
            if (selectVivo)
            {
                buttonHome.FlatAppearance.BorderSize = 0;
                buttonHome.BackColor = Color.FromArgb(235, 117, 0);
                buttonHome.Font = new Font("Consolas", 14);
                buttonHome.ForeColor = Color.Black;
            }
            else
            {
                buttonHome.FlatAppearance.BorderSize = 2;
                buttonHome.BackColor = Color.FromArgb(0, 67, 143);
                buttonHome.Font = new Font("Consolas", 12);
                buttonHome.ForeColor = Color.White;
            }
        }
        void buttonEncryption_redet(bool selectVivo)
        {
            panelEncryption.Visible = selectVivo;
            if (selectVivo)
            {
                buttonEncryption.FlatAppearance.BorderSize = 0;
                buttonEncryption.BackColor = Color.FromArgb(235, 117, 0);
                buttonEncryption.Font = new Font("Consolas", 14);
                buttonEncryption.ForeColor = Color.Black;
            }
            else
            {
                buttonEncryption.FlatAppearance.BorderSize = 2;
                buttonEncryption.BackColor = Color.FromArgb(0, 67, 143);
                buttonEncryption.Font = new Font("Consolas", 12);
                buttonEncryption.ForeColor = Color.White;
            }
        }
        void buttonDecryption_redet(bool selectVivo)
        {
            panelDecryption.Visible = selectVivo;
            if (selectVivo)
            {
                buttonDecryption.FlatAppearance.BorderSize = 0;
                buttonDecryption.BackColor = Color.FromArgb(235, 117, 0);
                buttonDecryption.Font = new Font("Consolas", 14);
                buttonDecryption.ForeColor = Color.Black;
            }
            else
            {
                buttonDecryption.FlatAppearance.BorderSize = 2;
                buttonDecryption.BackColor = Color.FromArgb(0, 67, 143);
                buttonDecryption.Font = new Font("Consolas", 12);
                buttonDecryption.ForeColor = Color.White;
            }
        }

        void clearMissing(byte mode = 1)
        {
            try
            {
                if (mode == 1)
                {
                    labelHelpImputData.Visible = true;
                    richTextBoxInputText.Text = "";
                    pictureBox1.Image = Image.FromFile($@"{FileMenager.TotalRoot}\ProgramData\Pro_code_editor\SystemContent\no photo uploaded.png");
                }
                else if (mode == 2)
                {
                    labelHelpOutputData.Visible = true;
                    richTextBoxOutputText.Text = "";
                    pictureBox2.Image = Image.FromFile($@"{FileMenager.TotalRoot}\ProgramData\Pro_code_editor\SystemContent\no photo uploaded.png");
                }
                else
                {
                    labelHelpImputData.Visible = true;
                    richTextBoxInputText.Text = "";
                    pictureBox1.Image = Image.FromFile($@"{FileMenager.TotalRoot}\ProgramData\Pro_code_editor\SystemContent\no photo uploaded.png");
                }
                GC.Collect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }
        void printMissing(byte mode = 1)
        {
            try
            {
                PrintDocument doc = new PrintDocument();
                if (mode == 1) doc.PrintPage += PrintPageHandler1;
                else if (mode == 2) doc.PrintPage += PrintPageHandler2;
                else doc.PrintPage += PrintPageHandler1;

                PrintDialog print = new PrintDialog();
                print.Document = doc;

                if (print.ShowDialog() == DialogResult.OK)
                    doc.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            selectPanelListVivo = SelectPanelList.selectHome;
            updatePaneSelection();
        }
        private void panelHome_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panelHomeUp_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pictureBoxHome_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (richTextBoxInputText.Text != null && richTextBoxInputText.Text != "")
                {
                    SaveFileDialog savedialog = new SaveFileDialog();

                    Helper.setSaveDialogOptions(ref savedialog);

                    if (savedialog.ShowDialog() == DialogResult.OK) //если в диалоговом окне нажата кнопка "ОК"
                        Helper.saveImage(pictureBox1.Image, savedialog.FileName);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearMissing(1);
        }
        private void buttonPrint_Click(object sender, EventArgs e)
        {
            printMissing(1);
        }       
        void PrintPageHandler1(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(pictureBox1.Image,new Point(0,0));
        }
        private void buttonSaveToGallery_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
                SaveQRToGallery();
        }
        private void checkBoxAvtoSave_CheckedChanged(object sender, EventArgs e)
        {
            AvtoSaveQRToGallery = checkBoxAvtoSave.Checked;
            FileMenager.autosaveToGalleryStatus = AvtoSaveQRToGallery;
            File.WriteAllText($@"{FileMenager.TotalRoot}ProgramData\Pro_code_editor\Parameters\autosave to gallery status.txt", AvtoSaveQRToGallery.ToString());
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void richTextBoxInputText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (richTextBoxInputText.Text != null && richTextBoxInputText.Text != "")
                    QRrested();
                else
                    pictureBox1.Image = Image.FromFile($@"{FileMenager.TotalRoot}\ProgramData\Pro_code_editor\SystemContent\no photo uploaded.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }
        private bool AvtoSaveQRToGallery = true;
        public void QRrested()
        {
            try
            {
                pictureBox1.Image = Helper.CreateQRCode(richTextBoxInputText.Text, pictureBox1.Width, pictureBox1.Height, selectionBarcodeFormatBCF);
                if (AvtoSaveQRToGallery)
                    SaveQRToGallery();
            }
            catch (Exception ex)
            {
                if (FileMenager.language == "en") ErrorMessage("QR creation error", ex);
                else if (FileMenager.language == "ru") ErrorMessage("Ошибка создания QR", ex);
                else ErrorMessage("QR creation error", ex);
            }
        }
        private void SaveQRToGallery()
        {
            Helper.saveImage(pictureBox1.Image, $@"{FileMenager.TotalRoot}ProgramData\Pro_code_editor\GalleryCollection\{Helper.getNewImageNameToGallery()}.png");
        }
        private void labelHelpImputData_Click(object sender, EventArgs e)
        {
            labelHelpImputData.Visible = false;
            richTextBoxInputText.Select();
        }
        private void richTextBoxInputText_Click(object sender, EventArgs e)
        {
            labelHelpImputData.Visible = false;
        }
        private void buttonEncryption_Click(object sender, EventArgs e)
        {
            selectPanelListVivo = SelectPanelList.selectEncryption;
            updatePaneSelection();
        }
        private void panelEncryption_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panelEncryptionUp_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pictureBoxEncryption_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectionBarcodeFormatSTR = comboBox1.SelectedIndex.ToString();
            changeBarcodeFormat();
        }
        private void changeBarcodeFormat()
        {
            switch (selectionBarcodeFormatSTR)
            {
                case "0": selectionBarcodeFormatBCF = BarcodeFormat.QR_CODE; break;
                case "1": selectionBarcodeFormatBCF = BarcodeFormat.AZTEC; break;
                case "2": selectionBarcodeFormatBCF = BarcodeFormat.CODABAR; break;
                case "3": selectionBarcodeFormatBCF = BarcodeFormat.CODE_39; break;
                case "4": selectionBarcodeFormatBCF = BarcodeFormat.CODE_93; break;
                case "5": selectionBarcodeFormatBCF = BarcodeFormat.CODE_128; break;
                case "6": selectionBarcodeFormatBCF = BarcodeFormat.DATA_MATRIX; break;
                case "7": selectionBarcodeFormatBCF = BarcodeFormat.ITF; break;
                case "8": selectionBarcodeFormatBCF = BarcodeFormat.PDF_417; break;
                case "9": selectionBarcodeFormatBCF = BarcodeFormat.MSI; break;
                default: return;
            }
            restedPictureBox1();
        }
        private void restedPictureBox1()
        {
            if (richTextBoxInputText.Text == null || richTextBoxInputText.Text == "")
                pictureBox1.Image = Image.FromFile($@"{FileMenager.TotalRoot}\ProgramData\Pro_code_editor\SystemContent\no photo uploaded.png");
            else
                QRrested();
            GC.Collect();
        }
        String selectionBarcodeFormatSTR = "QR";
        BarcodeFormat selectionBarcodeFormatBCF = BarcodeFormat.QR_CODE;

        Exception ErrorMessageException;
        private void ErrorMessage(string message, Exception ex)
        {
            ErrorMessageException = ex;
            labelQRcreationError.Text = message;

            panelQRcreationError.Location = new Point(-140, panelQRcreationError.Location.Y);
            panelQRcreationError.Visible = true;

            timerShowQRErrorPanel.Enabled = true;
        }
        private void panelQRcreationError_Paint(object sender, PaintEventArgs e)
        {

        }
        private void labelQRcreationError_Click(object sender, EventArgs e)
        {

        }
        private void timerShowQRErrorPanel_Tick(object sender, EventArgs e)
        {
            if (panelQRcreationError.Location.X < 6)
                panelQRcreationError.Location = new Point(panelQRcreationError.Location.X + 4, panelQRcreationError.Location.Y);
            else
                timerShowQRErrorPanel.Enabled = false;
        }

        private void ClosePanelQRcreationError_Click(object sender, EventArgs e)
        {
            ClosePanelQRcreationErrorMissing();
        }
        private void ClosePanelQRcreationErrorMissing()
        {
            panelQRcreationError.Visible = false;
            labelQRcreationError.Text = "";
        }
        private void ClosePanelQRcreationError_MouseEnter(object sender, EventArgs e)
        {
            ClosePanelQRcreationError.ForeColor = SystemColors.HotTrack;
        }
        private void ClosePanelQRcreationError_MouseLeave(object sender, EventArgs e)
        {
            ClosePanelQRcreationError.ForeColor = Color.WhiteSmoke;
        }

        private void InfoErrorPanelQRcreationError_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ErrorMessageException.ToString(),ErrorMessageException.Message);
        }
        private void InfoErrorPanelQRcreationError_MouseEnter(object sender, EventArgs e)
        {
            InfoErrorPanelQRcreationError.ForeColor = SystemColors.HotTrack;
        }
        private void InfoErrorPanelQRcreationError_MouseLeave(object sender, EventArgs e)
        {
            InfoErrorPanelQRcreationError.ForeColor = Color.WhiteSmoke;
        }

        private void GarbageCollection_Tick(object sender, EventArgs e)
        {
            GC.Collect();
        }

        private void buttonDecryption_Click(object sender, EventArgs e)
        {
            selectPanelListVivo = SelectPanelList.selectDecryption;
            updatePaneSelection();
        }
        private void panelDecryption_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panelDecryptionUp_Paint(object sender, PaintEventArgs e)
        {

        }
        private void labelDecryption_Click(object sender, EventArgs e)
        {

        }
        private void pictureBoxDecryption_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void buttonSaveDecr_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog savedialog = new SaveFileDialog();

                Helper.setSaveDialogOptions(ref savedialog);

                if (savedialog.ShowDialog() == DialogResult.OK) //если в диалоговом окне нажата кнопка "ОК"
                    Helper.saveImage(pictureBox2.Image, savedialog.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonSaveToGalleryDecr_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null)
                SaveQRToGallery2();
        }
        private void SaveQRToGallery2()
        {
            Helper.saveImage(pictureBox2.Image, $@"{FileMenager.TotalRoot}ProgramData\Pro_code_editor\GalleryCollection\{Helper.getNewImageNameToGallery()}.png");
        }
        private void buttonPrintDecr_Click(object sender, EventArgs e)
        {
            printMissing(2);
        }
        void PrintPageHandler2(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(pictureBox2.Image, new Point(0, 0));
        }
        private void buttonClearDecr_Click(object sender, EventArgs e)
        {
            clearMissing(2);
        }
        private void buttonOpenToEnecr_Click(object sender, EventArgs e)
        {
            if (richTextBoxOutputText.Text != null && richTextBoxOutputText.Text != "")
            {
                labelHelpImputData.Visible = false;
                richTextBoxInputText.Text = richTextBoxOutputText.Text;
                QRrested();
                selectPanelListVivo = SelectPanelList.selectEncryption;
                updatePaneSelection();
            }
            else
                MessageBox.Show("Невозможно открыть в зашифровке\nт.к. нет расшифрованного текста","Проблемма");
        }
        private void buttonLoadDecr_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = openFileDialog1.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
        private void buttonPrintScreenDecr_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = ImageHelper.getScreenImage();
        }
        private void labelHelpOutputData_Click(object sender, EventArgs e)
        {

        }
        private void richTextBoxOutputText_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBoxOutputText.Text = Helper.DecodeImage(pictureBox2.Image);
                labelHelpOutputData.Visible = false;
            }
            catch(Exception ex)
            {
                if (FileMenager.language == "en") ErrorMessage("QR decryption error", ex);
                else if (FileMenager.language == "ru") ErrorMessage("Ошибка расшифровки QR", ex);
                else ErrorMessage("QR decryption error", ex);
            }
        }
        private void buttonCopuOutputText_Click(object sender, EventArgs e)
        {
            if (richTextBoxOutputText.Text != null)
                Clipboard.SetText(richTextBoxOutputText.Text);
        }
    }
    enum SelectPanelList
    {
        selectHome,
        selectEncryption,
        selectDecryption
    }
}