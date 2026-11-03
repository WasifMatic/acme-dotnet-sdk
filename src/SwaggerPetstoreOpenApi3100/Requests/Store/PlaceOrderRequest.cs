using System;
using SwaggerPetstoreOpenApi3100.Models.Enums;

namespace SwaggerPetstoreOpenApi3100.Requests.Store;

/// <summary>
/// The inputs of the PlaceOrder operation.
/// </summary>
public sealed record PlaceOrderRequest
{
    public long? Id { get; init; }

    public long? PetId { get; init; }

    public int? Quantity { get; init; }

    public DateTimeOffset? ShipDate { get; init; }

    /// <summary>
    /// Order Status
    /// </summary>
    public OrderStatus? Status { get; init; }

    public bool? Complete { get; init; }
}
