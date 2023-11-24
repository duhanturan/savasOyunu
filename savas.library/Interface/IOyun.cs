using savas.library.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace savas.library.Interface
{
	public interface IOyun
	{
		event EventHandler GecenSureDegisti;
		bool DevamEdiyorMu {  get; }
		TimeSpan GecenSure { get; }

		void Baslat();
		void AtesEt();
		void UcakSavarHareketEttir(Yon yon);

	}
}
