using FitDiary.Models;

namespace FitDiary.Views.Modals;

public partial class ExerciseEntryModal : ContentPage
{
    public Action<ExerciseModel> OnSave;
    private string localPath;
    public ExerciseEntryModal(ExerciseModel data)
	{
		InitializeComponent();

        ExerciseName.Text = data.ExerciseName;

        if (File.Exists(data.GetPath()))
        {
            localPath = data.GetPath();
            FileOutput.Text = File.ReadAllText(localPath); 
        }
    }

    private void SaveClicked(object sender, EventArgs e)
    {
        foreach (var control in Content.GetVisualTreeDescendants())
        {
            if (control is Entry entry && string.IsNullOrWhiteSpace(entry.Text))
            {
                DisplayAlert("Warning", "All entries must be filled", "Ok");
                return;
            }
                
        }
        ExerciseModel data = new ExerciseModel(ExerciseName.Text, float.Parse(WeightEntry.Text), Int32.Parse(RepsEntry.Text), Int32.Parse(SetsEntry.Text));
        data.SaveExercise();
        Navigation.PopModalAsync();
    }

    // should be destroyed instead
    private void CancelClicked(object sender, EventArgs e)
    {
        Navigation.PopModalAsync();

    }

    private void DeleteClicked(object sender, EventArgs e)
    {
        if (File.Exists(localPath))
        {
            File.Delete(localPath);
            Navigation.PopModalAsync();
        }
    }
}