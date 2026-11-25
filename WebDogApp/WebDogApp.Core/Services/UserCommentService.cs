using WebDogApp.Core.Contracts;
using WebDogApp.Infrastructure.Data;
using WebDogApp.Infrastructure.Data.Domain;
namespace WebDogApp.Core.Services;
public class UserCommentService : IUserCommentService
{

    private readonly ApplicationDbContext _context;
    public UserCommentService(ApplicationDbContext context)
    {
        _context = context;
    }
    public List<UserComment> GetAll() => _context.UserComments.OrderByDescending(c => c.Id).ToList();
    public bool Add(string userName, string email, string comment)
    {


        _context.UserComments.Add(new UserComment { UserName = userName, Email = email, Comment = comment });
        return _context.SaveChanges() > 0;
    }
}
