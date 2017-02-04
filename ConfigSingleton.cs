using UnityEngine;
using System.Collections;
using Novel;
//システム設定

public class ConfigSingleton{

    private static ConfigSingleton mInstance;

    private float mBGMLevel;
    private float mSELevel;
    private float mMessageSpeed;
    private int mSkiplv;

    //シングルトン実装
    private ConfigSingleton()
    {
        //デフォルトは０
        mSkiplv = 0;
    }

    // 唯一のインスタンスを取得します。
    public static ConfigSingleton Instance
    {

        get
        {
            if (mInstance == null)
            {
                mInstance = new ConfigSingleton();
            }

            return mInstance;
        }

    }

    //Skipの段数　0,1,2,3
    public int Skiplv
    {
        set { this.mSkiplv = value; }
        get { return this.mSkiplv; }
    }

    //BGM
    public float BGMLevel
    {
        set { this.mBGMLevel = value; }
        get { return this.mBGMLevel; }
    }
    //SE
    public float SELevel
    {
        set { this.mSELevel = value; }
        get { return this.mSELevel; }
    }
    //メッセージ速度
    public float MessageSpeed
    {
        set { this.mMessageSpeed = value; }
        get { return this.mMessageSpeed; }
    }



}
