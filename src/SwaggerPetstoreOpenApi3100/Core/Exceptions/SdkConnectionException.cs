using System;

namespace SwaggerPetstoreOpenApi3100.Core.Exceptions;

public class SdkConnectionException(string message, Exception? innerException = null)
    : SdkException(message, innerException);
