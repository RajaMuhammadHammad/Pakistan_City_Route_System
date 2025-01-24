
namespace G_MAP
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.M = new GMap.NET.WindowsForms.GMapControl();
            this.Back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            this.SuspendLayout();
            // 
            // M
            // 
            this.M.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.M.Bearing = 0F;
            this.M.CanDragMap = true;
            this.M.EmptyTileColor = System.Drawing.Color.Navy;
            this.M.GrayScaleMode = false;
            this.M.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.M.LevelsKeepInMemory = 5;
            this.M.Location = new System.Drawing.Point(12, 12);
            this.M.MarkersEnabled = true;
            this.M.MaxZoom = 2;
            this.M.MinZoom = 2;
            this.M.MouseWheelZoomEnabled = true;
            this.M.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.M.Name = "M";
            this.M.NegativeMode = false;
            this.M.PolygonsEnabled = true;
            this.M.RetryLoadTile = 0;
            this.M.RoutesEnabled = true;
            this.M.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.M.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.M.ShowTileGridLines = false;
            this.M.Size = new System.Drawing.Size(1406, 665);
            this.M.TabIndex = 0;
            this.M.Zoom = 0D;
            this.M.Load += new System.EventHandler(this.M_Load);
            // 
            // Back
            // 
            this.Back.Image = ((System.Drawing.Image)(resources.GetObject("Back.Image")));
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Margin = new System.Windows.Forms.Padding(4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(45, 46);
            this.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Back.TabIndex = 40;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 698);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.M);
            this.Name = "Form5";
            this.Text = "Map";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl M;
        private System.Windows.Forms.PictureBox Back;
    }
}