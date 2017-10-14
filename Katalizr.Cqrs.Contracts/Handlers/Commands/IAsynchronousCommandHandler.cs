using System;
using System.Threading;
using System.Threading.Tasks;
using Katalizr.Cqrs.Contracts.Handlers.Requests;
using Katalizr.Cqrs.Contracts.Models;

namespace Katalizr.Cqrs.Contracts.Handlers.Commands
{
  /// <summary>
  /// Represents an asynchronous command handler, that handle <see cref="ICommand"/>.
  /// </summary>
  /// <typeparam name="TCommand">The type of the command, inherits from <see cref="ICommand"/>.</typeparam>
  /// <exception cref="ArgumentNullException">The command is null.</exception>
  /// <inheritdoc cref="IAsynchronousRequestHandler{TRequest}"/>
  public interface IAsynchronousCommandHandler<in TCommand> : IAsynchronousRequestHandler<TCommand> where TCommand : ICommand
  {
  }

  /// <summary>
  /// Represents an asynchronous command handler, that handle <see cref="ICommand{TResponse}"/>
  /// </summary>
  /// <typeparam name="TCommand">The type of the command, inherits from <see cref="ICommand{TResponse}"/>.</typeparam>
  /// <typeparam name="TResponse">The type of the response.</typeparam>
  /// <inheritdoc cref="IAsynchronousRequestHandler{TRequest,TReponse}"/>
  public interface IAsynchronousCommandHandler<in TCommand, TResponse> : IAsynchronousRequestHandler<TCommand, TResponse> where TCommand : ICommand<TResponse>
  {
  }
}
