using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Progress progress = new Progress();
            progress.Play();
        }
    }

    class Progress
    {
        public Design design = new Design();
        public Calendar calendar = new Calendar();
        private int currentMonth = 0;
        private List<string> monthNames;
        private List<int[]> monthData;

        public Progress()
        {
            monthNames = new List<string>
            {
                "JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE",
                "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER"
            };

            monthData = new List<int[]>
            {
                new int[] {3, 31}, new int[] {6, 28}, new int[] {6, 31}, new int[] {2, 30},
                new int[] {4, 31}, new int[] {0, 30}, new int[] {2, 31}, new int[] {5, 31},
                new int[] {1, 30}, new int[] {3, 31}, new int[] {6, 30}, new int[] {1, 31}
            };
        }

        public void Play()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.CursorVisible = false;
            design.ShowWelcomeScreen();

            bool running = true;
            while (running)
            {
                DisplayCurrentMonth();

                ConsoleKeyInfo key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.RightArrow:
                        if (currentMonth < 11) currentMonth++;
                        break;
                    case ConsoleKey.LeftArrow:
                        if (currentMonth > 0) currentMonth--;
                        break;
                    case ConsoleKey.Escape:
                    case ConsoleKey.Q:
                        running = false;
                        break;
                }
            }

            design.ShowExitScreen();
            Console.CursorVisible = true;
        }

        private void DisplayCurrentMonth()
        {
            Console.Clear();
            calendar.DrawCalendar(monthNames[currentMonth], monthData[currentMonth][0],
                                monthData[currentMonth][1], currentMonth + 1);
            design.ShowNavigation(currentMonth, 11);
        }
    }

    class Design
    {
        public void ShowWelcomeScreen()
        {
            Console.Clear();
            Console.WriteLine();

            // Enhanced flower garden with depth
            Console.ForegroundColor = ConsoleColor.Magenta;
            CenterText("              ⚘  ❀  ✿  ❁  ✾  ❃  ✿  ❀  ⚘              ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            CenterText("         .-'^'-.   .-'^'-.   .-'^'-.   .-'^'-.        ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            CenterText("        /  ◉ ◉ \\  / ◉ ◉  \\  / ◉ ◉  \\  /  ◉ ◉ \\       ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            CenterText("       │ ◉ ◉ ◉ ◉││ ◉ ◉ ◉ ◉││ ◉ ◉ ◉ ◉││ ◉ ◉ ◉ ◉│      ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            CenterText("        \\ ◉ ◉ ◉/  \\ ◉ ◉ ◉/  \\ ◉ ◉ ◉/  \\ ◉ ◉ ◉/       ");
            Console.ForegroundColor = ConsoleColor.Green;
            CenterText("          \\│/       \\│/       \\│/       \\│/          ");
            CenterText("           │         │         │         │           ");
            CenterText("           │         │         │         │           ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            CenterText("      ═══════════════════════════════════════════     ");
            Console.ResetColor();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            CenterText("╔══════════════════════════════════════════════════════════╗");
            CenterText("║                                                          ║");
            CenterText("║         ✦  ✧  2 0 2 5   C A L E N D A R  ✧  ✦         ║");
            CenterText("║                                                          ║");
            CenterText("║              ～ Flower Garden Edition ～                 ║");
            CenterText("║                                                          ║");
            CenterText("╚══════════════════════════════════════════════════════════╝");
            Console.ResetColor();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            CenterText("         ⚘      ⚘      ⚘      ⚘      ⚘      ⚘          ");
            CenterText("        \\│/    \\│/    \\│/    \\│/    \\│/    \\│/         ");
            CenterText("         │      │      │      │      │      │          ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            CenterText("    ～～～～～～～～～～～～～～～～～～～～～～～～～～～    ");
            Console.ResetColor();

            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            CenterText("▶  Use  ◄ LEFT  and  RIGHT ►  arrow keys to navigate  ◀");
            Console.ForegroundColor = ConsoleColor.Gray;
            CenterText("Press  [ESC]  or  [Q]  to exit the calendar");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            CenterText("┌───────────────────────────────────────────────────────┐");
            CenterText("│     ★  Press any key to start your journey  ★        │");
            CenterText("└───────────────────────────────────────────────────────┘");
            Console.ResetColor();
            Console.ReadKey(true);
        }

        public void ShowNavigation(int current, int max)
        {
            Console.WriteLine();

            // Enhanced bottom garden with decorative border
            Console.ForegroundColor = ConsoleColor.Green;
            CenterText("      ⚘     ⚘     ⚘     ⚘     ⚘     ⚘     ⚘     ⚘      ");
            CenterText("     \\│/   \\│/   \\│/   \\│/   \\│/   \\│/   \\│/   \\│/     ");
            CenterText("      │     │     │     │     │     │     │     │      ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            CenterText(" ══════════════════════════════════════════════════════════");
            Console.ResetColor();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            CenterText("╔══════════════════════════════════════════════════════════╗");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.White;
            string leftArrow = current > 0 ? "◄◄◄  PREVIOUS" : "            ";
            string rightArrow = current < max ? "NEXT  ►►►" : "         ";
            string position = $"Month  [{current + 1}  of  {max + 1}]";

            CenterText($"      {leftArrow}       {position}       {rightArrow}      ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            CenterText("╚══════════════════════════════════════════════════════════╝");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine();
            CenterText("Press  [ESC]  or  [Q]  to exit");
            Console.ResetColor();
        }

        public void ShowExitScreen()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();

            // Beautiful farewell bouquet
            Console.ForegroundColor = ConsoleColor.Magenta;
            CenterText("               ╭─╮   ╭─╮   ╭─╮   ╭─╮   ╭─╮");
            CenterText("              ╱◉ ◉╲ ╱◉ ◉╲ ╱◉ ◉╲ ╱◉ ◉╲ ╱◉ ◉╲");
            Console.ForegroundColor = ConsoleColor.Yellow;
            CenterText("             │◉ ◉ ◉│◉ ◉ ◉│◉ ◉ ◉│◉ ◉ ◉│◉ ◉ ◉│");
            Console.ForegroundColor = ConsoleColor.Magenta;
            CenterText("              ╲◉ ◉╱ ╲◉ ◉╱ ╲◉ ◉╱ ╲◉ ◉╱ ╲◉ ◉╱");
            Console.ForegroundColor = ConsoleColor.Green;
            CenterText("               \\│/   \\│/   \\│/   \\│/   \\│/");
            CenterText("                │     │     │     │     │");
            CenterText("                 \\    │    │    │    /");
            CenterText("                  \\   │    │    │   /");
            CenterText("                   \\  │    │    │  /");
            CenterText("                    \\ │    │    │ /");
            CenterText("                     \\│    │    │/");
            CenterText("                      \\    │    /");
            CenterText("                       \\   │   /");
            CenterText("                        \\  │  /");
            CenterText("                         \\ │ /");
            CenterText("                          \\│/");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            CenterText("                         ╱═══╲");
            CenterText("                        │ ❀ ❀ │");
            CenterText("                        │ ❀ ❀ │");
            CenterText("                         ╲═══╱");
            Console.ResetColor();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            CenterText("╔══════════════════════════════════════════════════════════╗");
            CenterText("║                                                          ║");
            CenterText("║          ✦  Thank you for using the  ✦                  ║");
            CenterText("║              2025 Flower Calendar!                       ║");
            CenterText("║                                                          ║");
            CenterText("║         ⚘  Have a blooming wonderful year!  ⚘            ║");
            CenterText("║                                                          ║");
            CenterText("╚══════════════════════════════════════════════════════════╝");
            Console.ResetColor();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            CenterText("              ❀   ✿   ❁   ✾   ❃   ✿   ❀              ");
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            CenterText("Press any key to exit...");
            Console.ResetColor();
            Console.ReadKey();
        }

        private void CenterText(string text)
        {
            int windowWidth = Console.WindowWidth;
            int padding = Math.Max(0, (windowWidth - text.Length) / 2);
            Console.WriteLine(new string(' ', padding) + text);
        }
    }

    class Calendar
    {
        public void DrawCalendar(string monthName, int startDay, int totalDays, int monthNumber)
        {
            // Enhanced top flower decoration
            Console.ForegroundColor = ConsoleColor.Magenta;
            CenterText("            ⚘   ❀   ✿   ❁   ✾   ❃   ✿   ❀   ⚘        ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            CenterText("        .-'^'-.   .-'^'-.   .-'^'-.   .-'^'-.   .-'^'-.   ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            CenterText("       / ◉ ◉  \\  / ◉ ◉  \\  / ◉ ◉  \\  / ◉ ◉  \\  / ◉ ◉  \\  ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            CenterText("      │ ◉ ◉ ◉ ◉││ ◉ ◉ ◉ ◉││ ◉ ◉ ◉ ◉││ ◉ ◉ ◉ ◉││ ◉ ◉ ◉ ◉│ ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            CenterText("       \\ ◉ ◉ ◉/  \\ ◉ ◉ ◉/  \\ ◉ ◉ ◉/  \\ ◉ ◉ ◉/  \\ ◉ ◉ ◉/  ");
            Console.ForegroundColor = ConsoleColor.Green;
            CenterText("         \\│/       \\│/       \\│/       \\│/       \\│/     ");
            Console.ResetColor();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            CenterText($"═══════════  {monthName} 2025  ⚘  Month {monthNumber} of 12  ═══════════");
            Console.ResetColor();
            Console.WriteLine();

            // Enhanced calendar frame top with decorative border
            Console.ForegroundColor = ConsoleColor.White;
            CenterText("╔═══════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.ForegroundColor = ConsoleColor.Cyan;
            CenterText("║   SUNDAY   │   MONDAY   │  TUESDAY   │ WEDNESDAY  │  THURSDAY  │   FRIDAY   │  SATURDAY  ║");
            Console.ForegroundColor = ConsoleColor.White;
            CenterText("╠════════════╪════════════╪════════════╪════════════╪════════════╪════════════╪════════════╣");
            Console.ResetColor();

            // Draw calendar grid with better structure
            for (int week = 0; week < 6; week++)
            {
                // Top spacing
                Console.ForegroundColor = ConsoleColor.White;
                CenterText("║            │            │            │            │            │            │            ║");

                // Day number row
                string dayLine = "║";
                for (int day = 0; day < 7; day++)
                {
                    int currentDay = week * 7 + day + 1 - startDay;

                    if (currentDay > 0 && currentDay <= totalDays)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        dayLine += $"    {currentDay,2}      ";
                    }
                    else
                    {
                        dayLine += "            ";
                    }

                    if (day < 6)
                        dayLine += "│";
                }
                dayLine += "║";
                CenterText(dayLine);

                // Bottom spacing
                Console.ForegroundColor = ConsoleColor.White;
                CenterText("║            │            │            │            │            │            │            ║");

                // Separator line between weeks
                if (week < 5)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    CenterText("╠════════════╪════════════╪════════════╪════════════╪════════════╪════════════╪════════════╣");
                }

                Console.ResetColor();

                // Check if we've printed all days
                if (week * 7 + 7 - startDay >= totalDays)
                    break;
            }

            // Calendar frame bottom
            Console.ForegroundColor = ConsoleColor.White;
            CenterText("╚═══════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine();
        }

        private void CenterText(string text)
        {
            int windowWidth = Console.WindowWidth;
            int padding = Math.Max(0, (windowWidth - text.Length) / 2);
            Console.WriteLine(new string(' ', padding) + text);
        }
    }
}
