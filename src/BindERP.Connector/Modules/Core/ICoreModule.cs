using BindERP.Connector.Modules.Core.Contracts;

namespace BindERP.Connector.Modules.Core;

public interface ICoreModule
{
    public IBanksService BanksService
    {
        get;
    }

    public ICategoriesService CategoriesService
    {
        get;
    }

    public ICitiesService CitiesService
    {
        get;
    }

    public ICurrenciesService CurrenciesService
    {
        get;
    }

    public ILocationsService LocationsService
    {
        get;
    }

    public IPriceListsService PriceListsService
    {
        get;
    }

    public IProfilesService ProfilesService
    {
        get;
    }

    public ISeriesService SeriesService
    {
        get;
    }

    public IStatesService StatesService
    {
        get;
    }

    public IUsersService UsersService
    {
        get;
    }
        
}
