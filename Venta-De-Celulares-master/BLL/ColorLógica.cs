using DAL;
using Entity;

namespace BLL
{
    public class ColorLógica : Lógica<Color>
    {
        public ColorLógica() : base (new ColorRepository()) { }
    }
}
