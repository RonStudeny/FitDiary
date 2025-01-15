using FitDiary.Models;

namespace FitDiary.Views.ContentViews;

public partial class ExerciseView : ContentView
{
	public static readonly BindableProperty ExerciseTextProperty = BindableProperty.Create(nameof(ExerciseText), typeof(string), typeof(ExerciseView), propertyChanged:
		(bindable, oldValue, newValue) => 
		{
			var control = (ExerciseView)bindable;

			control.LabelText.Text = (string) newValue;
		});
	public string ExerciseText
	{
		get => (string)GetValue(ExerciseTextProperty);
		set => SetValue(ExerciseTextProperty, value);
	}

    public ExerciseView()
    {
        InitializeComponent();
    }
    public ExerciseView(string s)
	{
		InitializeComponent();
		ExerciseText = s;
	}

	public TapGestureRecognizer GetTapRecognizer() => TapRecognizer;

    private void ExerciseTapped(object sender, TappedEventArgs e)
    {
		
    }
}