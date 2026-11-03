<!-- Generated file — do not edit; regenerated with the SDK. -->

# Store — operations

Accessor: `client.Store` · Source: `src/SwaggerPetstoreOpenApi3100/Api/Store.cs` · 7 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ArchivedOrders

- **Signature**: `ArchivedOrders(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `IReadOnlyList<Order>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Order` | `src/SwaggerPetstoreOpenApi3100/Models/Order.cs` |

### DeleteOrder

- **Signature**: `DeleteOrder(DeleteOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `OrderId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeleteOrderError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteOrderRequest` | `src/SwaggerPetstoreOpenApi3100/Requests/Store/DeleteOrderRequest.cs` |
| `DeleteOrderError` | `src/SwaggerPetstoreOpenApi3100/Errors/DeleteOrderError.cs` |

### GetInventory

- **Auth**: `options.ApiKey`
- **Signature**: `GetInventory(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `IReadOnlyDictionary<string, int>`
- **Error**: `ApiException<RawError>` — **Case B**

### GetOrderById

- **Signature**: `GetOrderById(GetOrderByIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `OrderId`
- **Returns**: `Order`
- **Error**: `ApiException<GetOrderByIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetOrderByIdRequest` | `src/SwaggerPetstoreOpenApi3100/Requests/Store/GetOrderByIdRequest.cs` |
| `Order` | `src/SwaggerPetstoreOpenApi3100/Models/Order.cs` |
| `GetOrderByIdError` | `src/SwaggerPetstoreOpenApi3100/Errors/GetOrderByIdError.cs` |

### GetStoreAnnouncements

- **Signature**: `GetStoreAnnouncements(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `StoreAnnouncement`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `StoreAnnouncement` | `src/SwaggerPetstoreOpenApi3100/Models/StoreAnnouncement.cs` |

### GetStoreStatus

- **Signature**: `GetStoreStatus(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `StoreStatus`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `StoreStatus` | `src/SwaggerPetstoreOpenApi3100/Models/StoreStatus.cs` |

### PlaceOrder

- **Signature**: `PlaceOrder(PlaceOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `Order`
- **Error**: `ApiException<PlaceOrderError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PlaceOrderRequest` | `src/SwaggerPetstoreOpenApi3100/Requests/Store/PlaceOrderRequest.cs` |
| `OrderStatus` | `src/SwaggerPetstoreOpenApi3100/Models/Enums/OrderStatus.cs` |
| `Order` | `src/SwaggerPetstoreOpenApi3100/Models/Order.cs` |
| `PlaceOrderError` | `src/SwaggerPetstoreOpenApi3100/Errors/PlaceOrderError.cs` |

