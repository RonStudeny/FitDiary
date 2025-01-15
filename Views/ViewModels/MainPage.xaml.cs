using FitDiary.Models;
using FitDiary.Views.ContentViews;
using FitDiary.Views.Modals;

namespace FitDiary.Views.ViewModels;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
        ExerciseModel.Nav = Navigation;


        AppModel app = new AppModel();
        app.Sessions.Add(new SessionModel());
        app.Sessions[0].Exercises.Add(new ExerciseModel("Bench press", 75, 5, 3));
        app.Sessions[0].Exercises.Add(new ExerciseModel("Squat", 85, 9, 3));
        app.Sessions[0].Exercises.Add(new ExerciseModel("Deadlift", 120, 3, 2));

        
        
        


        foreach (var exercise in app.Sessions[0].Exercises)
        {
            ExerciseView exerciseView = new ExerciseView(exercise.ToString());
            exerciseView.GetTapRecognizer().Tapped += exercise.OnTap;
            ExerciseContainer.Children.Add(exerciseView);
        }

    }

    

    //private void PushDialogue(ExerciseModel exercise)
    //{
    //    ExerciseEntryView dialogue = new ExerciseEntryView(exercise);
    //    dialogue.IsVisible = true;
    //}

}
