using savas.library.Enum;
using savas.library.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace savas.library.Concrete
{
	public class Oyun : IOyun
	{
		public bool DevamEdiyorMu { get; private set; }

		public TimeSpan GecenSure {  get; }

		public void AtesEt()
		{
			throw new NotImplementedException();
		}

		public void Baslat()
		{
			if (DevamEdiyorMu) return;
			DevamEdiyorMu = true;
        }

		private void Bitir()
		{
			if (!DevamEdiyorMu) return;
			DevamEdiyorMu = false;
		}

		public void UcakSavarHareketEttir(Yon yon)
		{
			throw new NotImplementedException();
		}
	}
}
