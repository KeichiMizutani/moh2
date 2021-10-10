# C_とどげ！わたしのzipファイル
## 作品概要
3Dシューティングゲーム

**ゲームのURL**<br>
[とどけ！わたしのzipファイル](https://unityroom.com/games/zip)

**制作背景**<br>
今回のMoveOnHackathonのテーマは「オンラインとオフラインの差を埋めよ！」です。そこで今回私たちはオンラインとオフラインの『 課題提出 』のちがいに注目しました。オフラインは提出したら直ぐに受理され、提出時そのままの状態で届きます。対してオンラインは、サーバーの混雑具合で提出から受理まで時間がかかる時があったり、なんらかの障害でデータ破損が起きたりします。このようにオンライン提出にはたくさんの障害があります。そこで今回私たちはそれらの障害をやっつけながら提出物を守る3Dシューティングゲームを作りました。

**ゲームのルール**
- zipファイルを教授の元に届ける３Dスクロールシューティング
- HPを維持したままゴールを目指そう！
- WASDまたは矢印キーで上下左右移動
- SPACEキーで球を発射
- HPは時間経過で減っていくので敵を倒して回復しよう
- アイテムを取るとしばらくの間打つ球の量が増えて強くなる
- リザルト画面では残りHPに応じて教授からありがたい言葉を頂ける

**デモ動画**<br>
[![](https://img.youtube.com/vi/5iPF6cShoNA/0.jpg)](https://www.youtube.com/watch?v=5iPF6cShoNA)

## 開発技術
- Unity
- Blender
- C#
- UniversalRenderPipeline
- Post Processing
- Unity Shader Graph
- [UniRx - Reactive Extensions for Unity](https://assetstore.unity.com/packages/tools/integration/unirx-reactive-extensions-for-unity-17276)

## 今後の展望
- エンドレスモードの追加
- 難易度設定の追加
- 軽量化するためにBulletをObjectPoolで使い回し
- 強化要素の追加
