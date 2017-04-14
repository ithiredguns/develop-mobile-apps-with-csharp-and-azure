﻿using Rox;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VideoApp.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VideoDetail : ContentPage
	{
		public VideoDetail (Models.Video video)
		{
			InitializeComponent ();
			BindingContext = new ViewModels.VideoDetailViewModel(this.GetVideoView(), video);
		}

		public VideoView GetVideoView()
		{
			return VideoView;
		}
	}
}