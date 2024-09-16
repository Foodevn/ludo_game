using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo_game_v2.DuLieu
{
	internal class DuLieuUser
	{
		#region Required variables
		private String Username;
		private int mauQC;
		private int soQC;
		public int SoQuanVeDich;
		public ArrayList arrQC = new ArrayList();
		public Point[] arrVtDich = new Point[6];
		#endregion
		#region Properties
		public String UserName
		{
			get { return Username; }
			set { Username = value; }
		}
		public int MauQuanCo
		{
			get { return mauQC; }
			set { mauQC = value; }
		}
		public int SoQuanCo
		{
			get { return soQC; }
			set { soQC = value; }
		}

		#endregion
		#region function
		public DuLieuUser(int SoQCo)
		{
			SoQuanCo = SoQCo;
			SoQuanVeDich = 0;
			for (int i = 0; i < SoQuanCo; i++)
			{
				XuLy.QuanCo tam = new XuLy.QuanCo();
				arrQC.Add(tam);
			}
		}

		#endregion
	}
}
