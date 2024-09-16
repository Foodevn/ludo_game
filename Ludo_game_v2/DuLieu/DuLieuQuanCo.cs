using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo_game_v2.DuLieu
{
	internal class DuLieuQuanCo
	{
		#region Required variables
		private Point vtTrongChuong;
		private int vtTrenBC;
		private int vtRQ;
		private int vtVD;
		private int Mau;
		public int Bac;
		private int State;
		public int Count;
		#endregion
		#region Properties
		public int TrangThaiQuanCo
		{
			get { return State; }
			set { State = value; }
		}
		public int SanSang
		{
			get { return 0; }
		}
		public int DangDi
		{
			get { return 1; }
		}
		public int VeDich
		{
			get { return 2; }
		}
		public int MauCo
		{
			get { return Mau; }
			set { Mau = value; }
		}

		public int ViTriTrenBanCo
		{
			get { return vtTrenBC; }
			set { vtTrenBC = value; }
		}
		public Point ViTriTrongChuong
		{
			get { return vtTrongChuong; }
			set { vtTrongChuong = value; }
		}
		public int ViTriRaQuan
		{
			get { return vtRQ; }
			set { vtRQ = value; }
		}
		public int ViTriVeDich
		{
			get { return vtVD; }
			set { vtVD = value; }
		}

		#endregion
	}
}
