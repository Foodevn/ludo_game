using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ludo_game_v2.Thehien
{
	public partial class TheHienQuanCo : UserControl
	{
		public TheHienQuanCo()
		{
			InitializeComponent();
		}
		public PictureBox picQC =new PictureBox();
		public string strFileName { get; set; }
		public String LayHinhQuanCo(int m)
		{
			switch (m)
			{
				case 1: strFileName = "Xanh.gif" ; break;
				case 2: strFileName = "Do.gif"; break;
				case 3: strFileName = "Duong.gif"; break;
				case 4: strFileName = "Vang.gif"; break;
			}
			return strFileName;
		}
		public void HienThi(int m)
		{
			LayHinhQuanCo(m);
			picQC.Image = new System.Drawing.Bitmap("C:\\Users\\HOANG PHUC\\source\\repos\\Ludo_game_v2\\Ludo_game_v2\\img\\HinhNgua\\" + strFileName);
		}
	}
}
