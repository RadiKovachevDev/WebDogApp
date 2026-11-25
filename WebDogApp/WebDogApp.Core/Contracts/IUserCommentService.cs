using WebDogApp.Infrastructure.Data.Domain;
namespace WebDogApp.Core.Contracts;
public interface IUserCommentService
{
    List<UserComment> GetAll();
    bool Add(string userName, string email, string comment);
}
