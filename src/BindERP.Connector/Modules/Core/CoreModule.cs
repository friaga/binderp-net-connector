using BindERP.Connector.Modules.Core.Contracts;

namespace BindERP.Connector.Modules.Core;

public class CoreModule : ICoreModule
{
    public CoreModule(IBanksService banks, ICategoriesService categories, ICitiesService cities, ICurrenciesService currencies, ILocationsService locations, IPriceListsService prices, IProfilesService profiles, ISeriesService series, IStatesService states, IUsersService users)
    {
        this.BanksService       = banks;
        this.CategoriesService  = categories;
        this.CitiesService      = cities;
        this.CurrenciesService  = currencies;
        this.LocationsService   = locations;
        this.PriceListsService  = prices;
        this.ProfilesService    = profiles;
        this.SeriesService      = series;
        this.StatesService      = states;
        this.UsersService       = users;
    }

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
