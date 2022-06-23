using DAL;
using Entity;

namespace BLL
{
    public class AccesorioLógica : Lógica<Accesorio>
    {
        public AccesorioLógica() : base (new AccesorioRepository()) { }
    }
}
