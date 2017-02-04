using UnityEngine;
using System.Collections;
using Novel;

public class MovieMgr : MonoBehaviour {

    private MovieTexture movie;
    private int MOUSELEFTBUTTON = 0;
    private AudioSource audioSource;
    private string mMovieFile;
    private MovieDataSingleton moviedatasingleton;
 
	// Use this for initialization
	void Start () {

        //インスタンス取得
        ConfigSingleton configsingleton = ConfigSingleton.Instance;
        moviedatasingleton = MovieDataSingleton.Instance;

        mMovieFile = moviedatasingleton.MovieFile;

        //ファイル名がnullだったらtitleの動画を読み込む
        if(mMovieFile == null){
            mMovieFile = "novel/data/movie/title";
        }

        GameObject obj = GameObject.Find("Plane");

         //動画読み込み 
        movie = (MovieTexture)Resources.Load(mMovieFile);
        obj.GetComponent<Renderer>().material.mainTexture = movie;
       
       //BGM設定
        AudioClip audioClip = Resources.Load(mMovieFile, typeof(AudioClip)) as AudioClip;
        audioSource = this.gameObject.AddComponent<AudioSource>();
        audioSource.clip = audioClip; 
        
        //音量設定
        audioSource.volume = configsingleton.BGMLevel;

        //BGM再生
        audioSource.Play();
        movie.Play();
  	}

	// Update is called once per frame
    void Update()
    {

        //全画面切り替え
        if (Input.GetKeyDown(KeyCode.F4) == true)
        {
            if (Screen.fullScreen == true)
            {
                Screen.fullScreen = false;
                Screen.SetResolution(1280, 720, false);

            }
            else
            {
                Screen.fullScreen = true;
            }
        }

        //動画が終了、もしくはマウスボタン押下、スキップフラグ有効
        if (movie.isPlaying == false || (moviedatasingleton.flag_movieskip == true && Input.GetMouseButtonDown(MOUSELEFTBUTTON)))
        {
            NovelSingleton.StatusManager.callJoker(moviedatasingleton.NextsceneFile, "");
        }

    }
}
