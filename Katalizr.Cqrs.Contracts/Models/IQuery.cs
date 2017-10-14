namespace Katalizr.Cqrs.Contracts.Models
{
  /// <summary>
  /// Represents a query with an expected response.
  /// </summary>
  /// <typeparam name="TResponse"></typeparam>
  public interface IQuery<out TResponse> : IRequest<TResponse>
  {
  }
}
