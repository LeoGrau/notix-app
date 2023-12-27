namespace Notix.API.Shared.Domain.Service.Communication;

public class BaseResponse<TEntity>
{
    public TEntity? Resource { get; set; }
    public bool Success { get; set; }
    public string Message { get; set; }

    public BaseResponse(TEntity resource)
    {
        Resource = resource;
        Success = true;
        Message = string.Empty;
    }

    public BaseResponse(string message)
    {
        Resource = default;
        Success = false;
        Message = message;
    }
}