
namespace KeygenTest
{
    partial class Keygen
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
            this.btnStart = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btnGiveValues = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.dtpCreation = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudValidDays = new System.Windows.Forms.NumericUpDown();
            this.nudKeyRefValidDays = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpKeyRefCreation = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCheckValues = new System.Windows.Forms.Button();
            this.txtRefCNPJ = new System.Windows.Forms.TextBox();
            this.txtKeyRefCHPJ = new System.Windows.Forms.TextBox();
            this.btnSaveDB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudValidDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKeyRefValidDays)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(306, 128);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(112, 35);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Genarate";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(13, 132);
            this.txtKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(272, 26);
            this.txtKey.TabIndex = 2;
            // 
            // btnGiveValues
            // 
            this.btnGiveValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiveValues.Location = new System.Drawing.Point(307, 68);
            this.btnGiveValues.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGiveValues.Name = "btnGiveValues";
            this.btnGiveValues.Size = new System.Drawing.Size(112, 35);
            this.btnGiveValues.TabIndex = 3;
            this.btnGiveValues.Text = "Values";
            this.btnGiveValues.UseVisualStyleBackColor = true;
            this.btnGiveValues.Click += new System.EventHandler(this.btnGiveValues_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "CNPJ:";
            // 
            // mtbCNPJ
            // 
            this.mtbCNPJ.Location = new System.Drawing.Point(116, 12);
            this.mtbCNPJ.Mask = "99,999,999/9999-99";
            this.mtbCNPJ.Name = "mtbCNPJ";
            this.mtbCNPJ.Size = new System.Drawing.Size(163, 26);
            this.mtbCNPJ.TabIndex = 6;
            this.mtbCNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbCNPJ.TextChanged += new System.EventHandler(this.mtbCNPJ_TextChanged);
            // 
            // dtpCreation
            // 
            this.dtpCreation.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCreation.Location = new System.Drawing.Point(116, 44);
            this.dtpCreation.Name = "dtpCreation";
            this.dtpCreation.Size = new System.Drawing.Size(163, 26);
            this.dtpCreation.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Criação:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Dias Validos:";
            // 
            // nudValidDays
            // 
            this.nudValidDays.Location = new System.Drawing.Point(116, 73);
            this.nudValidDays.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.nudValidDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudValidDays.Name = "nudValidDays";
            this.nudValidDays.Size = new System.Drawing.Size(163, 26);
            this.nudValidDays.TabIndex = 11;
            this.nudValidDays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudKeyRefValidDays
            // 
            this.nudKeyRefValidDays.Location = new System.Drawing.Point(119, 269);
            this.nudKeyRefValidDays.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.nudKeyRefValidDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKeyRefValidDays.Name = "nudKeyRefValidDays";
            this.nudKeyRefValidDays.Size = new System.Drawing.Size(163, 26);
            this.nudKeyRefValidDays.TabIndex = 18;
            this.nudKeyRefValidDays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Dias Validos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Criação:";
            // 
            // dtpKeyRefCreation
            // 
            this.dtpKeyRefCreation.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKeyRefCreation.Location = new System.Drawing.Point(119, 240);
            this.dtpKeyRefCreation.Name = "dtpKeyRefCreation";
            this.dtpKeyRefCreation.Size = new System.Drawing.Size(163, 26);
            this.dtpKeyRefCreation.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ref CNPJ:";
            // 
            // btnCheckValues
            // 
            this.btnCheckValues.Location = new System.Drawing.Point(307, 230);
            this.btnCheckValues.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCheckValues.Name = "btnCheckValues";
            this.btnCheckValues.Size = new System.Drawing.Size(112, 35);
            this.btnCheckValues.TabIndex = 19;
            this.btnCheckValues.Text = "Check";
            this.btnCheckValues.UseVisualStyleBackColor = true;
            this.btnCheckValues.Click += new System.EventHandler(this.btnCheckValues_Click);
            // 
            // txtRefCNPJ
            // 
            this.txtRefCNPJ.Location = new System.Drawing.Point(306, 12);
            this.txtRefCNPJ.Name = "txtRefCNPJ";
            this.txtRefCNPJ.Size = new System.Drawing.Size(100, 26);
            this.txtRefCNPJ.TabIndex = 20;
            // 
            // txtKeyRefCHPJ
            // 
            this.txtKeyRefCHPJ.Location = new System.Drawing.Point(119, 205);
            this.txtKeyRefCHPJ.Name = "txtKeyRefCHPJ";
            this.txtKeyRefCHPJ.Size = new System.Drawing.Size(100, 26);
            this.txtKeyRefCHPJ.TabIndex = 21;
            // 
            // btnSaveDB
            // 
            this.btnSaveDB.Location = new System.Drawing.Point(307, 173);
            this.btnSaveDB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaveDB.Name = "btnSaveDB";
            this.btnSaveDB.Size = new System.Drawing.Size(112, 35);
            this.btnSaveDB.TabIndex = 22;
            this.btnSaveDB.Text = "Save DB";
            this.btnSaveDB.UseVisualStyleBackColor = true;
            this.btnSaveDB.Click += new System.EventHandler(this.btnSaveDB_Click);
            // 
            // Keygen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 320);
            this.Controls.Add(this.btnSaveDB);
            this.Controls.Add(this.txtKeyRefCHPJ);
            this.Controls.Add(this.txtRefCNPJ);
            this.Controls.Add(this.btnCheckValues);
            this.Controls.Add(this.nudKeyRefValidDays);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpKeyRefCreation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudValidDays);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpCreation);
            this.Controls.Add(this.mtbCNPJ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGiveValues);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.btnStart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Keygen";
            this.Text = "keygen";
            this.Load += new System.EventHandler(this.Keygen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudValidDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKeyRefValidDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Button btnGiveValues;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbCNPJ;
        private System.Windows.Forms.DateTimePicker dtpCreation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudValidDays;
        private System.Windows.Forms.NumericUpDown nudKeyRefValidDays;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpKeyRefCreation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCheckValues;
        private System.Windows.Forms.TextBox txtRefCNPJ;
        private System.Windows.Forms.TextBox txtKeyRefCHPJ;
        private System.Windows.Forms.Button btnSaveDB;
    }
}

