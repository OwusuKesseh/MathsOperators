using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MathsOperators.Models
{
    // Models returned by MeController actions.
    public class GetViewModel
    {
        public string DateOfBirth { get; set; }
    }
}