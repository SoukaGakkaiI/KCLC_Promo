using DxLibDLL;
namespace Invitation
{
    public class Program
    {
        public static void Main()
        {
            DX.ChangeWindowMode(1);
            if (DX.DxLib_Init() == -1) return;
            DX.SetDrawScreen(DX.DX_SCREEN_BACK);
            DX.SetGraphMode(800, 600, 32);

            Game game = new Game();
            while (DX.ProcessMessage() == 0)
            {
                DX.ClearDrawScreen();
                game.Drive();
                DX.ScreenFlip();
            }

            DX.DxLib_End();
        }
    }
}