


using System.Text;
using PracticalWork_2_Application_Design_Patterns.managers;
using PracticalWork_2_Application_Design_Patterns.models;

Console.OutputEncoding = Encoding.UTF8;

UserManager userManager = new UserManager();

User user1 = new User { Name = "Alice", Email = "alice@example.com" };
User user2 = new User { Name = "Bob", Email = "bob@example.com" };

userManager.AddUser(user1);
userManager.AddUser(user2);

Console.WriteLine("== После добавления ==");
foreach (var u in userManager.Users)
    Console.WriteLine($"{u.Name} ({u.Email}) — роль: {u.role ?? "нет"}");

userManager.GiveRoleToUser(user1, "Admin");
userManager.GiveRoleToUser(user2, "User");

Console.WriteLine("\n== После назначения ролей ==");
foreach (var u in userManager.Users)
    Console.WriteLine($"{u.Name} ({u.Email}) — роль: {u.role}");

User updatedBob = new User { Name = "Bobby", Email = "bob@example.com", role = "Moderator" };
userManager.UpdateUser(user2, updatedBob);

Console.WriteLine("\n== После обновления ==");
foreach (var u in userManager.Users)
    Console.WriteLine($"{u.Name} ({u.Email}) — роль: {u.role}");

userManager.RemoveUser(user1);

Console.WriteLine("\n== После удаления Alice ==");
foreach (var u in userManager.Users)
    Console.WriteLine($"{u.Name} ({u.Email}) — роль: {u.role}");