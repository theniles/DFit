using DFit.Views.Converters;
using Microsoft.Maui.Controls;
namespace DFit.Views.Controls;

public partial class WaterGlassProgressBar : ContentView
{
    /// <summary>
    /// Size of the glass in pixels
    /// </summary>
	public static readonly BindableProperty SizeProperty =
		BindableProperty.Create(nameof(Size), typeof(double), typeof(WaterGlassProgressBar), 100d);
	public double Size { get => (double)GetValue(SizeProperty); set => SetValue(SizeProperty, value); }

    /// <summary>
    /// Scale of the base width
    /// </summary>
    public static readonly BindableProperty BaseWidthProperty =
        BindableProperty.Create(nameof(BaseWidth), typeof(double), typeof(WaterGlassProgressBar), .4d);
    public double BaseWidth { get => (double)GetValue(BaseWidthProperty); set => SetValue(BaseWidthProperty, value); }

    /// <summary>
    /// Scale of the edge width
    /// </summary>
    public static readonly BindableProperty EdgeWidthProperty =
    BindableProperty.Create(nameof(EdgeWidth), typeof(double), typeof(WaterGlassProgressBar), .1d);
    public double EdgeWidth { get => (double)GetValue(EdgeWidthProperty); set => SetValue(EdgeWidthProperty, value); }

    /// <summary>
    /// Scale of the glass height
    /// </summary>
    public static readonly BindableProperty GlassHeightProperty =
    BindableProperty.Create(nameof(GlassHeight), typeof(double), typeof(WaterGlassProgressBar), 1d);
    public double GlassHeight { get => (double)GetValue(GlassHeightProperty); set => SetValue(GlassHeightProperty, value); }

    /// <summary>
    /// Scale of until where the glass will be filled
    /// </summary>
    public static readonly BindableProperty WaterHeightProperty =
        BindableProperty.Create(nameof(WaterHeight), typeof(double), typeof(WaterGlassProgressBar), .8d, coerceValue: CoerceWaterHeight);
    public double WaterHeight { get => (double)GetValue(WaterHeightProperty); set => SetValue(WaterHeightProperty, value); }

    /// <summary>
    /// Randomness in water generation
    /// </summary>
    public static readonly BindableProperty SaltProperty =
        BindableProperty.Create(nameof(Salt), typeof(double), typeof(WaterGlassProgressBar), 0d);
    public double Salt { get => (double)GetValue(SaltProperty); set => SetValue(SaltProperty, value); }

    /// <summary>
    /// Constant translation in water generation
    /// </summary>
    public static readonly BindableProperty DeltaProperty =
        BindableProperty.Create(nameof(Delta), typeof(double), typeof(WaterGlassProgressBar), 0d);
    public double Delta { get => (double)GetValue(DeltaProperty); set => SetValue(DeltaProperty, value); }

    /// <summary>
    /// Progress, clamped from 0 to 1
    /// </summary>
    public static readonly BindableProperty ProgressProperty =
        BindableProperty.Create(nameof(Progress), typeof(double), typeof(WaterGlassProgressBar), 0d, coerceValue: CoerceProgress);
    public double Progress { get => (double)GetValue(ProgressProperty); set => SetValue(ProgressProperty, value); }

    public static object CoerceProgress(BindableObject bindable, object value)
    {
        return Math.Clamp((double)value, 0d, 1d);
    }

    public static object CoerceWaterHeight(BindableObject bindable, object value)
    {
        return Math.Min((double)value, ((WaterGlassProgressBar)bindable).GlassHeight);
    }

    public WaterGlassProgressBar()
	{
		InitializeComponent();
	}
}