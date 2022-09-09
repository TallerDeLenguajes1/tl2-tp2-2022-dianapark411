// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
try
{
    //Logger.Info("Info");
    Logger.Debug("Debug");
    System.Console.ReadKey();
}
catch (Exception ex)
{
    Logger.Error(ex, "Goodbye cruel world");
}