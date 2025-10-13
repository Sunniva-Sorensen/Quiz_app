using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizApp.Models
{
    public class Answer
    {
        [Key]
        public int AnswerId { get; set; }

        [Required, StringLength(300)]
        public string Text { get; set; } = string.Empty;

        public bool IsCorrect { get; set; }

        [ForeignKey(nameof(Question))]
        public int QuestionId { get; set; }
        public Question? Question { get; set; }
    }
}