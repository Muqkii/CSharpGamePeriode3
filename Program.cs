namespace Periode3Csharpgame
{
    public static class Pogram
    {
        static void Main()
        {
            while (Menu.isRunning)
            {
                Menu.printMenu(Menu.menuMain);
            }
        }
    }
}
