using System;
using System.Threading;
using System.Threading.Tasks;
using Katalizr.Cqrs.Contracts.Models;

namespace Katalizr.Cqrs.Contracts.Handlers.Requests
{
  /// <summary>
  /// Represents an asynchronous request handler, that handle <see cref="IRequest"/>.
  /// </summary>
  /// <typeparam name="TRequest">The type of the request, inherits from <see cref="IRequest"/>.</typeparam>
  public interface IAsynchronousRequestHandler<in TRequest> where TRequest : IRequest
  {
    /// <summary>
    /// Handles the request with the appropriate request handler.
    /// </summary>
    /// <param name="request">The request to handle.</param>
    /// <returns>Returns a task representing the result of the processing of the request.</returns>
    /// <exception cref="ArgumentNullException">The request is null.</exception>
    Task Handle(TRequest request);

    /// <summary>
    /// Handles the request with the appropriate request handler.
    /// </summary>
    /// <param name="request">The request to handle.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the work. See <see cref="CancellationToken"/></param>
    /// <returns>Returns a task representing the result of the processing of the request.</returns>
    /// <exception cref="ArgumentNullException">The request is null.</exception>
    /// <exception cref="OperationCanceledException">The token has had cancellation requested.</exception>
    Task Handle(TRequest request, CancellationToken cancellationToken);
  }

  /// <summary>
  /// Represents an asynchronous request handler, that handle <see cref="IRequest{TResponse}"/>
  /// </summary>
  /// <typeparam name="TRequest">The type of the request, inherits from <see cref="IRequest{TResponse}"/>.</typeparam>
  /// <typeparam name="TResponse">The type of the response.</typeparam>
  public interface IAsynchronousRequestHandler<in TRequest, TResponse> where TRequest : IRequest<TResponse>
  {
    /// <summary>
    /// Handles the request with the appropriate request handler and return the associated result.
    /// </summary>
    /// <param name="request">The request to handle.</param>
    /// <returns>Returns a task representing the result of the processing of the request.</returns>
    /// <exception cref="ArgumentNullException">The request is null.</exception>
    Task<TResponse> Handle(TRequest request);

    /// <summary>
    /// Handles the request with the appropriate request handler and return the associated result.
    /// </summary>
    /// <param name="request">The request to handle.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the work. See <see cref="CancellationToken"/></param>
    /// <returns>Returns a task representing the result of the processing of the request.</returns>
    /// <exception cref="ArgumentNullException">The request is null.</exception>
    /// <exception cref="OperationCanceledException">The token has had cancellation requested.</exception>
    Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken);
  }
}
