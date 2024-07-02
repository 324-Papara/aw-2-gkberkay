namespace Pa.Api;

public class ApiResponse<T> 
{
    public T? Data { get; set; }
    public List<string> Errors { get; set; }
    public bool IsSuccess { get; set; }
    public string Message { get; set; }

    public ApiResponse(T data)
    {
        this.Data = data;
        this.IsSuccess = true;
        this.Errors = new List<string>();
        this.Message = "İşlem başarıyla gerçekleştirildi.";
    }

    public ApiResponse(List<string> messages)
    {
        this.IsSuccess = false;
        this.Errors = messages;
        this.Message = "İşlem gerçekleştirilemedi.";
    }
}