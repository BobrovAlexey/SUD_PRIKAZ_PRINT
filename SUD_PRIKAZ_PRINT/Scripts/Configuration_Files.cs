using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Configuration_Files
{
    //Класс для чтения/записи INI-файлов
    public class INIManager
    {

        //Конструктор, принимающий путь к INI-файлу
        public INIManager(string aPath)
        {
            path = aPath;
        }

        //Конструктор без аргументов (путь к INI-файлу нужно будет	задать отдельно)
        public INIManager() : this("") { }

        //Возвращает значение из INI-файла (по указанным секции и ключу)
        public string GetPrivateString(string aSection, string aKey)
        {
            //Для получения значения
            StringBuilder buffer = new StringBuilder(SIZE);

            //Получить значение в buffer
            GetPrivateString(aSection, aKey, null, buffer, SIZE, path);

            //Вернуть полученное значение
            return buffer.ToString();
        }


        // Получаем все ключи секции
        public Dictionary<string, string> GetKeys(string aSection)
        {

            //Для получения значения
            byte[] buffer = new byte[SIZE];

            //Получить значение в buffer
            GetPrivateProfileSection(aSection, buffer, SIZE, path);

            String[] tmp = Encoding.Unicode.GetString(buffer).Trim('\0').Split('\0');

            Dictionary<string, string> result = new Dictionary<string, string>();

            foreach (String entry in tmp)
            {
                if(!String.IsNullOrEmpty(entry))
                result.Add(entry.Substring(0, entry.IndexOf("=")), entry.Substring(entry.IndexOf("=") + 1));
            }

            return result;
        }


        // Получаем спсиок секций
        public List<string> GetSections(string filter_Section = null)
        {

            //Для получения значения

            byte[] buffer = new byte[SIZE];
            GetPrivateProfileSectionNames(buffer, SIZE, path);
            string allSections = System.Text.Encoding.Default.GetString(buffer);
            string[] sectionNames = allSections.Split('\0');
            List<string> result = new List<string>();
            foreach (string sectionName in sectionNames)
            {
                if (sectionName != string.Empty && 
                    (filter_Section == null || Regex.Match(sectionName, filter_Section).Success))
                    result.Add(sectionName);
            }
            return result;
        }


        //Пишет значение в INI-файл (по указанным секции и ключу)
        public void WritePrivateString(string aSection, string aKey, string aValue)
        {
            //Записать значение в INI-файл
            WritePrivateString(aSection, aKey, aValue, path);
        }


        //Удаляем ключ из выбранной секции.
        public void DeleteKey(string _Section,string _Key)
        {
            this.WritePrivateString(_Section, _Key, null);
        }
        //Удаляем выбранную секцию
        public void DeleteSection(string _Section)
        {

            Dictionary<string,string> _L = this.GetKeys(_Section);
            foreach (string _dockKey in _L.Keys)
            {
                this.DeleteSection(_dockKey);
                this.DeleteSection(_Section+_dockKey);
                this.DeleteKey(_Section, _dockKey);
            }
            this.WritePrivateString(_Section, null, null);
            
        }
       

        //Возвращает или устанавливает путь к INI файлу
        public string Path { get { return path; } set { path = value; } }

        //Поля класса
        private const int SIZE = 1024; //Максимальный размер (для чтения	значения из файла)
        private string path = null; //Для хранения пути к INI-файлу

        
       
        //Импорт функции GetPrivateProfileString (для чтения значений) из библиотеки kernel32.dll
        [DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileString", CharSet =CharSet.Unicode )]
        private static extern int GetPrivateString(string section, string key, string def, StringBuilder buffer, int size, string path);

        //Импорт функции GetPrivateProfileSection (для чтения значений всей секции) из библиотеки kernel32.dll
        [DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileSection",CharSet = CharSet.Unicode)]
        private static extern int GetPrivateProfileSection(string lpAppName, byte[] lpszReturnBuffer, int nSize, string lpFileName);

        [DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileSectionNamesA",CharSet = CharSet.Unicode)]
        private static extern int GetPrivateProfileSectionNames(byte[] lpszReturnBuffer, int nSize, string lpFileName);

        //Импорт функции WritePrivateProfileString (для записи значений) из библиотеки	kernel32.dll
        [DllImport("kernel32.dll", EntryPoint = "WritePrivateProfileString",CharSet = CharSet.Unicode)]
        private  static extern int WritePrivateString(string section, string key, string str, string path);

        public string Read_Value(string _group, string _name)
        {
            string _value = "";
            try
            {
                _value = this.GetPrivateString(_group.ToUpper(), _name.ToUpper());
            }
            catch (Exception _exp)
            {
                MessageBox.Show(_exp.Message.ToString(), "Ошибка получения параметра (некорректно заплнен раздел " + _group + ")", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return _value;
        }

        public void Write_Value(string _group, string _name, string _value)
        {


            try
            {
                if (_name == null) this.DeleteSection(_group);
                else
                this.WritePrivateString(_group.ToUpper(), _name, _value);
            }
            catch (Exception _exp)
            {
                MessageBox.Show(_exp.Message.ToString(), "Ошибка записи параметра (некорректно заплнен раздел " + _group + ")", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public byte Read_Value_Byte(string _group, string _name)
        {
            byte _value = 0;


            try
            {
                _value = Convert.ToByte(this.GetPrivateString(_group.ToUpper(), _name.ToUpper()));
            }
            catch (Exception _exp)
            {
                MessageBox.Show(_exp.Message.ToString(), "Ошибка получения параметра (некорректно заплнен раздел "+ _group+")", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return _value;
        }
    }
}
