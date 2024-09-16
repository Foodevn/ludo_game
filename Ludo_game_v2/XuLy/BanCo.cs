using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo_game_v2.XuLy
{
	internal class BanCo
	{
		#region Variables
		public DuLieu.DuLieuBanCo DLBC=new DuLieu.DuLieuBanCo();

		XuLy.QuanCo qc = new XuLy.QuanCo();
		#endregion
		#region Property
		public DuLieu.DuLieuBanCo ThongTinBanCo
		{
			get { return DLBC; }
			set { DLBC = value; }
		}
		#endregion
		public void SapBanCo(System.Windows.Forms.Panel panel, DuLieu.DuLieuTuyChon tc)
		{
			//HuyBC(panel);
			CapNhatDuLieuBanco(tc);
			int n = DLBC.SoNguoichoi;
			for (int i = 0; i < n; i++)
				TaoViTriQuan((Point)DLBC.arrVTChuong[i], i, (DuLieu.DuLieuUser)DLBC.arrUsers[i], panel);
		}
		public void CapNhatDuLieuBanco(DuLieu.DuLieuTuyChon tc)
		{
			
			DLBC.SoNguoichoi = tc.SoNguoiChoi;
		}
		public void TaoViTriQuan(Point vtCB, int i, DuLieu.DuLieuUser User, System.Windows.Forms.Panel panel)
		{
			Point p;
			int X = -24, Y = -24;
			if (i == 1) { Y = -Y; }
			if (i == 2) { X = -X; Y = -Y; }
			if (i == 3) { X = -X; }
			for (int j = 0; j < User.SoQuanCo; j++)
			{
				if (j == 0 || j == 2 || j == 4)
					p = new Point(vtCB.X + (j / 2 * X), vtCB.Y);
				else
					p = new Point(vtCB.X + ((j - 1) / 2 * X), vtCB.Y + Y);
				qc = (XuLy.QuanCo)User.arrQC[j];
				qc.QCDL.ViTriTrongChuong = p;
				qc.QCDL.ViTriTrenBanCo = -1;
				qc.QCDL.ViTriRaQuan = i * 14;
				if (qc.QCDL.ViTriRaQuan == 0) qc.QCDL.ViTriVeDich = 55;
				else qc.QCDL.ViTriVeDich = qc.QCDL.ViTriRaQuan - 1;
				qc.QCDL.MauCo = i + 1;
				int x = qc.QCDL.ViTriTrongChuong.X;
				int y = qc.QCDL.ViTriTrongChuong.Y;
				qc.QCTH.picQC.Location = new Point(x,y);
				qc.QCTH.HienThi(i + 1);
				panel.Controls.Add(qc.QCTH.picQC);
			}
		}
	}
}
