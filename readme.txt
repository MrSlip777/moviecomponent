2017/02/04 Slip

JokerScriptにて動画を再生する方法を記載しています。
①環境構築、②Movieタグの使用方法

①環境構築
■CSファイル設置
JokerScriptにて、以下のファイルをCSファイル設置場所で
示す場所に配置します。

・MovieComponent.cs
・MovieDataSingleton.cs
・MovieMgr.cs

［CSファイル設置場所］
JOKER/
   └ Scripts/
      ├ Nobel/
      │  ├ Components/
      │  │  └ MovieComponent.cs
      │  　…
      ├MovieDataSingleton.cs
      ├MovieMgr.cs
      　…
■動画ファイル設置場所
以下の階層に”movie”という名前のフォルダを作成し、
その中に再生したい動画ファイルを置きます（.avi、.mov形式など）

JOKER_GAME/
   └ Resources/
      ├ Resources/
      │  └ data/
      │      ├ movie/ ←ここにフォルダを作成します
      │ 
      　…

■movieシーンの作成手順
	[手順]
	1.File→New Sceneを押下し、新規シーンを作成する
	2.Hierarchy下のcreate→3DObject→Planeを押下する
	3.手順2で作成したPlaneを選択する
	4.Inspectorタブを押下する
	5.Transformを以下のように設定する
	　Rotation X:90、Y：0、Z:-180
	6.File→Save Scenesを押下し、”movie.unity”としてシーンを保存する
	※Asset→JOKER_GAME→Scenesにファイル名を”movie.unity”として保存する

②Movieタグの使用方法
スクリプトにて、Movieというタグを挿入することで、動画が再生できます。

■Movieタグ
・パラメータ名	・説明
Movie file	動画のパス名
flag		マウス押下によるスキップ有無
nextscene	動画終了後に読み込むスクリプトパス名

例）
[Movie file="novel/data/movie/title" flag="true" nextscene="wide/libs/title"]
