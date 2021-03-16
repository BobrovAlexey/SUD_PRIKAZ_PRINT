using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Word;
//using Microsoft.Office.Interop.Excel;

namespace SUD_PRIKAZ_PRINT
{
	class FileOutFromInp : IDisposable
	{


		private FormMain ParentFormMain
		{

			get { return ((FormMain)System.Windows.Forms.Application.OpenForms["FormMain"]); }
			set { }
		}

	
		private Word.ApplicationClass AppWD 
		{
			get { return ((FormMain)System.Windows.Forms.Application.OpenForms["FormMain"]).AppWD; }
			set { }
		}

		
		private Word.Document   WD_Output;

		// Имя выходного файла
		private string Name_File_Output;



		// Flag: Has Dispose already been called?
		bool disposed = false;

		// Public implementation of Dispose pattern callable by consumers.
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Protected implementation of Dispose pattern.
		protected virtual void Dispose(bool disposing)
		{
			if (disposed)
				return;

			if (disposing)
			{
                // Free any other managed objects here.
                //this.WD_Output.Close();
                


            }

			// Free any unmanaged objects here.
			disposed = true;
		}


        // _Inp - путь к вхлдящему документу
        // _Templ - путь к шаблону
        // _Out - путь к исходящему файлу

        public FileOutFromInp(int _Num, string _INN, ref Array_Element_Paste _FromPrilPaste)
        {
			string _OutputFile;
			for (int _i=0; _i< this.ParentFormMain.List_FileTemplateOut.Count;_i++)
			{
				_OutputFile = this.ParentFormMain.List_FileTemplateOut[_i].Prefix +
					this.ParentFormMain.Name_File_Out_Template + 
					this.ParentFormMain.List_FileTemplateOut[_i].Postfix;
				_OutputFile = Path.Combine(this.ParentFormMain.Directory_Out, _OutputFile).ToUpper();
				
				this.Name_File_Output = this.ParentFormMain.Fortmating_Directory(_OutputFile) + ".doc";
						
				if (!String.IsNullOrEmpty(_INN))
				{
					this.OpenFileDoc(this.ParentFormMain.List_FileTemplateOut[_i].NameFileNormalize);
					this.InsertText(_FromPrilPaste[0].Name, _FromPrilPaste[0].Value);
					this.Replace_By_Paste(_FromPrilPaste, 1);
					this.Run_by_Padte_All(_INN);
					this.Save_File(_Num.ToString());
				}
				
			}

        }

		

		~FileOutFromInp()
		{
			Dispose(false);
		}
		
		
		private void OpenFileDoc(string _Name_File)
		{

			try
			{
                this.WD_Output = this.AppWD.Documents.Add(_Name_File, true, WdNewDocumentType.wdNewBlankDocument, true);
                
			}
			catch (Exception _exp)
			{
                this.ParentFormMain.Error_During_Execution = true;
                MessageBox.Show(_exp.Message.ToString(), 
					"Ошибка открытия выходного Word документа "+ _Name_File,
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				
			}
		}


		public void Save_File(string _Num)
		{
			
			try
			{
				
				string _Str = this.ParentFormMain.Sym_Start + "ПОРЯДКОВЫЙ НОМЕР" + this.ParentFormMain.Sym_End;
				this.Name_File_Output = this.Name_File_Output.Replace(_Str, _Num);
                 this.WD_Output.SaveAs(this.Name_File_Output, WdSaveFormat.wdFormatDocument97);
                this.WD_Output.Close(WdSaveOptions.wdSaveChanges, WdOriginalFormat.wdOriginalDocumentFormat);
             

            }

			catch (Exception _exp)
			{
                this.ParentFormMain.Error_During_Execution = true;
                MessageBox.Show(_exp.Message.ToString(), "Ошибка закрытия документов  Microsof Office",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				
			}
			
				
			
		}


		
		// Запуск 3 вариантов вставок
		private void Run_by_Padte_All(string _INN)
		{
			string _Uch;

			// Определяем номер участка
			// Если есть такой заголовок столбца и в соответвующей строчке значение 
			_Uch = this.ParentFormMain.FromReestrPaste[_INN]["УЧАСТОК"].Value;
			
			if (_Uch == null)
				_Uch = this.ParentFormMain.Number_Uch_Default;
			

             // если участок не определен - делаем его равным номеру учасстка по умолчанию
            //if (String.IsNullOrEmpty(_Uch)) _Uch = this.ParentFormMain.uc;

            // замена вставками из реестра по строке с таким ИНН
            this.Replace_By_Paste(this.ParentFormMain.FromReestrPaste[_INN]);
            
            // Замена общих вставок
            this.Replace_By_Paste(this.ParentFormMain.GeneralPaste);

            // замена вставок конкретного участка
            if (this.ParentFormMain.ListDeskPaste.ContainsKey(_Uch))
                this.Replace_By_Paste(this.ParentFormMain.ListDeskPaste[_Uch]);

            // замена запятых
            this.Replace_ZPT();

        }

        private void Replace_ZPT()
        {
            this.FindAndReplace(", ,", ",");
            this.FindAndReplace(",,", ",");
            this.FindAndReplace(",,", ",");
            this.FindAndReplace(",,", ",");
        }

        // Перебор всех вставок

        private void Replace_By_Paste(Array_Element_Paste _Arr,int _i_Start =0)
        {
            string _S;
            for (int _i= _i_Start; _i<_Arr.Count;_i++)
            {

                _S = this.ParentFormMain.Sym_Start + _Arr[_i].Name + this.ParentFormMain.Sym_End;
                this.Name_File_Output = this.Name_File_Output.Replace(_S, _Arr[_i].Value);
                this.FindAndReplace(_S, _Arr[_i].Value);
            }
                        
        }

		// Функция замены в Word-документе
		private bool FindAndReplace(string _Stroka_Seek, string _Stroka_Replace)
		{

            this.AppWDParameters();
			this.AppWD.Selection.Find.Text = _Stroka_Seek;// что искать
			this.AppWD.Selection.Find.Replacement.Text = _Stroka_Replace; //на что менять

			return this.AppWD.Selection.Find.Execute(_Stroka_Seek, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
			_Stroka_Replace, 2);

		}

		private bool InsertText(string _Stroka_Seek, string _Stroka_Replace)
		{
			string _Stroka_Seek_Paste = this.ParentFormMain.Sym_Start+_Stroka_Seek+ this.ParentFormMain.Sym_End;
			this.AppWDParameters();
			this.AppWD.Selection.Find.Text = _Stroka_Seek_Paste;// что искать
			

			if (this.AppWD.Selection.Find.Execute())
			{
				this.AppWD.Selection.InsertAfter(_Stroka_Replace);
			}
			return FindAndReplace(_Stroka_Seek_Paste, "");
		}
		
		private void AppWDParameters()
        {
			this.AppWD.Selection.Find.ClearFormatting();
			this.AppWD.Selection.Find.Forward = true;          //только вперед
			
			this.AppWD.Selection.Find.Wrap = WdFindWrap.wdFindContinue;
			this.AppWD.Selection.Find.Format = false;
			this.AppWD.Selection.Find.MatchCase = false;       //Учет регистра или нет
			this.AppWD.Selection.Find.MatchWholeWord = false; //Слово целиком
			this.AppWD.Selection.Find.MatchWildcards = false;
			this.AppWD.Selection.Find.MatchSoundsLike = false;
			this.AppWD.Selection.Find.MatchAllWordForms = false;


		}

	}
}
