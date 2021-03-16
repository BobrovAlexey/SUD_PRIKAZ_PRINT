using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;
using Configuration_Files;
using System.Drawing;

namespace SUD_PRIKAZ_PRINT
{


    // Класс шаблона выходного файла 
    public class FileForPrintOut
    {

        private FormMain ParentFormMain
        {

            get { return ((FormMain)System.Windows.Forms.Application.OpenForms["FormMain"]); }
        }


        public string NameFileOutput;
        public string TypeFile = "";
        public string NameFileTemlate; // Путь к шаблону из .ini
        public string NameFileNormalize
        { get { return this.ParentFormMain.Fortmating_Directory(this.NameFileTemlate); } }

        public string Prefix;//Префикс названия файла 
        public string Postfix;//Постфикс названия файла 

                       
        public FileForPrintOut(string _TypeFile, string _Name_File_Output)
        {
            this.NameFileOutput = _Name_File_Output;
            this.TypeFile = _TypeFile;

        }

       
    }
    public partial class FormMain : Form
    {



        public bool Error_During_Execution;
        public bool Mark_Execution = false;
        private INIManager managerOfConfiguration;
        // переменная ссылка на текущий каталог             
        public string CurrentDirectory
        {
            get { return String.IsNullOrEmpty (Program.App_Key_CurrentDirectory) ?  
                    Application.StartupPath : Program.App_Key_CurrentDirectory; }
            set { }
        }

        // Описания символов для отделения вставок
        public string Sym_Start   // начало вставки
        {
            get { return (this.managerOfConfiguration.Read_Value("MAIN", "S_Start")); }
            set { this.managerOfConfiguration.Write_Value("MAIN", "S_Start", value); }
        }

        public string Sym_End   // конец вставки
        {
            get { return (this.managerOfConfiguration.Read_Value("MAIN", "S_End")); }
            set { this.managerOfConfiguration.Write_Value("MAIN", "S_End", value); }
        }

        public byte AddDays   // Количество дней к текущей дате 
        {
            get { return (this.managerOfConfiguration.Read_Value_Byte("MAIN", "AddDays")); }
            set { this.managerOfConfiguration.Write_Value("MAIN", "AddDays", value.ToString()); }
        }

        public string Number_Uch_Default   // Номер участкаа пол умолчанию
        {
            get { return (this.managerOfConfiguration.Read_Value("MAIN", "Number_Uch_Default")); }
            set { this.managerOfConfiguration.Write_Value("MAIN", "Number_Uch_Default", value.ToString()); }
        }

        public string Name_File_Reestr // Имя файла реестра

        {
            get { return (this.managerOfConfiguration.Read_Value("MAIN", "NAME_FILE_REESTR")); }
            set { this.managerOfConfiguration.Write_Value("MAIN", "NAME_FILE_REESTR", value.ToString()); }
        }

        public string Name_File_Out_Template // Описание шаблона названия выходных файлов

        {
            get { return (this.managerOfConfiguration.Read_Value("MAIN", "NAME_FILE_OUT_TEMPLATE")); }
            set { this.managerOfConfiguration.Write_Value("MAIN", "NAME_FILE_OUT_TEMPLATE", value.ToString()); }
        }


        public string Valuta // Описание шаблона названия выходных файлов

        {
            get { return (this.managerOfConfiguration.Read_Value("MAIN", "VALUTA")); }
            set { this.managerOfConfiguration.Write_Value("MAIN", "VALUTA", value.ToString()); }
        }

        // Separator - Если >1 символа,  то первые символы ращделитель между тремя знаками (тысячи, милионы)
        // Последний символ разделитеь дробной части
        // ПРробел при записи иссправляется на _, при чтении обратно в пробел
        // Если символ один - между тремя симолами разделителя не будет
        public string Separator // Разделитель целой и дробной части 

        {
            get { return (this.managerOfConfiguration.Read_Value("MAIN", "SEPARATOR").Replace("_", " ")); }
            set { this.managerOfConfiguration.Write_Value("MAIN", "SEPARATOR", value.ToString().Replace(" ","_") ); }
        }

