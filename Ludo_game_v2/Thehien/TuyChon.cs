﻿using System;
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
	public partial class TuyChon : Form
	{
		public TuyChon()
		{
			InitializeComponent();
			
		}
		public  DuLieu.DuLieuTuyChon tc = new DuLieu.DuLieuTuyChon();
	}
}
