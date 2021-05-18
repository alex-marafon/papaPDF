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
using Tesseract;

namespace PDF_to_Excel___Word_e_TXT
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
   
                InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Origem();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DestinoWord();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DestinoExcel();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (tbDestinoXLS.Text == "" || tbOrigem.Text == "")
            {
                MessageBox.Show("Endereço de Origem ou Destino do Excel incorreto");
            }
            try
            {
                SautinSoft.PdfFocus excel = new SautinSoft.PdfFocus();
                excel.OpenPdf(tbOrigem.Text);
                excel.ToExcel(tbDestinoXLS.Text);

            }
            catch (Exception ex)
            {
                tbErro.Text = ex.ToString();
            }
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            if (tbDestinoDOC.Text == "" || tbOrigem.Text == "")
            {
                MessageBox.Show("Endereço de Origem ou Destino de Documento incorreto");
            }
            try
            {
                SautinSoft.PdfFocus excel = new SautinSoft.PdfFocus();
                excel.OpenPdf(tbOrigem.Text);
                excel.ToWord(tbDestinoDOC.Text);
               
            }
            catch (Exception ex)
            {
                tbErro.Text = ex.ToString();
            }
        }


        private void buttonJPG_Click(object sender, EventArgs e)
        {
            DestinoPDFJpg();
        }

        public void Origem()
        {
            using (OpenFileDialog up = new OpenFileDialog())
            {
                up.InitialDirectory = "c:\\";
                up.Filter = "JPG files (*.jpg)|*.jpg|PDF files (*.pdf)|*.pdf";
                up.FilterIndex = 2;
                up.RestoreDirectory = true;

                if (up.ShowDialog() == DialogResult.OK)
                {
                    tbOrigem.Text = up.FileName;
                }
            }
        }

        public void DestinoWord()
        {
            using (SaveFileDialog dow = new SaveFileDialog())
            {
                dow.Filter = "DOC files (*.doc)|*.doc";
                if (dow.ShowDialog() == DialogResult.OK)
                {
                    tbDestinoDOC.Text = dow.FileName;
                }
            }
        }  
        public void DestinoExcel()
        {
            using (SaveFileDialog dow = new SaveFileDialog())
            {
                dow.Filter = "XLS files (*.xls)|*.xls";
                if (dow.ShowDialog() == DialogResult.OK)
                {
                    tbDestinoXLS.Text = dow.FileName;
                }
            }
        }

        public void DestinoPDFJpg()
        {
            using (SaveFileDialog dow = new SaveFileDialog())
            {
                dow.Filter = "TXT files (*.txt)|*.txt";
                //dow.Filter = "PDF files (*.pdf)|*.pdf|JPG files (*.jpg)|*.jpg";
                if (dow.ShowDialog() == DialogResult.OK)
                {
                    tbtDestinoJPG.Text = dow.FileName;
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (tbtDestinoJPG.Text == "" || tbOrigem.Text == "")
            {
                MessageBox.Show("Endereço de Origem ou Destino de Documento incorreto");
            }
            try
            {
                //SautinSoft.PdfFocus excel = new SautinSoft.PdfFocus();
                //excel.OpenPdf(tbOrigem.Text);
                //excel.ToWord(tbDestinoDOC.Text);  
                var testImage = tbOrigem.Text;
                try
                {
                    using (var engine = new TesseractEngine(@"tessdata", "por", EngineMode.Default))
                    {
                        using (var jpg = Pix.LoadFromFile(testImage))
                        {
                            using (var page = engine.Process(jpg))
                            {
                                var texto = page.GetText();
                                Console.WriteLine("Taxa de Precisão: {0}", page.GetMeanConfidence());
                                Console.WriteLine("Texto: \r \n {0}", texto);
                                TextWriter arquivo = File.CreateText(tbtDestinoJPG.Text);
                                arquivo.Write(texto);
                                arquivo.Close();
                            }
                        }
                    };
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: {0}", ex.Message);
                }
                finally
                {
                    Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                tbErro.Text = ex.ToString();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" O papa pdf é um projeto desenvolvido para fins de estudo.  -  Versão demo.  Em breve estara disponivel gratuitamento na internet. - Para mais informações : Marafon Sistemas Digitais  -  Tel.: 66 99964-7827 ");
        }
    }
}
