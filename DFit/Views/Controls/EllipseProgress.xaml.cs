using DFit.Views.Converters;
using Microsoft.Maui.Controls;
namespace DFit.Views.Controls;

public partial class EllipseProgress : ContentView
{

	public static readonly BindableProperty RadiusProperty =
		BindableProperty.Create(nameof(Radius), typeof(Size), typeof(EllipseProgress));
	public Size Radius { get => (Size)GetValue(RadiusProperty); set => SetValue(RadiusProperty, value); }


	public static readonly BindableProperty CenterProperty =
		BindableProperty.Create(nameof(Center), typeof(Point), typeof(EllipseProgress));
	public Point Center { get => (Point)GetValue(CenterProperty); set => SetValue(CenterProperty, value); }


	public static readonly BindableProperty ArcAngleProperty =
		BindableProperty.Create(nameof(ArcAngle), typeof(double), typeof(EllipseProgress));
	public double ArcAngle { get => (double)GetValue(ArcAngleProperty); set => SetValue(ArcAngleProperty, value); }


	public static readonly BindableProperty ProgressProperty =
		BindableProperty.Create(nameof(Progress), typeof(double), typeof(EllipseProgress));
	public double Progress { get => (double)GetValue(ProgressProperty); set => SetValue(ProgressProperty, value); }



	public EllipseProgress()
	{
		InitializeComponent();
		ArcAngle = Math.PI / 2;
		//SetBinding(ArcAngleProperty, new Binding(nameof(Progress), source: this, converter: new FractionToRadiansConverter(), mode: BindingMode.OneWay));
	}
}