using System.Threading.Tasks;
using SwaggerPetstoreOpenApi3100.Core.ErrorResponse;
using SwaggerPetstoreOpenApi3100.Core.Models;

namespace SwaggerPetstoreOpenApi3100.Errors;

public sealed class FindPetsByTagsError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private FindPetsByTagsError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static FindPetsByTagsError AsNoContent(RawError value) => new(Optional<RawError>.Some(value), default);

    private static FindPetsByTagsError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    private static Task<FindPetsByTagsError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 => response.RawBody().As(AsNoContent),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<FindPetsByTagsError> Response { get; } = new(Create);
}
