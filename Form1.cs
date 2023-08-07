using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;
using System.Windows;

namespace Staj___Not_defteri_uygulaması
{
    public partial class Form1 : Form
    {
        private bool isFileAlreadySaved;
        private bool isFileDirty;
        private string currOpenFileName;
        public static string LangSupportForm2;
        public static string ButtonLangSupportForm3;
        public static string LabelLangSupportForm3;
        public static string dateAndTime;
        public string getFind;
        public static bool highlightControl;
        public bool engON;
        public bool turkON;
        public bool gerON;

        public Form1()
        {
            InitializeComponent();
            this.Text = "C# NotePad uygulaması / Mert Çakır";
            int FormWidth = this.Width;
            LangSupportForm2= "NotePad Uygulaması\n Hazırlayan: Mert Çakır \nGüncel Sürüm: 0.9";
            ButtonLangSupportForm3 = "Bul";
            LabelLangSupportForm3 = "Ara";
            turkON = true;
            //TextBox atamaları
            richTextBox2.Dock = DockStyle.Fill; 
            System.Drawing.Font currentFont = richTextBox2.SelectionFont;
            System.Drawing.FontStyle newFontStyle;
            newFontStyle = FontStyle.Regular;

            richTextBox2.SelectionFont = new Font(
               currentFont.FontFamily,
               currentFont.Size,
               newFontStyle
            );
            //--
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.White;
            
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem22_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox2.Text=="")
            {
                if (engON)
                {
                    this.Text = "Mert Çakır C# NotePad App";
                }
                else if (turkON)
                {
                    this.Text = "C# NotePad uygulaması / Mert Çakır";
                }
                else
                {
                    this.Text = "Mert Çakır C# Notizblock App";
                }
                
            }
            if (engON)
            {
                this.Text = "*Mert Çakır C# NotePad App";
            }
            else if (turkON)
            {
                this.Text = "*C# NotePad uygulaması / Mert Çakır";
            }
            else
            {
                this.Text = "*Mert Çakır C# Notizblock App";
            }
            isFileDirty = true;
            geriAl.Enabled = true;
        }

      

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            Form2 hakkinda = new Form2();
            hakkinda.Show();
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            System.Drawing.Font currentFont = richTextBox2.SelectionFont;
            System.Drawing.FontStyle newFontStyle;
            newFontStyle = FontStyle.Bold;

            richTextBox2.SelectionFont = new Font(
               currentFont.FontFamily,
               currentFont.Size,
               newFontStyle
            );

        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Drawing.Font currentFont = richTextBox2.SelectionFont;
            System.Drawing.FontStyle newFontStyle;
            newFontStyle = FontStyle.Regular;

