using FitDiary.Views.Modals;
using System.Diagnostics;


namespace FitDiary.Models;

public class ExerciseModel
{
    public static INavigation Nav { get; set; }

    public ExerciseModel(string name, float weight, int reps, int sets)
    {
        ExerciseName = name;
        Weight = weight;
        Reps = reps;
        Sets = sets;

    }
    public ExerciseModel(string name)
    {
        ExerciseName = name;
    }

    public string ExerciseName { get; set; }
    public float Weight { get; set; }
    public int Reps { get; set; }
    public int Sets { get; set; }

    public override string ToString()
    {
        return $"{ExerciseName} {Weight} Kg - {Reps} reps for {Sets} sets";
    }

    public string GetPath()
    {
        var path = FileSystem.Current.AppDataDirectory;
        var fullPath = Path.Combine(path, ExerciseName);
        return fullPath;

    }

    public async void OnTap(object? sender, TappedEventArgs e)
    {
        Debug.WriteLine("This worked " + ExerciseName);
        await Nav.PushAsync(new ExerciseEntryModal(this));
    }

    public void SaveExercise()
    {
         File.AppendAllText(GetPath(),$"{this.ToString()}\n");
        //await Shell.Current.DisplayAlert("Saved!", ExerciseName + " has been saved", "Ok");
    }
}
