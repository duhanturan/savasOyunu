using savas.library.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace savas.library.Concrete
{
	internal class UcakSavar:Cisim
	{
        public UcakSavar(int panelGenisligi)
        {
             Left = (panelGenisligi-Width)/2;
        }
    }
}
