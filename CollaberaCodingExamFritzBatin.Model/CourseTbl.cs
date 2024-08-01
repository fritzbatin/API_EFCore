using System;
using System.Collections.Generic;

namespace CollaberaCodingExamFritzBatin.Model;

public partial class CourseTbl
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? DegreeTypeId { get; set; }
}
