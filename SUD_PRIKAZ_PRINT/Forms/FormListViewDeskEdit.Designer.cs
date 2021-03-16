namespace SUD_PRIKAZ_PRINT
{
    partial class FormListViewDeskEdit
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
            this.labelUCH = new System.Windows.Forms.Label();
            this.TextBoxUCH = new System.Windows.Forms.TextBox();
            this.TextBoxSUD = new System.Windows.Forms.TextBox();
            this.labelSudiy = new System.Windows.Forms.Label();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.groupBoxDeskPaste = new System.Windows.Forms.GroupBox();
            this.ListViewDeskPaste = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDescriptiom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripDeskPaste = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeskToolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.DeskToolStripMenuItemDel = new System.Windows.Forms.ToolStripMenuItem();
            this.DeskToolStripMenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxUchastok = new System.Windows.Forms.GroupBox();
            this.GroupBoxEdit = new System.Windows.Forms.GroupBox();
            this.labelPaste = new System.Windows.Forms.Label();
            this.TextBoxPaste = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxDeskPaste.SuspendLayout();
            this.contextMenuStripDeskPaste.SuspendLayout();
            this.groupBoxUchastok.SuspendLayout();
            this.GroupBoxEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUCH
            // 
            this.labelUCH.AutoSize = true;
            this.labelUCH.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUCH.Location = new System.Drawing.Point(25, 41);
            this.labelUCH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUCH.Name = "labelUCH";
            this.labelUCH.Size = new System.Drawing.Size(150, 23);
            this.labelUCH.TabIndex = 0;
            this.labelUCH.Text = "Номер участка :";
            this.toolTip.SetToolTip(this.labelUCH, "Номер участка");
            // 
            // TextBoxUCH
            // 
            this.TextBoxUCH.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxUCH.Location = new System.Drawing.Point(183, 37);
            this.TextBoxUCH.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxUCH.Name = "TextBoxUCH";
            this.TextBoxUCH.Size = new System.Drawing.Size(139, 32);
            this.TextBoxUCH.TabIndex = 1;
            this.toolTip.SetToolTip(this.TextBoxUCH, "Укажите номер участка");
            // 
            // TextBoxSUD
            // 
            this.TextBoxSUD.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxSUD.Location = new System.Drawing.Point(20, 121);
            this.TextBoxSUD.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxSUD.Name = "TextBoxSUD";
            this.TextBoxSUD.Size = new System.Drawing.Size(302, 32);
            this.TextBoxSUD.TabIndex = 3;
            this.toolTip.SetToolTip(this.TextBoxSUD, "Укажите Ф.И.О. судьи");
            // 
            // labelSudiy
            // 
            this.labelSudiy.AutoSize = true;
            this.labelSudiy.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSudiy.Location = new System.Drawing.Point(25, 84);
            this.labelSudiy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSudiy.Name = "labelSudiy";
            this.labelSudiy.Size = new System.Drawing.Size(136, 23);
            this.labelSudiy.TabIndex = 2;
            this.labelSudiy.Text = "Ф.И.О. Судьи:";
            this.toolTip.SetToolTip(this.labelSudiy, "Ф.И.О.  Судьи");
            // 
            // ButtonSave
            // 
            this.ButtonSave.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSave.Image = global::SUD_PRIKAZ_PRINT.Properties.Resources.check_ok;
            this.ButtonSave.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ButtonSave.Location = new System.Drawing.Point(918, 205);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ButtonSave.Size = new System.Drawing.Size(360, 58);
            this.ButtonSave.TabIndex = 5;
            this.ButtonSave.Text = "Сохранить";
            this.toolTip.SetToolTip(this.ButtonSave, "Подтверждение сохранения данных");
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCancel.Image = global::SUD_PRIKAZ_PRINT.Properties.Resources.Cancel;
            this.ButtonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonCancel.Location = new System.Drawing.Point(25, 205);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(360, 58);
            this.ButtonCancel.TabIndex = 4;
            this.ButtonCancel.Text = "Отмена";
            this.toolTip.SetToolTip(this.ButtonCancel, "Отмена  ввода. Изменения не будут сохранены");
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // groupBoxDeskPaste
            // 
            this.groupBoxDeskPaste.Controls.Add(this.ListViewDeskPaste);
            this.groupBoxDeskPaste.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxDeskPaste.Location = new System.Drawing.Point(405, 12);
            this.groupBoxDeskPaste.Name = "groupBoxDeskPaste";
            this.groupBoxDeskPaste.Size = new System.Drawing.Size(493, 170);
            this.groupBoxDeskPaste.TabIndex = 25;
            this.groupBoxDeskPaste.TabStop = false;
            this.groupBoxDeskPaste.Text = "Вставки  судебного  участка";
            this.toolTip.SetToolTip(this.groupBoxDeskPaste, "Описание вставок судебного участка");
            // 
            // ListViewDeskPaste
            // 
            this.ListViewDeskPaste.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderDescriptiom});
            this.ListViewDeskPaste.ContextMenuStrip = this.contextMenuStripDeskPaste;
            this.ListViewDeskPaste.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListViewDeskPaste.FullRowSelect = true;
            this.ListViewDeskPaste.GridLines = true;
            this.ListViewDeskPaste.HideSelection = false;
            this.ListViewDeskPaste.Location = new System.Drawing.Point(9, 24);
            this.ListViewDeskPaste.MultiSelect = false;
            this.ListViewDeskPaste.Name = "ListViewDeskPaste";
            this.ListViewDeskPaste.ShowGroups = false;
            this.ListViewDeskPaste.ShowItemToolTips = true;
            this.ListViewDeskPaste.Size = new System.Drawing.Size(478, 140);
            this.ListViewDeskPaste.TabIndex = 4;
            this.toolTip.SetToolTip(this.ListViewDeskPaste, "Редактировать таблицу возможно с помощью контексного меню.");
            this.ListViewDeskPaste.UseCompatibleStateImageBehavior = false;
            this.ListViewDeskPaste.View = System.Windows.Forms.View.Details;
            this.ListViewDeskPaste.SelectedIndexChanged += new System.EventHandler(this.ListViewDeskPaste_SelectedIndexChanged);
            this.ListViewDeskPaste.DoubleClick += new System.EventHandler(this.ListViewDeskPaste_DoubleClick);
            this.ListViewDeskPaste.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListViewDeskPaste_KeyDown);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Наименование ";
            this.columnHeaderName.Width = 157;
            // 
            // columnHeaderDescriptiom
            // 
            this.columnHeaderDescriptiom.Text = "Описание";
            this.columnHeaderDescriptiom.Width = 309;
            // 
            // contextMenuStripDeskPaste
            // 
            this.contextMenuStripDeskPaste.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeskToolStripMenuItemEdit,
            this.DeskToolStripMenuItemDel,
            this.DeskToolStripMenuItemAdd});
            this.contextMenuStripDeskPaste.Name = "contextMenuStrip1";
            this.contextMenuStripDeskPaste.Size = new System.Drawing.Size(148, 70);
            // 
            // DeskToolStripMenuItemEdit
            // 
            this.DeskToolStripMenuItemEdit.Name = "DeskToolStripMenuItemEdit";
            this.DeskToolStripMenuItemEdit.ShowShortcutKeys = false;
            this.DeskToolStripMenuItemEdit.Size = new System.Drawing.Size(147, 22);
            this.DeskToolStripMenuItemEdit.Text = "Редактировать";
            this.DeskToolStripMenuItemEdit.Click += new System.EventHandler(this.DeskToolStripMenuItemEdit_Click);
            // 
            // DeskToolStripMenuItemDel
            // 
            this.DeskToolStripMenuItemDel.Name = "DeskToolStripMenuItemDel";
            this.DeskToolStripMenuItemDel.ShowShortcutKeys = false;
            this.DeskToolStripMenuItemDel.Size = new System.Drawing.Size(147, 22);
            this.DeskToolStripMenuItemDel.Text = "Удалить";
            this.DeskToolStripMenuItemDel.Click += new System.EventHandler(this.DeskToolStripMenuItemDel_Click_1);
            // 
            // DeskToolStripMenuItemAdd
            // 
            this.DeskToolStripMenuItemAdd.Name = "DeskToolStripMenuItemAdd";
            this.DeskToolStripMenuItemAdd.ShowShortcutKeys = false;
            this.DeskToolStripMenuItemAdd.Size = new System.Drawing.Size(147, 22);
            this.DeskToolStripMenuItemAdd.Text = "Добавить";
            this.DeskToolStripMenuItemAdd.Click += new System.EventHandler(this.DeskToolStripMenuItemAdd_Click);
            // 
            // groupBoxUchastok
            // 
            this.groupBoxUchastok.Controls.Add(this.labelUCH);
            this.groupBoxUchastok.Controls.Add(this.TextBoxUCH);
            this.groupBoxUchastok.Controls.Add(this.labelSudiy);
            this.groupBoxUchastok.Controls.Add(this.TextBoxSUD);
            this.groupBoxUchastok.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxUchastok.Location = new System.Drawing.Point(25, 12);
            this.groupBoxUchastok.Name = "groupBoxUchastok";
            this.groupBoxUchastok.Size = new System.Drawing.Size(360, 170);
            this.groupBoxUchastok.TabIndex = 26;
            this.groupBoxUchastok.TabStop = false;
            this.groupBoxUchastok.Text = "Судебный  участок";
            this.toolTip.SetToolTip(this.groupBoxUchastok, "Описание судебного участка");
            // 
            // GroupBoxEdit
            // 
            this.GroupBoxEdit.Controls.Add(this.labelPaste);
            this.GroupBoxEdit.Controls.Add(this.TextBoxPaste);
            this.GroupBoxEdit.Controls.Add(this.labelDescription);
            this.GroupBoxEdit.Controls.Add(this.TextBoxDescription);
            this.GroupBoxEdit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxEdit.Location = new System.Drawing.Point(918, 12);
            this.GroupBoxEdit.Name = "GroupBoxEdit";
            this.GroupBoxEdit.Size = new System.Drawing.Size(360, 170);
            this.GroupBoxEdit.TabIndex = 27;
            this.GroupBoxEdit.TabStop = false;
            this.GroupBoxEdit.Text = "Редактирование вставки";
            this.toolTip.SetToolTip(this.GroupBoxEdit, "Корректировка текущей  вставки");
            this.GroupBoxEdit.Visible = false;
            // 
            // labelPaste
            // 
            this.labelPaste.AutoSize = true;
            this.labelPaste.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPaste.Location = new System.Drawing.Point(25, 41);
            this.labelPaste.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPaste.Name = "labelPaste";
            this.labelPaste.Size = new System.Drawing.Size(96, 23);
            this.labelPaste.TabIndex = 0;
            this.labelPaste.Text = "Вставка  :";
            this.toolTip.SetToolTip(this.labelPaste, "Вставка");
            // 
            // TextBoxPaste
            // 
            this.TextBoxPaste.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxPaste.Location = new System.Drawing.Point(125, 37);
            this.TextBoxPaste.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxPaste.Name = "TextBoxPaste";
            this.TextBoxPaste.Size = new System.Drawing.Size(215, 32);
            this.TextBoxPaste.TabIndex = 1;
            this.toolTip.SetToolTip(this.TextBoxPaste, "Укажите наимеование вставки");
            this.TextBoxPaste.Enter += new System.EventHandler(this.TextBoxPaste_Enter);
            this.TextBoxPaste.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxPaste_KeyDown);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDescription.Location = new System.Drawing.Point(25, 84);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(175, 23);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "Описание вставки:";
            this.toolTip.SetToolTip(this.labelDescription, "Описание вставки");
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxDescription.Location = new System.Drawing.Point(20, 121);
            this.TextBoxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(320, 32);
            this.TextBoxDescription.TabIndex = 3;
            this.toolTip.SetToolTip(this.TextBoxDescription, "Укажите значение вставки");
            this.TextBoxDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxDescription_KeyDown);
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 50000;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Информация :";
            // 
            // FormListViewDeskEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(1294, 281);
            this.Controls.Add(this.GroupBoxEdit);
            this.Controls.Add(this.groupBoxUchastok);
            this.Controls.Add(this.groupBoxDeskPaste);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonCancel);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormListViewDeskEdit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование данных  судебного участка и  его описания вставок";
            this.groupBoxDeskPaste.ResumeLayout(false);
            this.contextMenuStripDeskPaste.ResumeLayout(false);
            this.groupBoxUchastok.ResumeLayout(false);
            this.groupBoxUchastok.PerformLayout();
            this.GroupBoxEdit.ResumeLayout(false);
            this.GroupBoxEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelUCH;
        private System.Windows.Forms.TextBox TextBoxUCH;
        private System.Windows.Forms.TextBox TextBoxSUD;
        private System.Windows.Forms.Label labelSudiy;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.GroupBox groupBoxDeskPaste;
        public System.Windows.Forms.ListView ListViewDeskPaste;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderDescriptiom;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDeskPaste;
        private System.Windows.Forms.ToolStripMenuItem DeskToolStripMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem DeskToolStripMenuItemDel;
        private System.Windows.Forms.ToolStripMenuItem DeskToolStripMenuItemAdd;
        private System.Windows.Forms.GroupBox groupBoxUchastok;
        private System.Windows.Forms.GroupBox GroupBoxEdit;
        private System.Windows.Forms.Label labelPaste;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox TextBoxDescription;
        private System.Windows.Forms.ToolTip toolTip;
        internal System.Windows.Forms.TextBox TextBoxPaste;
    }
}