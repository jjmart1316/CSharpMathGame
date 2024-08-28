namespace MathGame
{
  public class Quiz
  {
    public Dictionary<int, string> Types = new() {
        {1, "Addition"},
        {2, "Subtraction"},
        {3, "Multiplication"},
        {4, "Division"}
    };

    public Quiz() { }

    public string GetQuizName(int id) => Types[id];
    public int GetQuizId(string value) => Types.FirstOrDefault(x => x.Value == value).Key;

    public static void AdditionGame(User user)
    {
      Random random = new();
      int a = random.Next(0, 100);
      int b = random.Next(0, 100);
      DisplayHeader(user);
      Console.WriteLine($"Solve for X: {a} + {b} = X");
      Console.Write("X = ");
      int x = Convert.ToInt32(Console.ReadLine());
      if (a + b == x)
      {
        CorrectAnswer(user);
      }
      else
      {
        IncorrectAnswer(user);
      }
    }
    public static void SubtractionGame(User user)
    {
      DisplayHeader(user);
      Console.WriteLine("This is the sub game");
    }
    public static void MultiplicationGame(User user)
    {
      DisplayHeader(user);
      Console.WriteLine("This is the mul game");
    }
    public static void DivisionGame(User user)
    {
      DisplayHeader(user);
      Console.WriteLine("This is the div game");
    }
    public static void DisplayHeader(User user)
    {
      Console.WriteLine("***************************************************************");
      Console.Write($"Player name: {user.Username}");
      Console.Write(" | ");
      Console.Write($"Current Quiz: {user.CurrentGame}");
      Console.Write(" | ");
      Console.Write($"Score: {user.CurrentScore}");
      Console.WriteLine();
      Console.WriteLine("***************************************************************");
    }

    public static void CorrectAnswer(User user)
    {
      Console.WriteLine("Correct!");
      user.CurrentScore += 10;
    }
    public static void IncorrectAnswer(User user) {
      Console.WriteLine("Incorrect!!");
      user.CurrentScore = 0;
    }
  }
}