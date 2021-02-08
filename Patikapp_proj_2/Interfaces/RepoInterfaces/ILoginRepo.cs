namespace Patikapp_proj_2.Repositories
{
    interface ILoginRepo
    {
        bool logIn(string username, string psw);
        bool isAdmin();
    }
}