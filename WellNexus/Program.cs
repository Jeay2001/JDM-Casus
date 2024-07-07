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
                    FysioPatientMenu();
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
        public static void FysioPatientMenu()
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
            FysioPatientMenu();
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
            Parent parent = new Parent(25, "John", "Doe", "johndoe", "parent@example.com", "password123", "123 Parent St");
            try
            {
                parent.GetPatientTestResult();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            Console.WriteLine("Press enter to return to the menu");
            Console.ReadLine();
            OuderMenu();
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

        // patient menu
        public static void PatientMenu()
        {
            Console.Clear();
            List<string> options = new List<string> {
                "Oefeningen",
                "Meldingen",
                "Terug naar Main Menu"
            };
            int choice = DisplayMenuOptions(options, "Patient Menu - select an option");
            switch (choice)
            {
                case 1:
                    TestMenupatient();
                    break;
                case 2:
                    ShowAnnouncementsPatient();
                    break;
                case 3:
                    MainMenu();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    PatientMenu();
                    break;
            }
        }

        public static void ShowAnnouncementsPatient()
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
            PatientMenu();
        }

        public static void TestMenupatient()
        {
            Console.Clear();
            Console.WriteLine(" Welcome to the test");
            Console.WriteLine("Hoelang kan je je hoofd optillen?");
            int answer1 = Convert.ToInt32(Console.ReadLine());
            int Score1 = 0;
            if (answer1 <= 0)
            {
                Score1 = 0;
            }
            else if (answer1 < 10)
            {
                Score1 = 1;
            }
            else if (answer1 < 30)
            {
                Score1 = 2;
            }
            else if (answer1 < 60)
            {
                Score1 = 3;
            }
            else if (answer1 < 120)
            {
                Score1 = 4;
            }
            else if (answer1 >= 120)
            {
                Score1 = 5;
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            Console.Clear();
            Console.WriteLine("Was het mogelijk om je been op te tillen de hand aan te raken? vul 0 in voor niet mogelijk vul 1 in voor wel mogelijk maar niet de hand aan te raken vul 2 in als beide is gelukt");
            int answer2 = Convert.ToInt32(Console.ReadLine());
            int Score2 = 0;
            if (answer2 == 0)
            {
                Score2 = 0;
            }
            else if (answer2 == 1)
            {
                Score2 = 1;
            }
            else if (answer2 == 2)
            {
                Score2 = 2;
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            int TotalScore = Score1 + Score2;
            Console.Clear();
            Console.WriteLine("Hoeveel seconden kon je je been gestrekt houden?");
            int answer3 = Convert.ToInt32(Console.ReadLine());
            int Score3 = 0;
            if (answer3 <= 0)
            {
                Score3 = 0;
            }
            else if (answer3 < 10)
            {
                Score3 = 1;
            }
            else if (answer3 < 30)
            {
                Score3 = 2;
            }
            else if (answer3 < 60)
            {
                Score3 = 3;
            }
            else if (answer3 < 120)
            {
                Score3 = 4;
            }
            else if (answer3 >= 120)
            {
                Score3 = 5;
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            TotalScore += Score3;
            Console.Clear();
            Console.WriteLine("Hoe gemakelijk kon je naar de zij draaien?");
            Console.WriteLine("1: niet mogelijk");
            Console.WriteLine("2: kan draaien maar krijgt arm niet vrij");
            Console.WriteLine("3: kan draaien maar krijgt arm met moeite vrij");
            Console.WriteLine("4: kan draaien en krijgt arm vrij");
            int answer4 = Convert.ToInt32(Console.ReadLine());
            int Score4 = answer4 - 1;
            TotalScore += Score4;
            Console.Clear();
            Console.WriteLine("beantwoord de volgende stellingen met Y voor ja en N voor nee");
            int Score5 = 0;
            Console.WriteLine("1/6 Kan je een sit-up doen met handen op de benen en counterbalance?");
            string response1 = Console.ReadLine();
            if (response1 == "Y")
            {
                Score5 += 1;
            }
            else if (response1 == "N")
            {
                Score5 += 0;
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            Console.WriteLine("2/6 Kan je een sit-up doen met handen op de borst en counterbalance?");
            string response2 = Console.ReadLine();
            if (response2 == "Y")
            {
                Score5 += 1;
            }
            else if (response2 == "N")
            {
                Score5 += 0;
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            Console.WriteLine("3/6 Kan je een sit-up doen met handen achter het hoofd en counterbalance?");
            string response3 = Console.ReadLine();
            if (response3 == "Y")
            {
                Score5 += 1;
            }
            else if (response3 == "N")
            {
                Score5 += 0;
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            Console.WriteLine("4/6 Kan je een sit-up doen met handen op de benen en zonder counterbalance?");
            string response4 = Console.ReadLine();
            if (response4 == "Y")
            {
                Score5 += 1;
            }
            else if (response4 == "N")
            {
                Score5 += 0;
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            Console.WriteLine("5/6 Kan je een sit-up doen met handen op de borst en zonder counterbalance?");
            string response5 = Console.ReadLine();
            if (response5 == "Y")
            {
                Score5 += 1;
            }
            else if (response5 == "N")
            {
                Score5 += 0;
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            Console.WriteLine("6/6 Kan je een sit-up doen met handen achter het hoofd en counterbalance?");
            string response6 = Console.ReadLine();
            if (response6 == "Y")
            {
                Score5 += 1;
            }
            else if (response6 == "N")
            {
                Score5 += 0;
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            int answer5 = Score5;
            TotalScore += Score5;
            Console.Clear();
            Console.WriteLine("Kun je zelfstandig zitten?");
            Console.WriteLine("1: niet mogelijk");
            Console.WriteLine("2: kan zitten gebeurdeer langzaam en heeft veel moeite");
            Console.WriteLine("3: kan zitten gebeurd langzaam en heeft weinig moeite");
            Console.WriteLine("4: kan zitten gebeurd snel en heeft weinig moeite");
            int answer6 = Convert.ToInt32(Console.ReadLine());
            int Score6 = answer6 - 1;
            TotalScore += Score6;
            Console.Clear();
            Console.WriteLine("Kun je je arm volledig strekken en optillen?");
            Console.WriteLine("1: niet mogelijk");
            Console.WriteLine("2: Kan arm optillen tot 90 graden en niet strekken");
            Console.WriteLine("3: Kan arm volledig optillen tot boven hoofd en niet strekken");
            Console.WriteLine("4: Kan arm volledig optillen en strekken");
            int answer7 = Convert.ToInt32(Console.ReadLine());
            int Score7 = answer7 - 1;
            TotalScore += Score7;
            Console.Clear();
            Console.WriteLine("Hoelang in seconden kan je je arm boven het hoofd houden?");
            int answer8 = Convert.ToInt32(Console.ReadLine());
            int Score8 = 0;
            if (answer8 <= 0)
            {
                Score8 = 0;
            }
            else if (answer8 < 10)
            {
                Score8 = 1;
            }
            else if (answer8 < 30)
            {
                Score8 = 2;
            }
            else if (answer8 < 60)
            {
                Score8 = 3;
            }
            else if (answer8 >= 60)
            {
                Score8 = 4;
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            TotalScore += Score8;
            Console.Clear();
            Console.WriteLine("Kan zelfstandig van staan naar zitten op grond");
            Console.WriteLine("1: Niet in staat. Bang om het zelfs maar te proberen, zelfs als een stoel als ondersteuning wordt gebruikt. Het kind is bang dat hij/zij zal instorten, in een zit zal vallen, of zichzelf zal verwonden.");
            Console.WriteLine("2: Veel moeite. In staat, maar moet zich aan een stoel vasthouden voor ondersteuning tijdens de afdaling. Niet in staat, of niet bereid om het te proberen als hij/zij geen stoel als ondersteuning mag gebruiken.");
            Console.WriteLine("3: Enige moeite. Kan van staan naar zitten gaan zonder een stoel als ondersteuning te gebruiken, maar heeft minstens enige moeite tijdens de afdaling. Kan de Gower’s manoeuvre nodig hebben. Daalt enigszins langzaam en/of met enige bezorgdheid af; heeft mogelijk niet volledig controle of balans tijdens het manoeuvreren naar een zitpositie.");
            Console.WriteLine("4: Geen moeite. Vereist geen compenserende manoeuvres.");
            int answer9 = Convert.ToInt32(Console.ReadLine());
            int Score9 = answer9 - 1;
            TotalScore += Score9;
            Console.Clear();
            Console.WriteLine("Kun je van een buikligging naar viervoet positie komen?");
            Console.WriteLine("1: Niet in staat.");
            Console.WriteLine("2: Nauwelijks in staat om een viervoetige positie aan te nemen en te behouden. Niet in staat om het hoofd op te tillen en recht vooruit te kijken.");
            Console.WriteLine("3: Kan een viervoetige positie behouden met een rechte rug en het hoofd opgeheven (om recht vooruit te kijken). Maar, kan niet kruipen (vooruit bewegen).");
            Console.WriteLine("4: an een viervoetige positie behouden, recht vooruit kijken en vooruit kruipen.");
            Console.WriteLine("5: Behoudt het evenwicht terwijl hij/zij één been optilt en uitstrekt.");
            int answer10 = Convert.ToInt32(Console.ReadLine());
            int Score10 = answer10 - 1;
            TotalScore += Score10;
            Console.Clear();
            Console.WriteLine("Opstaan van een knielende positie op de grond naar een staande positie");
            Console.WriteLine("1: Niet in staat, zelfs niet als een stoel als ondersteuning mag worden gebruikt.");
            Console.WriteLine("2: Veel moeite. In staat, maar moet een stoel als ondersteuning gebruiken. (Niet in staat als geen stoel mag worden gebruikt.)");
            Console.WriteLine("3: Matige moeite. In staat om op te staan zonder een stoel als ondersteuning te gebruiken, maar moet één of beide handen op de dijen/knieën of de vloer plaatsen. (Niet in staat zonder handen te gebruiken.)");
            Console.WriteLine("4: Lichte moeite. Hoeft de handen niet op de knieën, dijen of vloer te plaatsen, maar heeft minstens enige moeite tijdens het opstaan.");
            Console.WriteLine("5: Geen moeite.");
            int answer11 = Convert.ToInt32(Console.ReadLine());
            int Score11 = answer11 - 1;
            TotalScore += Score11;
            Console.Clear();
            Console.WriteLine("Kun je van een stoel opstaan?");
            Console.WriteLine("1: Niet in staat om uit de stoel op te staan, zelfs niet als de handen op de zijkanten van de stoelzitting mogen worden geplaatst.");
            Console.WriteLine("2: Veel moeite. In staat, maar moet de handen op de zijkanten van de stoelzitting plaatsen. Niet in staat als de handen niet op de zijkanten van de zitting mogen worden geplaatst.");
            Console.WriteLine("3: Matige moeite. In staat, maar moet de handen op de knieën/dijen plaatsen. Hoeft de handen niet op de zijkanten van de zitting te plaatsen.");
            Console.WriteLine("4: Lichte moeite. Hoeft de handen niet op de zitting, knieën of dijen te plaatsen, maar heeft minstens enige moeite tijdens het opstaan.");
            Console.WriteLine("5: Geen moeite.");
            int answer12 = Convert.ToInt32(Console.ReadLine());
            int Score12 = answer12 - 1;
            TotalScore += Score12;
            Console.Clear();
            Console.WriteLine("Kan op een stoel staan");
            Console.WriteLine("1: Niet in staat om op een stoel te staan.");
            Console.WriteLine("2: Veel moeite. In staat, maar moet één hand op de onderzoekstafel (of de hand van de onderzoeker) plaatsen.");
            Console.WriteLine("3: Enige moeite. In staat, hoeft de onderzoekstafel niet als ondersteuning te gebruiken, maar moet een hand op de knie/dij plaatsen.");
            Console.WriteLine("4: In staat. Hoeft de onderzoekstafel of hand op de knie/dij niet te gebruiken.");
            int answer13 = Convert.ToInt32(Console.ReadLine());
            int Score13 = answer13 - 1;
            TotalScore += Score13;
            Console.Clear();
            Console.WriteLine("Kan item vanaf de grond oprapen");
            Console.WriteLine("1: Niet in staat om voorover te buigen en een potlood van de vloer op te pakken.");
            Console.WriteLine("2: Veel moeite. In staat, maar leunt sterk op de ondersteuning door de handen op de knieën/dijen te plaatsen");
            Console.WriteLine("3: Enige moeite. Heeft enige moeite (maar niet \"veel moeite\"). Moet minstens minimaal en kort de hand(en) op de knieën/dijen plaatsen voor ondersteuning. Is enigszins traag.");
            Console.WriteLine("4: Geen moeite. Geen compenserende manoeuvre nodig.");
            int answer14 = Convert.ToInt32(Console.ReadLine());
            int Score14 = answer14 - 1;
            TotalScore += Score14;
            Console.Clear();
            Console.WriteLine("Dankjewel voor het invullen van de test");
            Console.Clear();
            Console.WriteLine("These are the answers you enterd");
            Console.WriteLine("Answer 1: " + answer1 + "Score: " + Score1);
            Console.WriteLine("Answer 2: " + answer2 + "Score: " + Score2);
            Console.WriteLine("Answer 3: " + answer3 + "Score: " + Score3);
            Console.WriteLine("Answer 4: " + answer4 + "Score: " + Score4);
            Console.WriteLine("Answer 5: " + answer5 + "Score: " + Score5);
            Console.WriteLine("Answer 6: " + answer6 + "Score: " + Score6);
            Console.WriteLine("Answer 7: " + answer7 + "Score: " + Score7);
            Console.WriteLine("Answer 8: " + answer8 + "Score: " + Score8);
            Console.WriteLine("Answer 9: " + answer9 + "Score: " + Score9);
            Console.WriteLine("Answer 10: " + answer10 + "Score: " + Score10);
            Console.WriteLine("Answer 11: " + answer11 + "Score: " + Score11);
            Console.WriteLine("Answer 12: " + answer12 + "Score: " + Score12);
            Console.WriteLine("Answer 13: " + answer13 + "Score: " + Score13);
            Console.WriteLine("Answer 14: " + answer14 + "Score: " + Score14);
            Console.WriteLine("Total Score: " + TotalScore);
            Console.WriteLine("Press enter to return to the menu");
            Console.ReadLine();
            PatientMenu();
        }
    }
}


