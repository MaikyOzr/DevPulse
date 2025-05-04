namespace DevPulse.Shared.Responses;

public class ApiResponse<T>
{
    public ApiResponse(){}
    
    public ApiResponse(string message, bool success = false, string error = "", T data = default)
    {
        Message = message;
        Success = success;
        Error = error;
        Data = data;
    }
    public T Data { get; set; }

    public string Message { get; set; }

    public bool Success { get; set; }

    public string Error { get; set; }
}
