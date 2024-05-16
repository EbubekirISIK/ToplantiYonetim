namespace MeetingApp.Models
{
	public static class Repository
	{
		private static List<UserInfo> _users = new List<UserInfo>();
		static Repository()
		{
			_users.Add(new UserInfo() { id = 1, Name = "ali", Email = "ali@g.com", Phone = "120", WillAttend = true });
			_users.Add(new UserInfo() { id = 2, Name = "canan", Email = "canan@g.com", Phone = "210", WillAttend = true });
			_users.Add(new UserInfo() { id = 3, Name = "veli", Email = "veli@g.com", Phone = "546", WillAttend = false });

		}
		public static List<UserInfo> Users { get {  return _users; } }
		public static void CreateUser(UserInfo user) { 
			user.id = Users.Count + 1;
			_users.Add(user);
		}
		
		public static UserInfo? GetById(int id) {
			return _users.FirstOrDefault(user => user.id == id);
		}
	}
}
