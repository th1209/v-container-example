### このリポジトリの概要

- VContainerを使ってみたサンプルリポジトリ

### サンプルのフォルダ構成

- Tutorial/
    - VContainer公式のチュートリアルスクリプト
    - LifetimeScopeを使い､C#ピュアなクラスや､MonoBehaviourをDIする例
    - 以下のコードそのまま
        - https://vcontainer.hadashikick.jp/ja/getting-started/hello-world
- Example/01_SimpleDI
    - IContainerBuilderとIObjectResolverを使った､最も基本的なDIの例
- Example/02_LifetimeScope
    - LifetimeScope(いい感じにDIコンテナ生成までの依存関係の登録を行ってくれるMonoBehaviour)の使用例
    - LifetimeScopeに親子関係を持たせてあって､以下のようにしてある
        - 1. 親:アプリ全体に関するクラスの初期化&DI
        - 2. 子:個別シーン(ここではインゲーム用のシーンと仮定)のクラスの初期化&DI
- Example/03_EntryPoint
    - EntryPoint(DIコンテナのビルド後に最初に呼ばれる処理)の例
- Example/04_BuildCallbacks
    - DIコンテナビルド時のコールバックの例
- Example/Dummy
    - 01〜04の例に使う､ダミーのManagerクラス群(それっぽい名前で例示した､何もしないクラス群)