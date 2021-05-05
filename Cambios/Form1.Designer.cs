
namespace Cambios
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_origem = new System.Windows.Forms.ComboBox();
            this.cb_destino = new System.Windows.Forms.ComboBox();
            this.btn_converter = new System.Windows.Forms.Button();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_troca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(170, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor:";
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(258, 108);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(391, 31);
            this.txt_valor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(49, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Moeda de Origem:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(46, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Moeda de Destino:";
            // 
            // cb_origem
            // 
            this.cb_origem.FormattingEnabled = true;
            this.cb_origem.Location = new System.Drawing.Point(258, 175);
            this.cb_origem.Name = "cb_origem";
            this.cb_origem.Size = new System.Drawing.Size(391, 33);
            this.cb_origem.TabIndex = 6;
            // 
            // cb_destino
            // 
            this.cb_destino.FormattingEnabled = true;
            this.cb_destino.Location = new System.Drawing.Point(258, 244);
            this.cb_destino.Name = "cb_destino";
            this.cb_destino.Size = new System.Drawing.Size(391, 33);
            this.cb_destino.TabIndex = 7;
            // 
            // btn_converter
            // 
            this.btn_converter.Enabled = false;
            this.btn_converter.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_converter.Location = new System.Drawing.Point(692, 92);
            this.btn_converter.Name = "btn_converter";
            this.btn_converter.Size = new System.Drawing.Size(152, 47);
            this.btn_converter.TabIndex = 8;
            this.btn_converter.Text = "Converter";
            this.btn_converter.UseVisualStyleBackColor = true;
            this.btn_converter.Click += new System.EventHandler(this.btn_converter_Click);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_resultado.Location = new System.Drawing.Point(222, 314);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(473, 28);
            this.lbl_resultado.TabIndex = 9;
            this.lbl_resultado.Text = "Escolha um valor, moeda de origem e de Destino";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(32, 382);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(59, 25);
            this.lbl_status.TabIndex = 10;
            this.lbl_status.Text = "status";
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(600, 391);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(266, 34);
            this.ProgressBar1.TabIndex = 11;
            // 
            // btn_troca
            // 
            this.btn_troca.Enabled = false;
            this.btn_troca.Image = global::Cambios.Properties.Resources.ic_change;
            this.btn_troca.Location = new System.Drawing.Point(722, 159);
            this.btn_troca.Name = "btn_troca";
            this.btn_troca.Size = new System.Drawing.Size(79, 62);
            this.btn_troca.TabIndex = 12;
            this.btn_troca.UseVisualStyleBackColor = true;
            this.btn_troca.Click += new System.EventHandler(this.btn_troca_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 450);
            this.Controls.Add(this.btn_troca);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.btn_converter);
            this.Controls.Add(this.cb_destino);
            this.Controls.Add(this.cb_origem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Câmbios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_origem;
        private System.Windows.Forms.ComboBox cb_destino;
        private System.Windows.Forms.Button btn_converter;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.ProgressBar ProgressBar1;
        private System.Windows.Forms.Button btn_troca;
    }
}

