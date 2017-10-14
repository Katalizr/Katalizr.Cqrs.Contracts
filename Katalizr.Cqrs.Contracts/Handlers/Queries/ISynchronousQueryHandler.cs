using System;
using Katalizr.Cqrs.Contracts.Handlers.Requests;
using Katalizr.Cqrs.Contracts.Models;

namespace Katalizr.Cqrs.Contracts.Handlers.Queries
{
  /// <summary>
  /// Represents an synchronous query handler, that handle <see cref="IQuery{TResponse}"/>.
  /// </summary>
  /// <typeparam name="TQuery">The type of the query, inherits from <see cref="IQuery{TResponse}"/>.</typeparam>
  /// <typeparam name="TResponse">The type of the query.</typeparam>
  /// <inheritdoc cref="ISynchronousRequestHandler{TQuery,TResponse}"/>
  public interface ISynchronousQueryHandler<in TQuery, out TResponse> : ISynchronousRequestHandler<TQuery, TResponse> where TQuery : IQuery<TResponse>
  {
  }
}
