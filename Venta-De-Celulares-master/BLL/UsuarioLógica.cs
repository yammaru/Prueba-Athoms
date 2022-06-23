using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class UsuarioLógica : Lógica<Usuario>
    {
        public UsuarioLógica() : base(new UsuarioRepository())
        {
        }
    }
}
