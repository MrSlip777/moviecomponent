//OP、EDの動画のファイル、フラグの管理
//次シーンのシナリオファイル管理

using UnityEngine;
using System.Collections;

public class MovieDataSingleton{
   
    //インスタンス
    private static MovieDataSingleton mInstance;

    //動画ファイル名
    private string mMovieFile;
    //スキップフラグ
    private bool mflag_movieskip;
    //次シナリオファイル
    private string mNextsceneFile;

    //シングルトン実装
    private MovieDataSingleton()
    {
        mMovieFile = null;
        mNextsceneFile = null;
        mflag_movieskip = true;
    }

    // 唯一のインスタンスを取得します。
    public static MovieDataSingleton Instance
    {
        
        get{
            if(mInstance == null){
                mInstance = new MovieDataSingleton();
            }

            return mInstance;
        }

    }

    //動画ファイル名　getset
    public string MovieFile
    {
        set { this.mMovieFile = value; }
        get { return this.mMovieFile; }
    }

    //次シナリオファイル　getset
    public string NextsceneFile
    {
        set { this.mNextsceneFile = value; }
        get { return this.mNextsceneFile; }
    }

    //スキップフラグ　getset
    public bool flag_movieskip
    {
        set { this.mflag_movieskip = value; }
        get { return this.mflag_movieskip; }
    }
}
