using BindERP.Connector.Modules.Communications.Contracts;

namespace BindERP.Connector.Modules.Communications;

public class CommunicationsModule : ICommunicationsModule
{
    public CommunicationsModule(IActivitiesService activities, ICommentsService comments)
    {
        this.ActivitiesService = activities;
        this.CommentsService   = comments;
    }

    public IActivitiesService ActivitiesService
    {
        get;
    }

    public ICommentsService CommentsService
    {
        get;
    }
}
