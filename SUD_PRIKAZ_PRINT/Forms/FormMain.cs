using System;
using System.Windows.Forms;


namespace SUD_PRIKAZ_PRINT
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();

            this.Visible = !Program.App_WithoutWindow;
            this.ButtonConfig.Visible = Program.App_Key_Config;

        }


        private void Start_Process()
        {

            if (this.Exist_All_Dir())
            {

                Static_StatusStripMessage("Процесс запущен.");
                this.ButtonStart.Text = "Стоп";
                this.toolTipAll.SetToolTip(this.ButtonStart, "Нажатием Стоп - останавливаем процесс формирования файлов.");
                this.StartMake();
                if (this.Mark_Execution)
                {
                    this.ButtonStart.Text = "Стоп";
                    this.toolTipAll.SetToolTip(this.ButtonStart, "Нажатием Стоп - останавливаем процесс формирования файлов.");
                }
                    else
                        {
                            this.ButtonStart.Text = "Старт";
                            this.toolTipAll.SetToolTip(this.ButtonStart, "Нажатием Старт - запускаем процесс формирования файлов.");
                        }

                //    Static_StatusStripMessage("Процесс завершен."); 

            }
        }

        public static void Static_StatusStripMessage(string _Message)
        {
            if (!Program.App_WithoutWindow)
            {


                //((FormMain)System.Windows.Forms.Application.OpenForms["FormMain"]).statusStrip.Items.Clear();
                if (System.Windows.Forms.Application.OpenForms["FormMain"] != null)
                {
                    ((FormMain)System.Windows.Forms.Application.OpenForms["FormMain"]).statusStrip.Items[0].Text = _Message;

                    
                }
            }
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {

            if (this.Mark_Execution)
            {
                this.Abort_Process();
            }
            else
            {
                this.toolStripProgressBar.Visible = true;
                this.Start_Process();
            }
           
        }

        private void ButtonConfig_Click(object sender, EventArgs e)
        {
            if (!this.Mark_Execution) this.Start_Configuration();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {

            this.SaveValueNumber_Uch();

        }

        private void FormMain_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {

            this.Start_About();
           
        }



        
        private void DomainUpDownUch_TextChanged(object sender, EventArgs e)
        {
            if (this.DomainUpDownUch.Text.Length > 0 && this.DomainUpDownUch.Text != "0"
                && !this.deskSud.ContainsKey(this.DomainUpDownUch.Text))
                MessageBox.Show("Проверьте номер участка", "Ошибка ввода. ");
            else

                this.Number_Uch_Default = this.DomainUpDownUch.Text;           
        }


       
        private void FormMain_Load(object sender, EventArgs e)
        {

            this.Open_Configuration(Program.Path_Ini_File);
            this.LoadValue();


            Static_StatusStripMessage("Данные конфигурации загружены. Программа готова к выполнению задания.");
            if (!Program.App_WithoutWindow) this.Activate();

            if (Program.App_Key_Run)
            {
                Start_Process();
                
                if (Program.App_WithoutWindow) this.Close();
            }
            this.Focus();
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.F1:
                    if (this.Mark_Execution == false)
                        this.Start_About();
                    break;

                case Keys.F2:
                    if (this.Mark_Execution == false)
                        this.Start_Configuration();
                    break;


                case Keys.Escape:
                    Abort_Process();
                    break;

            }
            
        }

        private void Start_Configuration()
        {
            DialogResult _Dr;
            using (FormConfigurate _FC = new FormConfigurate())
            {
                _Dr = _FC.ShowDialog();

            }

            if (_Dr == DialogResult.OK) this.SaveValue();
        }

        private void Start_About()
        {
            this.Cursor = Cursors.Arrow;
            using (AboutBox helpAbout = new AboutBox())
            {
                helpAbout.ShowDialog();
            }
        }


        private bool Abort_Process(string _Message= "Прервать процесc ?", MessageBoxButtons _Button = MessageBoxButtons.YesNo)
            {
            DialogResult _DialogResult;
            bool _ret = false;
            this.toolStripProgressBar.Visible = false;
            if (this.Mark_Execution == false)
            {
                this.Visible = false;
                this.Close();
            }
            else
            {

                _DialogResult = MessageBox.Show(_Message, "Запрос остановки процесса", _Button, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (_DialogResult == DialogResult.Yes || _DialogResult == DialogResult.Cancel)
                {

                    this.Mark_Execution = false;
                    this.ButtonStart.Text = "Старт";
                    this.toolTipAll.SetToolTip(this.ButtonStart, "Нажатием Старт - запускаем процесс формирования файлов.");
                    _ret = _DialogResult == DialogResult.Yes;
                }
                
            }

            this.toolStripProgressBar.Visible = this.Mark_Execution;
            return _ret;

        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Mark_Execution == false) e.Cancel = false;
            else
            {
                e.Cancel = ! Abort_Process("Прервать процесc и закрыть программу ?\t\nЕсли Отмена - только остановить процесс." ,MessageBoxButtons.YesNoCancel);
                //e.Cancel = this.Mark_Execution;
            }
                        
        }

        
    }
}
