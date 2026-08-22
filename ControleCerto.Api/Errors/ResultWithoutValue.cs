namespace ControleCerto.Errors
{
    public class Result
    {
        private readonly AppError? _error;
        private readonly bool _isSuccess;

        private Result()
        {
            _isSuccess = true;
            _error = null;
        }

        public Result(AppError appError)
        {
            _error = appError;
            _isSuccess = false;
        }

        public static Result Success() => new();

        public static implicit operator Result(AppError error) => new(error);

        public bool IsSuccess => _isSuccess;
        public bool IsError => !_isSuccess;

        public AppError Error => !_isSuccess ? _error! : throw new InvalidOperationException("Result is a success");

        public TResult Match<TResult>(
            Func<TResult> onSuccess,
            Func<AppError, TResult> onError)
        {
            return _isSuccess ? onSuccess() : onError(_error!);
        }

        public override string ToString() => _isSuccess ? string.Empty : _error!.ErrorMessage ?? string.Empty;
    }
}
