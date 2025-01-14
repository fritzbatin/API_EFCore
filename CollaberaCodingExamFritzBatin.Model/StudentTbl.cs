﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CollaberaCodingExamFritzBatin.Model;

public partial class StudentTbl
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string CityId { get; set; } = null!;

    public int CourseId { get; set; }

    public int? GenderId { get; set; }
}

public class AddStudent
{
    public string Name { get; set; } = null!;

    public string CityId { get; set; } = null!;

    public int CourseId { get; set; }

    public int? GenderId { get; set; }
}

public class UpdateStudent
{
    public string Name { get; set; } = null!;

    public string CityId { get; set; } = null!;

    public int CourseId { get; set; }

    public int? GenderId { get; set; }
}