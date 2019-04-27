using System.Collections.Generic;
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
        public void Alterar(VendedorModel vendedor)
        {
            _vendedorRepository.Alterar(vendedor);
            
        }

        public void Deletar(VendedorModel vendedor)
        {
            _vendedorRepository.Deletar(vendedor);
        }

        public void Incluir(VendedorModel vendedor)
        {
            _vendedorRepository.Incluir(vendedor);
            
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