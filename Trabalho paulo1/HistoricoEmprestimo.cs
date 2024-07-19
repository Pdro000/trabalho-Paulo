using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_paulo1;

public class HistoricoEmprestimo
{
    public void Entrar(string placaEntrada)
    {
        throw new NotImplementedException();
    }

    public void ExibirInformacoesuSUARIO(string placaInformacoes)
    {
        throw new NotImplementedException();
    }

    public void ExibirInformacoesUsuario(string placaInformacoes)
    {
        throw new NotImplementedException();
    }

    public TimeSpan TempoDisponivel(Livro livro)
    {
        throw new NotImplementedException();
    }

    public void VerificarVencimento(string placaVerificar, int v)
    {
        throw new NotImplementedException();
    }

    public void VerificarVencimento(object verificarEmprestimo, int v)
    {
        throw new NotImplementedException();
    }

    class HistoricoEmprestimos
    {
        private List<Emprestimo> listaEmprestimos;

        // Construtor
        public HistoricoEmprestimos(List<HistoricoEmprestimo> listaEmprestimos)
        {
            _ = this.listaEmprestimos;
        }

        public List<HistoricoEmprestimo> ListaEmprestimos { get; private set; }

        // Método para adicionar empréstimo ao histórico
        public void adicionarEmprestimo(Emprestimo emprestimo)
        {
            listaEmprestimos.Add(emprestimo);
        }

        // Método para listar todos os empréstimos registrados
        public List<HistoricoEmprestimo> listarEmprestimos()
        {
            List<Emprestimo> listaEmprestimos1 = listaEmprestimos;
            return ListaEmprestimos;
        }
    }

}
