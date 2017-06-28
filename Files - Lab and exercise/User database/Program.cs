//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.IO;

//namespace User_database
//{
//    class Program
//    {
//        static void Main()
//        {
//            var inputLine = Console.ReadLine();

//            var users = new Dictionary<string, string>();
//            var loggedUsers = new Dictionary<string, string>();
//            var registeredUsers = new List<string>();
//            if (!File.Exists("users.txt"))
//            {
//                File.Create("users.txt");
//            }
//            while (inputLine!="exit")
//            {
//               

                
//                else
//                {
//                    registeredUsers = File.ReadAllLines("users.txt").ToList();
//                }
//                if (splittedInput.Length==4)
//                {
//                    var username = splittedInput[1];
//                    var password = splittedInput[2];
//                    var confirmPassword = splittedInput[3];
//                    if (registeredUsers.Contains(username))
//                    {
//                        Console.WriteLine("The given username already exists");
//                    }
//                    else
//                    {
//                        if (!users.ContainsKey(username))
//                        {
//                            if (password != confirmPassword)
//                            {
//                                Console.WriteLine("The two passwords must match.");
//                            }
//                            else
//                            {
//                                users[username] = password;
//                            }
//                        }
//                        else
//                        {
//                            Console.WriteLine("The given username already exists.");
//                        }
//                    }
                    
//                }
//                else if (splittedInput.Length==3)
//                {
//                    var username = splittedInput[1];
//                    var password = splittedInput[2];
//                    if (loggedUsers.ContainsKey(username))
//                    {
//                        Console.WriteLine("There is already a logged in user.");
//                    }
//                    else
//                    {
//                        if (!users.ContainsKey(username))
//                        {
//                            Console.WriteLine("There is no user with the given username");
//                        }
//                        else
//                        {
//                            string value = string.Empty;
//                            users.TryGetValue(username, out value);
//                            if (value == password)
//                            {
//                                loggedUsers[username] = password;
//                            }
//                            else
//                            {
//                                Console.WriteLine("The password you entered is incorrect");
//                            }
//                        }
//                    }
                    

//                }
//                else if (splittedInput.Length==1)
//                {
//                    if (loggedUsers.Count==0)
//                    {
//                        Console.WriteLine("There is no currently logged in user.");
//                    }
//                    else
//                    {
//                        loggedUsers.Clear();
//                    }

//                }
//                inputLine = Console.ReadLine();
//            }
//            File.AppendAllLines("users.txt", users.Keys);
//        }
//    }
//}
