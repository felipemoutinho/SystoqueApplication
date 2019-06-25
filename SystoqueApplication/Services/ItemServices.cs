using System.Collections.Generic;
using SystoqueApplication.Interfaces;
using SystoqueApplication.Models;

namespace SystoqueApplication.Services
{
    public class ItemServices : IItemService
    {
        private readonly IItemRepository _itemRepository;

        public ItemServices(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }
        public void Excluir(Item item)
        {
            throw new System.NotImplementedException();
        }

        public List<Item> Incluir(string codigoProduto, int qtdItem)
        {
            return _itemRepository.Incluir(codigoProduto, qtdItem);
        }

        public decimal TotalVenda()
        {
            return _itemRepository.TotalVenda();
        }
    }
}