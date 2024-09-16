using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ludo_game_v2
{
	public partial class XuLyChinh : Form
	{
		public XuLyChinh()
		{
			InitializeComponent();
		}
		private Thehien.TuyChon TuyChonThamSo = new Thehien.TuyChon();
		private XuLy.BanCo BC = new XuLy.BanCo();
		private Thehien.TheHienXiNgau TheHienXN=new Thehien.TheHienXiNgau();
		private XuLy.XiNgau XN = new XuLy.XiNgau();
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new XuLyChinh());
		}

		private void btnSapBanCo_Click(object sender, EventArgs e)
		{
			ResetManHinh();
			BC.SapBanCo(this.panelBC, this.TuyChonThamSo.tc);// moi
			//this.btnSapBanCo.Enabled = false;
			this.btnDoXiNgau.Enabled = true;
		}
		public void ResetManHinh()
		{
			this.panelBC.BackgroundImage = new Bitmap("C:\\Users\\HOANG PHUC\\source\\repos\\Ludo_game_v2\\Ludo_game_v2\\img\\Cocangua.JPG");
			this.TheHienXN.SoXiNgauTheHien = this.TuyChonThamSo.tc.SoHotXiNgau;
			this.TheHienXN.DinhViXiNgau();
			this.BC.DLBC.CapNhatDL(this.TuyChonThamSo.tc);
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
