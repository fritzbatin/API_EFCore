﻿using System;
using System.Collections.Generic;

namespace CollaberaCodingExamFritzBatin.Model;

public partial class SubjectTbl
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int StudentCapacity { get; set; }

    public bool? IsActive { get; set; }

    public int CourseId { get; set; }
}
