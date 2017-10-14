using System;
using Katalizr.Cqrs.Contracts.Handlers.Requests;
using Katalizr.Cqrs.Contracts.Models;

namespace Katalizr.Cqrs.Contracts.Handlers.Commands
{
  /// <summary>
  /// Represents an synchronous command handler, that handle <see cref="ICommand{TResponse}"/>.
  /// </summary>
  /// <typeparam name="TCommand">The type of the command, inherits from <see cref="ICommand{TResponse}"/>.</typeparam>
  /// <inheritdoc cref="ISynchronousRequestHandler{TRequest}"/>
  public interface ISynchronousCommandHandler<in TCommand> : ISynchronousRequestHandler<TCommand> where TCommand : ICommand
  {
  }

  /// <summary>
  /// Represents an synchronous command handler, that handle <see cref="ICommand{TResponse}"/>.
  /// </summary>
  /// <typeparam name="TCommand">The type of the command, inherits from <see cref="ICommand{TResponse}"/>.</typeparam>
  /// <typeparam name="TResponse">The type of the command.</typeparam>
  /// <inheritdoc cref="ISynchronousRequestHandler{TRequest,TResponse}"/>
  public interface ISynchronousCommandHandler<in TCommand, out TResponse> : ISynchronousRequestHandler<TCommand, TResponse> where TCommand : ICommand<TResponse>
  {
  }
}
