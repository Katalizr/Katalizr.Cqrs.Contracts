using System;
using Katalizr.Cqrs.Contracts.Models;
using Katalizr.Cqrs.Contracts.Exceptions;

namespace Katalizr.Cqrs.Contracts.Dispatchers
{
  /// <summary>
  /// Represents an synchronous dispatcher.
  /// </summary>
  public interface ISynchronousDispatcher
  {
    /// <summary>
    /// Dispatches a request to the appropriate request handler.
    /// </summary>
    /// <param name="request">The request to dispatch.</param>
    /// <typeparam name="TRequest">The type of the request to process..</typeparam>
    /// <exception cref="ArgumentNullException">The request is null.</exception>
    /// <exception cref="NoHandlerFoundException">No request handler has been found for the request.</exception>
    /// <exception cref="MultipleHandlerFoundException">Too many request handler has been found for the request.</exception>
    void Dispatch<TRequest>(TRequest request) where TRequest : IRequest;

    /// <summary>
    /// Dispatches a request to the appropriate request handler.
    /// </summary>
    /// <param name="request">The request to dispatch.</param>
    /// <typeparam name="TRequest">The type of the request to process..</typeparam>
    /// <typeparam name="TResponse">The type of the response to return.</typeparam>
    /// <returns>The response that will be returned after the execution of the request handler.</returns>
    /// <exception cref="ArgumentNullException">The request is null.</exception>
    /// <exception cref="NoHandlerFoundException">No request handler has been found for the request.</exception>
    /// <exception cref="MultipleHandlerFoundException">Too many request handler has been found for the request.</exception>
    TResponse Dispatch<TRequest,TResponse>(TRequest request) where TRequest : IRequest<TResponse>;
  }
}
