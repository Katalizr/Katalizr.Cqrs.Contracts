using System;
using System.Threading;
using System.Threading.Tasks;
using Katalizr.Cqrs.Contracts.Handlers.Requests;
using Katalizr.Cqrs.Contracts.Models;

namespace Katalizr.Cqrs.Contracts.Handlers.Queries
{
  /// <summary>
  /// Represents an asynchronous query handler, that handle <see cref="IQuery{TResponse}"/>.
  /// </summary>
  /// <typeparam name="TQuery">The type of the query, inherits from <see cref="IQuery{TResponse}"/>.</typeparam>
  /// <typeparam name="TResponse">The type of the response.</typeparam>
  /// <inheritdoc cref="IAsynchronousRequestHandler{TRequest, TResponse}"/>
  public interface IAsynchronousQueryHandler<in TQuery, TResponse> : IAsynchronousRequestHandler<TQuery, TResponse> where TQuery : IQuery<TResponse>
  {
  }
}
