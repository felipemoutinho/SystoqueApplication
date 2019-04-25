using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SystoqueApplication.Interfaces;
using SystoqueApplication.Models;

namespace SystoqueApplication.Services
{
    public class VendedorServices : IVendedorServices
    {
        private readonly IVendedorRepository _vendedorRepository;
        public VendedorServices(IVendedorRepository vendedorRepository)
        {
            _vendedorRepository = vendedorRepository;
        }
        public string Alterar(VendedorModel vendedor)
        {
            _vendedorRepository.Alterar(vendedor);
            return "ok";
        }

        public string Incluir(VendedorModel vendedor)
        {
            _vendedorRepository.Incluir(vendedor);
            return "ok";
        }

        public List<VendedorModel> Lista()
        {
            return _vendedorRepository.Lista();
        }

        public VendedorModel Selecionar(int? id)
        {
            return _vendedorRepository.Selecionar(id);
        }
    } 
}