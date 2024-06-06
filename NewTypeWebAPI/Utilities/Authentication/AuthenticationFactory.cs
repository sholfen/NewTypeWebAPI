using NewTypeWebAPI.Utilities.Cache;

namespace NewTypeWebAPI.Utilities.Authentication
{
    //todo: add sso function

    public enum LoginType
    {
        AccountPassword = 1,
        AccountPasswordWithOPT = 2,
        AccountPasswordWithAuthCode = 3,
        SSO = 4,
    }

    public class BaseLoginModel
    {
        public LoginType LoginType { get; set; }

        public bool ValidModel()
        {
            return true;
        }
    }

    public class UserAccountLoginModel : BaseLoginModel
    {
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public UserAccountLoginModel()
        {
            LoginType = LoginType.AccountPassword;
        }
    }

    public class ValidationCodeLoginModel : BaseLoginModel
    {
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string ValidationCode { get; set; } = string.Empty;
    }

    public class SSOHandler
    {
        public void ReceiveSSOToken(string token)
        {
            if (string.IsNullOrEmpty(token))
            {
            }
        }
    }

    public interface IAuthenticator
    {
        bool Authenticate(BaseLoginModel loginModel);
    }

    public class AuthenticationFactory
    {
        private static AuthenticationFactory? instance;

        private AuthenticationFactory()
        {

        }

        public static AuthenticationFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AuthenticationFactory();
                }
                return instance;
            }
        }

        public IAuthenticator GetAuthenticator(LoginType loginType)
        {
            IAuthenticator? authenticator = null;

            return authenticator;
        }
    }

    //public class NormalAuthenticator : IAuthenticator
    //{
    //    private ICacheManager _users;
    //    private ICacheManager _userNameMapping;

    //    public NormalAuthenticator()
    //    {
    //        _users = new MemoryCacheManager();
    //        _userNameMapping = new MemoryCacheManager();
    //    }

    //    public bool Authenticate(BaseLoginModel loginModel)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
