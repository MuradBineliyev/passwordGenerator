using System;
namespace Application
{
	public class pswGenerator
	{
		public pswGenerator()
		{
			string z = "1";
			string upcase = "ABCDEFGHJKLMNOPQRSTUVWXYZ";
			string charac = "!@$?_-.,/])(*&^%%#[{}=";
			string num = "1234567890";
			string lcase = "abcdefghijkmnopqrstuvwxyz";
			string[] arr = { upcase, charac, num, lcase };
		Random rnd = new Random();
		string a = upcase[rnd.Next(0, upcase.Length)].ToString();
			for (int i = 0; i< 15; i++)
					{

				int randarr = rnd.Next(0, arr.Length);
				for (int j = 0; j < z.Length; j++)
				{
					if (z[j]!=randarr)
					{
						z += randarr.ToString();
					}
				}


						int randelements = rnd.Next(0, arr[randarr].Length);
						a += arr[randarr][randelements];
								


					}
			foreach (var yaz in z)
			{
				Console.WriteLine(yaz);
			}
				Console.WriteLine(a);

		}
	}
}
