using System.Reflection;

namespace MathGame
{
  public class User(string username)
  {
    public string Username { get; set; } = username;
    public string CurrentGame { get; set; } = "Not selected";
    public int CurrentScore { get; set; } = 0;
    public int HighestScore { get; set; } = 0;
    public Quiz Quiz { get; set; } = new Quiz();
    public override string ToString() => $"username:{Username}, Current Game: {CurrentGame}, Current Score: {CurrentScore}, Highest Score: {HighestScore}";

    public void QuizSelection()
    {
      Quiz.DisplayHeader(this);
      int choice = -1;
      Console.WriteLine("Select the type of quiz");
      foreach (int key in Quiz.Types.Keys)
      {
        Console.WriteLine($"{key}: {Quiz.Types[key]}");
      }

      while (!Quiz.Types.ContainsKey(choice))
      {
        Console.Write("Select quiz type (number): ");
        string line = Console.ReadLine() ?? string.Empty;
        _ = int.TryParse(line, out choice);
      }
      CurrentGame = Quiz.Types[choice];
    }

    public void StartQuiz()
    {
      typeof(Quiz)?.GetMethod($"{CurrentGame}Game")?.Invoke(Quiz, [this]);
    }
  }
}