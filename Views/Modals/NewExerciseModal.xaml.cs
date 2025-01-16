using FitDiary.Models;

namespace FitDiary.Views.Modals;

public partial class NewExerciseModal : ContentPage
{
	public NewExerciseModal()
	{
		InitializeComponent();
	}

    private void SaveClicked(object sender, EventArgs e)
    {

    }

    private void CancelClicked(object sender, EventArgs e)
    {
        Navigation.PopModalAsync();
    }
}