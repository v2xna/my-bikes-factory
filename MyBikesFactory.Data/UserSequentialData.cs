using MyBikesFactory.Business; // Don't Forget
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikesFactory.Data
{
    public class UserSequentialData
    {
        public const string COLUMN_SEPARATOR = ",";

        public static string GetFilePath()
        {
            return AppDomain.CurrentDomain.BaseDirectory + @"\login.txt";
        }

        // Load File Method
        public static List<User> Load()
        {
            var listOfUsers = new List<User>();
            string filePath = GetFilePath();

            // if this file exist
            if (!File.Exists(filePath))
                return listOfUsers;

            // if it exists
            string data = File.ReadAllText(filePath);

            // removes blank spaces
            if(data.Trim().Length == 0)
                return listOfUsers;

            // Splitting our data , Every record is an object
            string[] lines = data.Split(Environment.NewLine);

            // Loop our lines
            foreach (string line in lines)
            {
                // get our values for that line, now we split line based on column separator
                // every new line and goes down = 0- user 1- pass
                string[] lineFields = line.Split(COLUMN_SEPARATOR);

                string username = lineFields[0];
                string password = lineFields[1];

                var user = new User(username, password); // constructor

                listOfUsers.Add(user);
            }
            return listOfUsers;
        }
    }
}
