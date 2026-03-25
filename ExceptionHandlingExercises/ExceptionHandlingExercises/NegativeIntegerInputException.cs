using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingExercises
{
    public class NegativeIntegerInputException : Exception
    {

        public NegativeIntegerInputException(List<int> negatives) : base($"The following negative integer(s) are not allowed in this operation: [{String.Join(",", negatives)}]")
        {
        }
    }
}
