# Reference

Every operation below is shown in its throwing form. On an error status it throws `ApiException<TError>` — the status code, headers, content type and the operation's error type, `RawError` (the raw body) when the spec declares none — and where an operation offers an `…AsResult` sibling, that sibling returns `ApiResult<TResponse, TError>` instead. A request that produces no usable response surfaces as `SdkConnectionException` or `SdkTimeoutException`, a body that does not match the documented response type as `ResponseDeserializationException`, and a credential that cannot be applied as `AuthSchemeException`; all of them derive from `SdkException` and name the failed call. See [README → Error Handling](README.md#error-handling).

> Source: [SwaggerPetstoreOpenApi30Client](SwaggerPetstoreOpenApi30Client.cs)

## PetApi

> Source: [PetApi](Api/PetApi.cs)

<details>
<summary><code>Task&lt;Pet&gt; AddPet(AddPetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Add a new pet to the store.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PetApi.AddPet(new AddPetRequest
        {
            Name = "doggie",
            PhotoUrls = ["some example string"],
            Id = 10L,
        });
    // TODO: Handle 'response' of type Pet
}
catch (ApiException<AddPetError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AddPetRequest](Requests/PetApi/AddPetRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Pet](Models/Pet.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[AddPetError](Errors/AddPetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeletePet(DeletePetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a pet.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.PetApi.DeletePet(new DeletePetRequest
        {
            PetId = 10L,
        });
}
catch (ApiException<DeletePetError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeletePetRequest](Requests/PetApi/DeletePetRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeletePetError](Errors/DeletePetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;Pet&gt;&gt; FindPetsByStatus(FindPetsByStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Multiple status values can be provided with comma separated strings.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PetApi.FindPetsByStatus(new FindPetsByStatusRequest());
    // TODO: Handle 'response' of type IReadOnlyList<Pet>
}
catch (ApiException<FindPetsByStatusError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FindPetsByStatusRequest](Requests/PetApi/FindPetsByStatusRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[Pet](Models/Pet.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[FindPetsByStatusError](Errors/FindPetsByStatusError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;Pet&gt;&gt; FindPetsByTags(FindPetsByTagsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Multiple tags can be provided with comma separated strings. Use tag1, tag2, tag3 for testing.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PetApi.FindPetsByTags(new FindPetsByTagsRequest());
    // TODO: Handle 'response' of type IReadOnlyList<Pet>
}
catch (ApiException<FindPetsByTagsError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FindPetsByTagsRequest](Requests/PetApi/FindPetsByTagsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[Pet](Models/Pet.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[FindPetsByTagsError](Errors/FindPetsByTagsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Pet&gt; GetPetById(GetPetByIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a single pet.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PetApi.GetPetById(new GetPetByIdRequest
        {
            PetId = 10L,
        });
    // TODO: Handle 'response' of type Pet
}
catch (ApiException<GetPetByIdError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetPetByIdRequest](Requests/PetApi/GetPetByIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Pet](Models/Pet.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetPetByIdError](Errors/GetPetByIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Pet&gt; UpdatePet(UpdatePetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update an existing pet by Id.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PetApi.UpdatePet(new UpdatePetRequest
        {
            Name = "doggie",
            PhotoUrls = ["some example string"],
            Id = 10L,
        });
    // TODO: Handle 'response' of type Pet
}
catch (ApiException<UpdatePetError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdatePetRequest](Requests/PetApi/UpdatePetRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Pet](Models/Pet.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[UpdatePetError](Errors/UpdatePetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Pet&gt; UpdatePetWithForm(UpdatePetWithFormRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a pet resource based on the form data.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PetApi.UpdatePetWithForm(new UpdatePetWithFormRequest
        {
            PetId = 10L,
        });
    // TODO: Handle 'response' of type Pet
}
catch (ApiException<UpdatePetWithFormError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdatePetWithFormRequest](Requests/PetApi/UpdatePetWithFormRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Pet](Models/Pet.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[UpdatePetWithFormError](Errors/UpdatePetWithFormError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiResponseModel&gt; UploadFile(UploadFileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Upload image of the pet.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PetApi.UploadFile(new UploadFileRequest
        {
            PetId = 10L,
        });
    // TODO: Handle 'response' of type ApiResponseModel
}
catch (ApiException<UploadFileError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UploadFileRequest](Requests/PetApi/UploadFileRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiResponseModel](Models/ApiResponseModel.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[UploadFileError](Errors/UploadFileError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Store

> Source: [Store](Api/Store.cs)

<details>
<summary><code>Task DeleteOrder(DeleteOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

For valid response try integer IDs with value < 1000. Anything above 1000 or non-integers will generate API errors.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Store.DeleteOrder(new DeleteOrderRequest
        {
            OrderId = 1L,
        });
}
catch (ApiException<DeleteOrderError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteOrderRequest](Requests/Store/DeleteOrderRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteOrderError](Errors/DeleteOrderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyDictionary&lt;string, int&gt;&gt; GetInventory(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a map of status codes to quantities.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Store.GetInventory();
    // TODO: Handle 'response' of type IReadOnlyDictionary<string, int>
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyDictionary&lt;string, int&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Order&gt; GetOrderById(GetOrderByIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

For valid response try integer IDs with value <= 5 or > 10. Other values will generate exceptions.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Store.GetOrderById(new GetOrderByIdRequest
        {
            OrderId = 1L,
        });
    // TODO: Handle 'response' of type Order
}
catch (ApiException<GetOrderByIdError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetOrderByIdRequest](Requests/Store/GetOrderByIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Order](Models/Order.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetOrderByIdError](Errors/GetOrderByIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Order&gt; PlaceOrder(PlaceOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Place a new order in the store.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Store.PlaceOrder(new PlaceOrderRequest
        {
            Id = 10L,
            PetId = 198772L,
            Quantity = 7,
        });
    // TODO: Handle 'response' of type Order
}
catch (ApiException<PlaceOrderError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PlaceOrderRequest](Requests/Store/PlaceOrderRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Order](Models/Order.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PlaceOrderError](Errors/PlaceOrderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## UserApi

> Source: [UserApi](Api/UserApi.cs)

<details>
<summary><code>Task&lt;User&gt; CreateUser(CreateUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This can only be done by the logged in user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UserApi.CreateUser(new CreateUserRequest
        {
            Id = 10L,
            Username = "theUser",
            FirstName = "John",
            LastName = "James",
            Email = "john@email.com",
            Password = "12345",
            Phone = "12345",
            UserStatus = 1,
        });
    // TODO: Handle 'response' of type User
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateUserRequest](Requests/UserApi/CreateUserRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[User](Models/User.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;User&gt; CreateUsersWithListInput(CreateUsersWithListInputRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates list of users with given input array.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UserApi.CreateUsersWithListInput(new CreateUsersWithListInputRequest());
    // TODO: Handle 'response' of type User
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateUsersWithListInputRequest](Requests/UserApi/CreateUsersWithListInputRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[User](Models/User.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteUser(DeleteUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This can only be done by the logged in user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.UserApi.DeleteUser(new DeleteUserRequest
        {
            Usersname = "some example string",
        });
}
catch (ApiException<DeleteUserError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteUserRequest](Requests/UserApi/DeleteUserRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteUserError](Errors/DeleteUserError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;User&gt; GetUserByName(GetUserByNameRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get user detail based on username.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UserApi.GetUserByName(new GetUserByNameRequest
        {
            Usersname = "some example string",
        });
    // TODO: Handle 'response' of type User
}
catch (ApiException<GetUserByNameError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetUserByNameRequest](Requests/UserApi/GetUserByNameRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[User](Models/User.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetUserByNameError](Errors/GetUserByNameError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task LoginUser(LoginUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Log into the system.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.UserApi.LoginUser(new LoginUserRequest());
}
catch (ApiException<LoginUserError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[LoginUserRequest](Requests/UserApi/LoginUserRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[LoginUserError](Errors/LoginUserError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task LogoutUser(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Log user out of the system.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.UserApi.LogoutUser();
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task UpdateUser(UpdateUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This can only be done by the logged in user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.UserApi.UpdateUser(new UpdateUserRequest
        {
            Usersname = "some example string",
            Id = 10L,
            Username = "theUser",
            FirstName = "John",
            LastName = "James",
            Email = "john@email.com",
            Password = "12345",
            Phone = "12345",
            UserStatus = 1,
        });
}
catch (ApiException<UpdateUserError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateUserRequest](Requests/UserApi/UpdateUserRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[UpdateUserError](Errors/UpdateUserError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

