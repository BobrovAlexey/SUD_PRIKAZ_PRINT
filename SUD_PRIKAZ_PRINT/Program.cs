using System;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Collections.Generic;


namespace SUD_PRIKAZ_PRINT
{
    static class Program
    {

        public static App_KeysTable App_Keys;

        // CONFIG - с кнопкой настройки
        public static bool App_Key_Config
        {
            get
            {
                return Program.App_Keys.ContainsKey("CONFIG") && !Program.App_Keys.ContainsKey("NOCONFIG");
            }
            set { }
        }



        // Процесс запускается сразу без запуска окна
        public static bool App_WithoutWindow
        {
            get
            {
                return Program.App_Keys.ContainsKey("WITHOUTWINDOW");
            }
            set { }
        }

        // сразу запуск
        public static bool App_Key_Run
        {
            get
            {
                return Program.App_Keys.ContainsKey("RUN") || Program.App_Keys.ContainsKey("WITHOUTWINDOW");
            }
            set { }
        }

        public static string App_Key_CurrentDirectory
        {
            get
            {
                return Program.App_Keys.ContainsKey("CURRENTDIRECRORY") ? Program.App_Keys["CURRENTDIRECRORY"] : Application.StartupPath;
            }
            set { }
        }


        public static string Path_Ini_File
        {
            get
            {
                return Program.App_Keys.ContainsKey("INIFILE") ?
                    (Program.App_Keys["INIFILE"].Contains("\\") ?
                    Program.App_Keys["INIFILE"] :
                    Path.Combine(Program.App_Key_CurrentDirectory, Program.App_Keys["INIFILE"]))

                    : "";
            }
            set { }
        }

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Формирование словаря ключей строки запуска программы
            App_Keys = new App_KeysTable(args);
            //foreach (string _Key in App_Keys.Keys) MessageBox.Show(App_Keys[_Key], _Key);
            Application.Run(new FormMain());
        }
    }

    [Serializable]
    public class App_KeysTable : Dictionary<string, string>,ISerializable
    {
        public App_KeysTable(string[] _Arr) : base ()

        {
            string _key, _value;
            int _index;
            for (int i = 0; i != _Arr.Length; ++i)
            {
                if (_Arr[i].Substring(0, 1) == "/" || _Arr[i].Substring(0, 1) == "-")
                {
                    _key = _Arr[i].Substring(1);
                    _value = "";
                    _index = _key.IndexOf(":") > -1 ? _key.IndexOf(":") : _key.IndexOf("=");
                    if (_index > 0 && _index < _key.Length)
                    {
                        _value = _key.Substring(_index + 1);
                        _key = _key.Substring(0, _index);
                    }
                    _key = _key.Trim().ToUpper();
                    _value = _value.Trim().ToUpper();
                    if (_key.Length > 0) this.Add(_key.ToUpper(), _value.ToUpper());
                }


            }

        }

   
        protected   App_KeysTable(SerializationInfo info, StreamingContext context) : base() { }


    }
}
