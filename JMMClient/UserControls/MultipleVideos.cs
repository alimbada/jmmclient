﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JMMClient.ViewModel;

namespace JMMClient.UserControls
{
	public class MultipleVideos
	{
		public int SelectedCount { get; set; }
		public List<int> VideoLocalIDs { get; set; }
		public List<VideoLocalVM> VideoLocals { get; set; }
		
	}
}
