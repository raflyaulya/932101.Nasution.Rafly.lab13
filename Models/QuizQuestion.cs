using System.ComponentModel.DataAnnotations;

namespace _932101.Nasution.Rafly.lab13.Models
{
    public record QuizQuestion(int firstNumber, int secondNumber, string operation, int answer);
}