namespace SportMusic
{
    partial class Form2
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
            this.panelSelectedTracks = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelSelectedTracks
            // 
            this.panelSelectedTracks.AutoScroll = true;
            this.panelSelectedTracks.Location = new System.Drawing.Point(12, 92);
            this.panelSelectedTracks.Name = "panelSelectedTracks";
            this.panelSelectedTracks.Size = new System.Drawing.Size(860, 458);
            this.panelSelectedTracks.TabIndex = 0;
            this.panelSelectedTracks.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSelectedTracks_Paint);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.panelSelectedTracks);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSelectedTracks;
    }
}