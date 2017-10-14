using System;
using Katalizr.Cqrs.Contracts.Models;

namespace Katalizr.Cqrs.Contracts.Handlers.Requests
{
  /// <summary>
  /// Represents an synchronous request handler, that handle <see cref="IRequest{TResponse}"/>.
  /// </summary>
  /// <typeparam name="TRequest">The type of the request, inherits from <see cref="IRequest{TResponse}"/>.</typeparam>
  public interface ISynchronousRequestHandler<in TRequest> where TRequest : IRequest
  {
    /// <summary>
    /// Handles the request with the appropriate command handler.
    /// </summary>
    /// <param name="request">The request to handle.</param>
    /// <exception cref="ArgumentNullException">The command is null.</exception>
    void Handle(TRequest request);
  }

  /// <summary>
  /// Represents an synchronous request handler, that handle <see cref="IRequest{TResponse}"/>.
  /// </summary>
  /// <typeparam name="TRequest">The type of the request, inherits from <see cref="IRequest{TResponse}"/>.</typeparam>
  /// <typeparam name="TResponse">The type of the request.</typeparam>
  public interface ISynchronousRequestHandler<in TRequest, out TResponse> where TRequest : IRequest<TResponse>
  {
    /// <summary>
    /// Handles the request with the appropriate request handler and return the associated result.
    /// </summary>
    /// <param name="request">The request to handle.</param>
    /// <returns>Returns the result of the processing of the request.</returns>
    /// <exception cref="ArgumentNullException">The command is null.</exception>
    TResponse Handle(TRequest request);
  }
}
