using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Text.Json;
using System.Threading;

namespace OpenAI.Chat;

public partial class ChatClient
{
    /// <summary>
    /// [Protocol Method] Creates a streaming model response for the given chat conversation and returns raw JSON objects.
    /// </summary>
    /// <param name="content"> The content to send as the body of the request. </param>
    /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
    /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
    /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
    /// <returns> An async collection of raw JSON objects as BinaryData. </returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual AsyncCollectionResult<BinaryData> CompleteChatStreamingRawAsync(BinaryContent content, RequestOptions options = null)
    {
        Argument.AssertNotNull(content, nameof(content));
        
        return new AsyncSseUpdateCollection<BinaryData>(
            async () => await CompleteChatAsync(content, options).ConfigureAwait(false),
            DeserializeRawJsonData,
            options?.CancellationToken ?? CancellationToken.None);
    }

    /// <summary>
    /// [Protocol Method] Creates a streaming model response for the given chat conversation and returns raw JSON objects.
    /// </summary>
    /// <param name="content"> The content to send as the body of the request. </param>
    /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
    /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
    /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
    /// <returns> A collection of raw JSON objects as BinaryData. </returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual CollectionResult<BinaryData> CompleteChatStreamingRaw(BinaryContent content, RequestOptions options = null)
    {
        Argument.AssertNotNull(content, nameof(content));
        
        return new SseUpdateCollection<BinaryData>(
            () => CompleteChat(content, options),
            DeserializeRawJsonData,
            options?.CancellationToken ?? CancellationToken.None);
    }
    
    /// <summary>
    /// Deserializes an SSE item into a raw BinaryData object containing the JSON data.
    /// </summary>
    private static BinaryData DeserializeRawJsonData(JsonElement element, ModelReaderWriterOptions options)
    {
        return BinaryData.FromString(element.GetRawText());
    }
}