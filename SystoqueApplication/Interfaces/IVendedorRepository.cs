using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystoqueApplication.Models;

namespace SystoqueApplication.Interfaces
{
    public interface IVendedorRepository
    {
        void Incluir(VendedorModel vendedor);
        void Alterar(VendedorModel vendedor);

        List<VendedorModel> Lista();
    }
}
