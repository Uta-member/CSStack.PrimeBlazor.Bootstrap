# CSStack.PrimeBlazor.Bootstrap

Bootstrap を Blazor に簡単に導入するためのパッケージです。CSS などをプロジェクト内に配置しているため、インターネットに接続していない環境でも利用可能です。

# GetStarted

## インストール

NuGet からインストールします。

```
dotnet add package CSStack.PrimeBlazor.Bootstrap
```

## 使用方法

`_Imports.razor`に以下を追加します。

```razor
@using CSStack.PrimeBlazor.Bootstrap
```

## CSS の読み込み

`wwwroot/index.html`または`Components/App.razor`に以下を追加します。

```html
<link
  rel="stylesheet"
  href="_content/CSStack.PrimeBlazor.Bootstrap/style/standard.css"
/>
```

## JS の読み込み

`wwwroot/index.html`または`Components/App.razor`に以下を追加します。

```html
<script src="_content/CSStack.PrimeBlazor.Bootstrap/js/bootstrap.bundle.min.js"></script>
```

## DI コンテナにサービスを登録

`Program.cs`に以下を追加します。

```csharp
builder.Services.AddPrimeBlazorBootstrap();
```

## Routesにサービスを拾うためのコンポーネントを追加
`Routes.razor`に以下を追加します。もしくはLayoutのrazorなどでも問題ありません。

```html
@* 追加 *@
<BootstrapComponent/>
@* ここまで *@
<Router AppAssembly="typeof(Program).Assembly">
    <Found Context="routeData">
        <RouteView RouteData="routeData" DefaultLayout="typeof(MainLayout)"/>
        <FocusOnNavigate RouteData="routeData" Selector="h1"/>
    </Found>
</Router>
```
