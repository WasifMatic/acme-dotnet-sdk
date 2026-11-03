using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using SwaggerPetstoreOpenApi3100.Core;
using SwaggerPetstoreOpenApi3100.Core.Authentication;
using SwaggerPetstoreOpenApi3100.Core.ErrorResponse;
using SwaggerPetstoreOpenApi3100.Core.Exceptions;
using SwaggerPetstoreOpenApi3100.Core.Models;
using SwaggerPetstoreOpenApi3100.Core.Request;
using SwaggerPetstoreOpenApi3100.Core.Response;
using SwaggerPetstoreOpenApi3100.Errors;
using SwaggerPetstoreOpenApi3100.Models;
using SwaggerPetstoreOpenApi3100.Requests.Store;

namespace SwaggerPetstoreOpenApi3100.Api;

/// <summary>
/// Access to Petstore orders
/// </summary>
public sealed class Store
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Store(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get archived orders
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="Order"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns orders that have been archived by the store
    /// </remarks>
    public Task<IReadOnlyList<Order>> ArchivedOrders(RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/store/archivedOrders"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<Order>>(),
            RawErrorResponse.Instance,
            AuthScheme.None,
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Delete purchase order by identifier.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteOrderError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// For valid response try integer IDs with value &lt; 1000. Anything above 1000 or non-integers will generate API errors.
    /// </remarks>
    public Task DeleteOrder(DeleteOrderRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/store/order/{orderId}"),
            [new TemplateParam("orderId", request.OrderId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteOrderError.Response,
            AuthScheme.None,
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Returns pet inventories by status.
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyDictionary{TKey, TValue}"/> of <see cref="int"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a map of status codes to quantities.
    /// </remarks>
    public Task<IReadOnlyDictionary<string, int>> GetInventory(RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/store/inventory"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyDictionary<string, int>>(),
            RawErrorResponse.Instance,
            _auth.ApiKey,
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Find purchase order by ID.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Order"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetOrderByIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// For valid response try integer IDs with value &lt;= 5 or &gt; 10. Other values will generate exceptions.
    /// </remarks>
    public Task<Order> GetOrderById(GetOrderByIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/store/order/{orderId}"),
            [new TemplateParam("orderId", request.OrderId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Order>(),
            GetOrderByIdError.Response,
            AuthScheme.None,
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get store announcements
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="StoreAnnouncement"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the latest announcements published by the store
    /// </remarks>
    public Task<StoreAnnouncement> GetStoreAnnouncements(RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/store/announcements"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<StoreAnnouncement>(),
            RawErrorResponse.Instance,
            AuthScheme.None,
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get store status
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="StoreStatus"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the current operational status of the store
    /// </remarks>
    public Task<StoreStatus> GetStoreStatus(RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/store/status"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<StoreStatus>(),
            RawErrorResponse.Instance,
            AuthScheme.None,
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Place an order for a pet.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Order"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PlaceOrderError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Place a new order in the store.
    /// </remarks>
    public Task<Order> PlaceOrder(PlaceOrderRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/store/order"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(
                new Param("id", request.Id),
                new Param("petId", request.PetId),
                new Param("quantity", request.Quantity),
                new Param("shipDate", request.ShipDate),
                new Param("status", request.Status),
                new Param("complete", request.Complete)),
            JsonResponse.Create<Order>(),
            PlaceOrderError.Response,
            AuthScheme.None,
            requestOptions,
            cancellationToken);

    // CUSTOM CODE (QA #465 scenario 3): hand-written helper at the END of Store.cs, must survive regeneration
    public async Task<bool> TryPlaceOrder(PlaceOrderRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            await PlaceOrder(request, null, cancellationToken);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}
