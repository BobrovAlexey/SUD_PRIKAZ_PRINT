namespace SUD_PRIKAZ_PRINT
{
    partial class FormListViewDocEdit
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListViewDocEdit));
            this.labelDOC = new System.Windows.Forms.Label();
            this.textBoxDOC = new System.Windows.Forms.TextBox();
            this.textBoxDocName = new System.Windows.Forms.TextBox();
            this.labelDocName = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxTemplate = new System.Windows.Forms.TextBox();
            this.labelDocTemplate = new System.Windows.Forms.Label();
            this.textBoxPostfix = new System.Windows.Forms.TextBox();
            this.labelPostfix = new System.Windows.Forms.Label();
            this.textBoxPrefix = new System.Windows.Forms.TextBox();
            this.labelPreFix = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labelDOC
            // 
            this.labelDOC.AutoSize = true;
            this.labelDOC.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDOC.Location = new System.Drawing.Point(29, 58);
            this.labelDOC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDOC.Name = "labelDOC";
            this.labelDOC.Size = new System.Drawing.Size(152, 23);
            this.labelDOC.TabIndex = 0;
            this.labelDOC.Text = "Код документа :";
            this.toolTip.SetToolTip(this.labelDOC, "Код документа");
            // 
            // textBoxDOC
            // 
            this.textBoxDOC.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDOC.Location = new System.Drawing.Point(192, 53);
            this.textBoxDOC.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDOC.Name = "textBoxDOC";
            this.textBoxDOC.Size = new System.Drawing.Size(189, 32);
            this.textBoxDOC.TabIndex = 1;
            this.toolTip.SetToolTip(this.textBoxDOC, "Укажите код документа.");
            // 
            // textBoxDocName
            // 
            this.textBoxDocName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDocName.Location = new System.Drawing.Point(636, 53);
            this.textBoxDocName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDocName.Name = "textBoxDocName";
            this.textBoxDocName.Size = new System.Drawing.Size(349, 32);
            this.textBoxDocName.TabIndex = 3;
            this.toolTip.SetToolTip(this.textBoxDocName, "Укажите название документа");
            // 
            // labelDocName
            // 
            this.labelDocName.AutoSize = true;
            this.labelDocName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDocName.Location = new System.Drawing.Point(417, 58);
            this.labelDocName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDocName.Name = "labelDocName";
            this.labelDocName.Size = new System.Drawing.Size(200, 23);
            this.labelDocName.TabIndex = 2;
            this.labelDocName.Text = "Название документа :";
            this.toolTip.SetToolTip(this.labelDocName, "Название документа");
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Image = global::SUD_PRIKAZ_PRINT.Properties.Resources.check_ok;
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonSave.Location = new System.Drawing.Point(664, 256);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonSave.Size = new System.Drawing.Size(322, 58);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Сохранить";
            this.toolTip.SetToolTip(this.buttonSave, "Подтверждение сохранения введенных данных.");
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Image = global::SUD_PRIKAZ_PRINT.Properties.Resources.Cancel;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(29, 256);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(322, 58);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Отмена";
            this.toolTip.SetToolTip(this.buttonCancel, "Отмена  ввода. Изменения не будут сохранены..");
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // textBoxTemplate
            // 
            this.textBoxTemplate.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTemplate.Location = new System.Drawing.Point(138, 120);
            this.textBoxTemplate.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTemplate.Name = "textBoxTemplate";
            this.textBoxTemplate.Size = new System.Drawing.Size(847, 32);
            this.textBoxTemplate.TabIndex = 7;
            this.toolTip.SetToolTip(this.textBoxTemplate, "Укажите путь к шаблону документа.\r\n%TEMPLATESDIRECTORY% - ссылка на каталог с шаб" +
        "лонами.");
            // 
            // labelDocTemplate
            // 
            this.labelDocTemplate.AutoSize = true;
            this.labelDocTemplate.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDocTemplate.Location = new System.Drawing.Point(29, 125);
            this.labelDocTemplate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDocTemplate.Name = "labelDocTemplate";
            this.labelDocTemplate.Size = new System.Drawing.Size(98, 23);
            this.labelDocTemplate.TabIndex = 6;
            this.labelDocTemplate.Text = "Шаблон  :";
            this.toolTip.SetToolTip(this.labelDocTemplate, resources.GetString("labelDocTemplate.ToolTip"));
            this.labelDocTemplate.Click += new System.EventHandler(this.LabelDocTemplate_Click);
            this.labelDocTemplate.MouseLeave += new System.EventHandler(this.LabelDocTemplate_MouseLeave);
            this.labelDocTemplate.MouseHover += new System.EventHandler(this.LabelDocTemplate_MouseHover);
            // 
            // textBoxPostfix
            // 
            this.textBoxPostfix.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPostfix.Location = new System.Drawing.Point(749, 184);
            this.textBoxPostfix.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPostfix.Name = "textBoxPostfix";
            this.textBoxPostfix.Size = new System.Drawing.Size(236, 32);
            this.textBoxPostfix.TabIndex = 11;
            this.toolTip.SetToolTip(this.textBoxPostfix, "Укажите окончание названия документа.");
            // 
            // labelPostfix
            // 
            this.labelPostfix.AutoSize = true;
            this.labelPostfix.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPostfix.Location = new System.Drawing.Point(521, 189);
            this.labelPostfix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPostfix.Name = "labelPostfix";
            this.labelPostfix.Size = new System.Drawing.Size(198, 23);
            this.labelPostfix.TabIndex = 10;
            this.labelPostfix.Text = "Постфикс  названия :";
            this.toolTip.SetToolTip(this.labelPostfix, "Постфикс названия документа");
            // 
            // textBoxPrefix
            // 
            this.textBoxPrefix.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPrefix.Location = new System.Drawing.Point(224, 184);
            this.textBoxPrefix.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPrefix.Name = "textBoxPrefix";
            this.textBoxPrefix.Size = new System.Drawing.Size(231, 32);
            this.textBoxPrefix.TabIndex = 9;
            this.toolTip.SetToolTip(this.textBoxPrefix, "Укажите начало названия документа.");
            // 
            // labelPreFix
            // 
            this.labelPreFix.AutoSize = true;
            this.labelPreFix.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPreFix.Location = new System.Drawing.Point(29, 189);
            this.labelPreFix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPreFix.Name = "labelPreFix";
            this.labelPreFix.Size = new System.Drawing.Size(182, 23);
            this.labelPreFix.TabIndex = 8;
            this.labelPreFix.Text = "Префикс названия :";
            this.toolTip.SetToolTip(this.labelPreFix, "Префикс названия документа");
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 50000;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Информация :";
            // 
            // FormListViewDocEdit
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(1030, 357);
            this.Controls.Add(this.textBoxPostfix);
            this.Controls.Add(this.labelPostfix);
            this.Controls.Add(this.textBoxPrefix);
            this.Controls.Add(this.labelPreFix);
            this.Controls.Add(this.textBoxTemplate);
            this.Controls.Add(this.labelDocTemplate);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxDocName);
            this.Controls.Add(this.labelDocName);
            this.Controls.Add(this.textBoxDOC);
            this.Controls.Add(this.labelDOC);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormListViewDocEdit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование строки описания шаблона документа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDOC;
        private System.Windows.Forms.TextBox textBoxDOC;
        private System.Windows.Forms.TextBox textBoxDocName;
        private System.Windows.Forms.Label labelDocName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxTemplate;
        private System.Windows.Forms.Label labelDocTemplate;
        private System.Windows.Forms.TextBox textBoxPostfix;
        private System.Windows.Forms.Label labelPostfix;
        private System.Windows.Forms.TextBox textBoxPrefix;
        private System.Windows.Forms.Label labelPreFix;
        private System.Windows.Forms.ToolTip toolTip;
    }
}