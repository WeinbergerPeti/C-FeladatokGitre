using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace GitFeladatok
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] szamok = new int[10];
			F01(szamok);
			F05(szamok);

			Console.ReadKey();
		}

		static void F01(int[] tomb)
		{
			Random random = new Random();
			for (int i = 0; i < tomb.Length; i++)
			{
				tomb[i] = random.Next(1, 51);
			}
		}

		static int F02(int[] tomb)
		{
			int szamlalo = 0;
			for (int i = 0; i < tomb.Length; i++)
			{
				if (tomb[i] % 2 == 0)
				{
					szamlalo++;
				}
			}
			return szamlalo;
		}

		static double F03(int[] tomb)
		{
			double atlag = 0;
			for (int i = 0; i < tomb.Length; i++)
			{
				atlag += tomb[i];
			}
			return  atlag/=tomb.Length;
		}

		static int[] F04(int[] tomb)
		{
			int[] paratlanok = new int[10];
			for (int i = 0; i < tomb.Length; i++)
			{
				if (tomb[i] % 2 == 0)
				{
					//tomb[i]++;
					paratlanok[i] = tomb[i]++;
				}
				else
				{
					paratlanok[i] = tomb[i];
				}
			}
			return paratlanok;
		}

		static void F05(int[] tomb)
		{
			Console.WriteLine($"Ennyi db pozitív szám van a tömbben: {F02(tomb)}");
			Console.WriteLine($"A tömb elemeinek az átlaga: {F03(tomb):F4}");
			Console.WriteLine("A tömbből alkotott páratlan számok:");
			foreach (int paratlan in F04(tomb))
			{
				Console.Write($"{paratlan}, ");
			}
			Console.WriteLine();
		}
	}
}
