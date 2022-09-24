using BindERP.Connector.Modules.Communications.Contracts;

namespace BindERP.Connector.Modules.Communications;

public interface ICommunicationsModule
{
    public IActivitiesService ActivitiesService
    {
        get;
    }

    public ICommentsService CommentsService
    {
        get;
    }
}
