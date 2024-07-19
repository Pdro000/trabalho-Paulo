using System;
using Trabalho_paulo;
using Trabalho_paulo1;
Livro livro = new Livro();
Date date = new Date();
Penalidade penalidade = new Penalidade();
Emprestimo emprestimo = new Emprestimo();
HistoricoEmprestimo HistoricoEmprestimo = new HistoricoEmprestimo();
Usuario usuario = new Usuario();

public class trabalho_paulo
{
    public static string VerificarEmprestimo { get; private set; }

    private static void Trabalho(string[] args, Livro livro)
    {
        HistoricoEmprestimo historicoEmprestimo = new HistoricoEmprestimo();
        bool continuarExecucao = true;

        while (continuarExecucao)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Alugar um livro");
            Console.WriteLine("2 - verificar usuario");
            Console.WriteLine("3 - Verificar quanto tempo você tem disponível");       
            Console.WriteLine("4 - Sair do programa");

            string opcaoStr = Console.ReadLine();
            int opcao;

            Console.WriteLine();
            
        }
    }
}