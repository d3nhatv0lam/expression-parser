using ExpressionParser.Presenters;

namespace ExpressionParser;

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
        
        MainView view = new MainView();
        MainPresenter presenter = new MainPresenter(view);
        
        Application.Run(view);
        
        presenter.Dispose();
    }
}