using System;
using System.Collections.Generic;
namespace SocialMediaFriendConnections
{
    // Class representing a User Node in the Singly Linked List
    class UserNode
    {
        public int UserID;
        public string Name;
        public int Age;
        public List<int> FriendIDs;
        public UserNode Next;

        public UserNode(int userID, string name, int age)
        {
            UserID = userID;
            Name = name;
            Age = age;
            FriendIDs = new List<int>();
            Next = null;
        }
    }

    // Class to manage the Social Media Friend Connections
    class FriendConnections
    {
        private UserNode head;

        // Add a User
        public void AddUser(int userID, string name, int age)
        {
            UserNode newUser = new UserNode(userID, name, age);
            if (head == null)
            {
                head = newUser;
                return;
            }

            UserNode temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newUser;
        }

        // Find User by ID
        private UserNode FindUser(int userID)
        {
            UserNode temp = head;
            while (temp != null)
            {
                if (temp.UserID == userID)
                    return temp;
                temp = temp.Next;
            }
            return null;
        }

        // Add Friend Connection between Two Users
        public void AddFriend(int userID1, int userID2)
        {
            UserNode user1 = FindUser(userID1);
            UserNode user2 = FindUser(userID2);

            if (user1 == null || user2 == null)
            {
                Console.WriteLine("One or both users not found!");
                return;
            }

            if (!user1.FriendIDs.Contains(userID2))
                user1.FriendIDs.Add(userID2);
            if (!user2.FriendIDs.Contains(userID1))
                user2.FriendIDs.Add(userID1);

            Console.WriteLine($"Friend connection added between {user1.Name} and {user2.Name}");
        }

        // Remove Friend Connection
        public void RemoveFriend(int userID1, int userID2)
        {
            UserNode user1 = FindUser(userID1);
            UserNode user2 = FindUser(userID2);

            if (user1 == null || user2 == null)
            {
                Console.WriteLine("One or both users not found!");
                return;
            }

            user1.FriendIDs.Remove(userID2);
            user2.FriendIDs.Remove(userID1);

            Console.WriteLine($"Friend connection removed between {user1.Name} and {user2.Name}");
        }

        // Find Mutual Friends
        public void FindMutualFriends(int userID1, int userID2)
        {
            UserNode user1 = FindUser(userID1);
            UserNode user2 = FindUser(userID2);

            if (user1 == null || user2 == null)
            {
                Console.WriteLine("One or both users not found!");
                return;
            }

            List<int> mutualFriends = new List<int>();

            foreach (int id in user1.FriendIDs)
            {
                if (user2.FriendIDs.Contains(id))
                    mutualFriends.Add(id);
            }

            Console.Write($"Mutual Friends of {user1.Name} and {user2.Name}: ");
            if (mutualFriends.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (int id in mutualFriends)
                {
                    UserNode mutualUser = FindUser(id);
                    Console.Write(mutualUser.Name + " ");
                }
                Console.WriteLine();
            }
        }

        // Display All Friends of a Specific User
        public void DisplayFriends(int userID)
        {
            UserNode user = FindUser(userID);
            if (user == null)
            {
                Console.WriteLine("User not found!");
                return;
            }

            Console.Write($"Friends of {user.Name}: ");
            if (user.FriendIDs.Count == 0)
            {
                Console.WriteLine("No Friends");
            }
            else
            {
                foreach (int id in user.FriendIDs)
                {
                    UserNode friend = FindUser(id);
                    Console.Write(friend.Name + " ");
                }
                Console.WriteLine();
            }
        }

        // Search User by Name or ID
        public void SearchUser(string nameOrID)
        {
            UserNode temp = head;
            while (temp != null)
            {
                if (temp.Name.Equals(nameOrID, StringComparison.OrdinalIgnoreCase) || temp.UserID.ToString() == nameOrID)
                {
                    Console.WriteLine($"User Found - ID: {temp.UserID}, Name: {temp.Name}, Age: {temp.Age}");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("User not found!");
        }

        // Count Friends for Each User
        public void CountFriends()
        {
            UserNode temp = head;
            while (temp != null)
            {
                Console.WriteLine($"{temp.Name} has {temp.FriendIDs.Count} friends.");
                temp = temp.Next;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FriendConnections network = new FriendConnections();

            while (true)
            {
                Console.WriteLine("\nSocial Media Friend Connections");
                Console.WriteLine("1. Add User");
                Console.WriteLine("2. Add Friend Connection");
                Console.WriteLine("3. Remove Friend Connection");
                Console.WriteLine("4. Find Mutual Friends");
                Console.WriteLine("5. Display All Friends of a User");
                Console.WriteLine("6. Search User");
                Console.WriteLine("7. Count Friends for Each User");
                Console.WriteLine("8. Exit");
                Console.Write("Enter Choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 8)
                {
                    Console.WriteLine("Exiting...");
                    break;
                }

                int userID, userID1, userID2;
                string name;
                int age;

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter User ID: ");
                        userID = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Name: ");
                        name = Console.ReadLine();
                        Console.Write("Enter Age: ");
                        age = Convert.ToInt32(Console.ReadLine());
                        network.AddUser(userID, name, age);
                        break;

                    case 2:
                        Console.Write("Enter First User ID: ");
                        userID1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Second User ID: ");
                        userID2 = Convert.ToInt32(Console.ReadLine());
                        network.AddFriend(userID1, userID2);
                        break;

                    case 3:
                        Console.Write("Enter First User ID: ");
                        userID1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Second User ID: ");
                        userID2 = Convert.ToInt32(Console.ReadLine());
                        network.RemoveFriend(userID1, userID2);
                        break;

                    case 4:
                        Console.Write("Enter First User ID: ");
                        userID1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Second User ID: ");
                        userID2 = Convert.ToInt32(Console.ReadLine());
                        network.FindMutualFriends(userID1, userID2);
                        break;

                    case 5:
                        Console.Write("Enter User ID: ");
                        userID = Convert.ToInt32(Console.ReadLine());
                        network.DisplayFriends(userID);
                        break;

                    case 6:
                        Console.Write("Enter User ID or Name: ");
                        name = Console.ReadLine();
                        network.SearchUser(name);
                        break;

                    case 7:
                        network.CountFriends();
                        break;

                    default:
                        Console.WriteLine("Invalid Choice! Try Again.");
                        break;
                }
            }
        }
    }
}
