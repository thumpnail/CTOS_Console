using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaitLib;


namespace CTOS_Console {
    public class CTOSmain {

        public static bool hacker_isInside = false;
        public static string userNameIn;
        public static string userPasswordIn;
        public static string filename;

        //Main function
        public static void Main() {
            welcome();
        }

        //"homescreen"
        public static void welcome() {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("hallo und herzlich willkommen zu");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("@@@@@ @@@@@@@ @@@@@@ @@@@@@");
            Console.WriteLine("@        @    @    @ @     ");
            Console.WriteLine("@        @    @    @ @@@@@@");
            Console.WriteLine("@        @    @    @      @");
            Console.WriteLine("@@@@@    @    @@@@@@ @@@@@@");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Anmeldung");
            Console.WriteLine();

            Console.Write("Benutzernamen: ");
            userNameIn = Console.ReadLine();
            Console.Write("Passwort: ");
            userPasswordIn = Console.ReadLine();
            login();
        }

        //login
        public static void login() {
            if (File.Exists(UserDB.userFolderPath + "/" + getFilename())) {
                UserDB.read();
                if (userNameIn.Equals(UserDB.name)) {
                    if (userPasswordIn.Equals(UserDB.password)) {
                        if (userNameIn.Equals("h4ck3r"))
                        {
                            Console.WriteLine("hacker angemeldet");
                            Console.Clear();
                            MainConsole.hackerConsole();
                        } else if (userNameIn.Equals("admin")) {
                            MainConsole.userConsole();
                        } else {
                            Console.WriteLine("erfolgreich");
                            Console.Clear();
                            MainConsole.userConsole();
                        }
                    } else {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("falsches passwort");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("drücke enter um es nochmal zu versuchen");
                        Console.ReadKey();
                        restart();
                    }
                } else {
                    errorAcc();
                }
            } else {
                errorAcc();
            }
            restart();
        }

        //logout
        public static void logout() {
            Wait.waitSec(4);
            Environment.Exit(0);
        }

        //restart the Console
        public static void restart() {
            Console.Clear();
            Main();
        }

        //put out the correct filename
        public static string getFilename() {
            filename = userNameIn + ".txt";
            return filename;
        }

        public static void errorAcc() {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("sie haben kein akkount. Bitte wenden sie sich an den admin.");
            Console.ForegroundColor = ConsoleColor.White;
            if (!(File.Exists(UserDB.fileFolderPath + "/file.txt"))) { UserDB.read(); }
            Console.WriteLine("drücke enter um es nochmal zu versuchen");
            Console.ReadKey();
            restart();
        }
    }
}