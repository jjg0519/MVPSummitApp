﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;
using Xamvvm;

namespace MVPSummitApp
{
	public partial class SchedulePage : ContentPage, IBasePage<SchedulePageModel>
	{
		public SchedulePage()
		{
			InitializeComponent();

		}
	}
}
