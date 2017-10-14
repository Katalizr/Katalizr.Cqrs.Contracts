namespace Katalizr.Cqrs.Contracts.Models
{
  public interface IRequest
  {
  }

  public interface IRequest<out TResponse>{}
}
