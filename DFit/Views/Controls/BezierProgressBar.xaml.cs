using Microsoft.Maui.Controls;
namespace DFit.Views.Controls;

public partial class BezierProgressBar : ContentView
{

	public static readonly BindableProperty BottomMiddleWidthProperty =
		BindableProperty.Create(nameof(BottomMiddleWidth), typeof(double), typeof(BezierProgressBar), 40d);
	public double BottomMiddleWidth { get => (double)GetValue(BottomMiddleWidthProperty); set => SetValue(BottomMiddleWidthProperty, value); }

	public static readonly BindableProperty BottomEdgeWidthProperty =
		BindableProperty.Create(nameof(BottomEdgeWidth), typeof(double), typeof(BezierProgressBar), 10d);
	public double BottomEdgeWidth { get => (double)GetValue(BottomEdgeWidthProperty); set => SetValue(BottomEdgeWidthProperty, value); }

	public static readonly BindableProperty TopMiddleWidthProperty =
		BindableProperty.Create(nameof(TopMiddleWidth), typeof(double), typeof(BezierProgressBar), 50d);
	public double TopMiddleWidth { get => (double)GetValue(TopMiddleWidthProperty); set => SetValue(TopMiddleWidthProperty, value); }

	public static readonly BindableProperty TopEdgeWidthProperty =
		BindableProperty.Create(nameof(TopEdgeWidth), typeof(double), typeof(BezierProgressBar), 0d);
	public double TopEdgeWidth { get => (double)GetValue(TopEdgeWidthProperty); set => SetValue(TopEdgeWidthProperty, value); }

	public static readonly BindableProperty TopHeightProperty =
		BindableProperty.Create(nameof(TopHeight), typeof(double), typeof(BezierProgressBar), 10d);
	public double TopHeight { get => (double)GetValue(TopHeightProperty); set => SetValue(TopHeightProperty, value); }

	public static readonly BindableProperty MiddleHeightProperty =
		BindableProperty.Create(nameof(MiddleHeight), typeof(double), typeof(BezierProgressBar), 40d);
	public double MiddleHeight { get => (double)GetValue(MiddleHeightProperty); set => SetValue(MiddleHeightProperty, value); }

	public static readonly BindableProperty BottomHeightProperty =
		BindableProperty.Create(nameof(BottomHeight), typeof(double), typeof(BezierProgressBar), 10d);
	public double BottomHeight { get => (double)GetValue(BottomHeightProperty); set => SetValue(BottomHeightProperty, value); }

	public BezierProgressBar()
	{
		InitializeComponent();
	}
}