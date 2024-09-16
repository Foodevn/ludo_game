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
	public partial class TheHienXiNgau : UserControl
	{
	
		#region Required variables
		
	
		private int soXNTH;
		private System.ComponentModel.Container components = null;
		#endregion
		#region Contractors
		public TheHienXiNgau()
		{
			InitializeComponent();
			
		}

		#endregion
		#region Properties
		public int SoXiNgauTheHien
		{
			get { return soXNTH; }
			set { soXNTH = value; }
		}
		#endregion
		#region function
		public void DinhViXiNgau()
		{			
				this.picXN.Location = new Point(32, 8);		
		}


		#endregion


	}
}
