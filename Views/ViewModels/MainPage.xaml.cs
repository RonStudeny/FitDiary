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
        app.Sessions[0].Exercises.Add(new ExerciseModel("Bench press"));
        app.Sessions[0].Exercises.Add(new ExerciseModel("Squat"));
        app.Sessions[0].Exercises.Add(new ExerciseModel("Deadlift"));
        app.Sessions[0].Exercises.Add(new ExerciseModel("Pulldown"));
        app.Sessions[0].Exercises.Add(new ExerciseModel("Row"));


        
        
        


        foreach (var exercise in app.Sessions[0].Exercises)
        {
            ExerciseView exerciseView = new ExerciseView(exercise.ExerciseName);
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
