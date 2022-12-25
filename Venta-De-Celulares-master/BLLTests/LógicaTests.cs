using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace BLL.Tests
{
    [TestClass()]
    public class LógicaTests
    {
        ClienteLógica cll = new ClienteLógica();
        CelularLógica cl = new CelularLógica();
        UsuarioLógica ul = new UsuarioLógica();
        private Cliente GetCliente()
        {
            Cliente c = new Cliente();

            c.Cédula = "";
            c.Nombres = "";
            c.PrimerApellido = "";
            c.SegundoApellido = "";
            c.Edad = 0;
            c.CorreoElectrónico = "";
            c.Dirección = "";
            c.Teléfono = "";
            c.Género = ' ';

            return c;
        }
        private Cliente GetCliente2()
        {
            Cliente c = new Cliente();

            c.Cédula = "";
            c.Nombres = "";
            c.PrimerApellido = "";
            c.SegundoApellido = "";
            c.Edad = 0;
            c.CorreoElectrónico = "";
            c.Dirección = "";
            c.Teléfono = "";
            c.Género = 'F';

            return c;
        }
        private Celular GetCelular2()
        {
            Celular c = new Celular();

            MarcaLógica mc = new MarcaLógica();
            ColorLógica lc = new ColorLógica();

            c.Referencia = "";
            c.Almacenamiento = 0;
            c.MegapixelesEnLaCámara = 0;
            c.RAM = 0;
            c.Nombre = "";
            c.Precio = 0.00F ;
            c.Descripción = "";
            c.Cantidad = 0;
            c.Tipo = "Inteligente" == "Inteligente" ? TipoDeCelular.INTELIGENTE : TipoDeCelular.REGULAR;
            c.Precio = 0;
            c.Marca = mc.Get(int.Parse("1"));
            c.Color = lc.Get(1);

            return c;
        }
        private Celular GetCelular()
        {
            Celular c = new Celular();

            MarcaLógica mc = new MarcaLógica();
            ColorLógica lc = new ColorLógica();

            c.Referencia = "";
            c.Almacenamiento = 0;
            c.MegapixelesEnLaCámara = 0;
            c.RAM = 0;
            c.Nombre = "";
            c.Precio = 0.0F;
            c.Descripción = "";
            c.Cantidad = 0;
            c.Tipo ="Inteligente" == "Inteligente" ? TipoDeCelular.INTELIGENTE : TipoDeCelular.REGULAR;
            c.Precio = 0;
            c.Marca = mc.Get(int.Parse("1"));
            c.Color = lc.Get(1);

            return c;
        }


        private Usuario GetUsuario()
        {
            Usuario u = new Usuario();
            u.Nombre = null;
            u.Contraseña = null;
            u.Rol = '1';
            return u;
        }
        private Usuario GetUsuario2()
        {
            Usuario u = new Usuario();
            u.Nombre = "12354";
            u.Contraseña = "12345678";
            u.Rol = '1';
            return u;
        }
    
        [TestMethod]
        public void InsertUsuarioTestfail()
        {

           
            Assert.IsFalse(ul.Insert(GetUsuario2())==0);
        }
        [TestMethod]
        public void InsertUsuarioTestSussece()
        {
            Assert.IsTrue(ul.Insert(GetUsuario())==0);
        }
        [TestMethod]
        public void InsertClienteTestfail()
        {


            Assert.IsFalse(cll.Insert(GetCliente()) == 0);
        }
        [TestMethod]
        public void InsertClienteTestSussece()
        {
            Assert.IsTrue(cll.Insert(GetCliente2()) == 0);
        }
        [TestMethod]
        public void InsertCelularesTestfail()
        {


            Assert.IsFalse(cl.Insert(GetCelular()) == 0);
        }
        [TestMethod]
        public void InsertCelularesTestSussece()
        {
            Assert.IsTrue(cl.Insert(GetCelular2()) == 0);
        }


    }
}