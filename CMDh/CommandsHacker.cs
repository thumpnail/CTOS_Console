using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CTOS_Console {
    public class CommandsHacker {



        //command parameter

        private static bool knowIP = false;
        private static string IP;
        private static bool knowPS = false;
        private static bool isConnectedClient = false;
        private static bool isConnectedServer = false;
        private static bool isConnectedMobilephone = false;
        private static bool isConnectedInternet = false;
        private static bool isConnectedGoogle = false;
        private static bool AntiVirus = false;
        private static bool firewall = false;
        private static bool Backdoor = false;
        private static bool ini = false;

        private static string[] hackerCommands = { /*0*/"listCommands", /*1*/"logout", /*2*/"startHackSoftware", /*3*/"getPassword",
            /*4*/"install_Backdoor", /*5*/"install_Virus", /*6*/"getBankAccounts", /*7*/"download_data", /*8*/"descript_data",
            /*9*/"hack_ip", /*10*/"hack_Blackout", /*11*/"hack_Server", /*12*/"hack_Moilephone", /*13*/"hack_firewall",
            /*14*/"hack_antivirus", /*15*/"connect_client", /*16*/"connect_server", /*17*/"connect_mobilephone",
            /*18*/"connect_internet", /*19*/"connect_google", /*20*/"disconnect_client", /*21*/"disconnect_server",
            /*22*/"disconnect_mobilephone", /*23*/"disconnect_internet", /*24*/"disconnect_google" };

        //Standard commands)

        public static void listCommands() {
            for (int i = 0; i < hackerCommands.Length; i++) {
                if (i == 0 || i == 1 || i == 2 || i == 3 || i == 9 || i == 18) {
                    Console.ForegroundColor = ConsoleColor.Green;
                } else {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                Console.WriteLine(hackerCommands[i]);

            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void logout() {
            CTOS_Console.MainConsole.logout = true;
            Console.Clear();
            CTOSmain.welcome();
        }

        //hacker commands

        public static void startHackSoftware() {

            Random rnd = new Random();

            for (int i = 0; i < rnd.Next(6, 20); i++) {
                Console.Write(".");
                CTOS_Console.Wait.waitSec(1);
            }

            ini = true;
            Console.WriteLine("hackSW wurde Initialisiert");
            Console.hackerConsole();
        }

        public static void getPassword() {

            Random rnd = new Random();

            if (ini) {
                if (knowIP && isConnectedClient && isConnectedInternet || knowIP && isConnectedGoogle && isConnectedInternet || knowIP && isConnectedMobilephone && isConnectedInternet || knowIP && isConnectedServer && isConnectedInternet) {
                    Console.WriteLine("Get component... Please wait");

                    for (int i = 0; i < rnd.Next(30, 100); i++) {
                        Console.Write(".");
                        wait.waitMilsec(rnd.Next(100, 2000));
                    }

                    Console.WriteLine("Component downloaded");
                    wait.waitSec(2);
                    Console.WriteLine("Search crack server...");

                    for (int i = 0; i < rnd.Next(30, 1000); i++) {
                        Console.Write(".");
                        wait.waitMilsec(rnd.Next(100, 2000));
                    }

                    Console.WriteLine("Crack server found");
                    wait.waitSec(2);
                    Console.WriteLine("Search password... Please wait");

                    for (int i = 0; i < rnd.Next(30, 100); i++) {
                        Console.Write(".");
                        wait.waitMilsec(rnd.Next(100, 2000));
                    }

                    Console.WriteLine("Password found");

                    knowPS = true;
                } else {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("you are not connected");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        public static void install_Backdoor() {

        }

        public static void install_Virus() {

        }

        public static void getBankAccounts() {

        }

        public static void download_data() {

        }

        public static void descript_data() {

        }

        public static void hack_ip() {
            if (ini) {
                Console.Write("IP: ");
                IP = Console.ReadLine();
                Console.WriteLine("got ip");
                knowIP = true;
            }
        }

        public static void hack_Blackout() {

        }

        public static void hack_Server() {

        }

        public static void hack_Moilephone() {

        }

        public static void hack_firewall() {

        }

        public static void hack_antivirus() {

        }

        public static void connect_client() {
            if (knowIP) {

            }
        }

        public static void connect_server() {

        }

        public static void connect_mobilephone() {

        }

        public static void connect_internet() {
            Random rnd = new Random();

            Console.Write("Connecting to Internet");

            do {
                for (int i = 0; i < rnd.Next(30, 100); i++) {
                    Console.Write(".");
                    wait.waitMilsec(rnd.Next(100, 2000));
                }
            } while (!connect_failure(1, 100, 50));

            Console.WriteLine();
            isConnectedInternet = true;
            Console.WriteLine("Connected to Internet");
        }

        public static void connect_google() {

        }

        public static void disconnect_ip() {

        }

        public static void disconnect_client() {

        }

        public static void disconnect_server() {

        }

        public static void disconnect_mobilephone() {

        }

        public static void disconnect_internet() {

        }

        public static void disconnect_google() {

        }

        public static void wrongCommand() {

        }

        public static bool connect_failure(int min, int max, int c) {
            Random rnd = new Random();
            int randomInt = rnd.Next(min, max);
            if (randomInt <= c) {
                return false;
            } else {
                return true;
            }
        }

    }
}
