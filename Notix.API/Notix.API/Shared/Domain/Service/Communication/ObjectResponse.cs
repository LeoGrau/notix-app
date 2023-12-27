namespace Notix.API.Shared.Domain.Service.Communication;

public class ObjectResponse : BaseResponse<Object>
{
    public ObjectResponse(object resource) : base(resource)
    {
    }

    public ObjectResponse(string message) : base(message)
    {
    }
}