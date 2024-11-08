﻿namespace DotnetEdu.Domain.Entities;

// Question types for quizzes
public class QuizQuestion
{
    public string QuestionText { get; set; }
    public IEnumerable<string> Options { get; set; }
    public int CorrectAnswerIndex { get; set; }
}