using System.Threading.Tasks;
using SwaggerPetstoreOpenApi30.Core.ErrorResponse;
using SwaggerPetstoreOpenApi30.Core.Models;

namespace SwaggerPetstoreOpenApi30.Errors;

public sealed class UploadFileError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private UploadFileError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static UploadFileError AsNoContent(RawError value) => new(Optional<RawError>.Some(value), default);

    private static UploadFileError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    private static Task<UploadFileError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 or 404 => response.RawBody().As(AsNoContent),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<UploadFileError> Response { get; } = new(Create);
}
