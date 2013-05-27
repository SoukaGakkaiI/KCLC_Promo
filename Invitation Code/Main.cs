using System;
using System.Collections.Generic;
using System.Linq;
using DxLibDLL;

namespace Invitation
{
    public class GameMain
    {
        static IScene scene;
        static List<Action> tasklist = new List<Action>();

        public static void Main()
        {
            DX.ChangeWindowMode(1);
            DX.SetDoubleStartValidFlag(1);
            if (DX.DxLib_Init() == -1) return;
            DX.SetDrawScreen(DX.DX_SCREEN_BACK);
            DX.SetGraphMode(800, 600, 32);
            scene = new Game();
            while (DX.ProcessMessage() == 0)
            {
                DX.ClearDrawScreen();
                Input.Update();
                scene.Work();
                DX.ScreenFlip();
            }

            DX.DxLib_End();
        }

        /// <summary>
        /// 指定したSceneのインスタンスを新しく作り、移ります。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public static void ChangeScene<T>()
            where T : IScene, new()
        {
            scene = new T();
        }

        /// <summary>
        /// 指定したSceneに移ります。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="_scene"></param>
        public static void ChangeScene<T>(IScene _scene)
            where T : IScene
        {
            scene = _scene;
        }
    }
}