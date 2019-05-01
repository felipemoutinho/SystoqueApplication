using SystoqueApplication.Models;

namespace SystoqueApplication.Interfaces
{
    public interface IItemService
    {
        void Incluir(Item item);
        void Excluir(Item item);
    }
}
