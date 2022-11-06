using Microsoft.Maui.Controls;
namespace DFit.Views.Controls;

public partial class CircularProgressBar : ContentView
{

	public static readonly BindableProperty ProgressProperty =
		BindableProperty.Create(nameof(Progress), typeof(double), typeof(CircularProgressBar));
	public double Progress { get => (double)GetValue(ProgressProperty); set => SetValue(ProgressProperty, value); }


	public static readonly BindableProperty RadiusProperty =
		BindableProperty.Create(nameof(Radius), typeof(double), typeof(CircularProgressBar));
	public double Radius { get => (double)GetValue(RadiusProperty); set => SetValue(RadiusProperty, value); }


	

	public CircularProgressBar()
	{
		InitializeComponent();
		BindingContext = this;
	}
}