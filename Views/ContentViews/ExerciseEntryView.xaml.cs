using FitDiary.Models;

namespace FitDiary.Views.ContentViews;

public partial class ExerciseEntryView : ContentView
{
    public Action<ExerciseModel> OnSave;

	public ExerciseEntryView(ExerciseModel data)
	{
		InitializeComponent();
        ExerciseName.Text = data.ExerciseName;
        WeightEntry.Text = data.Weight.ToString();
        RepsEntry.Text = data.Reps.ToString();
        SetsEntry.Text = data.Sets.ToString();

       // OnSave = onSave;
	}

    private void SaveClicked(object sender, EventArgs e)
    {
        ExerciseModel data = new ExerciseModel(ExerciseName.Text, float.Parse(WeightEntry.Text), Int32.Parse(RepsEntry.Text), Int32.Parse(SetsEntry.Text));
        OnSave?.Invoke(data);
    }

    // should be destroyed instead
    private void CancelClicked(object sender, EventArgs e)
    {
        IsVisible = false;
    }

    public void Show() => IsVisible = true;
    public void Hide() => IsVisible = false;

}