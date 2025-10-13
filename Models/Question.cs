namespace QuizApp.Models;


public class Question
{
    public int QuestionId { get; set; }
    public string QuestionText { get; set; } = string.Empty;

    public int QuizId { get; set; }
    public Quiz? Quiz { get; set; }

    public List<Answer> Answers { get; set; } = new();

}