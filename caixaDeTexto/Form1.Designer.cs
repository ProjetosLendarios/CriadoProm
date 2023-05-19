
using System.Windows.Forms;

namespace caixaDeTexto
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TextBoxDisplay = new System.Windows.Forms.TextBox();
            this.TextBoxTabela01 = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.TextBoxTabela02 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxView01 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBoxDisplay
            // 
            this.TextBoxDisplay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TextBoxDisplay.Font = new System.Drawing.Font("Tahoma", 15F);
            this.TextBoxDisplay.Location = new System.Drawing.Point(0, 41);
            this.TextBoxDisplay.Multiline = true;
            this.TextBoxDisplay.Name = "TextBoxDisplay";
            this.TextBoxDisplay.ReadOnly = true;
            this.TextBoxDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxDisplay.Size = new System.Drawing.Size(1173, 563);
            this.TextBoxDisplay.TabIndex = 0;
            this.TextBoxDisplay.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.Zoom);
            // 
            // TextBoxTabela01
            // 
            this.TextBoxTabela01.Location = new System.Drawing.Point(70, 12);
            this.TextBoxTabela01.Name = "TextBoxTabela01";
            this.TextBoxTabela01.Size = new System.Drawing.Size(144, 21);
            this.TextBoxTabela01.TabIndex = 1;
            this.TextBoxTabela01.TextChanged += new System.EventHandler(this.TextBoxTabela01_TextChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(435, 10);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Inserir";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(516, 10);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Text = "Copiar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // TextBoxTabela02
            // 
            this.TextBoxTabela02.Location = new System.Drawing.Point(285, 12);
            this.TextBoxTabela02.Name = "TextBoxTabela02";
            this.TextBoxTabela02.Size = new System.Drawing.Size(144, 21);
            this.TextBoxTabela02.TabIndex = 2;
            this.TextBoxTabela02.TextChanged += new System.EventHandler(this.TextBoxTabela02_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "| Tabela 2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tabela 1:";
            // 
            // TextBoxView01
            // 
            this.TextBoxView01.Location = new System.Drawing.Point(654, 12);
            this.TextBoxView01.Name = "TextBoxView01";
            this.TextBoxView01.Size = new System.Drawing.Size(100, 21);
            this.TextBoxView01.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(599, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "| View 1:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 604);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxView01);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxTabela02);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.TextBoxTabela01);
            this.Controls.Add(this.TextBoxDisplay);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("Form1.IconOptions.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MirrorBase - Class Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxDisplay;
        private System.Windows.Forms.TextBox TextBoxTabela01;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.TextBox TextBoxTabela02;
        private Label label1;
        private Label label2;
        private TextBox TextBoxView01;
        private Label label3;
    }
}

