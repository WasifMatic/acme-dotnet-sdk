<!-- Generated file — do not edit; regenerated with the SDK. -->

# UserApi — operations

Accessor: `client.UserApi` · Source: `Api/UserApi.cs` · 7 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateUser

- **Signature**: `CreateUser(CreateUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `User`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateUserRequest` | `Requests/UserApi/CreateUserRequest.cs` |
| `User` | `Models/User.cs` |

### CreateUsersWithListInput

- **Signature**: `CreateUsersWithListInput(CreateUsersWithListInputRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `User`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateUsersWithListInputRequest` | `Requests/UserApi/CreateUsersWithListInputRequest.cs` |
| `User` | `Models/User.cs` |

### DeleteUser

- **Signature**: `DeleteUser(DeleteUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Usersname`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeleteUserError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteUserRequest` | `Requests/UserApi/DeleteUserRequest.cs` |
| `DeleteUserError` | `Errors/DeleteUserError.cs` |

### GetUserByName

- **Signature**: `GetUserByName(GetUserByNameRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Usersname`
- **Returns**: `User`
- **Error**: `ApiException<GetUserByNameError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetUserByNameRequest` | `Requests/UserApi/GetUserByNameRequest.cs` |
| `User` | `Models/User.cs` |
| `GetUserByNameError` | `Errors/GetUserByNameError.cs` |

### LoginUser

- **Signature**: `LoginUser(LoginUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `username` ← `Username`, `password` ← `Password`
- **Returns**: `void` (Task)
- **Error**: `ApiException<LoginUserError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `LoginUserRequest` | `Requests/UserApi/LoginUserRequest.cs` |
| `LoginUserError` | `Errors/LoginUserError.cs` |

### LogoutUser

- **Signature**: `LogoutUser(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

### UpdateUser

- **Signature**: `UpdateUser(UpdateUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Usersname`
- **Returns**: `void` (Task)
- **Error**: `ApiException<UpdateUserError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateUserRequest` | `Requests/UserApi/UpdateUserRequest.cs` |
| `UpdateUserError` | `Errors/UpdateUserError.cs` |

