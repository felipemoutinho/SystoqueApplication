using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SystoqueApplication.Repository.Vendedor;
using SystoqueApplication.Models;

namespace SystoqueUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            VendedorRepository vr = new VendedorRepository();
            VendedorModel vm = new VendedorModel();
            vm.Matricula = 1;
            vm.Nome = "Felipe";
            vm.Datanasc = new DateTime();
            vm.Comissao = 0;
            bool teste = vr.Incluir(vm);
            Assert.IsTrue(teste);
        }
    }
}
