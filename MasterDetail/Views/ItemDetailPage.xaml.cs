using System;
using System.Collections.Generic;

using MasterDetail.ViewModels;

using Xamarin.Forms;

namespace MasterDetail.Views
{
	public partial class ItemDetailPage : ContentPage
	{
		ItemDetailViewModel viewModel;

		public ItemDetailPage(ItemDetailViewModel viewModel)
		{
			InitializeComponent();

			BindingContext = this.viewModel = viewModel;
		}
	}
}
