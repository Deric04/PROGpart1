using System;
using System.Media;
using System.Runtime.ConstrainedExecution;
using System.Threading;

namespace CyberSecurityAwarenessBot
{
    class Program
    {
        static string userName = "";

        static void Main(string[] args)
        {
            Console.Title = "Cybersecurity Awareness Bot";

            PlayVoiceGreeting();
            DisplayLogo();
            GetUserName();
            DisplayWelcome();
            ChatLoop();
        }

        // Voice Greeting
        static void PlayVoiceGreeting()
        {
            try
            {
                SoundPlayer player = new SoundPlayer(@"C:\Users\tshep\OneDrive\Desktop\ProgPART1\greeting.wav");
                player.Load();
                player.PlaySync(); // waits for audio to finish
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Voice greeting file not found.");
                Console.ResetColor();
            }
        }

        // ASCII Logo
        static void DisplayLogo()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(  "===================================================================================================");
            Console.WriteLine("                                  CYBERSECURITY AWARENESS BOT");
            Console.WriteLine(" ===================================================================================================");
            Console.WriteLine(@"          __________
                                         /          \
                                        /   ______   \

                                       |   /      \   |
                                       |  |        |  |
                                       |  |        |  |
                                  _____|__|________|__|_____
                                 /                          \

                                |    ____________________    |
                                |   |                    |   |
                                |   |     [ LOCKED ]     |   |
                                |   |____________________|   |
                                |              __            |
                                |             (  )           |
                                |              ||            |
                                 \_____________||___________/

                                                                    CYBER AWARENESS BOT by Tshephang Matsepe

                                                    ");

            Console.ResetColor();
        }

        // Ask for user's name
        static void GetUserName()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Please enter your name: ");
            Console.ResetColor();

            userName = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(userName))
            {
                Console.Write("Name field cannot be empty. Please re-enter your name: ");
                userName = Console.ReadLine();
            }
        }

        // Welcome message
        static void DisplayWelcome()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

            TypeEffect($"\nHello {userName}! Welcome to the Cybersecurity Awareness Bot.");
            TypeEffect("I'm here to help you stay safe online.");
            TypeEffect("You can ask me about passwords, phishing, or safe browsing.");
            TypeEffect("Type 'exit' anytime to close the chatbot.\n");

            Console.ResetColor();
        }

        // Chat loop
        static void ChatLoop()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write($"{userName}: ");
                Console.ResetColor();

                string input = Console.ReadLine().ToLower();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Bot: Please type a question so I can help.");
                    continue;
                }

                if (input.Contains("exit"))
                {
                    Console.WriteLine("Bot: Goodbye! Stay safe online.");
                    break;
                }

                string response = GetResponse(input);
                TypeEffect("Bot: " + response);
            }
        }

        // Chatbot responses
        static string GetResponse(string input)
        {
            if (input.Contains("how are you"))
                return "I'm functioning perfectly and ready to help you stay safe online.";

            if (input.Contains("purpose"))
                return "My purpose is to teach people about cybersecurity awareness.";

            if (input.Contains("what can i ask"))
                return "You can ask me about password safety, phishing, and safe browsing.";

            if (input.Contains("password"))
                return "Use strong passwords with uppercase, lowercase, numbers and symbols.Use passphrases (4–5 random words) at least 12–16 characters long. Length is harder for AI to crack than short, complex codes. Never reuse passwords.";

            if (input.Contains("phishing"))
                return "Phishing is when attackers trick you into revealing personal information through fake emails or websites. Always verify the sender's email address and avoid clicking on suspicious links. Use Phishing-Resistant MFA, move away from SMS codes to FIDO2 security keys or Passkeys, which are much harder to intercept or relay.\r\n";

            if (input.Contains("browsing"))
                return "Always check website URLs, avoid suspicious downloads, and never click unknown links. Always enable \"HTTPS-Only\" mode in your settings to ensure your connection to every site is scrambled and secure. Treat browser extensions as high-risk. Only install what is necessary and delete any you don't use, as they can be updated to include spyware.\r\n";

            return "I didn't quite understand that. Could you rephrase?";
        }

        // Typing effect
        static void TypeEffect(string message)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(25);
            }
            Console.WriteLine();
        }
    }
}

