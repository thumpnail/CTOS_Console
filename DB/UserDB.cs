using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTOS_Console {
    public class UserDB {
        public static string name;
        public static string password;
        public static int rights;
        public static string line;
        public static int counter = 0;
        public static string fileFolderPath = "C:/Users/" + currentUser() + "/Documents/CTOS";
        public static string userFolderPath = "C:/Users/" + currentUser() + "/Documents/CTOS/user";
        public static string[] linesUser = { "admin", "Asus1234", "3" };
        public static string[] lineFile = { userFolderPath };
        public static string[] lineHacker = { "h4ck3r", "hackmeifyoucan", "4" };
        public static string currentUserName;

        public static void creatFile() {

            Console.WriteLine(currentUser());
            CTOS_Console.Wait.waitSec(1);
            Console.WriteLine(fileFolderPath);
            CTOS_Console.Wait.waitSec(1);

            System.IO.Directory.CreateDirectory(fileFolderPath);
            CTOS_Console.Wait.waitSec(2);
            File.Create(fileFolderPath + "/file.txt");

            CTOS_Console.Wait.waitSec(2);
            Console.WriteLine(userFolderPath);
            CTOS_Console.Wait.waitSec(2);

            System.IO.Directory.CreateDirectory(userFolderPath);
            CTOS_Console.Wait.waitSec(2);
            File.Create(userFolderPath + "/admin.txt");
            CTOS_Console.Wait.waitSec(2);
            System.IO.File.WriteAllLines(userFolderPath + "/admin.txt", linesUser);
            CTOS_Console.Wait.waitSec(2);

            Console.WriteLine(userFolderPath);
            System.IO.Directory.CreateDirectory(userFolderPath);
            CTOS_Console.Wait.waitSec(2);
            File.Create(userFolderPath + "/h4ck3r.txt");
            CTOS_Console.Wait.waitSec(2);
            System.IO.File.WriteAllLines(userFolderPath + "/h4ck3r.txt", lineHacker);
            CTOS_Console.Wait.waitSec(2);

            System.IO.File.WriteAllLines(fileFolderPath + "/file.txt", lineFile);
            CTOS_Console.Wait.waitSec(2);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please restart the programm!");
            Console.ForegroundColor = ConsoleColor.White;
            CTOS_Console.Wait.waitSec(5);
            Environment.Exit(0);

        }

        public static void read() {
            if (File.Exists(fileFolderPath + "/file.txt")) {
                System.IO.StreamReader fileFileRead = new System.IO.StreamReader(fileFolderPath + "/file.txt");
                userFolderPath = fileFileRead.ReadLine();

                System.IO.StreamReader userFileRead = new System.IO.StreamReader(userFolderPath + "/" + CTOS_Console.);

                while ((line = userFileRead.ReadLine()) != null) {
                    if (counter == 0) {
                        name = line;
                    } else if (counter == 1) {
                        password = line;
                    } else if (counter == 2) {
                        rights = Int32.Parse(line);
                    }
                    counter++;
                }
                userFileRead.Close();
                fileFileRead.Close();
            } else {
                creatFile();
            }
        }
        public static string currentUser() {
            currentUserName = System.Environment.UserName;
            return currentUserName;
        }
    }
}
