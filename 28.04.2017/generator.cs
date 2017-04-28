using System;
namespace Application
{
	public class generator
	{
		public generator()
		{
			string useIndex = "";
			string upWord = "ABCDEFGHJKLMNOPQRSTUVWXYZ";
			string lWord = "abcdefghijkmnopqrstuvwxyz";
			string number = "1234567890";
			string elements = "`~!@#$%^&*())_+-=[]{};':,./<>?";
			string[] arr = { upWord, lWord, number, elements };
			Random rnd = new Random();
			string psw = upWord[rnd.Next(0, upWord.Length)].ToString();
			for (int i = 0; i < 15; i++)
			{
				int randArr = rnd.Next(0,arr.Length);
				int randArrElem = rnd.Next(0, arr[randArr].Length);
				useIndex += randArr;
				psw += arr[randArr][randArrElem];
			}
			if (useIndex.IndexOf('0') >= 0 && useIndex.IndexOf('1') >= 0 && useIndex.IndexOf('2') >= 0 && useIndex.IndexOf('3') >= 0)
			{
				Console.WriteLine(psw);
			}
			else 
			{ 
			Console.WriteLine("asss");
			}


		}

	}
}
