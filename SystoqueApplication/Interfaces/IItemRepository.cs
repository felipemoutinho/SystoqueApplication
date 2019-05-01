using SystoqueApplication.Models;

namespace SystoqueApplication.Interfaces
{
    public interface IItemRepository
    {
        void Incluir(Item item);
        void Excluir(Item item);
    }
}
