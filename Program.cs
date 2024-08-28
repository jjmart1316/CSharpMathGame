using MathGame;

User user = CreateUser();
StartGame(user);



Console.WriteLine(user);




static User CreateUser()
{
  Console.Write("What is your user name: ");
  string username = Console.ReadLine() ?? string.Empty;
  User user = new(username);
  return user;
}

static void StartGame(User user)
{

  user.QuizSelection();
  Boolean nextQuestion = true;
  while (nextQuestion)
  {
    user.StartQuiz();
  }

}
