﻿using DotnetEdu.Domain.Commons;

namespace DotnetEdu.Domain.Entities;

// Detailed properties for Article lessons
public class LessonArticle : Auditable
{
    public string Content { get; set; } // Text content of the article
}
