<!-- Generated file — do not edit; regenerated with the SDK. -->

# UserApi — operations

Accessor: `client.UserApi` · Source: `src/SwaggerPetstoreOpenApi3100/Api/UserApi.cs` · 7 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateUser

- **Signature**: `CreateUser(CreateUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `User`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateUserRequest` | `src/SwaggerPetstoreOpenApi3100/Requests/UserApi/CreateUserRequest.cs` |
| `User` | `src/SwaggerPetstoreOpenApi3100/Models/User.cs` |

### CreateUsersWithListInput

- **Signature**: `CreateUsersWithListInput(CreateUsersWithListInputRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `User`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateUsersWithListInputRequest` | `src/SwaggerPetstoreOpenApi3100/Requests/UserApi/CreateUsersWithListInputRequest.cs` |
| `User` | `src/SwaggerPetstoreOpenApi3100/Models/User.cs` |

### DeleteUser

- **Signature**: `DeleteUser(DeleteUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CurrentUsername`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeleteUserError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteUserRequest` | `src/SwaggerPetstoreOpenApi3100/Requests/UserApi/DeleteUserRequest.cs` |
| `DeleteUserError` | `src/SwaggerPetstoreOpenApi3100/Errors/DeleteUserError.cs` |

### GetUserByName

- **Signature**: `GetUserByName(GetUserByNameRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CurrentUsername`
- **Returns**: `User`
- **Error**: `ApiException<GetUserByNameError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetUserByNameRequest` | `src/SwaggerPetstoreOpenApi3100/Requests/UserApi/GetUserByNameRequest.cs` |
| `User` | `src/SwaggerPetstoreOpenApi3100/Models/User.cs` |
| `GetUserByNameError` | `src/SwaggerPetstoreOpenApi3100/Errors/GetUserByNameError.cs` |

### LoginUser

- **Signature**: `LoginUser(LoginUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `username` ← `Username`, `password` ← `Password`
- **Returns**: `void` (Task)
- **Error**: `ApiException<LoginUserError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `LoginUserRequest` | `src/SwaggerPetstoreOpenApi3100/Requests/UserApi/LoginUserRequest.cs` |
| `LoginUserError` | `src/SwaggerPetstoreOpenApi3100/Errors/LoginUserError.cs` |

### LogoutUser

- **Signature**: `LogoutUser(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

### UpdateUser

- **Signature**: `UpdateUser(UpdateUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CurrentUsername`
- **Returns**: `void` (Task)
- **Error**: `ApiException<UpdateUserError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateUserRequest` | `src/SwaggerPetstoreOpenApi3100/Requests/UserApi/UpdateUserRequest.cs` |
| `UpdateUserError` | `src/SwaggerPetstoreOpenApi3100/Errors/UpdateUserError.cs` |

