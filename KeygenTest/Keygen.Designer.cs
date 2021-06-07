
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
            this.txtKeys = new System.Windows.Forms.TextBox();
            this.btnGiveValues = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.dtpCreation = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudValidDays = new System.Windows.Forms.NumericUpDown();
            this.lblValidOrNot = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudValidDays)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(497, 115);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(112, 35);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Genarate";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtKeys
            // 
            this.txtKeys.Location = new System.Drawing.Point(13, 160);
            this.txtKeys.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKeys.Multiline = true;
            this.txtKeys.Name = "txtKeys";
            this.txtKeys.Size = new System.Drawing.Size(596, 295);
            this.txtKeys.TabIndex = 2;
            // 
            // btnGiveValues
            // 
            this.btnGiveValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiveValues.Location = new System.Drawing.Point(497, 14);
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
            this.mtbCNPJ.Text = "11222333000181";
            this.mtbCNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
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
            // lblValidOrNot
            // 
            this.lblValidOrNot.AutoSize = true;
            this.lblValidOrNot.Location = new System.Drawing.Point(285, 15);
            this.lblValidOrNot.Name = "lblValidOrNot";
            this.lblValidOrNot.Size = new System.Drawing.Size(0, 20);
            this.lblValidOrNot.TabIndex = 12;
            // 
            // Keygen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 469);
            this.Controls.Add(this.lblValidOrNot);
            this.Controls.Add(this.nudValidDays);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpCreation);
            this.Controls.Add(this.mtbCNPJ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGiveValues);
            this.Controls.Add(this.txtKeys);
            this.Controls.Add(this.btnStart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Keygen";
            this.Text = "keygen";
            this.Load += new System.EventHandler(this.Keygen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudValidDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtKeys;
        private System.Windows.Forms.Button btnGiveValues;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbCNPJ;
        private System.Windows.Forms.DateTimePicker dtpCreation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudValidDays;
        private System.Windows.Forms.Label lblValidOrNot;
    }
}

