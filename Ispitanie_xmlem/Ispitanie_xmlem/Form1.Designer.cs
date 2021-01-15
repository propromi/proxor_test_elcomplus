namespace Ispitanie_xmlem
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDownload = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.treeViewMy = new System.Windows.Forms.TreeView();
            this.textBoxLink = new System.Windows.Forms.TextBox();
            this.labelLink = new System.Windows.Forms.Label();
            this.textBoxBreath = new System.Windows.Forms.TextBox();
            this.labelAbout = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDownload
            // 
            this.buttonDownload.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonDownload.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F);
            this.buttonDownload.Location = new System.Drawing.Point(639, 43);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(157, 55);
            this.buttonDownload.TabIndex = 0;
            this.buttonDownload.Text = "Загрузить";
            this.buttonDownload.UseVisualStyleBackColor = false;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F);
            this.labelStatus.Location = new System.Drawing.Point(335, 100);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(197, 22);
            this.labelStatus.TabIndex = 1;
            this.labelStatus.Text = "Ничего не происходит";
            // 
            // buttonDraw
            // 
            this.buttonDraw.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F);
            this.buttonDraw.Location = new System.Drawing.Point(639, 209);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(157, 55);
            this.buttonDraw.TabIndex = 2;
            this.buttonDraw.Text = "Построить";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // treeViewMy
            // 
            this.treeViewMy.Location = new System.Drawing.Point(338, 140);
            this.treeViewMy.Name = "treeViewMy";
            this.treeViewMy.Size = new System.Drawing.Size(256, 292);
            this.treeViewMy.TabIndex = 3;
            // 
            // textBoxLink
            // 
            this.textBoxLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxLink.Location = new System.Drawing.Point(338, 52);
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.Size = new System.Drawing.Size(254, 30);
            this.textBoxLink.TabIndex = 4;
            // 
            // labelLink
            // 
            this.labelLink.AutoSize = true;
            this.labelLink.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F);
            this.labelLink.Location = new System.Drawing.Point(335, 27);
            this.labelLink.Name = "labelLink";
            this.labelLink.Size = new System.Drawing.Size(150, 22);
            this.labelLink.TabIndex = 5;
            this.labelLink.Text = "Вставьте ссылку";
            // 
            // textBoxBreath
            // 
            this.textBoxBreath.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxBreath.Enabled = false;
            this.textBoxBreath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxBreath.Location = new System.Drawing.Point(12, 12);
            this.textBoxBreath.Multiline = true;
            this.textBoxBreath.Name = "textBoxBreath";
            this.textBoxBreath.Size = new System.Drawing.Size(307, 420);
            this.textBoxBreath.TabIndex = 6;
            this.textBoxBreath.Text = "Инструкция:";
            // 
            // labelAbout
            // 
            this.labelAbout.AutoSize = true;
            this.labelAbout.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F);
            this.labelAbout.Location = new System.Drawing.Point(644, 393);
            this.labelAbout.Name = "labelAbout";
            this.labelAbout.Size = new System.Drawing.Size(131, 22);
            this.labelAbout.TabIndex = 7;
            this.labelAbout.Text = "Made by Proxor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 450);
            this.Controls.Add(this.labelAbout);
            this.Controls.Add(this.textBoxBreath);
            this.Controls.Add(this.labelLink);
            this.Controls.Add(this.textBoxLink);
            this.Controls.Add(this.treeViewMy);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonDownload);
            this.Name = "Form1";
            this.Text = "Испытание ксмелем";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.TreeView treeViewMy;
        private System.Windows.Forms.TextBox textBoxLink;
        private System.Windows.Forms.Label labelLink;
        private System.Windows.Forms.TextBox textBoxBreath;
        private System.Windows.Forms.Label labelAbout;
    }
}

