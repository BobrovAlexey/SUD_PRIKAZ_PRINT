namespace SUD_PRIKAZ_PRINT
{
    partial class FormConfigurate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfigurate));
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.numericUpDownAddDays = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPadLeft = new System.Windows.Forms.NumericUpDown();
            this.labelPadLeft = new System.Windows.Forms.Label();
            this.textBoxRub = new System.Windows.Forms.TextBox();
            this.labelRub = new System.Windows.Forms.Label();
            this.textBoxZPT = new System.Windows.Forms.TextBox();
            this.labelZPT = new System.Windows.Forms.Label();
            this.textBoxName_File_Out_Template = new System.Windows.Forms.TextBox();
            this.labelName_File_Out_Template = new System.Windows.Forms.Label();
            this.textBoxName_Reestr = new System.Windows.Forms.TextBox();
            this.labelNameReestr = new System.Windows.Forms.Label();
            this.labelAddDays = new System.Windows.Forms.Label();
            this.labelS_End = new System.Windows.Forms.Label();
            this.labelS_Start = new System.Windows.Forms.Label();
            this.textBoxS_End = new System.Windows.Forms.TextBox();
            this.textBoxS_Start = new System.Windows.Forms.TextBox();
            this.labelRazd = new System.Windows.Forms.Label();
            this.groupBoxDirectory = new System.Windows.Forms.GroupBox();
            this.textBoxTemplates = new System.Windows.Forms.TextBox();
            this.textBoxInp = new System.Windows.Forms.TextBox();
            this.labelTemplates = new System.Windows.Forms.Label();
            this.labelInp = new System.Windows.Forms.Label();
            this.LabelOut = new System.Windows.Forms.Label();
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.groupBoxDesk = new System.Windows.Forms.GroupBox();
            this.listViewDesk = new System.Windows.Forms.ListView();
            this.columnHeaderNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFIO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripDesk = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeskToolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.DeskToolStripMenuItemDel = new System.Windows.Forms.ToolStripMenuItem();
            this.DeskToolStripMenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxDoc = new System.Windows.Forms.GroupBox();
            this.listViewDocTemplate = new System.Windows.Forms.ListView();
            this.columnHeaderCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTemplate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrefix = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPostfix = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripDoc = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DocStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.DocStripMenuItemDel = new System.Windows.Forms.ToolStripMenuItem();
            this.DoclStripMenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.toolTipAll = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPadLeft)).BeginInit();
            this.groupBoxDirectory.SuspendLayout();
            this.groupBoxDesk.SuspendLayout();
            this.contextMenuStripDesk.SuspendLayout();
            this.groupBoxDoc.SuspendLayout();
            this.contextMenuStripDoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.Controls.Add(this.numericUpDownAddDays);
            this.groupBoxMain.Controls.Add(this.numericUpDownPadLeft);
            this.groupBoxMain.Controls.Add(this.labelPadLeft);
            this.groupBoxMain.Controls.Add(this.textBoxRub);
            this.groupBoxMain.Controls.Add(this.labelRub);
            this.groupBoxMain.Controls.Add(this.textBoxZPT);
            this.groupBoxMain.Controls.Add(this.labelZPT);
            this.groupBoxMain.Controls.Add(this.textBoxName_File_Out_Template);
            this.groupBoxMain.Controls.Add(this.labelName_File_Out_Template);
            this.groupBoxMain.Controls.Add(this.textBoxName_Reestr);
            this.groupBoxMain.Controls.Add(this.labelNameReestr);
            this.groupBoxMain.Controls.Add(this.labelAddDays);
            this.groupBoxMain.Controls.Add(this.labelS_End);
            this.groupBoxMain.Controls.Add(this.labelS_Start);
            this.groupBoxMain.Controls.Add(this.textBoxS_End);
            this.groupBoxMain.Controls.Add(this.textBoxS_Start);
            this.groupBoxMain.Controls.Add(this.labelRazd);
            this.groupBoxMain.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxMain.Location = new System.Drawing.Point(18, 12);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(776, 241);
            this.groupBoxMain.TabIndex = 11;
            this.groupBoxMain.TabStop = false;
            this.groupBoxMain.Text = "Основные параметры";
            this.toolTipAll.SetToolTip(this.groupBoxMain, "Группа, определяющая основные параметры программы");
            // 
            // numericUpDownAddDays
            // 
            this.numericUpDownAddDays.Location = new System.Drawing.Point(354, 31);
            this.numericUpDownAddDays.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDownAddDays.Name = "numericUpDownAddDays";
            this.numericUpDownAddDays.Size = new System.Drawing.Size(50, 29);
            this.numericUpDownAddDays.TabIndex = 31;
            this.toolTipAll.SetToolTip(this.numericUpDownAddDays, "Укажите количество дней");
            // 
            // numericUpDownPadLeft
            // 
            this.numericUpDownPadLeft.Location = new System.Drawing.Point(212, 125);
            this.numericUpDownPadLeft.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDownPadLeft.Name = "numericUpDownPadLeft";
            this.numericUpDownPadLeft.Size = new System.Drawing.Size(50, 29);
            this.numericUpDownPadLeft.TabIndex = 30;
            this.toolTipAll.SetToolTip(this.numericUpDownPadLeft, "Укажите количествво символов");
            // 
            // labelPadLeft
            // 
            this.labelPadLeft.AutoSize = true;
            this.labelPadLeft.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPadLeft.Location = new System.Drawing.Point(15, 128);
            this.labelPadLeft.Name = "labelPadLeft";
            this.labelPadLeft.Size = new System.Drawing.Size(191, 23);
            this.labelPadLeft.TabIndex = 28;
            this.labelPadLeft.Text = "Количество  чисел  :";
            this.toolTipAll.SetToolTip(this.labelPadLeft, resources.GetString("labelPadLeft.ToolTip"));
            // 
            // textBoxRub
            // 
            this.textBoxRub.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRub.Location = new System.Drawing.Point(308, 76);
            this.textBoxRub.Name = "textBoxRub";
            this.textBoxRub.Size = new System.Drawing.Size(132, 32);
            this.textBoxRub.TabIndex = 27;
            this.toolTipAll.SetToolTip(this.textBoxRub, "Укажите текст, который будет указан  после  сумм в вставке с налогами.");
            // 
            // labelRub
            // 
            this.labelRub.AutoSize = true;
            this.labelRub.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRub.Location = new System.Drawing.Point(209, 81);
            this.labelRub.Name = "labelRub";
            this.labelRub.Size = new System.Drawing.Size(93, 23);
            this.labelRub.TabIndex = 26;
            this.labelRub.Text = "Валюта  :";
            this.toolTipAll.SetToolTip(this.labelRub, "Этот реквизит определяет текст в отношении валюты");
            // 
            // textBoxZPT
            // 
            this.textBoxZPT.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxZPT.Location = new System.Drawing.Point(159, 78);
            this.textBoxZPT.Name = "textBoxZPT";
            this.textBoxZPT.Size = new System.Drawing.Size(32, 32);
            this.textBoxZPT.TabIndex = 25;
            this.toolTipAll.SetToolTip(this.textBoxZPT, "Укажите символы-разделители в суммах");
            // 
            // labelZPT
            // 
            this.labelZPT.AutoSize = true;
            this.labelZPT.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelZPT.Location = new System.Drawing.Point(15, 83);
            this.labelZPT.Name = "labelZPT";
            this.labelZPT.Size = new System.Drawing.Size(134, 23);
            this.labelZPT.TabIndex = 24;
            this.labelZPT.Text = "Разделитель  :";
            this.toolTipAll.SetToolTip(this.labelZPT, "Укажите разделитель для группы в три знака (может быть нескольколько символов). \r" +
        "\nЗатем символ, отделяющий целую часть суммы от дробной.");
            // 
            // textBoxName_File_Out_Template
            // 
            this.textBoxName_File_Out_Template.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName_File_Out_Template.Location = new System.Drawing.Point(19, 197);
            this.textBoxName_File_Out_Template.Name = "textBoxName_File_Out_Template";
            this.textBoxName_File_Out_Template.Size = new System.Drawing.Size(736, 32);
            this.textBoxName_File_Out_Template.TabIndex = 23;
            this.toolTipAll.SetToolTip(this.textBoxName_File_Out_Template, resources.GetString("textBoxName_File_Out_Template.ToolTip"));
            // 
            // labelName_File_Out_Template
            // 
            this.labelName_File_Out_Template.AutoSize = true;
            this.labelName_File_Out_Template.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName_File_Out_Template.Location = new System.Drawing.Point(15, 166);
            this.labelName_File_Out_Template.Name = "labelName_File_Out_Template";
            this.labelName_File_Out_Template.Size = new System.Drawing.Size(247, 23);
            this.labelName_File_Out_Template.TabIndex = 22;
            this.labelName_File_Out_Template.Text = "Шаблон названия файлов :";
            this.toolTipAll.SetToolTip(this.labelName_File_Out_Template, "Это реквизит определяет шаблон для назввания файлов.\r\nВставки определяются аналог" +
        "ично вставкам в файлах-шаблонах.");
            // 
            // textBoxName_Reestr
            // 
            this.textBoxName_Reestr.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName_Reestr.Location = new System.Drawing.Point(418, 122);
            this.textBoxName_Reestr.Name = "textBoxName_Reestr";
            this.textBoxName_Reestr.Size = new System.Drawing.Size(337, 32);
            this.textBoxName_Reestr.TabIndex = 21;
            this.toolTipAll.SetToolTip(this.textBoxName_Reestr, "Укажите путь к реестру налогоплательщиков. %CurrentDirectory% - указывает на теку" +
        "щий каталог.");
            // 
            // labelNameReestr
            // 
            this.labelNameReestr.AutoSize = true;
            this.labelNameReestr.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameReestr.Location = new System.Drawing.Point(274, 127);
            this.labelNameReestr.Name = "labelNameReestr";
            this.labelNameReestr.Size = new System.Drawing.Size(130, 23);
            this.labelNameReestr.TabIndex = 20;
            this.labelNameReestr.Text = "Имя реестра :";
            this.toolTipAll.SetToolTip(this.labelNameReestr, "Имя Excel файла, содержащего список налогоплательщиков с их данными.\r\nПосле нажат" +
        "ии на ярлык Имя реестра, откроется диалог выбора файла.");
            this.labelNameReestr.Click += new System.EventHandler(this.LabelNameReestr_Click);
            this.labelNameReestr.MouseLeave += new System.EventHandler(this.LabelNameReestr_MouseLeave);
            this.labelNameReestr.MouseHover += new System.EventHandler(this.LabelNameReestr_MouseHover);
            // 
            // labelAddDays
            // 
            this.labelAddDays.AutoSize = true;
            this.labelAddDays.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddDays.Location = new System.Drawing.Point(15, 31);
            this.labelAddDays.Name = "labelAddDays";
            this.labelAddDays.Size = new System.Drawing.Size(318, 23);
            this.labelAddDays.TabIndex = 18;
            this.labelAddDays.Text = "Количество дней  к текущей  дате :";
            this.toolTipAll.SetToolTip(this.labelAddDays, "Количество дней, прибавляемых к текущей дате, при формировании даты документа");
            // 
            // labelS_End
            // 
            this.labelS_End.AutoSize = true;
            this.labelS_End.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelS_End.Location = new System.Drawing.Point(624, 83);
            this.labelS_End.Name = "labelS_End";
            this.labelS_End.Size = new System.Drawing.Size(72, 23);
            this.labelS_End.TabIndex = 17;
            this.labelS_End.Text = "конец :";
            this.toolTipAll.SetToolTip(this.labelS_End, "Символ, указывающий на конец вставки ");
            // 
            // labelS_Start
            // 
            this.labelS_Start.AutoSize = true;
            this.labelS_Start.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelS_Start.Location = new System.Drawing.Point(455, 83);
            this.labelS_Start.Name = "labelS_Start";
            this.labelS_Start.Size = new System.Drawing.Size(81, 23);
            this.labelS_Start.TabIndex = 16;
            this.labelS_Start.Text = "начало :";
            this.toolTipAll.SetToolTip(this.labelS_Start, "Символ, указывающий на начало вставки ");
            // 
            // textBoxS_End
            // 
            this.textBoxS_End.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxS_End.Location = new System.Drawing.Point(702, 78);
            this.textBoxS_End.Name = "textBoxS_End";
            this.textBoxS_End.Size = new System.Drawing.Size(53, 32);
            this.textBoxS_End.TabIndex = 15;
            this.toolTipAll.SetToolTip(this.textBoxS_End, "Укажите символ");
            // 
            // textBoxS_Start
            // 
            this.textBoxS_Start.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxS_Start.Location = new System.Drawing.Point(542, 78);
            this.textBoxS_Start.Name = "textBoxS_Start";
            this.textBoxS_Start.Size = new System.Drawing.Size(49, 32);
            this.textBoxS_Start.TabIndex = 14;
            this.toolTipAll.SetToolTip(this.textBoxS_Start, "Укажите символ");
            // 
            // labelRazd
            // 
            this.labelRazd.AutoSize = true;
            this.labelRazd.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRazd.Location = new System.Drawing.Point(448, 31);
            this.labelRazd.Name = "labelRazd";
            this.labelRazd.Size = new System.Drawing.Size(318, 23);
            this.labelRazd.TabIndex = 13;
            this.labelRazd.Text = "Символы, определяющие вставку :";
            this.toolTipAll.SetToolTip(this.labelRazd, "Символы, выделяющие в тексте шаблонов вставки ");
            // 
            // groupBoxDirectory
            // 
            this.groupBoxDirectory.Controls.Add(this.textBoxTemplates);
            this.groupBoxDirectory.Controls.Add(this.textBoxInp);
            this.groupBoxDirectory.Controls.Add(this.labelTemplates);
            this.groupBoxDirectory.Controls.Add(this.labelInp);
            this.groupBoxDirectory.Controls.Add(this.LabelOut);
            this.groupBoxDirectory.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxDirectory.Location = new System.Drawing.Point(18, 276);
            this.groupBoxDirectory.Name = "groupBoxDirectory";
            this.groupBoxDirectory.Size = new System.Drawing.Size(776, 185);
            this.groupBoxDirectory.TabIndex = 12;
            this.groupBoxDirectory.TabStop = false;
            this.groupBoxDirectory.Text = "Каталоги";
            this.toolTipAll.SetToolTip(this.groupBoxDirectory, resources.GetString("groupBoxDirectory.ToolTip"));
            // 
            // textBoxTemplates
            // 
            this.textBoxTemplates.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTemplates.Location = new System.Drawing.Point(159, 139);
            this.textBoxTemplates.Name = "textBoxTemplates";
            this.textBoxTemplates.Size = new System.Drawing.Size(599, 32);
            this.textBoxTemplates.TabIndex = 25;
            this.toolTipAll.SetToolTip(this.textBoxTemplates, "Укажите каталог. %CurrentDirectory% - указывает на текущий каталог.\r\n");
            // 
            // textBoxInp
            // 
            this.textBoxInp.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInp.Location = new System.Drawing.Point(159, 33);
            this.textBoxInp.Name = "textBoxInp";
            this.textBoxInp.Size = new System.Drawing.Size(599, 32);
            this.textBoxInp.TabIndex = 23;
            this.toolTipAll.SetToolTip(this.textBoxInp, "Укажите каталог. %CurrentDirectory% - указывает на текущий каталог.\r\n");
            // 
            // labelTemplates
            // 
            this.labelTemplates.AutoSize = true;
            this.labelTemplates.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTemplates.Location = new System.Drawing.Point(11, 144);
            this.labelTemplates.Name = "labelTemplates";
            this.labelTemplates.Size = new System.Drawing.Size(135, 23);
            this.labelTemplates.TabIndex = 24;
            this.labelTemplates.Text = "С шаблонами:";
            this.toolTipAll.SetToolTip(this.labelTemplates, "Каталог, в котором размещаютя файлы с шаблоном текста.\r\nПосле нажатии на ярлык С " +
        "шаблонами  откроется диалог выбора каталога с шаблонами.\r\n");
            this.labelTemplates.Click += new System.EventHandler(this.LabelTemplates_Click);
            this.labelTemplates.MouseLeave += new System.EventHandler(this.LabelTemplates_MouseLeave);
            this.labelTemplates.MouseHover += new System.EventHandler(this.LabelTemplates_MouseHover);
            // 
            // labelInp
            // 
            this.labelInp.AutoSize = true;
            this.labelInp.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInp.Location = new System.Drawing.Point(11, 39);
            this.labelInp.Name = "labelInp";
            this.labelInp.Size = new System.Drawing.Size(108, 23);
            this.labelInp.TabIndex = 22;
            this.labelInp.Text = "Входящий:";
            this.toolTipAll.SetToolTip(this.labelInp, "Входящий каталог, в нем размещаются Excel-файлы с даннымм по налогам.\r\nПосле нажа" +
        "тии на ярлык Входящий  откроется диалог выбора входящего каталога.");
            this.labelInp.Click += new System.EventHandler(this.LabelInp_Click);
            this.labelInp.MouseLeave += new System.EventHandler(this.LabelInp_MouseLeave);
            this.labelInp.MouseHover += new System.EventHandler(this.LabelInp_MouseHover);
            // 
            // LabelOut
            // 
            this.LabelOut.AutoSize = true;
            this.LabelOut.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelOut.Location = new System.Drawing.Point(11, 89);
            this.LabelOut.Name = "LabelOut";
            this.LabelOut.Size = new System.Drawing.Size(118, 23);
            this.LabelOut.TabIndex = 22;
            this.LabelOut.Text = "Исходящий:";
            this.toolTipAll.SetToolTip(this.LabelOut, "Каталог, в который будут сформирваны исходящие файлы.\r\nПосле нажатии на ярлык Исх" +
        "одящий  откроется диалог выбора исходящего  каталога.\r\n");
            this.LabelOut.Click += new System.EventHandler(this.LabelOut_Click);
            this.LabelOut.MouseLeave += new System.EventHandler(this.LabelOut_MouseLeave);
            this.LabelOut.MouseHover += new System.EventHandler(this.LabelOut_MouseHover);
            // 
            // textBoxOut
            // 
            this.textBoxOut.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOut.Location = new System.Drawing.Point(177, 362);
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.Size = new System.Drawing.Size(599, 32);
            this.textBoxOut.TabIndex = 23;
            this.toolTipAll.SetToolTip(this.textBoxOut, "Укажите каталог. %CurrentDirectory% - указывает на текущий каталог.\r\n\r\n");
            // 
            // groupBoxDesk
            // 
            this.groupBoxDesk.Controls.Add(this.listViewDesk);
            this.groupBoxDesk.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxDesk.Location = new System.Drawing.Point(816, 12);
            this.groupBoxDesk.Name = "groupBoxDesk";
            this.groupBoxDesk.Size = new System.Drawing.Size(462, 241);
            this.groupBoxDesk.TabIndex = 24;
            this.groupBoxDesk.TabStop = false;
            this.groupBoxDesk.Text = "Судебные участки";
            this.toolTipAll.SetToolTip(this.groupBoxDesk, "Описание судебных участков и вставок по ним в шаблонах");
            // 
            // listViewDesk
            // 
            this.listViewDesk.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNum,
            this.columnHeaderFIO});
            this.listViewDesk.ContextMenuStrip = this.contextMenuStripDesk;
            this.listViewDesk.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewDesk.FullRowSelect = true;
            this.listViewDesk.GridLines = true;
            this.listViewDesk.HideSelection = false;
            this.listViewDesk.Location = new System.Drawing.Point(6, 19);
            this.listViewDesk.MultiSelect = false;
            this.listViewDesk.Name = "listViewDesk";
            this.listViewDesk.ShowGroups = false;
            this.listViewDesk.ShowItemToolTips = true;
            this.listViewDesk.Size = new System.Drawing.Size(450, 213);
            this.listViewDesk.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewDesk.TabIndex = 0;
            this.toolTipAll.SetToolTip(this.listViewDesk, "Редактировать таблицу возможно с помощью контексного меню.\r\nКлаиш DEL (Удаление) " +
        "или INS (Добавить).\r\nКлавиша Enter или жвойной клик - корректировка текущей запи" +
        "си.");
            this.listViewDesk.UseCompatibleStateImageBehavior = false;
            this.listViewDesk.View = System.Windows.Forms.View.Details;
            this.listViewDesk.DoubleClick += new System.EventHandler(this.ListViewDesk_DoubleClick);
            this.listViewDesk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListViewDesk_KeyDown);
            // 
            // columnHeaderNum
            // 
            this.columnHeaderNum.Text = "Номер участка";
            this.columnHeaderNum.Width = 145;
            // 
            // columnHeaderFIO
            // 
            this.columnHeaderFIO.Text = "Ф.И.О. Судьи";
            this.columnHeaderFIO.Width = 262;
            // 
            // contextMenuStripDesk
            // 
            this.contextMenuStripDesk.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeskToolStripMenuItemEdit,
            this.DeskToolStripMenuItemDel,
            this.DeskToolStripMenuItemAdd});
            this.contextMenuStripDesk.Name = "contextMenuStrip1";
            this.contextMenuStripDesk.Size = new System.Drawing.Size(148, 70);
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
            this.DeskToolStripMenuItemDel.Click += new System.EventHandler(this.DeskToolStripMenuItemDel_Click);
            // 
            // DeskToolStripMenuItemAdd
            // 
            this.DeskToolStripMenuItemAdd.Name = "DeskToolStripMenuItemAdd";
            this.DeskToolStripMenuItemAdd.ShowShortcutKeys = false;
            this.DeskToolStripMenuItemAdd.Size = new System.Drawing.Size(147, 22);
            this.DeskToolStripMenuItemAdd.Text = "Добавить";
            this.DeskToolStripMenuItemAdd.Click += new System.EventHandler(this.DeskToolStripMenuItemAdd_Click);
            // 
            // groupBoxDoc
            // 
            this.groupBoxDoc.Controls.Add(this.listViewDocTemplate);
            this.groupBoxDoc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxDoc.Location = new System.Drawing.Point(816, 276);
            this.groupBoxDoc.Name = "groupBoxDoc";
            this.groupBoxDoc.Size = new System.Drawing.Size(462, 185);
            this.groupBoxDoc.TabIndex = 25;
            this.groupBoxDoc.TabStop = false;
            this.groupBoxDoc.Text = "Шаблоны документов";
            this.toolTipAll.SetToolTip(this.groupBoxDoc, "Описание шаблонов документов и их размещения.");
            // 
            // listViewDocTemplate
            // 
            this.listViewDocTemplate.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCode,
            this.columnHeaderName,
            this.columnHeaderTemplate,
            this.columnHeaderPrefix,
            this.columnHeaderPostfix});
            this.listViewDocTemplate.ContextMenuStrip = this.contextMenuStripDoc;
            this.listViewDocTemplate.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewDocTemplate.FullRowSelect = true;
            this.listViewDocTemplate.GridLines = true;
            this.listViewDocTemplate.HideSelection = false;
            this.listViewDocTemplate.Location = new System.Drawing.Point(6, 19);
            this.listViewDocTemplate.MultiSelect = false;
            this.listViewDocTemplate.Name = "listViewDocTemplate";
            this.listViewDocTemplate.Size = new System.Drawing.Size(450, 151);
            this.listViewDocTemplate.TabIndex = 0;
            this.toolTipAll.SetToolTip(this.listViewDocTemplate, "Редактировать таблицу возможно с помощью контексного меню.\r\nКлаиш DEL (Удаление) " +
        "или INS (Добавить).\r\nКлавиша Enter или жвойной клик - корректировка текущей запи" +
        "си.");
            this.listViewDocTemplate.UseCompatibleStateImageBehavior = false;
            this.listViewDocTemplate.View = System.Windows.Forms.View.Details;
            this.listViewDocTemplate.DoubleClick += new System.EventHandler(this.ListViewDocTemplate_DoubleClick);
            this.listViewDocTemplate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListViewDocTemplate_KeyDown);
            // 
            // columnHeaderCode
            // 
            this.columnHeaderCode.Text = "Код";
            this.columnHeaderCode.Width = 142;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Наименование шаблона";
            this.columnHeaderName.Width = 270;
            // 
            // columnHeaderTemplate
            // 
            this.columnHeaderTemplate.Text = "Шаблон";
            this.columnHeaderTemplate.Width = 0;
            // 
            // columnHeaderPrefix
            // 
            this.columnHeaderPrefix.Text = "Перфикс";
            this.columnHeaderPrefix.Width = 0;
            // 
            // columnHeaderPostfix
            // 
            this.columnHeaderPostfix.Text = "Постфикс";
            this.columnHeaderPostfix.Width = 0;
            // 
            // contextMenuStripDoc
            // 
            this.contextMenuStripDoc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DocStripMenuItemEdit,
            this.DocStripMenuItemDel,
            this.DoclStripMenuItemAdd});
            this.contextMenuStripDoc.Name = "contextMenuStrip1";
            this.contextMenuStripDoc.Size = new System.Drawing.Size(148, 70);
            // 
            // DocStripMenuItemEdit
            // 
            this.DocStripMenuItemEdit.Name = "DocStripMenuItemEdit";
            this.DocStripMenuItemEdit.ShowShortcutKeys = false;
            this.DocStripMenuItemEdit.Size = new System.Drawing.Size(147, 22);
            this.DocStripMenuItemEdit.Text = "Редактировать";
            this.DocStripMenuItemEdit.Click += new System.EventHandler(this.DocStripMenuItemEdit_Click);
            // 
            // DocStripMenuItemDel
            // 
            this.DocStripMenuItemDel.Name = "DocStripMenuItemDel";
            this.DocStripMenuItemDel.ShowShortcutKeys = false;
            this.DocStripMenuItemDel.Size = new System.Drawing.Size(147, 22);
            this.DocStripMenuItemDel.Text = "Удалить";
            this.DocStripMenuItemDel.Click += new System.EventHandler(this.DocStripMenuItemDel_Click);
            // 
            // DoclStripMenuItemAdd
            // 
            this.DoclStripMenuItemAdd.Name = "DoclStripMenuItemAdd";
            this.DoclStripMenuItemAdd.ShowShortcutKeys = false;
            this.DoclStripMenuItemAdd.Size = new System.Drawing.Size(147, 22);
            this.DoclStripMenuItemAdd.Text = "Добавить";
            this.DoclStripMenuItemAdd.Click += new System.EventHandler(this.DoclStripMenuItemAdd_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Image = global::SUD_PRIKAZ_PRINT.Properties.Resources.check_ok;
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSave.Location = new System.Drawing.Point(832, 493);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(440, 60);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Сохранить";
            this.toolTipAll.SetToolTip(this.buttonSave, "Подтверждение сохранения введенных данных");
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Image = global::SUD_PRIKAZ_PRINT.Properties.Resources.Cancel;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(18, 493);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(440, 60);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Отмена";
            this.toolTipAll.SetToolTip(this.buttonCancel, "Отмена сохранения введенных данных");
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // toolTipAll
            // 
            this.toolTipAll.AutomaticDelay = 500000;
            this.toolTipAll.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipAll.ToolTipTitle = "Информация :";
            // 
            // FormConfigurate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(1290, 567);
            this.Controls.Add(this.groupBoxDoc);
            this.Controls.Add(this.groupBoxDesk);
            this.Controls.Add(this.textBoxOut);
            this.Controls.Add(this.groupBoxDirectory);
            this.Controls.Add(this.groupBoxMain);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConfigurate";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройка конфигурации";
            this.groupBoxMain.ResumeLayout(false);
            this.groupBoxMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPadLeft)).EndInit();
            this.groupBoxDirectory.ResumeLayout(false);
            this.groupBoxDirectory.PerformLayout();
            this.groupBoxDesk.ResumeLayout(false);
            this.contextMenuStripDesk.ResumeLayout(false);
            this.groupBoxDoc.ResumeLayout(false);
            this.contextMenuStripDoc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBoxMain;
        private System.Windows.Forms.Label labelAddDays;
        private System.Windows.Forms.Label labelS_End;
        private System.Windows.Forms.Label labelS_Start;
        private System.Windows.Forms.TextBox textBoxS_End;
        private System.Windows.Forms.TextBox textBoxS_Start;
        private System.Windows.Forms.Label labelRazd;
        private System.Windows.Forms.TextBox textBoxName_File_Out_Template;
        private System.Windows.Forms.Label labelName_File_Out_Template;
        private System.Windows.Forms.TextBox textBoxName_Reestr;
        private System.Windows.Forms.Label labelNameReestr;
        private System.Windows.Forms.GroupBox groupBoxDirectory;
        private System.Windows.Forms.TextBox textBoxTemplates;
        private System.Windows.Forms.TextBox textBoxInp;
        private System.Windows.Forms.Label labelTemplates;
        private System.Windows.Forms.Label labelInp;
        private System.Windows.Forms.TextBox textBoxOut;
        private System.Windows.Forms.Label LabelOut;
        private System.Windows.Forms.GroupBox groupBoxDesk;
        private System.Windows.Forms.ColumnHeader columnHeaderNum;
        private System.Windows.Forms.ColumnHeader columnHeaderFIO;
        private System.Windows.Forms.GroupBox groupBoxDoc;
        private System.Windows.Forms.ColumnHeader columnHeaderCode;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDesk;
        private System.Windows.Forms.ToolStripMenuItem DeskToolStripMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem DeskToolStripMenuItemDel;
        private System.Windows.Forms.ToolStripMenuItem DeskToolStripMenuItemAdd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDoc;
        private System.Windows.Forms.ToolStripMenuItem DocStripMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem DocStripMenuItemDel;
        private System.Windows.Forms.ToolStripMenuItem DoclStripMenuItemAdd;
        public System.Windows.Forms.ListView listViewDesk;
        public System.Windows.Forms.ListView listViewDocTemplate;
        private System.Windows.Forms.ColumnHeader columnHeaderPrefix;
        private System.Windows.Forms.ColumnHeader columnHeaderPostfix;
        private System.Windows.Forms.ColumnHeader columnHeaderTemplate;
        private System.Windows.Forms.TextBox textBoxZPT;
        private System.Windows.Forms.Label labelZPT;
        private System.Windows.Forms.TextBox textBoxRub;
        private System.Windows.Forms.Label labelRub;
        private System.Windows.Forms.ToolTip toolTipAll;
        private System.Windows.Forms.Label labelPadLeft;
        private System.Windows.Forms.NumericUpDown numericUpDownPadLeft;
        private System.Windows.Forms.NumericUpDown numericUpDownAddDays;
    }
}