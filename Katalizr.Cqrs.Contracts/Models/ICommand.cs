namespace Katalizr.Cqrs.Contracts.Models
{
  /// <summary>
  /// Represents a command
  /// </summary>
  public interface ICommand : IRequest
  {
  }

  /// <summary>
  /// Represents a command with an expected response.
  /// </summary>
  /// <typeparam name="TResponse"></typeparam>
  public interface ICommand<out TResponse> : IRequest<TResponse>
  {
  }
}
