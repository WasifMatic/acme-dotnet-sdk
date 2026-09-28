<!-- Generated file — do not edit; regenerated with the SDK. -->

# PetApi — operations

Accessor: `client.PetApi` · Source: `Api/PetApi.cs` · 8 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AddPet

- **Auth**: `options.PetstoreAuth`
- **Signature**: `AddPet(AddPetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Name`, `PhotoUrls`
- **Returns**: `Pet`
- **Error**: `ApiException<AddPetError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AddPetRequest` | `Requests/PetApi/AddPetRequest.cs` |
| `Category` | `Models/Category.cs` |
| `Tag` | `Models/Tag.cs` |
| `PetStatus` | `Models/Enums/PetStatus.cs` |
| `Pet` | `Models/Pet.cs` |
| `AddPetError` | `Errors/AddPetError.cs` |

### DeletePet

- **Auth**: `options.PetstoreAuth`
- **Signature**: `DeletePet(DeletePetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PetId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeletePetError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeletePetRequest` | `Requests/PetApi/DeletePetRequest.cs` |
| `DeletePetError` | `Errors/DeletePetError.cs` |

### FindPetsByStatus

- **Auth**: `options.PetstoreAuth`
- **Signature**: `FindPetsByStatus(FindPetsByStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `status` ← `Status`
- **Returns**: `IReadOnlyList<Pet>`
- **Error**: `ApiException<FindPetsByStatusError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FindPetsByStatusRequest` | `Requests/PetApi/FindPetsByStatusRequest.cs` |
| `PetStatus` | `Models/Enums/PetStatus.cs` |
| `Pet` | `Models/Pet.cs` |
| `FindPetsByStatusError` | `Errors/FindPetsByStatusError.cs` |

### FindPetsByTags

- **Auth**: `options.PetstoreAuth`
- **Signature**: `FindPetsByTags(FindPetsByTagsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `tags` ← `Tags`
- **Returns**: `IReadOnlyList<Pet>`
- **Error**: `ApiException<FindPetsByTagsError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FindPetsByTagsRequest` | `Requests/PetApi/FindPetsByTagsRequest.cs` |
| `Pet` | `Models/Pet.cs` |
| `FindPetsByTagsError` | `Errors/FindPetsByTagsError.cs` |

### GetPetById

- **Auth**: `options.ApiKey` OR `options.PetstoreAuth`
- **Signature**: `GetPetById(GetPetByIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PetId`
- **Returns**: `Pet`
- **Error**: `ApiException<GetPetByIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetPetByIdRequest` | `Requests/PetApi/GetPetByIdRequest.cs` |
| `Pet` | `Models/Pet.cs` |
| `GetPetByIdError` | `Errors/GetPetByIdError.cs` |

### UpdatePet

- **Auth**: `options.PetstoreAuth`
- **Signature**: `UpdatePet(UpdatePetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Name`, `PhotoUrls`
- **Returns**: `Pet`
- **Error**: `ApiException<UpdatePetError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 404, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdatePetRequest` | `Requests/PetApi/UpdatePetRequest.cs` |
| `Category` | `Models/Category.cs` |
| `Tag` | `Models/Tag.cs` |
| `PetStatus` | `Models/Enums/PetStatus.cs` |
| `Pet` | `Models/Pet.cs` |
| `UpdatePetError` | `Errors/UpdatePetError.cs` |

### UpdatePetWithForm

- **Auth**: `options.PetstoreAuth`
- **Signature**: `UpdatePetWithForm(UpdatePetWithFormRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PetId`
- **Query params (wire ← C#)**: `name` ← `Name`, `status` ← `Status`
- **Returns**: `Pet`
- **Error**: `ApiException<UpdatePetWithFormError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdatePetWithFormRequest` | `Requests/PetApi/UpdatePetWithFormRequest.cs` |
| `Pet` | `Models/Pet.cs` |
| `UpdatePetWithFormError` | `Errors/UpdatePetWithFormError.cs` |

### UploadFile

- **Auth**: `options.PetstoreAuth`
- **Signature**: `UploadFile(UploadFileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PetId`
- **Query params (wire ← C#)**: `additionalMetadata` ← `AdditionalMetadata`
- **Returns**: `ApiResponseModel`
- **Error**: `ApiException<UploadFileError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UploadFileRequest` | `Requests/PetApi/UploadFileRequest.cs` |
| `ApiResponseModel` | `Models/ApiResponseModel.cs` |
| `UploadFileError` | `Errors/UploadFileError.cs` |

