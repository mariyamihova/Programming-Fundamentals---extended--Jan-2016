
namespace User_Database_Two
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.IO;

    class Users
    {
        private static string dbPath = "users.txt";
        private static Dictionary<string,string> users =new Dictionary<string,string>();
        private static string loggedInuser = null;

        static void Main()
        {
            
            if (!File.Exists(dbPath))
            {
                File.Create(dbPath).Close();
            }

           var dbLines= File.ReadAllLines(dbPath);
            foreach (var line in dbLines)
            {
                var lineParts = line.Split(' ');
                var username = lineParts[0];
                var password = lineParts[1];

                users[username] = password;
            }

            var commands = File.ReadAllLines("input.txt");
            foreach (var command in commands)
            {
                var commandParts = command.Split(' ');
                switch(commandParts[0])
                {
                    case "register":
                        var username = commandParts[1];
                        var password = commandParts[2];
                        var confirmPassword = commandParts[3];
                        RegisterUser(username, password, confirmPassword);
                        break;
                    case "login":
                        username = commandParts[1];
                         password = commandParts[2];
                        LoginUser(username, password);
                        break;
                    case "logout":
                        Logout();
                        break;

                }
            }
        }

        public static void Logout()
        {
            if (loggedInuser==null)
            {
                Console.WriteLine("There is no currently logged in user.");
                return;
            }
            loggedInuser = null;
        }

        public static void LoginUser(string username, string password)
        {
            if (loggedInuser!=null)
            {
                Console.WriteLine("There is already a logged in user.");
                return;
            }
            if (!users.ContainsKey(username))
            {
                Console.WriteLine("There is no user with the given username.");
                return;
            }
            if (users[username]!=password)
            {
                Console.WriteLine("The password you entered is incorrect.");
                return;
            }
            loggedInuser = username;
        }

        public static void RegisterUser(string username, string password, string confirmPassword)
        {
            if (users.ContainsKey(username))
            {
                Console.WriteLine("The given username already exists.");
                return;
            }
            if (password!=confirmPassword)
            {
                Console.WriteLine("The two passwords must match.");
                return;
            }
            users[username] = password;
            File.AppendAllLines(dbPath, new[] { $"{username} {password}" });
        }
    }
}
