
using EnumExamples;

var user = new UserService().GetUser("jalaluddin");

if(user.Status == UserStatus.Inactive)
{

}
else if(user.Status == UserStatus.Active)
{

}
else
{

}

Console.WriteLine(UserStatus.Active.ToString());

int x = (int)UserStatus.Blocked;

Console.WriteLine(x);
