using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobAgent.Core.Exceptions;

public class DuplicateJobException : Exception
{
    public DuplicateJobException(string url)
        : base($"A job with URL '{url}' already exists.")
    {
    }
}
