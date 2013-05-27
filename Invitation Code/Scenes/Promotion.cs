using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DxLibDLL;
using Alice.Extensions;
using Alice.Functional.Monads;

namespace Invitation.Scenes
{
    public class Promotion : IScene
    {
        NetConnector cntr;
        List<Chara> charas;
        Chara boss = new Chara(300, 50, DXResources.Images["XP"]);
        int bossHp = 10;

        public Promotion(NetConnector _cntr)
        {
            cntr = _cntr;
            charas = new List<Chara>();
        }

        public void Work()
        {
            DX.DrawBox(0, 0, 800, 800, DX.GetColor(0, 200, 200), 1);

            // 1キーでやり直せる
            if (Input.GetKeyState(DX.KEY_INPUT_1).IsDown)
                GameMain.ChangeScene(new Promotion(cntr));

            // クライアントは地面あり
            if (cntr.Type == StartType.Client)
            {
                charas.ForEach(x =>
                {

                    if (x.Y > 600 - x.Size.Y)
                    {
                        x.Y = 600 - x.Size.Y;
                        x.Speed.Y = 0.4 * -x.Speed.Y;
                    }
                });

                // なにもいなかったら追加
                if (!charas.Any(x => !x.Killing))
                    charas.Add(new Chara(400, 300, DXResources.Images["Arrow"]));


                // ドラッグされたら
                if (Input.MouseState.IsHold)
                {
                    charas.Where(x => x.IsHit(Input.MousePoint) && !x.Hold)
                          .ForEach(x => { x.Hold = true; });
                }
                // 離されたら
                else
                {
                    charas.Where(x => x.Hold)
                          .ForEach(x => { x.Hold = false; x.Move(Input.MousePoint - Input.PreviousMousePoint); });
                }

                // 移動
                charas.Where(x => x.Hold)
                       .ForEach(x => { x.Center = Input.MousePoint; x.Speed.X = 0; x.Speed.Y = 0; });
            }

            // サーバーにはボスが出現
            // XPさん
            if (cntr.Type == StartType.Server && !boss.Killed)
            {
                boss.Draw();
                charas.Where(x => boss.IsHit(x))
                      .Where(x => !x.Killing)
                      .ToArray()
                      .ForEach(x =>
                      {
                          x.Kill(DXResources.Effects["Bomb"]);
                          bossHp--;
                      });
                if (bossHp < 0)
                    boss.Kill(DXResources.Effects["Explode"]);
            }

            // 範囲外は送信
            charas.Where(x => cntr.Type == StartType.Server ? x.Y >= 600 : x.Y <= 0)
                  .ToArray()
                  .ForEach(x =>
                      {
                          charas.Remove(x);
                          if(x.Y <= 0) x.Y = 600 - x.Size.Y;
                          else x.Y = 0;
                          cntr.Write(x.Serialize());
                      });

            // 消滅済みは削除
            charas.RemoveAll(charas.Where(x => x.Killed).Contains);

            // 受信してみてエラーじゃなかったら追加
            var read = new Error<Chara>(() => Chara.Deserialize(cntr.Read()));
            if(!read.IsError)
                charas.Add(read.Value);

            // 描画と動作
            charas.ForEach(x => { x.Move(); x.Draw(); });

        }
    }
}
