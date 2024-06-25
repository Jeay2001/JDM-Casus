using System.Numerics;

namespace WellNexus
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welkom bij het JDM dashboard");

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("");
                MainMenu();
            }
        }

        // Main Menu
        public static void MainMenu()
        {
            Console.Clear();
            List<string> options = new List<string> {
                "Patient Menu",
                "Ouders Menu",
                "Fysiotherapeut Menu",
                "Doctor Menu",
                "Onderzoeker Menu",
                "Exit"
            };
            int choice = DisplayMenuOptions(options, "Main Menu - select an option");
            switch (choice)
            {
                case 1:
                    PatientMenu();
                    break;
                case 2:
                    OuderMenu();
                    break;
                case 3:
                    FysioMenu();
                    break;
                case 4:
                    DoctorMenu();
                    break;
                case 5:
                    OnderzoekerMenu();
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    MainMenu();
                    break;
            }
        }

        // Display Menu Options
        public static int DisplayMenuOptions(List<string> options, string title)
        {
            Console.WriteLine(title);
            for (int i = 0; i < options.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {options[i]}");
            }
            Console.Write("Please select an option: ");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > options.Count)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and " + options.Count);
            }
            return choice;
        }


        // Fysio menu
        public static void FysioMenu()
        {
            Console.Clear();
            List<string> options = new List<string> {
                "Onderzoek Menu",
                "Meldingen",
                "Patient Menu",
                "Terug naar Main Menu"
            };
            int choice = DisplayMenuOptions(options, "Fysio Menu - select an option");
            switch (choice)
            {
                case 1:
                    OnderzoekMenu();
                    break;
                case 2:
                    MeldingenMenu();
                    break;
                case 3:
                    PatientMenu();
                    break;
                case 4:
                    MainMenu();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    FysioMenu();
                    break;
            }
        }

        // Onderzoek menu
        public static void OnderzoekMenu()
        {
            Console.Clear();
            List<string> options = new List<string> {
                "Onderzoeken inzien",
                "Steekproef aanvragen",
                "Steekproef menu",
                "Arts Alarmeren",
                "Terug naar Fysio Menu"
            };
            int choice = DisplayMenuOptions(options, "Onderzoek Menu - select an option");
            switch (choice)
            {
                case 1:
                    OnderzoekenInzien();
                    break;
                case 2:
                    SteekproefAanvragen();
                    break;
                case 3:
                    SteekproefMenu();
                    break;
                case 4:
                    ArtsAlarmeren();
                    break;
                case 5:
                    FysioMenu();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    OnderzoekMenu();
                    break;
            }
        }

        // Onderzoeken inzien
        public static void OnderzoekenInzien()
        {
            Console.Clear();
            List<string> tests = new List<string> {
                "Test 1234",
                "Test 1235",
                "Test 1256",
                "Test 1356",
                "Test 8901",
                "Test 4572",
                "Test 0354",
                "Terug naar Onderzoek Menu"
            };

            int choice = DisplayMenuOptions(tests, "Onderzoeken inzien - select a test");
            if (choice == tests.Count)
            {
                OnderzoekMenu();
            }
            else
            {
                DisplayTestDetails(tests[choice - 1]);
            }
        }

        // Display test details
        public static void DisplayTestDetails(string testName)
        {
            Console.Clear();
            Console.WriteLine($"Test Inzien: {testName}");

            List<string> exercises = new List<string> {
                "Oefening 1 - Antwoord",
                "Oefening 2 - Antwoord",
                "Oefening 3 - Antwoord",
                "Oefening 4 - Antwoord"
            };

            Console.WriteLine("\nOefeningen:");
            foreach (var exercise in exercises)
            {
                Console.WriteLine(exercise);
            }

            Console.WriteLine("\nPress any key to return to the Onderzoeken inzien menu...");
            Console.ReadKey();
            OnderzoekenInzien();
        }

        // Steekproef aanvragen
        public static void SteekproefAanvragen()
        {
            Console.Clear();
            List<string> tests = new List<string> {
                "Test 1234",
                "Test 1235",
                "Test 1256",
                "Test 1356",
                "Test 8901",
                "Test 4572",
                "Test 0354",
                "Terug naar Onderzoek Menu"
            };

            int choice = DisplayMenuOptions(tests, "Steekproef aanvragen - select a test");
            if (choice == tests.Count)
            {
                OnderzoekMenu();
            }
            else
            {
                RequestSteekproef(tests[choice - 1]);
            }
        }

        // Request steekproef
        public static void RequestSteekproef(string testName)
        {
            Console.Clear();
            Console.WriteLine($"Steekproef aangevraagd voor: {testName}");
            Console.WriteLine("Uw steekproefaanvraag is ontvangen en wordt verwerkt.");

            Console.WriteLine("\nPress any key to return to the Steekproef aanvragen menu...");
            Console.ReadKey();
            SteekproefAanvragen();
        }

        // Steekproef menu
        public static void SteekproefMenu()
        {
            Console.Clear();
            List<string> steekproeven = new List<string> {
                "Steekproef 123",
                "Steekproef 234",
                "Steekproef 345",
                "Steekproef 456",
                "Terug naar Onderzoek Menu"
            };

            int choice = DisplayMenuOptions(steekproeven, "Steekproef Menu - select a steekproef");
            if (choice == steekproeven.Count)
            {
                OnderzoekMenu();
            }
            else
            {
                DisplaySteekproefDetails(steekproeven[choice - 1]);
            }
        }

        // Display steekproef details
        public static void DisplaySteekproefDetails(string steekproefName)
        {
            Console.Clear();
            Console.WriteLine($"Steekproef Menu: {steekproefName}");
            Console.WriteLine("Patient name: (name)");
            Console.WriteLine("Test: (test number)");
            Console.WriteLine("Datum en tijd: (time and date)");
            Console.WriteLine("Location: (location)");

            Console.WriteLine("\nClick to create report.");
            Console.WriteLine("\nAccept? Yes | No");

            Console.WriteLine("\nPress any key to return to the Steekproef Menu...");
            Console.ReadKey();
            SteekproefMenu();
        }

        // Arts alarmeren
        public static void ArtsAlarmeren()
        {
            Console.Clear();
            List<string> tests = new List<string> {
                "Test 1234",
                "Test 1235",
                "Test 1256",
                "Test 1356",
                "Test 8901",
                "Test 4572",
                "Test 0354",
                "Terug naar Onderzoek Menu"
            };

            int choice = DisplayMenuOptions(tests, "Arts Alarmeren - select a test");
            if (choice == tests.Count)
            {
                OnderzoekMenu();
            }
            else
            {
                AlertDoctor(tests[choice - 1]);
            }
        }

        // Alert doctor
        public static void AlertDoctor(string testName)
        {
            Console.Clear();
            Console.WriteLine($"Arts gealarmeerd voor: {testName}");
            Console.WriteLine("Uw bericht is verstuurd naar de arts.");

            Console.WriteLine("\nPress any key to return to the Arts Alarmeren menu...");
            Console.ReadKey();
            ArtsAlarmeren();
        }

        // Meldingen menu
        public static void MeldingenMenu()
        {
            Console.Clear();
            List<string> notifications = new List<string> {
                "U hebt een nieuw onderzoek ontvangen",
                "U heeft nu een steekproef in (location)",
                "Ouder heeft steekproef op (date) bevestigd",
                "Arts heeft een afspraak met u gemaakt",
                "Arts heeft u een nieuw bericht gestuurd",
                "Melding 6",
                "Melding 7",
                "Terug naar Fysio Menu"
            };

            int choice = DisplayMenuOptions(notifications, "Meldingen Menu - Notifications:");
            if (choice == notifications.Count)
            {
                FysioMenu();
            }
            else
            {
                Console.WriteLine(notifications[choice - 1]);
                Console.WriteLine("\nPress any key to return to the Meldingen Menu...");
                Console.ReadKey();
                MeldingenMenu();
            }
        }

        // Patient menu
        public static void PatientMenu()
        {
            Console.Clear();
            List<string> patients = new List<string> {
                "Patient 1",
                "Patient 2",
                "Patient 3",
                "Patient 4",
                "Patient 5",
                "Patient 6",
                "Patient 7",
                "Terug naar Main Menu"
            };

            int choice = DisplayMenuOptions(patients, "Patient Menu - select a patient");
            if (choice == patients.Count)
            {
                MainMenu();
            }
            else
            {
                DisplayPatientDetails(patients[choice - 1]);
            }
        }

        // Display patient details
        public static void DisplayPatientDetails(string patientName)
        {
            Console.Clear();
            Console.WriteLine($"Patient Menu: {patientName}");
            Console.WriteLine($"(patient age) (patient doctor)");
            Console.WriteLine($"(patient appointments)");
            Console.WriteLine($"(patient appointments)");
            Console.WriteLine($"(patient appointments)");

            Console.WriteLine("\nTests and reports:");
            List<string> tests = new List<string> {
                "Test 1234 - Inzien",
                "Test 1235 - Inzien",
                "Report 1235 - Inzien",
                "Test 1235 - Inzien"
            };

            foreach (var test in tests)
            {
                Console.WriteLine(test);
            }

            Console.WriteLine("\nNotes:");
            Console.WriteLine("Notes");

            Console.WriteLine("\nPress any key to return to the Patient Menu...");
            Console.ReadKey();
            PatientMenu();
        }



        // Ouders menu
        static void OuderMenu()
        {
            Console.Clear();
            Console.WriteLine("Welkom bij het Ouder menu.");
            Console.WriteLine("Kies een optie:");
            Console.WriteLine("1. Onderzoek goed/afkeuren");
            Console.WriteLine("2. Oefeningen menu");
            Console.WriteLine("3. Mededelingen");
            Console.WriteLine("4. Uitloggen");
            try
            {
                Console.WriteLine("Voer een keuze in (1-4):");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // Onderzoek goed/afkeuren
                        AcceptDenyResearch();
                        break;
                    case 2:
                        // Oefeningen menu
                        ExerciseMenu();
                        break;
                    case 3:
                        // Mededelingen
                        ShowAnnouncements();
                        break;
                    case 4:
                        // Uitloggen
                        Console.WriteLine("Optie 4 gekozen: Uitloggen.");
                        break;
                    default:
                        Console.WriteLine("Ongeldige keuze.");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Er is een fout opgetreden: " + e.Message);
            }
        }

        static void AcceptDenyResearch()
        {
            Console.Clear();
            Console.WriteLine("Onderzoek goed/afkeuren");
            Console.WriteLine("Kies een optie:");
            Console.WriteLine("1. Goedkeuren");
            Console.WriteLine("2. Afkeuren");
            Console.WriteLine("3. Terug naar het ouder menu");
            try
            {
                Console.WriteLine("Voer een keuze in (1-3):");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // Goedkeuren
                        Console.WriteLine("Optie 1 gekozen: Goedkeuren.");
                        break;
                    case 2:
                        // Afkeuren
                        Console.WriteLine("Optie 2 gekozen: Afkeuren.");
                        break;
                    case 3:
                        // Terug naar het ouder menu
                        OuderMenu();
                        break;
                    default:
                        Console.WriteLine("Ongeldige keuze.");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Er is een fout opgetreden: " + e.Message);
            }
        }

        static void ExerciseMenu()
        {
            Console.Clear();
            Console.WriteLine("Welkom bij het Oefeningen menu.");
            Console.WriteLine("Kies een optie:");
            Console.WriteLine("1. Tests inzien");
            Console.WriteLine("2. Test beoordelen");
            Console.WriteLine("3. Test versturen");
            Console.WriteLine("4. Terug naar het ouder menu");
            try
            {
                Console.WriteLine("Voer een keuze in (1-3):");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // Test bekijken.
                        SeeTest();
                        break;
                    case 2:
                        // Test beoordelen.
                        GradeTest();
                        break;
                    case 3:
                        // Versturen van de oefening
                        SendExercise();
                        break;
                    case 4:
                        // Terug naar het ouder menu
                        OuderMenu();
                        break;
                    default:
                        Console.WriteLine("Ongeldige keuze.");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Er is een fout opgetreden: " + e.Message);
            }
        }

        static void SendExercise()
        {
            Console.Clear();
            Console.WriteLine("Oefening versturen");
            Console.WriteLine("Oefening 1: 12-03-24");
            Console.WriteLine("Oefening 2: 18-03-24");
            Console.WriteLine("Oefening 3: 16-04-24");
            Console.WriteLine("Oefening 4: 09-05-24");
            Console.WriteLine("Oefening 5: 25-06-24");
            try
            {
                Console.WriteLine("Kies een oefening om te versturen:");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Test {choice} is verstuurd.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Er is een fout opgetreden: " + e.Message);
            }
            Console.WriteLine("Press enter to return to the menu");
            Console.ReadLine();
            ExerciseMenu();
        }

        static void GradeTest()
        {
            Console.Clear();
            Console.WriteLine("Oefening versturen");
            Console.WriteLine("Oefening 1: 12-03-24");
            Console.WriteLine("Oefening 2: 18-03-24");
            Console.WriteLine("Oefening 3: 16-04-24");
            Console.WriteLine("Oefening 4: 09-05-24");
            Console.WriteLine("Oefening 5: 25-06-24");
            try
            {
                Console.WriteLine("Kies een oefening om te beoordelen:");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"U koos test {choice}.");
                Console.WriteLine("oefening 1: (antwoord)");
                Console.WriteLine("oefening 2: (antwoord)");
                Console.WriteLine("oefening 3: (antwoord)");
                Console.WriteLine("oefening 4: (antwoord)");
                Console.WriteLine("oefening 5: (antwoord)");
                Console.WriteLine("oefening 6: (antwoord)");
                Console.WriteLine("oefening 7: (antwoord)");
                Console.WriteLine("oefening 8: (antwoord)");
                Console.WriteLine("oefening 9: (antwoord)");
                Console.WriteLine("oefening 10: (antwoord)");
                Console.WriteLine("oefening 11: (antwoord)");
                Console.WriteLine("oefening 12: (antwoord)");
                Console.WriteLine("oefening 13: (antwoord)");
                Console.WriteLine("oefening 14: (antwoord)");
                Console.WriteLine("Is deze oefening goedgekeurd? y for yes, n for no");
                string choice1 = Console.ReadLine();
                if (choice1 == "y")
                {
                    Console.WriteLine("Oefening goedgekeurd.");
                }
                else if (choice1 == "n")
                {
                    Console.WriteLine("Oefening afgekeurd.");
                }
                else
                {
                    Console.WriteLine("Ongeldige keuze.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Er is een fout opgetreden: " + e.Message);
            }
            Console.WriteLine("Press enter to return to the menu");
            Console.ReadLine();
            ExerciseMenu();
        }

        static void SeeTest()
        {
            Console.Clear();
            {
                Console.WriteLine("Oefening versturen");
                Console.WriteLine("Oefening 1: 12-03-24: Sent");
                Console.WriteLine("Oefening 2: 18-03-24: Sent");
                Console.WriteLine("Oefening 3: 16-04-24: Sent");
                Console.WriteLine("Oefening 4: 09-05-24: Awaiting aproval");
                Console.WriteLine("Oefening 5: 25-06-24: In progress");
                try
                {
                    Console.WriteLine("Kies een oefening om te tonen:");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"U koos test {choice}.");
                    Console.WriteLine("oefening 1: (antwoord)");
                    Console.WriteLine("oefening 2: (antwoord)");
                    Console.WriteLine("oefening 3: (antwoord)");
                    Console.WriteLine("oefening 4: (antwoord)");
                    Console.WriteLine("oefening 5: (antwoord)");
                    Console.WriteLine("oefening 6: (antwoord)");
                    Console.WriteLine("oefening 7: (antwoord)");
                    Console.WriteLine("oefening 8: (antwoord)");
                    Console.WriteLine("oefening 9: (antwoord)");
                    Console.WriteLine("oefening 10: (antwoord)");
                    Console.WriteLine("oefening 11: (antwoord)");
                    Console.WriteLine("oefening 12: (antwoord)");
                    Console.WriteLine("oefening 13: (antwoord)");
                    Console.WriteLine("oefening 14: (antwoord)");
                    Console.WriteLine("Press enter to return to the menu");
                    Console.ReadLine();
                    ExerciseMenu();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Er is een fout opgetreden: " + e.Message);
                }
            }
        }

        static void ShowAnnouncements()
        {
            Console.Clear();
            Console.WriteLine("Mededelingen");
            Console.WriteLine("Mededeling 1: 12-03-24");
            Console.WriteLine("Mededeling 2: 18-03-24");
            Console.WriteLine("Mededeling 3: 16-04-24");
            Console.WriteLine("Mededeling 4: 09-05-24");
            Console.WriteLine("Mededeling 5: 25-06-24");
            Console.WriteLine("Press enter to return to the menu");
            Console.ReadLine();
            OuderMenu();
        }


        // Doctor menu
        public static void DoctorMenu()
        {
            Console.Clear();
            List<string> options = new List<string> {
                "Patiëntgegevens",
                "Afspraken",
                "Testresultaten",
                "Terug naar Main Menu"
            };
            int choice = DisplayMenuOptions(options, "Doctor Menu - select an option");
            switch (choice)
            {
                case 1:
                    // add methode
                    break;
                case 2:
                    // add methode
                    break;
                case 3:
                    // add methode
                    break;
                case 4:
                    MainMenu();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    DoctorMenu();
                    break;
            }
        }

        // onderzoeker menu
        public static void OnderzoekerMenu()
        {
            Console.Clear();
            List<string> options = new List<string> {
                "Patiëntgegevens",
                "Afspraken",
                "Testresultaten",
                "Terug naar Main Menu"
            };
            int choice = DisplayMenuOptions(options, "Doctor Menu - select an option");
            switch (choice)
            {
                case 1:
                    // add methode
                    break;
                case 2:
                    // add methode
                    break;
                case 3:
                    // add methode
                    break;
                case 4:
                    MainMenu();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    DoctorMenu();
                    break;
            }
        }
    }
}


     