            richTextBox2.SelectionFont = new Font(
               currentFont.FontFamily,
               currentFont.Size,
               newFontStyle
            );
        }

        private void italikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Drawing.Font currentFont = richTextBox2.SelectionFont;
            System.Drawing.FontStyle newFontStyle;
            newFontStyle = FontStyle.Italic;

            richTextBox2.SelectionFont = new Font(
               currentFont.FontFamily,
               currentFont.Size,
               newFontStyle
            );
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                TopMost = false;
            }
            if (e.Control && e.KeyCode==Keys.Z)
            {
                richTextBox2.Undo();
            }
            if (e.KeyCode==Keys.Y && e.Control)
            {
                richTextBox2.Redo();
            }
            if (e.KeyCode == Keys.A && e.Control)
            {
                richTextBox2.SelectAll();
            }
            if (e.KeyCode == Keys.X && e.Control)
            {
                richTextBox2.Cut();
            }
            if (e.KeyCode == Keys.C && e.Control)
            {
                richTextBox2.Copy();
            }
            if (e.KeyCode == Keys.V && e.Control)
            {
                richTextBox2.Paste();
            }
            if (e.KeyCode==Keys.S && e.Control)
            {
                SaveFileMenu();
            }
        }

        private void altÇizgiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Drawing.Font currentFont = richTextBox2.SelectionFont;
            System.Drawing.FontStyle newFontStyle;
            newFontStyle = FontStyle.Underline;

            richTextBox2.SelectionFont = new Font(
               currentFont.FontFamily,
               currentFont.Size,
               newFontStyle
            );
        }

        private void üstÇizgiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Drawing.Font currentFont = richTextBox2.SelectionFont;
            System.Drawing.FontStyle newFontStyle;
            newFontStyle = FontStyle.Strikeout;

            richTextBox2.SelectionFont = new Font(
               currentFont.FontFamily,
               currentFont.Size,
               newFontStyle
            );
        }

        private void hepsiniSeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox2.SelectAll();
        }

        private void toolStripMenuItem28_Click(object sender, EventArgs e)
        {
            ColorDialog colordialog = new ColorDialog();
            DialogResult result = colordialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                richTextBox2.SelectionColor = colordialog.Color;
                //richTextBox2.ForeColor = colordialog.Color;
            }
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox2.Cut();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox2.Copy();
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox2.Paste();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox2.SelectedText = "";
        }

        private void toolStripMenuItem25_Click(object sender, EventArgs e)
        {
            //HistoryTextBox historyTextBox = new HistoryTextBox();
            //historyTextBox.Undo();
            richTextBox2.Undo();
        }

        private void ileriAl_Click(object sender, EventArgs e)
        {
            richTextBox2.Redo();
        }

        private void toolStripMenuItem27_Click(object sender, EventArgs e)
        {
            FontDialog fontdialog = new FontDialog();
            fontdialog.ShowColor = true;
            fontdialog.ShowApply = true;
            DialogResult result = fontdialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                richTextBox2.SelectionFont = fontdialog.Font;
                richTextBox2.SelectionColor = fontdialog.Color;
            }
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isFileDirty)
            {
                DialogResult result;
                if (engON)
                { 
                   result  = MessageBox.Show("Save the changes?", "Save File", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                }
                else if (turkON)
                {
                   result = MessageBox.Show("Değişiklikleri kaydetmek ister misiniz?", "Dosyayı Kaydet", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                }
                else
                {
                   result = MessageBox.Show("Möchten Sie die Änderungen speichern?", "Datei speichern", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                }

                switch (result)
                {
                    case DialogResult.Yes:
                        SaveAsFileMenu();
                        richTextBox2.Clear();
                        break;
                    case DialogResult.No:
                        richTextBox2.Clear();
                        break;
                }
            }
            isFileAlreadySaved = false;
            isFileDirty = false;
            currOpenFileName = "";
            enabledisableundoredoprocess(false);
            if (engON)
            {
                this.Text = "New Mert Çakır C# NotePad App";
            }
            else if (turkON)
            {
                this.Text = "Yeni C# NotePad uygulaması / Mert Çakır";
            }
            else
            {
                this.Text = "Neu Mert Çakır C# Notizblock App";
            }
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf";

            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (Path.GetExtension(openFileDialog.FileName) == ".txt")
                    richTextBox2.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
                if (Path.GetExtension(openFileDialog.FileName) == ".rtf")
                    richTextBox2.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);

                
                if (engON)
                {
                    this.Text = Path.GetFileName(openFileDialog.FileName) + " C# NotePad App / Mert Çakır";
                }
                else if (turkON)
                {
                    this.Text = Path.GetFileName(openFileDialog.FileName) + " C# NotePad uygulaması / Mert Çakır";
                }
                else
                {
                    this.Text = Path.GetFileName(openFileDialog.FileName) + " C# Notizblock App / Mert Çakır";
                }
                isFileAlreadySaved = true;
                isFileDirty = false;
                currOpenFileName = openFileDialog.FileName;


                enabledisableundoredoprocess(false);

            }
       
            if (engON)
            {
                this.Text = Path.GetFileName(openFileDialog.FileName) + " C# NotePad App / Mert Çakır";
            }
            else if (turkON)
            {
                this.Text = Path.GetFileName(openFileDialog.FileName) + " C# NotePad uygulaması / Mert Çakır";
            }
            else
            {
                this.Text = Path.GetFileName(openFileDialog.FileName) + " C# Notizblock App / Mert Çakır";
            }
            //this.Text = "C# NotePad uygulaması / Mert Çakır";
        }

        private void enabledisableundoredoprocess(bool enabled)
        {
            geriAl.Enabled = false;
            ileriAl.Enabled = false;
        }

        private void farklıKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAsFileMenu();
        }

        private void SaveAsFileMenu()
        {
            
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
            //|Rich Text Format (*.rtf)|*.rtf";

            DialogResult result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (Path.GetExtension(saveFileDialog.FileName) == ".txt")
                    richTextBox2.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                if (Path.GetExtension(saveFileDialog.FileName) == ".rft")
                    richTextBox2.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);

                if (engON)
                {
                    this.Text = Path.GetFileName(saveFileDialog.FileName) + " -Mert Çakır NotePad App";
                }
                else if (turkON)
                {
                    this.Text = Path.GetFileName(saveFileDialog.FileName) + " -Mert Çakır NotePad Uygulaması";
                }
                else if (gerON)
                {
                    this.Text = Path.GetFileName(saveFileDialog.FileName) + " -Mert Çakır Notizblock App";
                }
                
                isFileAlreadySaved = true;
                isFileDirty = false;
                currOpenFileName = saveFileDialog.FileName;

            }
            //this.Text = "C# NotePad uygulaması / Mert Çakır";
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileMenu(); 
        }

        private void SaveFileMenu()
        {   
            if (isFileAlreadySaved)
            {
                if (Path.GetExtension(currOpenFileName) == ".txt")
                {
                    System.IO.StreamWriter file = new System.IO.StreamWriter(currOpenFileName);
                    file.WriteLine(this.richTextBox2.Text);
                    file.Close();
                }
                if (Path.GetExtension(currOpenFileName) == ".rft")
                {
                    System.IO.StreamWriter file = new System.IO.StreamWriter(currOpenFileName);
                    file.WriteLine(this.richTextBox2.Rtf);
                    file.Close();
                }
                isFileDirty = false;
                //this.Text = "C# NotePad uygulaması / Mert Çakır";
            }
            else
            {
                if (isFileDirty)
                {
                    SaveAsFileMenu();
                }
                else
                {
                    ClearScreen();
                }
            }
        }

        private void ClearScreen()
        {
            richTextBox2.Clear();
            isFileDirty = false;
        }

        private void NotePadForm_Load(object sender, EventArgs e)
        {
            isFileAlreadySaved = false;
            isFileDirty = false;
            currOpenFileName = "";

        }

        private void toolStripMenuItem30_Click(object sender, EventArgs e)
        {
            dateAndTime = DateTime.Now.ToString();
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void türkçeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turkON = true;
            engON = false;
            this.Text = "Mert Çakır C# NotePad Uygulaması";

            //Dosya menüsü ve içeriği-TR
            toolStripMenuItem1.Text = "Dosya";
            yeniToolStripMenuItem.Text = "Yeni";
            açToolStripMenuItem.Text = "Aç";
            kaydetToolStripMenuItem.Text = "Kaydet";
            farklıKaydetToolStripMenuItem.Text = "Farklı Kaydet";
            //Düzen menüsü ve içeriği-TR
            toolStripMenuItem17.Text = "Düzen";
            geriAl.Text = "Geri Al";
            ileriAl.Text = "İleri Al";
            kesToolStripMenuItem.Text = "Kes";
            kopyalaToolStripMenuItem.Text = "Kopyala";
            yapıştırToolStripMenuItem.Text = "Yapıştır";
            silToolStripMenuItem.Text = "Sil";
            hepsiniSeçToolStripMenuItem.Text = "Hepsini Seç";
            bulToolStripMenuItem.Text = "Bul";
            LabelLangSupportForm3= "Ara";
            ButtonLangSupportForm3 = "Bul";
            temizleToolStripMenuItem.Text = "Temizle";
            //Biçim menüsü ve içeriği-TR
            toolStripMenuItem18.Text = "Biçim";
            yazibicimi.Text = "Yazı Biçimi";
            yazirengi.Text = "Yazı Rengi";
            yazıÖzellikleriToolStripMenuItem.Text = "Yazı Özellikleri";
            boldToolStripMenuItem.Text = "Bold";
            italikToolStripMenuItem.Text = "İtalik";
            altÇizgiToolStripMenuItem.Text = "Altı Çizgili";
            üstÇizgiToolStripMenuItem.Text = "Çizgili";
            //Özellikler menüsü ve içeriği-TR
            toolStripMenuItem19.Text = "Özellikler";
            tarihvesaat.Text = "Tarih ve Saat";
            diller.Text = "Diller";
            türkçeToolStripMenuItem.Text = "Türkçe";
            ingilizceToolStripMenuItem.Text = "İngilizce";
            almancaToolStripMenuItem.Text = "Almanca";
            //Hakkında menüsü ve içeriği-TR
            toolStripMenuItem20.Text = "Hakkında";
        }

        private void ingilizceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            engON = true;
            turkON = false;
            this.Text = "Mert Çakır C# NotePad App";

            //Dosya menüsü ve içeriği-EN
            toolStripMenuItem1.Text = "File";
            yeniToolStripMenuItem.Text = "New";
            açToolStripMenuItem.Text = "Open";
            kaydetToolStripMenuItem.Text = "Save";
            farklıKaydetToolStripMenuItem.Text = "Save As";
            //Düzen menüsü ve içeriği-EN
            toolStripMenuItem17.Text = "Edit";
            geriAl.Text = "Undo";
            ileriAl.Text = "Redo";
            kesToolStripMenuItem.Text = "Cut";
            kopyalaToolStripMenuItem.Text = "Copy";
            yapıştırToolStripMenuItem.Text = "Paste";
            silToolStripMenuItem.Text = "Delete";
            hepsiniSeçToolStripMenuItem.Text = "Select All";
            bulToolStripMenuItem.Text = "Find";
            LabelLangSupportForm3 = "Search :";
            ButtonLangSupportForm3 = "Find";
            temizleToolStripMenuItem.Text = "Clear";
            //Biçim menüsü ve içeriği-EN
            toolStripMenuItem18.Text = "View";
            yazibicimi.Text = "Font";
            yazirengi.Text = "Font Color";
            yazıÖzellikleriToolStripMenuItem.Text = "Font Options";
            boldToolStripMenuItem.Text = "Bold";
            italikToolStripMenuItem.Text = "Italic";
            altÇizgiToolStripMenuItem.Text = "Underline";
            üstÇizgiToolStripMenuItem.Text = "Strikethrough";
            //Özellikler menüsü ve içeriği-EN
            toolStripMenuItem19.Text = "Options";
            tarihvesaat.Text = "Date and Time";
            diller.Text = "Languages";
            türkçeToolStripMenuItem.Text = "Turkish";
            ingilizceToolStripMenuItem.Text = "English";
            almancaToolStripMenuItem.Text = "German";
            //Hakkında menüsü ve içeriği-EN
            toolStripMenuItem20.Text = "About";
            LangSupportForm2 ="NotePad App\n Developer: Mert Çakır \nCurrent Version: 0.9";

        }

        private void almancaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gerON = true;
            turkON = false;
            engON = false;
            this.Text = "Mert Çakır C# Notizblock App";

            //Dosya menüsü ve içeriği-GER
            toolStripMenuItem1.Text = "Datei";
            yeniToolStripMenuItem.Text = "Neu";
            açToolStripMenuItem.Text = "Öffnen";
            kaydetToolStripMenuItem.Text = "Speichern";
            farklıKaydetToolStripMenuItem.Text = "Speichern Unter";
            //Düzen menüsü ve içeriği-GER
            toolStripMenuItem17.Text = "Bearbeiten";
            geriAl.Text = "Rückgängig";
            ileriAl.Text = "Wiederholen";
            kesToolStripMenuItem.Text = "Ausschneiden";
            kopyalaToolStripMenuItem.Text = "Kopieren";
            yapıştırToolStripMenuItem.Text = "Einfügen";
            silToolStripMenuItem.Text = "Löschen";
            hepsiniSeçToolStripMenuItem.Text = "Alles Markieren";
            bulToolStripMenuItem.Text = "Finden";
            LabelLangSupportForm3 = "Suche :";
            ButtonLangSupportForm3 = "Finden";
            temizleToolStripMenuItem.Text = "Klar";
            //Biçim menüsü ve içeriği-GER
            toolStripMenuItem18.Text = "Ansicht";
            yazibicimi.Text = "Schriftart";
            yazirengi.Text = "Schriftfarbe";
            yazıÖzellikleriToolStripMenuItem.Text = "Schriftart Optionen";
            boldToolStripMenuItem.Text = "Fett";
            italikToolStripMenuItem.Text = "Kursiv";
            altÇizgiToolStripMenuItem.Text = "Unterstreichen";
            üstÇizgiToolStripMenuItem.Text = "Durchstreichen";
            //Özellikler menüsü ve içeriği-GER
            toolStripMenuItem19.Text = "Optionen";
            tarihvesaat.Text = "Datum und Uhrzei";
            diller.Text = "Sprache";
            türkçeToolStripMenuItem.Text = "Türkisch";
            ingilizceToolStripMenuItem.Text = "Englisch";
            almancaToolStripMenuItem.Text = "Deutch";
            //Hakkında menüsü ve içeriği-GER
            toolStripMenuItem20.Text = "Informationen";
            LangSupportForm2 = "Notizblock App\n Entwickler: Mert Çakır \nAktuelle Version: 0.9";
        }

        private void bulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();

            getFind = Form3.FindWord;

            while (getFind == null)
            {
                getFind = Form3.FindWord;
            }

            Color highlightcolor = Color.Yellow;
            if (!getFind.Equals(""))
            {
                //richtextbox2.text = "bura çalıştı";
                Utility.HighlightText(richTextBox2, getFind, highlightcolor);
            }
            else
            {
                form3.Close();
            }
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void temizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color fakeColor = Color.White;
            Utility.HighlightText(richTextBox2, getFind, fakeColor);
        }
    }

    static class Utility
    {
        public static void HighlightText(this RichTextBox myRtb, string word, Color color)
        {

            if (word == string.Empty)
                return;


            int s_start = myRtb.SelectionStart, startIndex = 0, index;

            while ((index = myRtb.Text.IndexOf(word, startIndex)) != -1)
            {
                while (color==Color.White)
                {
                    myRtb.SelectionStart = index;
                    myRtb.SelectionLength = word.Length;
                    myRtb.SelectionBackColor = color;
                    startIndex = index + word.Length;
                    break;
                }
                myRtb.SelectionStart = index;
                myRtb.SelectionLength = word.Length;
                myRtb.SelectionBackColor = color;
                startIndex = index + word.Length;
            }

            myRtb.SelectionStart = s_start;
            myRtb.SelectionLength = 0;
            //myRtb.SelectionBackColor = Color.Black;
        }
    }

    public class HistoryTextBox : System.Windows.Forms.RichTextBox
    {
        bool ignoreChange = false;
        List<string> storage = null;


        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            //init storage...
            storage = new List<string>();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            base.OnTextChanged(e);
            //save change to storage...
            if (!ignoreChange)
            {
                storage.Add(this.Text);
            }
        }

        public void Undo()
        {
            this.ignoreChange = true;
            this.Text = storage[storage.Count - 1];
            storage.RemoveAt(storage.Count - 1);
            this.ignoreChange = false;
        }
    }
}




/*
 * 1-Undo tam anlamıyla düzgün çalışmıyor redo çalışıyor gibi
 * 2- .rtf kayıt sistemi sadece hazır rtf dosyalarını açabiliyor kayıt edemiyor.
 * 3- Font başka txt de kayıt olmuyor
 */
