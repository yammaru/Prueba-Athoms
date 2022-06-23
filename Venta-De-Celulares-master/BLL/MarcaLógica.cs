using DAL;
using Entity;

namespace BLL
{
    public class MarcaLógica : Lógica<Marca>
    {
        public MarcaLógica() : base (new MarcaRepository()) { }
    }
}
