using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.OperationResult
{
    public class OperationResult<T> where T : class
    {
        public T Entity { get; set; }

        public OperationResultType OperationResultType { get; set; }

        public string Message { get; set; }
    }
}
