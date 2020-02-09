namespace WeatherApp.Common
{
    public class Result<T>
    {
        public T Value { get; }
        public bool IsSuccess { get; }
        public string Error { get; }
        public bool IsFailure => !IsSuccess;

        public Result(T value)
        {
            Value = value;
            IsSuccess = true;
        }

        public Result(bool isSuccess, string error)
        {
            Error = error;
            IsSuccess = false;
        }
    }
}
