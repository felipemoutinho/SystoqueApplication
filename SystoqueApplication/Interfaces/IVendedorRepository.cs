﻿using System.Collections.Generic;
using SystoqueApplication.Models;

namespace SystoqueApplication.Interfaces
{
    public interface IVendedorRepository
    {
        void Incluir(VendedorModel vendedor);
        void Alterar(VendedorModel vendedor);

        void Deletar(VendedorModel vendedor);

        VendedorModel Selecionar(int? id);

        List<VendedorModel> Lista();
    }
}
