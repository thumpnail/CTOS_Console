using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaitLib;

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
            Wait.waitSec(1);
            Console.WriteLine(fileFolderPath);
            Wait.waitSec(1);

            System.IO.Directory.CreateDirectory(fileFolderPath);

            Wait.waitSec(1);
            Console.WriteLine(userFolderPath);
            Wait.waitSec(1);

            System.IO.Directory.CreateDirectory(userFolderPath);
            Wait.waitSec(1);
            StreamWriter adminWriter = new StreamWriter(userFolderPath + "/admin.txt");
            for (int i = 0; i < linesUser.Length; i++) {
                adminWriter.WriteLine(linesUser[i]);
            }
            adminWriter.Close();
            Wait.waitSec(1);

            Console.WriteLine(userFolderPath);
            System.IO.Directory.CreateDirectory(userFolderPath);
            Wait.waitSec(1);
            StreamWriter hackerWriter = new StreamWriter(fileFolderPath + "/h4ck3r.txt");
            for (int i = 0; i < lineHacker.Length; i++) {
                hackerWriter.WriteLine(lineHacker[i]);
            }
            hackerWriter.Close();
            Wait.waitSec(1);

            System.IO.File.WriteAllLines(fileFolderPath + "/file.txt", lineFile);
            Wait.waitSec(1);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please restart the programm!");
            Console.ForegroundColor = ConsoleColor.White;
            Wait.waitSec(3);
            Environment.Exit(0);

        }

        public static void read() {
            if (File.Exists(fileFolderPath + "/file.txt")) {
                System.IO.StreamReader fileFileRead = new System.IO.StreamReader(fileFolderPath + "/file.txt");
                userFolderPath = fileFileRead.ReadLine();

                System.IO.StreamReader userFileRead = new System.IO.StreamReader(userFolderPath + "/" + CTOS_Console.CTOSmain.getFilename());

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
