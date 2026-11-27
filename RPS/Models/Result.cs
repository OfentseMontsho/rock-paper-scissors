using System;
using System.Collections.Generic;
using System.Text;

//Data object summarizing turn results:
namespace RPS.Models
{
    public class Result
    {
        public Move PlayerMove { get; set; }
        public Move MovePredictor { get; set; }
        public string? Winner { get; set; }
        public int Damage { get; set; }
        public bool CriticalHit { get; set; }
        public bool IsTie => Winner == null;
    }
}
