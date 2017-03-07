using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.OperationResult
{
    public class OperationResultBuilder<T> where T : class
    {
        public OperationResult<T> BuildOperationResult(T entity, OperationResultType type, string message)
        {
            var operationResultToReturn = new OperationResult<T>()
            {
                Entity = entity,
                OperationResultType = type,
                Message = message
            };

            return operationResultToReturn;
        }
    }
}
