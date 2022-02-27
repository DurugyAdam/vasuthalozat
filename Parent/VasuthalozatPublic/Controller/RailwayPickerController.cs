using VasuthalozatCommon.Auth;

namespace VasuthalozatPublic.Controller
{
    public class RailwayPickerController
    {
        private readonly IAuthenticator authenticator = UserAuthenticator.Instance;

        public void SubscibeToLogout(IAuthenticator.LogoutDelegate logoutDelegate)
        {
            authenticator.LogoutEvent += logoutDelegate;
        }

        public void UnsubscribeFromLogout(IAuthenticator.LogoutDelegate logoutDelegate)
        {
            authenticator.LogoutEvent -= logoutDelegate;
        }

        public void Logout()
        {
            authenticator.Logout();
        }
    }
}
