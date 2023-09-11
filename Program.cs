using System;

public class Program
{
	public static void Main()
	{	
		
	  do{
			string nome, ra, situacao, aluno, faixaEtaria;
			int idade;
			double np1, np2, pim, media, exame, mediaExame;

			Console.Write("DIGITE NOME: ");
			nome = Console.ReadLine();
			Console.Write("DIGITE RA: ");
			ra = Console.ReadLine();
			Console.Write("DIGITE IDADE: ");
			idade = Convert.ToInt16(Console.ReadLine());
			Console.Write("DIGITE SITUAÇÃO: ");
			situacao = Console.ReadLine();
			Console.Write("DIGITE NP1: ");
			np1 = Convert.ToDouble(Console.ReadLine());
			Console.Write("DIGITE NP1: ");
			np2 = Convert.ToDouble(Console.ReadLine());
			Console.Write("DIGITE PIM: ");
			pim = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("\nNOME: " + nome.ToUpper());
			Console.WriteLine("RA: " + ra.ToUpper());
			Console.WriteLine("IDADE: " + idade);
			Console.WriteLine("SITUAÇÃO: " + situacao.ToLower());

			Console.WriteLine("\nNP1: " + np1);
			Console.WriteLine("NP2: " + np2);
			Console.WriteLine("PIM: " + pim);

			if (idade <= 12)
			{
				faixaEtaria = "CRIANÇA";
			} 
			else if ((idade > 12) && (idade < 18))
			{
				faixaEtaria = "ADOLESCENTE";
			}
			else if ((idade >= 18) && (idade < 30))
			{
				faixaEtaria = "JOVEM";
			}
			else if ((idade >= 30) && (idade < 60 ))
			{
				faixaEtaria = "ADULTO";
			}
			else
			{
				faixaEtaria = "IDOSO";
			}

			Console.WriteLine("====================");
			Console.WriteLine("Aluno: " + nome +", "+ faixaEtaria);

            Console.WriteLine("====================");
            media = Math.Round((((np1 + np2) * 0.8)/2) + (pim * 0.2),2);
			Console.WriteLine("Média: " + media);
            

            if (media >= 7)
			{
				aluno = "APROVADO";
				if (media == 10)
				{
					aluno = "APROVADO COM LOUVOR";
				}
			} else {
				aluno = "REPROVADO";
			}

			Console.WriteLine("Aluno: " + nome +", "+ aluno);
            Console.WriteLine("====================");

            if (aluno == "REPROVADO")
			{
				Console.Write("Digite nota de Exame: ");
				exame = Convert.ToDouble(Console.ReadLine());

				mediaExame = (exame + media) / 2;

				if ((exame < 5) || (mediaExame < 5))
				{
					aluno = "REPROVADO EXAME";
				} else {
					aluno = "APROVADO EXAME";
				}
				
				Console.WriteLine("Média final: " + mediaExame);
				Console.WriteLine("Aluno: " + nome +", "+ aluno);
                Console.WriteLine("====================");
            }

            Console.Write("\nDeseja continuar? s/n ");
        } while (Console.ReadLine() == "s");

    } 
}