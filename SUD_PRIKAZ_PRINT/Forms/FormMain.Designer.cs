namespace SUD_PRIKAZ_PRINT
{
    partial class FormMain
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

        
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.labelUch = new System.Windows.Forms.Label();
            this.DomainUpDownUch = new System.Windows.Forms.DomainUpDown();
            this.progressBarFile = new System.Windows.Forms.ProgressBar();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelText = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelImage = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelProcent = new System.Windows.Forms.Label();
            this.labelEsc = new System.Windows.Forms.Label();
            this.toolTipAll = new System.Windows.Forms.ToolTip(this.components);
            this.ButtonConfig = new System.Windows.Forms.Button();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUch
            // 
            this.labelUch.AutoSize = true;
            this.labelUch.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUch.Location = new System.Drawing.Point(27, 52);
            this.labelUch.Name = "labelUch";
            this.labelUch.Size = new System.Drawing.Size(283, 23);
            this.labelUch.TabIndex = 1;
            this.labelUch.Text = "Номер участка по умолчанию :";
            // 
            // DomainUpDownUch
            // 
            this.DomainUpDownUch.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DomainUpDownUch.Location = new System.Drawing.Point(316, 47);
            this.DomainUpDownUch.Name = "DomainUpDownUch";
            this.DomainUpDownUch.Size = new System.Drawing.Size(136, 35);
            this.DomainUpDownUch.Sorted = true;
            this.DomainUpDownUch.TabIndex = 2;
            this.DomainUpDownUch.Text = "0";
            this.toolTipAll.SetToolTip(this.DomainUpDownUch, "Выберите значение участка по умолчанию, либо укажите 0 - если в реестре указаны в" +
        "се значения участков");
            this.DomainUpDownUch.Wrap = true;
            this.DomainUpDownUch.TextChanged += new System.EventHandler(this.DomainUpDownUch_TextChanged);
            // 
            // progressBarFile
            // 
            this.progressBarFile.Location = new System.Drawing.Point(31, 131);
            this.progressBarFile.Name = "progressBarFile";
            this.progressBarFile.Size = new System.Drawing.Size(1090, 73);
            this.progressBarFile.Step = 1;
            this.progressBarFile.TabIndex = 4;
            this.toolTipAll.SetToolTip(this.progressBarFile, "Показывает прогресс формирования файлов");
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelText,
            this.toolStripStatusLabelImage,
            this.toolStripProgressBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 273);
            this.statusStrip.Margin = new System.Windows.Forms.Padding(0, 0, 100, 0);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1156, 22);
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statusStripText";
            // 
            // toolStripStatusLabelText
            // 
            this.toolStripStatusLabelText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabelText.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripStatusLabelText.ForeColor = System.Drawing.Color.Maroon;
            this.toolStripStatusLabelText.Name = "toolStripStatusLabelText";
            this.toolStripStatusLabelText.Size = new System.Drawing.Size(1141, 17);
            this.toolStripStatusLabelText.Spring = true;
            this.toolStripStatusLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabelImage
            // 
            this.toolStripStatusLabelImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripStatusLabelImage.Name = "toolStripStatusLabelImage";
            this.toolStripStatusLabelImage.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.AccessibleName = "AccN";
            this.toolStripProgressBar.AutoSize = false;
            this.toolStripProgressBar.MarqueeAnimationSpeed = 1;
            this.toolStripProgressBar.Maximum = 10000000;
            this.toolStripProgressBar.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.toolStripProgressBar.MergeIndex = 0;
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.toolStripProgressBar.Size = new System.Drawing.Size(150, 16);
            this.toolStripProgressBar.Step = 1;
            this.toolStripProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.toolStripProgressBar.Visible = false;
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(5, 17);
            // 
            // labelProcent
            // 
            this.labelProcent.AutoEllipsis = true;
            this.labelProcent.AutoSize = true;
            this.labelProcent.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelProcent.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProcent.ForeColor = System.Drawing.Color.Maroon;
            this.labelProcent.Location = new System.Drawing.Point(542, 151);
            this.labelProcent.Name = "labelProcent";
            this.labelProcent.Size = new System.Drawing.Size(66, 36);
            this.labelProcent.TabIndex = 6;
            this.labelProcent.Text = "0 %";
            // 
            // labelEsc
            // 
            this.labelEsc.AutoSize = true;
            this.labelEsc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEsc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelEsc.Location = new System.Drawing.Point(798, 217);
            this.labelEsc.Name = "labelEsc";
            this.labelEsc.Size = new System.Drawing.Size(320, 21);
            this.labelEsc.TabIndex = 7;
            this.labelEsc.Text = "Для остановки процесса нажмите  Esc";
            // 
            // toolTipAll
            // 
            this.toolTipAll.AutomaticDelay = 50000;
            this.toolTipAll.AutoPopDelay = 50000;
            this.toolTipAll.InitialDelay = 50000;
            this.toolTipAll.ReshowDelay = 100;
            this.toolTipAll.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipAll.ToolTipTitle = "Информация :";
            // 
            // ButtonConfig
            // 
            this.ButtonConfig.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonConfig.Image = global::SUD_PRIKAZ_PRINT.Properties.Resources.EditRes;
            this.ButtonConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonConfig.Location = new System.Drawing.Point(483, 43);
            this.ButtonConfig.Name = "ButtonConfig";
            this.ButtonConfig.Size = new System.Drawing.Size(306, 41);
            this.ButtonConfig.TabIndex = 3;
            this.ButtonConfig.Text = "Настройка программы";
            this.toolTipAll.SetToolTip(this.ButtonConfig, "Нажатием  Настройка программы - запускаем настройку");
            this.ButtonConfig.UseVisualStyleBackColor = true;
            this.ButtonConfig.Click += new System.EventHandler(this.ButtonConfig_Click);
            // 
            // ButtonStart
            // 
            this.ButtonStart.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonStart.Image = global::SUD_PRIKAZ_PRINT.Properties.Resources.Word;
            this.ButtonStart.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonStart.Location = new System.Drawing.Point(815, 43);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(306, 41);
            this.ButtonStart.TabIndex = 0;
            this.ButtonStart.Text = "Старт";
            this.toolTipAll.SetToolTip(this.ButtonStart, "Нажатием  Старт - запускаем процесс  формирования файлов");
            this.ButtonStart.UseMnemonic = false;
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 295);
            this.Controls.Add(this.labelProcent);
            this.Controls.Add(this.labelEsc);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.progressBarFile);
            this.Controls.Add(this.ButtonConfig);
            this.Controls.Add(this.DomainUpDownUch);
            this.Controls.Add(this.labelUch);
            this.Controls.Add(this.ButtonStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Формирование комплекта файлов для суда";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.FormMain_HelpButtonClicked);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Label labelUch;
        private System.Windows.Forms.Button ButtonConfig;
        private System.Windows.Forms.ProgressBar progressBarFile;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Label labelProcent;
        private System.Windows.Forms.Label labelEsc;
        private System.Windows.Forms.ToolTip toolTipAll;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelText;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelImage;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.DomainUpDown DomainUpDownUch;
    }
}

