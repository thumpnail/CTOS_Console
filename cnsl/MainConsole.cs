using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTOS_Console;

namespace CTOS_Console {
    public class MainConsole {
        public static bool logout = false;
        public static bool controlHackerStartConsole = true;
        public static int i = 1;

        //Main User/Admin Console
        public static void userConsole() {
            Console.Clear();
            if (i == 1) {
                Console.WriteLine("an der user Console registriert");
                i++;
            }
            if (CTOS_Console.Equals("admin") && i == 2) {
                Console.WriteLine(">admin rights");
                i++;
            }
            Console.Write(">");
            string command = Console.ReadLine();
            if (command.Equals("addUser")) {
                CommandsUser.addUser();
            } else if (command.Equals("editUser")) {
                CommandsUser.editUser();
            } else if (command.Equals("listCommands")) {
                CommandsUser.listCommands();
            } else if (command.Equals("delUser")) {
                CommandsUser.delUser();
            } else if (command.Equals("logout")) {
                CommandsUser.logout();
            } else {
                Console.WriteLine("Unbekannter Befehl");
                Wait.waitSec(3);
                userConsole();
            }
        }

        //the Hacker Console
        public static void hackerConsole() {
            do {
                if (controlHackerStartConsole) {
                    controlHackerStartConsole = false;
                    Console.WriteLine("an der hacker Console registriert");
                }
                Console.Write(">");
                switch (Console.ReadLine()) {
                    default: {
                        CommandsHacker.wrongCommand();
                    }
                    break;
                    case "listCommands": {
                        CommandsHacker.listCommands();
                    }
                    break;
                    case "getPassword": {
                        CommandsHacker.getPassword();
                    }
                    break;
                    case "install_Backdoor": {
                        CommandsHacker.install_Backdoor();
                    }
                    break;
                    case "install_Virus": {
                        CommandsHacker.install_Virus();
                    }
                    break;
                    case "getBankAccounts": {
                        CommandsHacker.getBankAccounts();
                    }
                    break;
                    case "download_data": {
                        CommandsHacker.download_data();
                    }
                    break;
                    case "descript_data": {
                        CommandsHacker.descript_data();
                    }
                    break;
                    case "hack_ip": {
                        CommandsHacker.hack_ip();
                    }
                    break;
                    case "hack_Blackout": {
                        CommandsHacker.hack_Blackout();
                    }
                    break;
                    case "hack_Server": {
                        CommandsHacker.hack_Blackout();
                    }
                    break;
                    case "hack_Moilephone": {
                        CommandsHacker.hack_Moilephone();
                    }
                    break;
                    case "hack_firewall": {
                        CommandsHacker.hack_firewall();
                    }
                    break;
                    case "hack_antivirus": {
                        CommandsHacker.hack_antivirus();
                    }
                    break;
                    case "connect_client": {
                        CommandsHacker.connect_client();
                    }
                    break;
                    case "connect_server": {
                        CommandsHacker.connect_server();
                    }
                    break;
                    case "connect_mobilephone": {
                        CommandsHacker.connect_mobilephone();
                    }
                    break;
                    case "connect_internet": {
                        CommandsHacker.connect_internet();
                    }
                    break;
                    case "connect_google": {
                        CommandsHacker.connect_google();
                    }
                    break;
                    case "disconnect_ip": {
                        CommandsHacker.disconnect_ip();
                    }
                    break;
                    case "disconnect_client": {
                        CommandsHacker.disconnect_client();
                    }
                    break;
                    case "disconnect_server": {
                        CommandsHacker.disconnect_server();
                    }
                    break;
                    case "disconnect_mobilephone": {
                        CommandsHacker.disconnect_server();
                    }
                    break;
                    case "disconnect_internet": {
                        CommandsHacker.disconnect_internet();
                    }
                    break;
                    case "disconnect_google": {
                        CommandsHacker.disconnect_google();
                    }
                    break;
                    case "logout": {
                        CommandsHacker.logout();
                    }
                    break;
                    case "startHackSoftware": {
                        CommandsHacker.startHackSoftware();
                    }
                    break;
                }
            } while (!logout);
            CTOS_Console.CTOSmain.logout();
        }
    }
}
