// Raphael Fernandes, 30099423, Sprint 2 
// Date: 6/10/2025 
// Version: 2.0 
// Name: Astronomical Processing 
// Simple Windows Forms Application for searching and sorting a list  
// of recorded neutrino interactions.

namespace AstronomicalProcessing;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }
}
