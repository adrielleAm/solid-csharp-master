using Alura.LeilaoOnline.WebApp.Models;
using System.Collections.Generic;

namespace Alura.LeilaoOnline.WebApp.Dados
{
    public interface ILeilaoDao
    {
        IEnumerable<Categoria> BuscarCategoria();

        IEnumerable<Leilao> BuscarLeiloes();

        Leilao BuscarPorId(int id);

        void AtualizarLeilao(Leilao model);

        void Incluir(Leilao model);

        void Excluir(Leilao model);
    }
}