using DAL;
using Entity;

namespace BLL
{
    public class TipoDeAccesorioLógica : Lógica<TipoDeAccesorio>
    {
        public TipoDeAccesorioLógica() : base (new TipoDeAccesorioRepository()) { }
    }
}
