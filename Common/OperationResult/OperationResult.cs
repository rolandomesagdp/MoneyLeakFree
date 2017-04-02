
namespace MoneyLeakFree.Common.OperationResult
{
    public class OperationResult<T> where T : class
    {
        public T Entity { get; set; }

        public OperationResultType OperationResultType { get; set; }

        public string Message { get; set; }
    }
}
