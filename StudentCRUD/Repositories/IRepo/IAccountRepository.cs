using Microsoft.AspNetCore.Identity;
using StudentCRUD.Models;

namespace StudentCRUD.Repositories.IRepo
{
    public interface IAccountRepository
    {
        public Task<IdentityResult> SignUpAsync(SignUpModel model);
        public Task<string> SignInAsync(SignInModel model);
    }
}
