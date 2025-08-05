# CSStack.PrimeBlazor.Bootstrap
BootstrapをBlazorに簡単に導入するためのパッケージです。CSSなどをプロジェクト内に配置しているため、インターネットに接続していない環境でも利用可能です。

# GetStarted
## インストール
NuGetからインストールします。
```
dotnet add package CSStack.PrimeBlazor.Bootstrap
```
## 使用方法
`_Imports.razor`に以下を追加します。
```razor
@using CSStack.PrimeBlazor.Bootstrap
```
## CSSの読み込み
`wwwroot/index.html`または`Components/App.razor`に以下を追加します。
```html
<link rel="stylesheet" href="_content/CSStack.PrimeBlazor.Bootstrap/style/standard.css"/>
```
## JSの読み込み
`wwwroot/index.html`または`Components/App.razor`に以下を追加します。
```html
<script src="_content/CSStack.PrimeBlazor.Bootstrap/js/bootstrap.bundle.min.js"></script>
```
## DIコンテナにサービスを登録
`Program.cs`に以下を追加します。
```csharp
builder.Services.AddPrimeBlazorBootstrap();
```