        // Если Count_PadL = 0 суммы будут выравнены по правому краю 
        public byte Count_PadL  // Количество пробелов слева для выравниваания сумм по правому краю

        {
            get { return (this.managerOfConfiguration.Read_Value_Byte("MAIN", "COUNT_PADL")); }
            set { this.managerOfConfiguration.Write_Value("MAIN", "COUNT_PADL", value.ToString()); }
        }

        public string Directory_Inp  // Каталог с входящими файлами
        {
            get { return (this.managerOfConfiguration.Read_Value("DIRECTORY", "INP")); }
            set { this.managerOfConfiguration.Write_Value("DIRECTORY", "inp", value.ToString()); }
        }
        public string Directory_Out // Каталог с исходящими файлами
        {
            get { return (this.managerOfConfiguration.Read_Value("DIRECTORY", "OUT")); }
            set { this.managerOfConfiguration.Write_Value("DIRECTORY", "out", value.ToString()); }
        }
        public string Directory_Tempalates // Каталог с шаблонами
        {
            get { return (this.managerOfConfiguration.Read_Value("DIRECTORY", "TEMPLATES")); }
            set { this.managerOfConfiguration.Write_Value("DIRECTORY", "TEMPLATES", value.ToString()); }
        }




        //объекты Excel и Word
        public  Excel.ApplicationClass AppXL = null;
        public  Word.ApplicationClass AppWD = null;

        public Dictionary<string, string> deskSud; // Описание судебных участков 
        public List<FileForPrintOut> List_FileTemplateOut;

        // загрузка списовых параметров
        private void LoadValue()
        {
            
            
            this.deskSud = new Dictionary<string, string>();
            this.deskSud = this.managerOfConfiguration.GetKeys("DESK");
                      
            this.LoadDiscriptionFileOut();
            this.LoadDiscriptionFilePaste();
        }


        // загрузка описания шаблонов
        private void LoadDiscriptionFileOut()
        {
            Dictionary<string, string> _L = this.managerOfConfiguration.GetKeys("FILE_OUT");

            if (this.List_FileTemplateOut == null)
            {
                this.List_FileTemplateOut = new List<FileForPrintOut>();
            }
            else this.List_FileTemplateOut.Clear();
            if (_L.Count > 0)
            {
                
                foreach (string _R_Key in _L.Keys)
                {
                    FileForPrintOut _item = new FileForPrintOut(_R_Key, _L[_R_Key])
                        {
                            NameFileTemlate = this.managerOfConfiguration.Read_Value(_R_Key, "NAMEFILETEMPLATE").ToUpper(),
                            Prefix = this.managerOfConfiguration.Read_Value(_R_Key, "PREFIX").ToUpper(),
                            Postfix = this.managerOfConfiguration.Read_Value(_R_Key, "POSTFIX").ToUpper()
                    };
                    //_item.NameFileNormalize = this.Fortmating_Directory(_item.NameFileTemlate);
                    this.List_FileTemplateOut.Add(_item);

                }
            }


                        
        }


