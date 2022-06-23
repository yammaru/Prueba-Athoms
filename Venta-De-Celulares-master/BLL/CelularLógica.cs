using DAL;
using Entity;

namespace BLL
{
    public class CelularLógica : Lógica<Celular>
    {
        public CelularLógica() : base (new CelularRepository()) { }
    }
}
