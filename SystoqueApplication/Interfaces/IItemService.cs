using System.Collections.Generic;
using SystoqueApplication.Models;

namespace SystoqueApplication.Interfaces
{
    public interface IItemService
    {
        List<Item> Incluir(string codigoProduto, int qtdItem);
        void Excluir(Item item);

        decimal TotalVenda();
    }
}
