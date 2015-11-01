using System;

namespace Excel
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			DataStruct data = new DataStruct ();
			IOWrite write = new IOWrite (data);


			//Набиране на данни в основната таблица
			data.addRow ("Николай", "Стоянов", "19");
			data.addRow ("Георги", "Мартинов", "23");

			//Проверка на таблица
			data.printTable ();
			write.exportTable ();
			write.runFile ();
		}
	}
}