        public void LoadDiscriptionFilePaste()
        {
           object _Current ;
            int _Cur_Index;
            this.DomainUpDownUch.Items.Clear();
            this.DomainUpDownUch.Items.Add("0");
            _Current = this.DomainUpDownUch.Items[0];

            Dictionary<string, string> _L =  this.deskSud;
            if (this.ListDeskPaste == null)
            {
                this.ListDeskPaste = new Dictionary<string, Array_Element_Paste>();
            }
            else this.ListDeskPaste.Clear();

            if (_L.Count > 0)
            {
                
                
                if (String.IsNullOrEmpty(this.Number_Uch_Default) && this.Number_Uch_Default != "0"
                 && !this.deskSud.ContainsKey(this.Number_Uch_Default)) this.Number_Uch_Default = "0";
                foreach (string _R_Key in _L.Keys)
                {

                    _Cur_Index=this.DomainUpDownUch.Items.Add(_R_Key);
                    if (_R_Key == this.Number_Uch_Default) 
                       _Current = this.DomainUpDownUch.Items[_Cur_Index];
                    
                    Dictionary<string, string> _L_ONE = this.managerOfConfiguration.GetKeys("DESK"+_R_Key);
                    Array_Element_Paste _Add_L_One = new Array_Element_Paste(_L_ONE.Count);
                    _Add_L_One.AddFromDictionary(ref _L_ONE);


                    this.ListDeskPaste.Add(_R_Key, _Add_L_One);
                    

                }
                
                this.DomainUpDownUch.Items.Reverse();

                this.DomainUpDownUch.SelectedItem = _Current;

                this.Number_Uch_Default = this.DomainUpDownUch.Text;
                //this.DomainUpDownUch.Refresh();


            }



        }


        // Сохранение в .ini перед завершением

        private void SaveValueNumber_Uch()
        {
            if (String.IsNullOrEmpty(this.DomainUpDownUch.Text) && this.DomainUpDownUch.Text != "0"
            && !this.deskSud.ContainsKey(this.DomainUpDownUch.Text)) this.DomainUpDownUch.Text = "0";
            this.Number_Uch_Default = this.DomainUpDownUch.Text;
        }
            private void SaveValue()
        {
            if (String.IsNullOrEmpty(this.DomainUpDownUch.Text) && this.DomainUpDownUch.Text != "0"
            && !this.deskSud.ContainsKey(this.DomainUpDownUch.Text)) this.DomainUpDownUch.Text = "0";
            this.Number_Uch_Default = this.DomainUpDownUch.Text;

            
            this.managerOfConfiguration.DeleteSection("DESK");
            foreach (string _deskKey in this.deskSud.Keys)
            {
                this.managerOfConfiguration.Write_Value("DESK", _deskKey, this.deskSud[_deskKey]);

                for(int _pasteKey = 0; _pasteKey < this.ListDeskPaste[_deskKey].Count; _pasteKey++)
                    this.managerOfConfiguration.Write_Value("DESK"+_deskKey, this.ListDeskPaste[_deskKey][_pasteKey].Name, this.ListDeskPaste[_deskKey][_pasteKey].Value);

            }
                        
            this.managerOfConfiguration.DeleteSection("FILE_OUT");
            if (this.List_FileTemplateOut != null)
            {
                this.List_FileTemplateOut.ForEach(x =>
                   {
                       this.managerOfConfiguration.Write_Value("FILE_OUT", x.TypeFile, x.NameFileOutput);
                       this.managerOfConfiguration.Write_Value(x.TypeFile, "NAMEFILETEMPLATE", x.NameFileTemlate.ToUpper());
                       this.managerOfConfiguration.Write_Value(x.TypeFile, "PREFIX", x.Prefix.ToUpper());
                       this.managerOfConfiguration.Write_Value(x.TypeFile, "POSTFIX", x.Postfix.ToUpper());
                   }

                   );

            }
                        
        }

