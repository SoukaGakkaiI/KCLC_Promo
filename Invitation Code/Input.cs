using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DxLibDLL;

namespace Invitation
{
    public struct KeyState
    {
        /// <summary>
        /// キーが離された瞬間です。
        /// </summary>
        public bool IsUp { get; set; }
        
        /// <summary>
        /// キーが押された瞬間です。
        /// </summary>
        public bool IsDown { get; set; }
        
        /// <summary>
        /// キーが押されているかです。
        /// </summary>
        public bool IsHold { get; set; }

        public KeyState(bool isUp, bool isDown, bool isHold) : this()
        {
            IsUp = isUp;
            IsDown = isDown;
            IsHold = isHold;
        }
    }

    public static class Input
    {
        static byte[] keyData = new byte[256];
        static byte[] keyCache = new byte[256];
        static int mouseState;
        static int mouseCache;

        /// <summary>
        /// マウスの位置を取得します。
        /// </summary>
        public static Vector MousePoint { get; set; }

        /// <summary>
        /// 一フレーム前のマウスの位置を取得します。
        /// </summary>
        public static Vector PreviousMousePoint { get; set; }

        /// <summary>
        /// マウスの状態を取得します。
        /// </summary>
        public static KeyState MouseState
        {
            get
            {
                return new KeyState((mouseCache & DX.MOUSE_INPUT_LEFT) == 0 && (mouseState & DX.MOUSE_INPUT_LEFT) != 0,
                                    (mouseCache & DX.MOUSE_INPUT_LEFT) != 0 && (mouseState & DX.MOUSE_INPUT_LEFT) == 0,
                                    (mouseState & DX.MOUSE_INPUT_LEFT) != 0);
            }
        }

        /// <summary>
        /// 毎フレーム呼ばれます。
        /// </summary>
        public static void Update()
        {
            keyCache = keyData;
            DX.GetHitKeyStateAll(out keyData[0]);
            mouseCache = mouseState;
            mouseState = DX.GetMouseInput();
            int mouseX, mouseY;
            DX.GetMousePoint(out mouseX, out mouseY);
            PreviousMousePoint = MousePoint ?? new Vector(-1,-1);
            MousePoint = new Vector(mouseX, mouseY);
        }

        /// <summary>
        /// 指定したキーの状態を取得します。
        /// </summary>
        /// <param name="keyNumber"></param>
        /// <returns></returns>
        public static KeyState GetKeyState(int keyNumber)
        {
            return new KeyState(keyCache[keyNumber] == 1 && keyData[keyNumber] != 1,
                                keyCache[keyNumber] != 1 && keyData[keyNumber] == 1,
                                keyData[keyNumber] == 1);
        }
    }
}
