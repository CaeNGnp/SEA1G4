using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4 {
    public abstract class User {
        public string Name { get; private set; }

        public string EmailAddress { get; private set; }

        public string ContactNo { get; private set; }
        public string UserId { get; private set; }

        /// <param name="n">name</param>
        /// <param name="c">contactt</param>
        /// <param name="e">email</param>
        /// <param name="id">id</param>
        public User(string n, string c, string e, string id) {
            Name = n;
            ContactNo = c;
            EmailAddress = e;
            UserId = id;
        }

        /// <summary>
        /// Write a console string to the user
        /// </summary>
        public void Write(string value) {
            string title = "User";
            ConsoleColor bgTitleColor = Console.BackgroundColor;
            ConsoleColor fgTitleColor = Console.ForegroundColor;

            if (this is Customer) {
                title = "Customer";
                bgTitleColor = ConsoleColor.Green;
                fgTitleColor = ConsoleColor.Black;
            } else if (this is Driver) {
                title = "Driver";
                bgTitleColor = ConsoleColor.Blue;
                fgTitleColor = ConsoleColor.White;
            } else if (this is Admin) {
                title = "Admin";
                bgTitleColor = ConsoleColor.Red;
                fgTitleColor = ConsoleColor.White;
            }

            Console.Write("> [");

            // Color the title
            Console.BackgroundColor = bgTitleColor;
            Console.ForegroundColor = fgTitleColor;
            Console.Write($"{title}");
            Console.ResetColor();

            Console.Write($" {Name}] {value}");
        }

        /// <summary>
        /// Write a console string to the user
        /// </summary>
        public void WriteLine(string value) {
            Write(value);
            Console.WriteLine();
        }
    }
}
