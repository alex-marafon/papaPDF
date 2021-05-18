
namespace PDF_to_Excel___Word_e_TXT
{
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOrigem = new System.Windows.Forms.Button();
            this.btnGerarExcel = new System.Windows.Forms.Button();
            this.btnGerarWord = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonJPG = new System.Windows.Forms.Button();
            this.tbtDestinoJPG = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbErro = new System.Windows.Forms.TextBox();
            this.tbDestinoDOC = new System.Windows.Forms.TextBox();
            this.tbDestinoXLS = new System.Windows.Forms.TextBox();
            this.tbOrigem = new System.Windows.Forms.TextBox();
            this.btnDestinoXLS = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDestinoDOC = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destino - Arquivo Convertido de PDF  para  Excell";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 467);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(343, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Desenvolvido por Marafon Sistemas Digitais   -  (66) 9 9964-7827";
            // 
            // btnOrigem
            // 
            this.btnOrigem.Location = new System.Drawing.Point(329, 105);
            this.btnOrigem.Name = "btnOrigem";
            this.btnOrigem.Size = new System.Drawing.Size(65, 23);
            this.btnOrigem.TabIndex = 1;
            this.btnOrigem.Text = "Origem";
            this.btnOrigem.UseVisualStyleBackColor = true;
            this.btnOrigem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGerarExcel
            // 
            this.btnGerarExcel.Location = new System.Drawing.Point(307, 180);
            this.btnGerarExcel.Name = "btnGerarExcel";
            this.btnGerarExcel.Size = new System.Drawing.Size(88, 38);
            this.btnGerarExcel.TabIndex = 4;
            this.btnGerarExcel.Text = "Excel";
            this.btnGerarExcel.UseVisualStyleBackColor = true;
            this.btnGerarExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnGerarWord
            // 
            this.btnGerarWord.Location = new System.Drawing.Point(307, 262);
            this.btnGerarWord.Name = "btnGerarWord";
            this.btnGerarWord.Size = new System.Drawing.Size(88, 38);
            this.btnGerarWord.TabIndex = 7;
            this.btnGerarWord.Text = "Word";
            this.btnGerarWord.UseVisualStyleBackColor = true;
            this.btnGerarWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Descrição de problema";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Origem - Arquivo PDF ou JPG";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(327, 419);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 28);
            this.button4.TabIndex = 11;
            this.button4.Text = "FECHAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonJPG);
            this.panel1.Controls.Add(this.tbtDestinoJPG);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbErro);
            this.panel1.Controls.Add(this.tbDestinoDOC);
            this.panel1.Controls.Add(this.tbDestinoXLS);
            this.panel1.Controls.Add(this.tbOrigem);
            this.panel1.Controls.Add(this.btnDestinoXLS);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnDestinoDOC);
            this.panel1.Controls.Add(this.btnGerarWord);
            this.panel1.Controls.Add(this.btnGerarExcel);
            this.panel1.Controls.Add(this.btnOrigem);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 492);
            this.panel1.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(266, 15);
            this.label8.TabIndex = 27;
            this.label8.Text = "Destino - Arquivo Convertido de  JPG  para  Texto";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "JPG -> TXT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonJPG
            // 
            this.buttonJPG.Location = new System.Drawing.Point(223, 346);
            this.buttonJPG.Name = "buttonJPG";
            this.buttonJPG.Size = new System.Drawing.Size(65, 23);
            this.buttonJPG.TabIndex = 9;
            this.buttonJPG.Text = "Destino";
            this.buttonJPG.UseVisualStyleBackColor = true;
            this.buttonJPG.Click += new System.EventHandler(this.buttonJPG_Click);
            // 
            // tbtDestinoJPG
            // 
            this.tbtDestinoJPG.Location = new System.Drawing.Point(12, 317);
            this.tbtDestinoJPG.Name = "tbtDestinoJPG";
            this.tbtDestinoJPG.Size = new System.Drawing.Size(383, 23);
            this.tbtDestinoJPG.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = " ";
            // 
            // tbErro
            // 
            this.tbErro.Location = new System.Drawing.Point(13, 402);
            this.tbErro.Multiline = true;
            this.tbErro.Name = "tbErro";
            this.tbErro.Size = new System.Drawing.Size(288, 58);
            this.tbErro.TabIndex = 22;
            // 
            // tbDestinoDOC
            // 
            this.tbDestinoDOC.Location = new System.Drawing.Point(12, 233);
            this.tbDestinoDOC.Name = "tbDestinoDOC";
            this.tbDestinoDOC.Size = new System.Drawing.Size(383, 23);
            this.tbDestinoDOC.TabIndex = 5;
            // 
            // tbDestinoXLS
            // 
            this.tbDestinoXLS.Location = new System.Drawing.Point(12, 151);
            this.tbDestinoXLS.Name = "tbDestinoXLS";
            this.tbDestinoXLS.Size = new System.Drawing.Size(383, 23);
            this.tbDestinoXLS.TabIndex = 2;
            // 
            // tbOrigem
            // 
            this.tbOrigem.Location = new System.Drawing.Point(11, 76);
            this.tbOrigem.Name = "tbOrigem";
            this.tbOrigem.Size = new System.Drawing.Size(383, 23);
            this.tbOrigem.TabIndex = 0;
            // 
            // btnDestinoXLS
            // 
            this.btnDestinoXLS.Location = new System.Drawing.Point(223, 180);
            this.btnDestinoXLS.Name = "btnDestinoXLS";
            this.btnDestinoXLS.Size = new System.Drawing.Size(65, 23);
            this.btnDestinoXLS.TabIndex = 3;
            this.btnDestinoXLS.Text = "Destino";
            this.btnDestinoXLS.UseVisualStyleBackColor = true;
            this.btnDestinoXLS.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(266, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Destino - Arquivo Convertido de PDF  para  Word";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Swis721 BlkCn BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(197, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 32);
            this.label5.TabIndex = 15;
            this.label5.Text = "PAPA PDF";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(329, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnDestinoDOC
            // 
            this.btnDestinoDOC.Location = new System.Drawing.Point(223, 262);
            this.btnDestinoDOC.Name = "btnDestinoDOC";
            this.btnDestinoDOC.Size = new System.Drawing.Size(65, 23);
            this.btnDestinoDOC.TabIndex = 6;
            this.btnDestinoDOC.Text = "Destino";
            this.btnDestinoDOC.UseVisualStyleBackColor = true;
            this.btnDestinoDOC.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(411, 492);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Papa PDF";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOrigem;
        private System.Windows.Forms.Button btnGerarExcel;
        private System.Windows.Forms.Button btnGerarWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDestinoDOC;
        private System.Windows.Forms.Button btnDestinoXLS;
        private System.Windows.Forms.TextBox tbErro;
        private System.Windows.Forms.TextBox tbDestinoDOC;
        private System.Windows.Forms.TextBox tbDestinoXLS;
        private System.Windows.Forms.TextBox tbOrigem;
        private System.Windows.Forms.Button buttonJPG;
        private System.Windows.Forms.TextBox tbtDestinoJPG;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
    }
}

