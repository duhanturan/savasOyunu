using savas.library.Concrete;
using savas.library.Enum;
using System;
using System.Windows.Forms;

namespace savas
{
	public partial class Anaform : Form
	{
		public Oyun _oyun ;
		public Anaform()
		{
			InitializeComponent();

			_oyun = new Oyun(ucaksavarPanel);
			_oyun.GecenSureDegisti += Oyun_GecenSureDegisti;
		}

		private void Anaform_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.Enter:
					_oyun.Baslat();
					break;
				case Keys.Space:
					_oyun.AtesEt();
					break;
				case Keys.Left:
					_oyun.UcakSavarHareketEttir(Yon.Sola);
					break;
				case Keys.Right:
					_oyun.UcakSavarHareketEttir(Yon.Saga);
					break;
			}
		}

		private void Oyun_GecenSureDegisti(object sender, EventArgs e)
		{
			label2.Text = _oyun.GecenSure.ToString(@"m\:ss");
		}

	}
}
