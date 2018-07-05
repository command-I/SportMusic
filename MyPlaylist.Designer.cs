namespace SportMusic
{
    partial class MyPlaylist
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
            this.label1 = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Login = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Download = new System.Windows.Forms.Button();
            this.button_Listen = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Edit = new System.Windows.Forms.Button();
            this.button_Export = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(240, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "Список плейлистов";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(671, 34);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(63, 13);
            this.label_Name.TabIndex = 16;
            this.label_Name.Text = "label_Name";
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Location = new System.Drawing.Point(673, 11);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(61, 13);
            this.label_Login.TabIndex = 15;
            this.label_Login.Text = "label_Login";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(685, 402);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 38);
            this.button5.TabIndex = 14;
            this.button5.Text = "Главная";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(685, 208);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(103, 38);
            this.button_Delete.TabIndex = 13;
            this.button_Delete.Text = "Удалить";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Download
            // 
            this.button_Download.Location = new System.Drawing.Point(685, 164);
            this.button_Download.Name = "button_Download";
            this.button_Download.Size = new System.Drawing.Size(103, 38);
            this.button_Download.TabIndex = 12;
            this.button_Download.Text = "Скачать";
            this.button_Download.UseVisualStyleBackColor = true;
            // 
            // button_Listen
            // 
            this.button_Listen.Location = new System.Drawing.Point(685, 76);
            this.button_Listen.Name = "button_Listen";
            this.button_Listen.Size = new System.Drawing.Size(103, 38);
            this.button_Listen.TabIndex = 10;
            this.button_Listen.Text = "Слушать";
            this.button_Listen.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(628, 364);
            this.dataGridView1.TabIndex = 9;
            // 
            // button_Edit
            // 
            this.button_Edit.Location = new System.Drawing.Point(685, 120);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(103, 38);
            this.button_Edit.TabIndex = 18;
            this.button_Edit.Text = "Изменить";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // button_Export
            // 
            this.button_Export.Location = new System.Drawing.Point(685, 252);
            this.button_Export.Name = "button_Export";
            this.button_Export.Size = new System.Drawing.Size(103, 38);
            this.button_Export.TabIndex = 19;
            this.button_Export.Text = "Выгрузить";
            this.button_Export.UseVisualStyleBackColor = true;
            // 
            // buttonDown
            // 
            this.buttonDown.Image = global::SportMusic.Properties.Resources.arrow_down;
            this.buttonDown.Location = new System.Drawing.Point(646, 104);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(30, 30);
            this.buttonDown.TabIndex = 21;
            this.buttonDown.UseVisualStyleBackColor = true;
            // 
            // buttonUp
            // 
            this.buttonUp.Image = global::SportMusic.Properties.Resources.arrow_up;
            this.buttonUp.Location = new System.Drawing.Point(646, 76);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 30);
            this.buttonUp.TabIndex = 20;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // MyPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.button_Export);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label_Login);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Download);
            this.Controls.Add(this.button_Listen);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MyPlaylist";
            this.Text = "Мои плейлисты";
            this.Load += new System.EventHandler(this.MyPlaylist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Download;
        private System.Windows.Forms.Button button_Listen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_Export;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
    }
}