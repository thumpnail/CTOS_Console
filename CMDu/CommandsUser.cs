using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTOS_Console {
    public class CommandsUser {
        public static string line;
        public static int counter = 0;

        public static void addUser() {
            if (CTOS_Console.CTOSmain.rights == 3) {

                Console.WriteLine("Gebe einen Benutzernamen an");
                string nameCreateUser = Console.ReadLine();

                if (!(File.Exists(CTOS_Console.userDB.userFolderPath + "/" + nameCreateUser + ".txt"))) {

                    FileStream addUserFileStream = new FileStream(CTOS_Console.userDB.userFolderPath + "/" + nameCreateUser + ".txt", FileMode.Create);
                    StreamWriter addUserStreamWriter = new StreamWriter(addUserFileStream);

                    Console.Write("Gebe ein passwort an: ");
                    string passwordCreateUser = Console.ReadLine();
                    Console.Write("Gebe die rechts stufe an(1, 2, 3): ");
                    string rightsCreateUser = Console.ReadLine();

                    string[] linesUserCreate = { nameCreateUser, passwordCreateUser, rightsCreateUser };

                    addUserStreamWriter.WriteLine(linesUserCreate[0]);
                    addUserStreamWriter.WriteLine(linesUserCreate[1]);
                    addUserStreamWriter.WriteLine(linesUserCreate[2]);
                    addUserStreamWriter.Close();
                    addUserFileStream.Close();
                    CTOS_Console.Console.userConsole();

                } else {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Dieser Benutzer exestiert schon, melden sie sich an oder nehmen einen anderen benutzernamen");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                    CTOS_Console.Console.userConsole();
                }
            } else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("du benötigst admin rechte um einen benutzter anzulegen");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                CTOS_Console.Console.userConsole();
            }

        }

        public static void editUser() {
            //eingelesen = 1 // ändern = 2
            string a1 = "";
            string a2 = "", b2 = "";
            int c2 = 0;

            Console.Write("Benutzername : ");
            a1 = Console.ReadLine();

            if (CTOS_Console.CTOSmain.rights >= 3) {
                if (File.Exists(CTOS_Console.userDB.userFolderPath + "/" + a1 + ".txt")) {
                    StreamReader editUserStreamReader = new StreamReader(CTOS_Console.userDB.userFolderPath + "/" + a1 + ".txt");
                    while ((line = editUserStreamReader.ReadLine()) != null) {
                        if (counter == 0) {
                            a2 = line;
                        } else if (counter == 1) {
                            b2 = line;
                        } else if (counter == 2) {
                            c2 = Int32.Parse(line);
                        }
                        counter++;
                    }
                    Console.WriteLine(a2);
                    Console.WriteLine(b2);
                    Console.WriteLine(c2);
                    Console.ReadKey();
                    CTOS_Console.Console.userConsole();
                } else {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Dieser Benutzer exestiert nicht");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                    CTOS_Console.Console.userConsole();
                }
            } else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("du benötigst admin rechte um einen benutzter anzulegen");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                CTOS_Console.Console.userConsole();
            }
        }

        public static void listUser() {

        }

        public static void infoUser() {

        }

        public static void delUser() {
            if (CTOS_Console.CTOSmain.rights == 3) {
                Console.Write("Benutzer : ");
                string a1 = Console.ReadLine();
                File.Delete(CTOS_Console.userDB.userFolderPath + "/" + a1 + ".txt");
                Console.WriteLine("Benutzer " + a1 + " gelöscht");
            } else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("du benötigst admin rechte um einen benutzter anzulegen");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
            }
            CTOS_Console.Console.userConsole();

        }

        public static void listCommands() {
            Console.WriteLine("addUser");
            Console.WriteLine("editUser");
            Console.WriteLine("listUser");
            Console.WriteLine("infoUser");
            Console.WriteLine("delUser");
            Console.WriteLine("logout");
            Console.ReadKey();
            CTOS_Console.Console.userConsole();
        }

        public static void logout() {
            CTOS_Console.CTOSmain.welcome();
        }

        //get called when the typer has typed the wrong command
        public static void wrongCommand() {

        }
    }
}
