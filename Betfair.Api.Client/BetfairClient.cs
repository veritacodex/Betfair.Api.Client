using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Linq;
using System;
using Betfair.Api.Client.Model.Response;
using Betfair.Api.Client.Model.Request;

namespace Betfair.Api.Client;

public class BetfairApiClient(string certFolder)
{
    private readonly HttpClientHelper _httpClientHelper = new(certFolder);

    public async Task<Account> GetAccount()
    {
        var jsonResponse = await _httpClientHelper.GetResponse(RequestConstants.ACCOUNTS_API, "getAccountFunds/", null);
        var account = JsonConvert.DeserializeObject<Account>(jsonResponse);
        account.RequestedOn = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        return account;
    }

    public async Task<List<MarketCatalogue>> GetMarketCatalogue(string eventId)
    {
        var parameters = new Dictionary<string, object>
        {
            [RequestConstants.FILTER] = new MarketFilter { EventIds = new HashSet<string> { eventId } },
            [RequestConstants.MARKET_PROJECTION] = new HashSet<MarketProjection>
                {
                    MarketProjection.RUNNER_METADATA,
                    MarketProjection.COMPETITION
                }
            ,
            [RequestConstants.SORT] = null,
            [RequestConstants.MAX_RESULTS] = "100",
            [RequestConstants.LOCALE] = null
        };
        var jsonResponse = await _httpClientHelper.GetResponse(RequestConstants.BETTING_API, "listMarketCatalogue/", parameters);
        return JsonConvert.DeserializeObject<List<MarketCatalogue>>(jsonResponse);
    }

    public async Task<CurrentOrderSummaryReport> GetOrdersReport()
    {
        var parameters = new Dictionary<string, object>
        {
            [RequestConstants.BET_IDS] = null,
            [RequestConstants.MARKET_IDS] = null,
            [RequestConstants.ORDER_PROJECTION] = null,
            [RequestConstants.PLACED_DATE_RANGE] = null,
            [RequestConstants.ORDER_BY] = null,
            [RequestConstants.SORT_DIR] = null,
            [RequestConstants.FROM_RECORD] = null,
            [RequestConstants.RECORD_COUNT] = null
        };

        var jsonResponse = await _httpClientHelper.GetResponse(RequestConstants.BETTING_API, "listCurrentOrders/", parameters);
        return JsonConvert.DeserializeObject<CurrentOrderSummaryReport>(jsonResponse);
    }

    public async Task<List<EventTypeResult>> GetEventTypes()
    {
        var parameters = new Dictionary<string, object>
        {
            [RequestConstants.FILTER] = new MarketFilter(),
            [RequestConstants.LOCALE] = null
        };
        var jsonResponse = await _httpClientHelper.GetResponse(RequestConstants.BETTING_API, "listEventTypes/", parameters);
        return JsonConvert.DeserializeObject<List<EventTypeResult>>(jsonResponse);
    }

    public async Task<List<EventResult>> GetEvents(MarketFilter marketFilter)
    {
        var parameters = new Dictionary<string, object>
        {
            [RequestConstants.FILTER] = marketFilter,
            [RequestConstants.LOCALE] = null
        };
        var jsonResponse = await _httpClientHelper.GetResponse(RequestConstants.BETTING_API, "listEvents/", parameters);
        var events = JsonConvert.DeserializeObject<List<EventResult>>(jsonResponse);
        return [.. events.OrderBy(x => x.Event.OpenDate)];
    }

    public async Task<List<EventResult>> GetEvents(string eventTypeId, int numberDaysFuture)
    {
        var filter = new MarketFilter
        {
            EventTypeIds = new HashSet<string> { eventTypeId },
            MarketStartTime = new TimeRange
            {
                From = DateTime.Now.AddDays(-1),
                To = DateTime.Now.AddDays(numberDaysFuture),
            }
        };
        return await GetEvents(filter);
    }

    public async Task<MarketBook> GetMarketBook(string marketId)
    {
        var parameters = new Dictionary<string, object>
        {
            [RequestConstants.MARKET_IDS] = new List<string> { marketId },
            [RequestConstants.PRICE_PROJECTION] = new PriceProjection
            {
                Virtualise = false,
                PriceData = new HashSet<PriceData> { PriceData.EX_BEST_OFFERS }
            },
            [RequestConstants.ORDER_PROJECTION] = null,
            [RequestConstants.MATCH_PROJECTION] = null,
            [RequestConstants.LOCALE] = null,
            [RequestConstants.CURRENCY_CODE] = null
        };
        var jsonResponse = await _httpClientHelper.GetResponse(RequestConstants.BETTING_API, "listMarketBook/", parameters);
        var books = JsonConvert.DeserializeObject<List<MarketBook>>(jsonResponse);
        return books[0];
    }

    public async Task<AccountStatement> GetAccountStatement(TimeRange timeRange)
    {
        var parameters = new Dictionary<string, object>()
        {
            [RequestConstants.ITEM_DATE_RANGE] = timeRange
        };

        var jsonResponse = await _httpClientHelper.GetResponse(RequestConstants.ACCOUNTS_API, "getAccountStatement/", parameters);
        return JsonConvert.DeserializeObject<AccountStatement>(jsonResponse);
    }

    public async Task<PlaceOrderResponse> PlaceOrder(string marketId, PlaceInstruction instruction)
    {
        var parameters = new Dictionary<string, object>
        {
            [RequestConstants.MARKET_ID] = marketId,
            [RequestConstants.INSTRUCTIONS] = new List<PlaceInstruction> { instruction },
            [RequestConstants.LOCALE] = null,
        };
        var jsonResponse = await _httpClientHelper.GetResponse(RequestConstants.BETTING_API, "placeOrders/", parameters);
        return JsonConvert.DeserializeObject<PlaceOrderResponse>(jsonResponse);
    }
}
