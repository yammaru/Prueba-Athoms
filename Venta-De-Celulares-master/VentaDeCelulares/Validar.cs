using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace VentaDeCelulares
{
    public class Validar
    {
        public static void SoloNumeros(KeyPressEventArgs PE)
        {
            if (char.IsDigit(PE.KeyChar))
            {
                PE.Handled = false; 
            }
            else if (char.IsControl(PE.KeyChar))
            {
                PE.Handled = false; 
            }
            else
            {
                PE.Handled = true; 
            }
        }

        public static void SoloLetras(KeyPressEventArgs PE)
        {
            if (char.IsLetter(PE.KeyChar))
            {
                PE.Handled = false;
            }
            else if (char.IsControl(PE.KeyChar))
            {
                PE.Handled = false;
            }
            else if (char.IsSeparator(PE.KeyChar))
            {
                PE.Handled = false;
            }
            else
            {
                PE.Handled = true;
            }
        }
    }
}
