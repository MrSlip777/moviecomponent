using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//動画ファイル名、スキップフラグの設定
//Movieシーンの遷移とセットで使用することを想定

//使用方法
//[Movie file=動画のパス名 flag=マウス押下によるスキップ有無 nextscene=動画終了後に読み込むスクリプトパス名]
//例）[Movie file="novel/data/movie/title" flag="true" nextscene="wide/libs/title"]

namespace Novel
{
    public class MovieComponent : AbstractComponent
    {
        private MovieDataSingleton moviedatasingleton;

        public MovieComponent()
        {

            moviedatasingleton = MovieDataSingleton.Instance;

            this.arrayVitalParam = new List<string> { 
                "file","flag","nextscene"
            };

            this.originalParam = new Dictionary<string, string>()
            {
                {"file",""},
                {"flag",""},
                {"nextscene",""},
            };
        }

        // Use this for initialization
        public override void start()
        {
            //動画ファイル
            string file = this.param["file"];
            //スキップフラグ
            bool flag = bool.Parse(this.param["flag"]);
            //次シーンシナリオファイル
            string nextscene = this.param["nextscene"];

            moviedatasingleton.MovieFile = file;
            moviedatasingleton.flag_movieskip = flag;
            moviedatasingleton.NextsceneFile = nextscene;

            this.gameManager.nextOrder();

        }
    }
}