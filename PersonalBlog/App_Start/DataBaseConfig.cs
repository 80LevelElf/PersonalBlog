using System.Linq;
using System.Web.Security;
using PersonalBlog.Entities.Enums;
using PersonalBlog.Logic.Managers;
using WebMatrix.WebData;

namespace PersonalBlog
{
	public class DataBaseConfig
	{
		public static void Initialize()
		{
			//Initialize SimpleMembershipProvider
			if (!WebSecurity.Initialized)
				WebSecurity.InitializeDatabaseConnection("MS_SQL", "User", "UserId", "Name", true);

			var roles = (SimpleRoleProvider)Roles.Provider;
			var membership = (SimpleMembershipProvider)Membership.Provider;

		    if (!roles.RoleExists("Admin"))
		    {
                roles.CreateRole("Admin");
                LogManager.LogSiteWork("Admin role was created");
            }

		    if (membership.GetUser("admin", false) == null)
		    {
                membership.CreateUserAndAccount("admin", "123456"/*TODO: change in production*/);
                LogManager.LogSiteWork("Admin user was created");
            }

			if (roles.GetRolesForUser("admin").All(i => i != "Admin"))
				roles.AddUsersToRoles(new[] { "admin" }, new[] { "Admin" });
		}
	}
}