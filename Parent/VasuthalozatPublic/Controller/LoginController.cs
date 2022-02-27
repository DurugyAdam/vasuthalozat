using VasuthalozatCommon.Model.UserHandling;
using VasuthalozatCommon.Auth;

namespace VasuthalozatPublic.Controller
{
    public class LoginController
    {
        private readonly IAuthenticator authenticator = UserAuthenticator.Instance;
        public User HandleLoginAttempt(string username, string password)
        {
            return authenticator.Authenticate(username, password);
        }
    }
}
