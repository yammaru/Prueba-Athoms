using DAL;
using Entity;

namespace BLL
{
    public class ClienteLógica : Lógica<Cliente>
    {
        public ClienteLógica() : base(new ClienteRepository()) { }
    }
}