        // Открытие конфигурвции
        private void Open_Configuration(string _name = null)
        {
            // В каталогк с программой
            if (String.IsNullOrEmpty (_name)) _name = 
                    Application.ExecutablePath.ToUpper().Replace(".EXE", ".INI");


            //Создание объекта, для работы с конфигурационным файлом 
            try
            {
                managerOfConfiguration = new INIManager(_name);
            }
            catch (Exception _exp)
            {
                MessageBox.Show(_exp.Message.ToString(), "Ошибка открытия конфигурационного файла", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        // Форматирование строки квталога  


        public static string OpenDialogFile(string _InitialDirectory = null,
            string _Filter = "Все файлы (*.*)|*.*", string _Description = null)
        {
            string _ret = null;
            
            if (_InitialDirectory == null)
                _InitialDirectory = ((FormMain)Application.OpenForms["FormMain"]).CurrentDirectory;
            
            if (_Description == null) _Description = "Выбор файла";

            using (OpenFileDialog _FD = new OpenFileDialog())
            {

                _FD.CheckFileExists = false;
                _FD.CheckPathExists = false;
                _FD.ReadOnlyChecked = false;
                _FD.InitialDirectory = _InitialDirectory;
                _FD.FileName = _InitialDirectory;
                _FD.Filter = _Filter;
                _FD.FilterIndex = 1;
                _FD.RestoreDirectory = true;
                _FD.ShowReadOnly = true;
                _FD.Multiselect = false;
                _FD.Title = _Description;

                if (_FD.ShowDialog() == DialogResult.OK)
                {
                    _ret = _FD.FileName;
                }
            }
            return _ret;

        }

        public static string OpenDialogDirectory(string _InitialDirectory = null, string _Description = null)
        {
            string _ret = null;
            if (_InitialDirectory == null)
                _InitialDirectory = ((FormMain)Application.OpenForms["FormMain"]).CurrentDirectory;

            if (_Description == null)  _Description = "Выбор каталога";
            
            using (FolderBrowserDialog _FD = new FolderBrowserDialog())
            {

                _FD.SelectedPath = _InitialDirectory;
                                
                _FD.Description = _Description;

                if (_FD.ShowDialog() == DialogResult.OK)
                {
                    _ret = _FD.SelectedPath;
                }
            }
            return _ret;

        }


        public static string InitalFile(string _InitialDirectory = null, bool _currentdirectoryonly = true)
        {
            string _ret = _InitialDirectory.ToLower().Trim();
            _ret = _ret.Replace(((FormMain)Application.OpenForms["FormMain"]).CurrentDirectory.ToLower().Trim(), "%currentdirectory%");
            if (_currentdirectoryonly == false)
            {
                _ret = _ret.Replace(
                    ((FormMain)Application.OpenForms["FormMain"]).Directory_Inp.ToLower().Trim(), "%inpdirectory%");
                _ret = _ret.Replace(((FormMain)Application.OpenForms["FormMain"]).Directory_Out.ToLower().Trim(), "%outdirectory%");
                _ret = _ret.Replace(((FormMain)Application.OpenForms["FormMain"]).Directory_Tempalates.ToLower().Trim(), "%templatesdirectory%");
            }
            _ret = _ret.Replace("%currentdirectory%", "%CurrentDirectory%");
            _ret = _ret.Replace("%inpdirectory%", "%InpDirectory%");
            _ret = _ret.Replace("%outdirectory%", "%OutDirectory%");
            _ret = _ret.Replace("%templatesdirectory%", "%TemplatesDirectory%");
            return _ret;

        }

        public string Fortmating_Directory(string _Dir, bool _pr = false)
        {
            string _result = _Dir.ToUpper();

            _result = _result.Replace("%INPDIRECORY%", this.Directory_Inp.ToUpper());
            _result = _result.Replace("%OUTDIRECTORY%", this.Directory_Out.ToUpper());
            _result = _result.Replace("%TEMPLATESDIRECTORY%", this.Directory_Tempalates.ToUpper());
            _result = _result.Replace("%CURRENTDIRECTORY%", this.CurrentDirectory.ToUpper());
            if (_pr == true)
             { 
            _result = _result.Replace("{", "_");
            _result = _result.Replace("}", "_");
            _result = _result.Replace("-", "_");
            _result = _result.Replace(".", "_");
            _result = _result.Replace("/", "_");
            _result = _result.Replace("\\", "_");
            _result = _result.Replace("%", "_");
            _result = _result.Replace(";", "_");
            _result = _result.Replace(".", "_");
            _result = _result.Replace("_DOC", ".DOC");
            _result = _result.Replace("_doc", ".doc");
            _result = _result.Replace("_DOCX", ".DOCX");
            _result = _result.Replace("_docx", ".docx");
            }
            return _result;
        }

        private bool Exist_One_Dir (string _Dir,string _Name, bool _Directory = true)
        {
            bool _ret;
            _Name = this.Fortmating_Directory(_Name);
            _ret =  _Directory ?  Directory.Exists(_Name) : File.Exists(_Name);
            if (_ret == false)
            {
                Mark_Execution = false;
                this.toolStripProgressBar.Visible = this.Mark_Execution;
                MessageBox.Show("Проверьте пожалуйста, отсутвует путь: " + _Name, "Проверка реквизита " + _Dir, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Static_StatusStripMessage(_Dir + " - отсутвует путь: " + _Name );
            }
            return _ret;

        }
        private bool Exist_All_Dir()
        {
            Static_StatusStripMessage("Выполняется проверка путей к каталогам и файлам  . . .");
            bool _ret = true,_ret_Templates;

            _ret &= Exist_One_Dir("Водящий каталог (Directory,Inp)", this.Directory_Inp);
            _ret &= Exist_One_Dir("Исходящий каталог (Directory,Out)", this.Directory_Out);
            _ret_Templates = Exist_One_Dir("Каталог с шаблонами (Directory,Templates)", this.Directory_Tempalates);
            _ret &= _ret_Templates;
            _ret &= Exist_One_Dir("Файл реестра (Name_File_Reestr)", this.Name_File_Reestr,false);
            if (_ret_Templates)
            {
                for (int _i = 0; _i < this.List_FileTemplateOut.Count; _i++)
                {
                    _ret &= Exist_One_Dir("Файл шаблона " + this.List_FileTemplateOut[_i].NameFileOutput,
                        this.List_FileTemplateOut[_i].NameFileTemlate, false);
                }
            }
            if ( _ret )
                Static_StatusStripMessage("Проверка путей к каталогам и файлам  выполнена. Доступ к каталогам и файлам есть");
            return _ret;
        }

        private void DoEventsWithShow (string _Message_Abort, string _Message_Ok = null)
        {
            Application.DoEvents();

            if (this.Mark_Execution)
            {
                if (_Message_Ok != null)  Static_StatusStripMessage(_Message_Ok);
                
            }
            else  Static_StatusStripMessage(_Message_Abort);
           

        }
            private void StartMake()
        {
            Static_StatusStripMessage("Процесс запущен. Выполняется полключение  Word и Excel   . . .");
           
            this.Mark_Execution = true;
            this.Error_During_Execution = false;
            this.progressBarFile.Style = ProgressBarStyle.Blocks;
            this.progressBarFile.Value = 0;
            this.progressBarFile.Step = 1;
            this.labelProcent.Text = "0 %";
            this.progressBarFile.Refresh();
            this.labelProcent.BackColor = this.progressBarFile.BackColor;
            this.labelProcent.Refresh();
            try
            {
                this.AppXL = new Excel.ApplicationClass() { Visible = false };
                this.AppWD = new Word.ApplicationClass() { Visible = false };
                
            }
            catch (Exception _exp)
            {
                this.Error_During_Execution = true;
                this.Mark_Execution = false;
                MessageBox.Show(_exp.Message.ToString(), "Ошибка открытия  Microsof Office",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (this.AppXL != null && this.AppXL.Application != null) this.AppXL.Quit();
                this.AppXL = null;

                if (this.AppWD != null && this.AppWD.Application != null)
                    this.AppWD.Quit(Word.WdSaveOptions.wdDoNotSaveChanges, Word.WdOriginalFormat.wdOriginalDocumentFormat);
                this.AppWD = null;
                this.toolStripProgressBar.Visible = this.Mark_Execution;


            }



            DoEventsWithShow("Процесс формирования файлов прерван.", "Процесс запущен. Начата проверка вставок   . . .");
            this.toolStripProgressBar.Visible = this.Mark_Execution;
            if (!this.Mark_Execution) return;

            if (this.DomainUpDownUch.Text !="0" && !this.ListDeskPaste.ContainsKey(this.DomainUpDownUch.Text))
            {
                Static_StatusStripMessage
               ("Процесс прерван.Не верно указан участок по умолчанию. Если значение не требуется ( в реестре указаны участки для всех плательщиков) - укажите 0");
                this.Mark_Execution = false;
                this.toolStripProgressBar.Visible = this.Mark_Execution;
                MessageBox.Show("Выберите значение из списка судебных участков. Если значение не требуется - укажите 0 ", "Процесс прерван. Не верно указан участок по умолчанию.",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);

                
                return;
            }


            // Загрузка описаний вставок
            this.DiscriptionPasteLoad();

            // проверка вставок
            if (this.Control_Paste() == false)
            {
                CloseAllFiles();
                Mark_Execution = false;
                this.toolStripProgressBar.Visible = this.Mark_Execution;
                DoEventsWithShow("Проверка вставок не пройдена.Процесс формирования файлов прерван. ",
                    "Проверка вставок выполнена. Начато формирование файлов   . . .");
                
            }
            if (!this.Mark_Execution) return;


            try
            {

              

                string _Directory_Input = this.Fortmating_Directory(this.Directory_Inp);
                string[] _List_File = Directory.GetFiles(_Directory_Input, "*.xls?", SearchOption.TopDirectoryOnly);
                this.progressBarFile.Maximum = _List_File.Length;
                this.progressBarFile.Refresh();
                if (_List_File.Length == 0)

                {
                    this.toolStripProgressBar.Visible = false;
                    MessageBox.Show("Отсутвуют файлы приложений с задолженностью", "Процесс остановлен");
                    this.Mark_Execution = false;
                }
                
                DoEventsWithShow("Отсутвуют файлы приложений с задолженностью.Процесс остановлен",
                "Процесс запущен. Формирование файлов выполняется  . . .");
                 if (!this.Mark_Execution) return;
                
                for (int _i = 0; _i < _List_File.Length; _i++)
                {
                    if(this.Error_During_Execution)
                    {
                        // Возникла ошибка доступа к файлам
                        MessageBox.Show("Возникла ошибка во время исполнения задания", "Процесс формирования файлов прерван");
                        this.Mark_Execution = false;
                        break;
                    }
                    InputFileWithPaste _InpFilePaste = new InputFileWithPaste(_List_File[_i], _i + 1);


                    DoEventsWithShow("Формирование файлов прервано.Процесс остановлен",
                    "Сформированы выходные файлы из " + _List_File[_i] +". Формирование файлов продолжается  . . .");
                    if (!this.Mark_Execution) break;

                    //Static_StatusStripMessage("Сформированы выходные файлы из " + _List_File[_i]);
                    this.progressBarFile.PerformStep();
                    this.labelProcent.Text = ((_i+1) * 100 / (_List_File.Length)).ToString() + " %";
                    
                }
                this.labelProcent.BackColor = Color.LimeGreen;
                this.toolStripProgressBar.Visible = false;
                if (this.Mark_Execution)
                    Static_StatusStripMessage("Процесс завершен. Формирование файлов выполнено.");
                else
                    Static_StatusStripMessage("Процесс остановлен. Формирование файлов прервано.");
            }
            catch (Exception _exp)
            {
             //   this.toolStripProgressBar.Visible = false;
                this.Error_During_Execution = true;
                MessageBox.Show(_exp.Message.ToString(), "Ошибка открытия входного файла ", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            finally
            {
                this.Mark_Execution = false;
                if (!this.Error_During_Execution) CloseAllFiles();
            }
        }

        private void CloseAllFiles()
        {
            if (this.AppXL != null && this.AppXL.Application != null) this.AppXL.Quit();
            this.AppXL = null;

            if (this.AppWD != null && this.AppWD.Application != null)
                this.AppWD.Quit(Word.WdSaveOptions.wdDoNotSaveChanges, Word.WdOriginalFormat.wdOriginalDocumentFormat);
            this.AppWD = null;
        }
    }

}