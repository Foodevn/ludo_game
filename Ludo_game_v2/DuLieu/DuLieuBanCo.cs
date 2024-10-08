﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo_game_v2.DuLieu
{
	internal class DuLieuBanCo
	{
		#region Variables
		private int nUsers;
		private int UserHH;
		private int nOco;//so o tren ban co
		public int[] arrBC;// mang luu  gia tri cua mau quan co
		public int SoXN;
		public int gtXN1, gtXN2;
		public int gtRQ1, gtRQ2;
		public int gtVD1, gtVD2;
		public ArrayList arrUsers = new ArrayList();
		public ArrayList arrVTChuong = new ArrayList();
		public String Hinh;

		#endregion
		#region Properties

		public int UserHienTai
		{
			get { return UserHH; }
			set { UserHH = value; }
		}
		public int SoNguoichoi
		{
			get { return nUsers; }
			set { nUsers = value; }
		}
		public int SoOBc
		{
			get { return nOco; }
			set { nOco = value; }
		}
		public String HinhBanCo
		{
			get { return Hinh; }
			set { Hinh = value; }
		}
		#endregion
		#region function
		public void CapNhatDL(DuLieu.DuLieuTuyChon tc)
		{
			arrUsers.Clear();
			arrVTChuong.Clear();
			this.SoNguoichoi = tc.SoNguoiChoi;
			this.UserHienTai = tc.NguoiUuTien;
			this.gtRQ1 = tc.gtRaQuan1;
			this.gtRQ2 = tc.gtRaQuan2;
			this.gtVD1 = tc.gtVeDich1;
			this.gtVD2 = tc.gtVeDich2;
			this.KhoiTao(tc.SoNguaQuan);

		}
		public void KhoiTao(int[] SoQN)
		{
			for (int i = 0; i < SoNguoichoi; i++)
			{
				DuLieu.DuLieuUser tam = new DuLieuUser((int)SoQN[i]);
				KhoiTaoMangVeDich(i, tam);
				arrUsers.Add(tam);
			}
			KhoiTaoMangChuong();

		}
		public void KhoiTaoMangVeDich(int iUser, DuLieu.DuLieuUser User)
		{
			Point p;
			int d = 27;
			int n = 6;
			int t;
			if (iUser == 0)
			{
				p = new Point(224, 388);
				for (int i = 0; i < n; i++)
				{
					t = p.Y + (-d * i);
					User.arrVtDich[i] = new Point(p.X, t);
				}
			}

			if (iUser == 1)
			{
				p = new Point(395, 222);
				for (int i = 0; i < n; i++)
				{
					t = p.X + (-d * i);
					User.arrVtDich[i] = new Point(t, p.Y);
				}
			}
			if (iUser == 2)
			{
				p = new Point(224, 50);
				for (int i = 0; i < n; i++)
				{
					t = p.Y + d * i;
					User.arrVtDich[i] = new Point(p.X, t);
				}
			}
			if (iUser == 3)
			{
				p = new Point(58, 222);
				for (int i = 0; i < n; i++)
				{
					t = p.X + d * i;
					User.arrVtDich[i] = new Point(t, p.Y);
				}
			}


		}
		public void KhoiTaoMangChuong()
		{
			Point temp = new Point(423, 406);
			arrVTChuong.Add(temp);
			temp = new Point(420, 38);
			arrVTChuong.Add(temp);
			temp = new Point(30, 38);
			arrVTChuong.Add(temp);
			temp = new Point(30, 406);
			arrVTChuong.Add(temp);
		}



		#endregion
	}
}
