using DAL;
using Entity;

namespace BLL
{
    public class CompraLógica : Lógica<Compra>
    {
        public CompraLógica() : base (new CompraRepository()) { }
    }
}
