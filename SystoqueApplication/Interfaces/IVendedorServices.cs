using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystoqueApplication.Models;

namespace SystoqueApplication.Interfaces
{
    public interface IVendedorServices
    {
        string Incluir(VendedorModel vendedor);

        string Alterar(VendedorModel vendedor);

        VendedorModel Selecionar(int? id);

        List<VendedorModel> Lista();
    }
}
