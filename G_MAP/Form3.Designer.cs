namespace G_MAP
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.End = new System.Windows.Forms.ComboBox();
            this.RouteTxt = new System.Windows.Forms.RichTextBox();
            this.DistanceTxt = new System.Windows.Forms.TextBox();
            this.btnMapLoad = new System.Windows.Forms.Button();
            this.GenBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.PictureBox();
            this.Start = new System.Windows.Forms.ComboBox();
            this.Generate = new System.Windows.Forms.Button();
            this.btnMapLoad2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            this.SuspendLayout();
            // 
            // End
            // 
            this.End.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.End.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.End.ForeColor = System.Drawing.Color.Blue;
            this.End.Items.AddRange(new object[] {
            "Karachi",
            "Lahore",
            "Peshawar",
            "Faisalabad",
            "Hyderabad",
            "Islambad",
            "Rawalpindi",
            "Quetta",
            "Larkana",
            "Gilgit-Baltistan",
            "Sahiwal",
            "Bahawalpur",
            "Gujrat",
            "Hub-Balochistan",
            "Mardan",
            "Gwadar"});
            this.End.Location = new System.Drawing.Point(176, 205);
            this.End.Margin = new System.Windows.Forms.Padding(4);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(385, 30);
            this.End.TabIndex = 65;
            this.End.SelectedIndexChanged += new System.EventHandler(this.End_SelectedIndexChanged);
            // 
            // RouteTxt
            // 
            this.RouteTxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RouteTxt.ForeColor = System.Drawing.Color.Red;
            this.RouteTxt.Location = new System.Drawing.Point(176, 288);
            this.RouteTxt.Margin = new System.Windows.Forms.Padding(4);
            this.RouteTxt.Name = "RouteTxt";
            this.RouteTxt.ReadOnly = true;
            this.RouteTxt.Size = new System.Drawing.Size(385, 78);
            this.RouteTxt.TabIndex = 71;
            this.RouteTxt.Text = "";
            this.RouteTxt.TextChanged += new System.EventHandler(this.RouteTxt_TextChanged);
            // 
            // DistanceTxt
            // 
            this.DistanceTxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DistanceTxt.ForeColor = System.Drawing.Color.Lime;
            this.DistanceTxt.Location = new System.Drawing.Point(176, 426);
            this.DistanceTxt.Margin = new System.Windows.Forms.Padding(4);
            this.DistanceTxt.Name = "DistanceTxt";
            this.DistanceTxt.ReadOnly = true;
            this.DistanceTxt.Size = new System.Drawing.Size(385, 30);
            this.DistanceTxt.TabIndex = 73;
            // 
            // btnMapLoad
            // 
            this.btnMapLoad.BackColor = System.Drawing.Color.Black;
            this.btnMapLoad.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMapLoad.ForeColor = System.Drawing.Color.White;
            this.btnMapLoad.Location = new System.Drawing.Point(787, 213);
            this.btnMapLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnMapLoad.Name = "btnMapLoad";
            this.btnMapLoad.Size = new System.Drawing.Size(199, 61);
            this.btnMapLoad.TabIndex = 75;
            this.btnMapLoad.Text = "View Map";
            this.btnMapLoad.UseVisualStyleBackColor = false;
            this.btnMapLoad.Click += new System.EventHandler(this.btnMapLoad_Click);
            // 
            // GenBtn
            // 
            this.GenBtn.BackColor = System.Drawing.Color.Black;
            this.GenBtn.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenBtn.ForeColor = System.Drawing.Color.White;
            this.GenBtn.Location = new System.Drawing.Point(756, 144);
            this.GenBtn.Margin = new System.Windows.Forms.Padding(4);
            this.GenBtn.Name = "GenBtn";
            this.GenBtn.Size = new System.Drawing.Size(267, 61);
            this.GenBtn.TabIndex = 76;
            this.GenBtn.Text = "Generate Route";
            this.GenBtn.UseVisualStyleBackColor = false;
            this.GenBtn.Click += new System.EventHandler(this.GenBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1366, 660);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightGray;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(13, 118);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 35);
            this.label6.TabIndex = 80;
            this.label6.Text = "From ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightGray;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(36, 205);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 35);
            this.label7.TabIndex = 81;
            this.label7.Text = "To ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 308);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 35);
            this.label1.TabIndex = 82;
            this.label1.Text = " Route";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 418);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 35);
            this.label2.TabIndex = 83;
            this.label2.Text = "Distance";
            // 
            // Back
            // 
            this.Back.Image = ((System.Drawing.Image)(resources.GetObject("Back.Image")));
            this.Back.Location = new System.Drawing.Point(-1, 540);
            this.Back.Margin = new System.Windows.Forms.Padding(4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(76, 62);
            this.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Back.TabIndex = 84;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Start
            // 
            this.Start.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Start.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.Color.Blue;
            this.Start.Items.AddRange(new object[] {
            "Karachi",
            "Lahore",
            "Peshawar",
            "Faisalabad",
            "Hyderabad",
            "Islambad",
            "Rawalpindi",
            "Quetta",
            "Larkana",
            "Gilgit-Baltistan",
            "Sahiwal",
            "Bahawalpur",
            "Gujrat",
            "Hub-Balochistan",
            "Mardan",
            "Gwadar"});
            this.Start.Location = new System.Drawing.Point(176, 118);
            this.Start.Margin = new System.Windows.Forms.Padding(4);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(385, 30);
            this.Start.TabIndex = 63;
            // 
            // Generate
            // 
            this.Generate.BackColor = System.Drawing.Color.Black;
            this.Generate.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generate.ForeColor = System.Drawing.Color.White;
            this.Generate.Location = new System.Drawing.Point(747, 392);
            this.Generate.Margin = new System.Windows.Forms.Padding(4);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(267, 61);
            this.Generate.TabIndex = 86;
            this.Generate.Text = "Generate Route";
            this.Generate.UseVisualStyleBackColor = false;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // btnMapLoad2
            // 
            this.btnMapLoad2.BackColor = System.Drawing.Color.Black;
            this.btnMapLoad2.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMapLoad2.ForeColor = System.Drawing.Color.White;
            this.btnMapLoad2.Location = new System.Drawing.Point(787, 461);
            this.btnMapLoad2.Margin = new System.Windows.Forms.Padding(4);
            this.btnMapLoad2.Name = "btnMapLoad2";
            this.btnMapLoad2.Size = new System.Drawing.Size(199, 61);
            this.btnMapLoad2.TabIndex = 87;
            this.btnMapLoad2.Text = "View Map";
            this.btnMapLoad2.UseVisualStyleBackColor = false;
            this.btnMapLoad2.Click += new System.EventHandler(this.btnMapLoad2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(677, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(399, 38);
            this.label4.TabIndex = 89;
            this.label4.Text = "SHORTEST PATH TO ALL";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(662, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(453, 38);
            this.label5.TabIndex = 90;
            this.label5.Text = "PATH BETWEEN TWO NODE";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 661);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMapLoad2);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GenBtn);
            this.Controls.Add(this.btnMapLoad);
            this.Controls.Add(this.DistanceTxt);
            this.Controls.Add(this.RouteTxt);
            this.Controls.Add(this.End);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox End;
        private System.Windows.Forms.RichTextBox RouteTxt;
        private System.Windows.Forms.TextBox DistanceTxt;
        private System.Windows.Forms.Button btnMapLoad;
        private System.Windows.Forms.Button GenBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Back;
        private System.Windows.Forms.ComboBox Start;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Button btnMapLoad2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
