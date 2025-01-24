
namespace G_MAP
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
            this.MAINPIC = new System.Windows.Forms.PictureBox();
            this.OPEN = new System.Windows.Forms.Button();
            this.Instruction = new System.Windows.Forms.Button();
            this.EXIST = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MAINPIC)).BeginInit();
            this.SuspendLayout();
            // 
            // MAINPIC
            // 
            this.MAINPIC.Image = ((System.Drawing.Image)(resources.GetObject("MAINPIC.Image")));
            this.MAINPIC.Location = new System.Drawing.Point(-4, 0);
            this.MAINPIC.Name = "MAINPIC";
            this.MAINPIC.Size = new System.Drawing.Size(1361, 742);
            this.MAINPIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MAINPIC.TabIndex = 1;
            this.MAINPIC.TabStop = false;
            this.MAINPIC.Click += new System.EventHandler(this.MAINPIC_Click);
            // 
            // OPEN
            // 
            this.OPEN.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OPEN.ForeColor = System.Drawing.Color.Black;
            this.OPEN.Location = new System.Drawing.Point(66, 609);
            this.OPEN.Name = "OPEN";
            this.OPEN.Size = new System.Drawing.Size(245, 71);
            this.OPEN.TabIndex = 2;
            this.OPEN.Text = "OPEN";
            this.OPEN.UseVisualStyleBackColor = true;
            this.OPEN.Click += new System.EventHandler(this.OPEN_Click);
            // 
            // Instruction
            // 
            this.Instruction.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instruction.ForeColor = System.Drawing.Color.Black;
            this.Instruction.Location = new System.Drawing.Point(353, 610);
            this.Instruction.Name = "Instruction";
            this.Instruction.Size = new System.Drawing.Size(378, 71);
            this.Instruction.TabIndex = 3;
            this.Instruction.Text = "INFO";
            this.Instruction.UseVisualStyleBackColor = true;
            this.Instruction.Click += new System.EventHandler(this.Instruction_Click);
            // 
            // EXIST
            // 
            this.EXIST.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXIST.ForeColor = System.Drawing.Color.Black;
            this.EXIST.Location = new System.Drawing.Point(777, 610);
            this.EXIST.Name = "EXIST";
            this.EXIST.Size = new System.Drawing.Size(245, 71);
            this.EXIST.TabIndex = 4;
            this.EXIST.Text = "EXIT";
            this.EXIST.UseVisualStyleBackColor = true;
            this.EXIST.Click += new System.EventHandler(this.EXIST_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 742);
            this.Controls.Add(this.EXIST);
            this.Controls.Add(this.Instruction);
            this.Controls.Add(this.OPEN);
            this.Controls.Add(this.MAINPIC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MAINPIC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MAINPIC;
        private System.Windows.Forms.Button OPEN;
        private System.Windows.Forms.Button Instruction;
        private System.Windows.Forms.Button EXIST;
    }
}