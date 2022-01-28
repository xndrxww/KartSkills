namespace Session1
{
    partial class CharityCustom
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.picureBox = new System.Windows.Forms.PictureBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // picureBox
            // 
            this.picureBox.Location = new System.Drawing.Point(28, 18);
            this.picureBox.Name = "picureBox";
            this.picureBox.Size = new System.Drawing.Size(100, 100);
            this.picureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picureBox.TabIndex = 0;
            this.picureBox.TabStop = false;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionLabel.Location = new System.Drawing.Point(158, 54);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(83, 20);
            this.DescriptionLabel.TabIndex = 1;
            this.DescriptionLabel.Text = "Описание";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(328, 26);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(173, 25);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Наименование";
            // 
            // CharityCustom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.picureBox);
            this.Name = "CharityCustom";
            this.Size = new System.Drawing.Size(670, 150);
            ((System.ComponentModel.ISupportInitialize)(this.picureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picureBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label nameLabel;
    }
}
