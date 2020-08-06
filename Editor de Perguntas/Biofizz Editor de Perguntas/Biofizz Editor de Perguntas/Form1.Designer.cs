namespace Biofizz_Editor_de_Perguntas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.questionsCounterToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.answerATextBox = new System.Windows.Forms.TextBox();
            this.answerBTextBox = new System.Windows.Forms.TextBox();
            this.answerCTextBox = new System.Windows.Forms.TextBox();
            this.answerDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.easyRadioButton = new System.Windows.Forms.RadioButton();
            this.mediumRadioButton = new System.Windows.Forms.RadioButton();
            this.hardRadioButton = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioCorrectAnswerA = new System.Windows.Forms.RadioButton();
            this.radioCorrectAnswerB = new System.Windows.Forms.RadioButton();
            this.radioCorrectAnswerD = new System.Windows.Forms.RadioButton();
            this.radioCorrectAnswerC = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(606, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salvarToolStripMenuItem,
            this.salvarComoToolStripMenuItem,
            this.toolStripMenuItem2,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.AbrirToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(210, 6);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // salvarComoToolStripMenuItem
            // 
            this.salvarComoToolStripMenuItem.Name = "salvarComoToolStripMenuItem";
            this.salvarComoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.salvarComoToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.salvarComoToolStripMenuItem.Text = "Salvar Como";
            this.salvarComoToolStripMenuItem.Click += new System.EventHandler(this.salvarComoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(210, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.questionsCounterToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 353);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(606, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(126, 17);
            this.toolStripStatusLabel1.Text = "Número de Perguntas:";
            // 
            // questionsCounterToolStripStatusLabel
            // 
            this.questionsCounterToolStripStatusLabel.Name = "questionsCounterToolStripStatusLabel";
            this.questionsCounterToolStripStatusLabel.Size = new System.Drawing.Size(13, 17);
            this.questionsCounterToolStripStatusLabel.Text = "0";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Arquivos TSV|*.tsv";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // prevButton
            // 
            this.prevButton.Enabled = false;
            this.prevButton.Location = new System.Drawing.Point(12, 27);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(75, 23);
            this.prevButton.TabIndex = 9;
            this.prevButton.Text = "Anterior";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Enabled = false;
            this.nextButton.Location = new System.Drawing.Point(519, 27);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 10;
            this.nextButton.Text = "Próxima";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // questionTextBox
            // 
            this.questionTextBox.Location = new System.Drawing.Point(12, 56);
            this.questionTextBox.MaxLength = 315;
            this.questionTextBox.Multiline = true;
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.questionTextBox.Size = new System.Drawing.Size(582, 88);
            this.questionTextBox.TabIndex = 1;
            this.questionTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.questionTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // answerATextBox
            // 
            this.answerATextBox.Location = new System.Drawing.Point(12, 160);
            this.answerATextBox.MaxLength = 135;
            this.answerATextBox.Multiline = true;
            this.answerATextBox.Name = "answerATextBox";
            this.answerATextBox.Size = new System.Drawing.Size(265, 83);
            this.answerATextBox.TabIndex = 2;
            this.answerATextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.answerATextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // answerBTextBox
            // 
            this.answerBTextBox.Location = new System.Drawing.Point(324, 163);
            this.answerBTextBox.MaxLength = 135;
            this.answerBTextBox.Multiline = true;
            this.answerBTextBox.Name = "answerBTextBox";
            this.answerBTextBox.Size = new System.Drawing.Size(270, 83);
            this.answerBTextBox.TabIndex = 3;
            this.answerBTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.answerBTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // answerCTextBox
            // 
            this.answerCTextBox.Location = new System.Drawing.Point(12, 261);
            this.answerCTextBox.MaxLength = 135;
            this.answerCTextBox.Multiline = true;
            this.answerCTextBox.Name = "answerCTextBox";
            this.answerCTextBox.Size = new System.Drawing.Size(265, 83);
            this.answerCTextBox.TabIndex = 4;
            this.answerCTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.answerCTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // answerDTextBox
            // 
            this.answerDTextBox.Location = new System.Drawing.Point(324, 261);
            this.answerDTextBox.MaxLength = 135;
            this.answerDTextBox.Multiline = true;
            this.answerDTextBox.Name = "answerDTextBox";
            this.answerDTextBox.Size = new System.Drawing.Size(270, 83);
            this.answerDTextBox.TabIndex = 5;
            this.answerDTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.answerDTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "D";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "C";
            // 
            // easyRadioButton
            // 
            this.easyRadioButton.AutoSize = true;
            this.easyRadioButton.Checked = true;
            this.easyRadioButton.Location = new System.Drawing.Point(40, 3);
            this.easyRadioButton.Name = "easyRadioButton";
            this.easyRadioButton.Size = new System.Drawing.Size(47, 17);
            this.easyRadioButton.TabIndex = 6;
            this.easyRadioButton.TabStop = true;
            this.easyRadioButton.Tag = "1";
            this.easyRadioButton.Text = "Fácil";
            this.easyRadioButton.UseVisualStyleBackColor = true;
            this.easyRadioButton.Click += new System.EventHandler(this.DifficultyRadioClicked);
            // 
            // mediumRadioButton
            // 
            this.mediumRadioButton.AutoSize = true;
            this.mediumRadioButton.Location = new System.Drawing.Point(94, 3);
            this.mediumRadioButton.Name = "mediumRadioButton";
            this.mediumRadioButton.Size = new System.Drawing.Size(54, 17);
            this.mediumRadioButton.TabIndex = 7;
            this.mediumRadioButton.Tag = "2";
            this.mediumRadioButton.Text = "Médio";
            this.mediumRadioButton.UseVisualStyleBackColor = true;
            // 
            // hardRadioButton
            // 
            this.hardRadioButton.AutoSize = true;
            this.hardRadioButton.Location = new System.Drawing.Point(154, 3);
            this.hardRadioButton.Name = "hardRadioButton";
            this.hardRadioButton.Size = new System.Drawing.Size(52, 17);
            this.hardRadioButton.TabIndex = 8;
            this.hardRadioButton.Tag = "3";
            this.hardRadioButton.Text = "Difícil";
            this.hardRadioButton.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Arquivos TSV|*.tsv";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mediumRadioButton);
            this.panel1.Controls.Add(this.hardRadioButton);
            this.panel1.Controls.Add(this.easyRadioButton);
            this.panel1.Location = new System.Drawing.Point(177, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 23);
            this.panel1.TabIndex = 13;
            // 
            // radioCorrectAnswerA
            // 
            this.radioCorrectAnswerA.AutoSize = true;
            this.radioCorrectAnswerA.Checked = true;
            this.radioCorrectAnswerA.Location = new System.Drawing.Point(279, 202);
            this.radioCorrectAnswerA.Name = "radioCorrectAnswerA";
            this.radioCorrectAnswerA.Size = new System.Drawing.Size(14, 13);
            this.radioCorrectAnswerA.TabIndex = 14;
            this.radioCorrectAnswerA.TabStop = true;
            this.radioCorrectAnswerA.Tag = "1";
            this.radioCorrectAnswerA.UseVisualStyleBackColor = true;
            // 
            // radioCorrectAnswerB
            // 
            this.radioCorrectAnswerB.AutoSize = true;
            this.radioCorrectAnswerB.Location = new System.Drawing.Point(309, 202);
            this.radioCorrectAnswerB.Name = "radioCorrectAnswerB";
            this.radioCorrectAnswerB.Size = new System.Drawing.Size(14, 13);
            this.radioCorrectAnswerB.TabIndex = 15;
            this.radioCorrectAnswerB.Tag = "2";
            this.radioCorrectAnswerB.UseVisualStyleBackColor = true;
            // 
            // radioCorrectAnswerD
            // 
            this.radioCorrectAnswerD.AutoSize = true;
            this.radioCorrectAnswerD.Location = new System.Drawing.Point(309, 303);
            this.radioCorrectAnswerD.Name = "radioCorrectAnswerD";
            this.radioCorrectAnswerD.Size = new System.Drawing.Size(14, 13);
            this.radioCorrectAnswerD.TabIndex = 16;
            this.radioCorrectAnswerD.Tag = "4";
            this.radioCorrectAnswerD.UseVisualStyleBackColor = true;
            // 
            // radioCorrectAnswerC
            // 
            this.radioCorrectAnswerC.AutoSize = true;
            this.radioCorrectAnswerC.Location = new System.Drawing.Point(279, 303);
            this.radioCorrectAnswerC.Name = "radioCorrectAnswerC";
            this.radioCorrectAnswerC.Size = new System.Drawing.Size(14, 13);
            this.radioCorrectAnswerC.TabIndex = 17;
            this.radioCorrectAnswerC.Tag = "3";
            this.radioCorrectAnswerC.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 375);
            this.Controls.Add(this.radioCorrectAnswerC);
            this.Controls.Add(this.radioCorrectAnswerD);
            this.Controls.Add(this.radioCorrectAnswerB);
            this.Controls.Add(this.radioCorrectAnswerA);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.answerDTextBox);
            this.Controls.Add(this.answerCTextBox);
            this.Controls.Add(this.answerBTextBox);
            this.Controls.Add(this.answerATextBox);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Editor de Perguntas Biofizz - Sem Título";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel questionsCounterToolStripStatusLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.TextBox answerATextBox;
        private System.Windows.Forms.TextBox answerBTextBox;
        private System.Windows.Forms.TextBox answerCTextBox;
        private System.Windows.Forms.TextBox answerDTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton easyRadioButton;
        private System.Windows.Forms.RadioButton mediumRadioButton;
        private System.Windows.Forms.RadioButton hardRadioButton;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioCorrectAnswerA;
        private System.Windows.Forms.RadioButton radioCorrectAnswerB;
        private System.Windows.Forms.RadioButton radioCorrectAnswerD;
        private System.Windows.Forms.RadioButton radioCorrectAnswerC;
    }
}

