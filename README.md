RemotingSample
==============

Remoting のサンプル

**ClassLibrary1**  
Server で呼び出したいメソッドのインターフェース

**Client**  
クライアント

**Server**  
サーバ(サービスではない)

**WindowsService**  
サービス  
InstallUtil.exe を使って登録する。  
インストール時に聞かれるアカウントは「コンピュータ名\アカウント」を入力する。  
(C:\Windows\Microsoft.NET\Framework\v4.0.30319)  
サービスから GUI を扱いたい場合は[ここ](http://stackoverflow.com/questions/3798612/service-starting-a-process-wont-show-gui-c-sharp)を参考にする。  

アイコンはここから  
http://msdn.microsoft.com/ja-jp/library/vstudio/ms247035(v=vs.100).aspx
