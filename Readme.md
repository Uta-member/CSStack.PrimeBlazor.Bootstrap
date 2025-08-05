# CSStack.PrimeBlazor.Bootstrap
Bootstrap��Blazor�ɊȒP�ɓ������邽�߂̃p�b�P�[�W�ł��BCSS�Ȃǂ��v���W�F�N�g���ɔz�u���Ă��邽�߁A�C���^�[�l�b�g�ɐڑ����Ă��Ȃ����ł����p�\�ł��B

# GetStarted
## �C���X�g�[��
NuGet����C���X�g�[�����܂��B
```
dotnet add package CSStack.PrimeBlazor.Bootstrap
```
## �g�p���@
`_Imports.razor`�Ɉȉ���ǉ����܂��B
```razor
@using CSStack.PrimeBlazor.Bootstrap
```
## CSS�̓ǂݍ���
`wwwroot/index.html`�܂���`Components/App.razor`�Ɉȉ���ǉ����܂��B
```html
<link rel="stylesheet" href="_content/CSStack.PrimeBlazor.Bootstrap/style/standard.css"/>
```
## JS�̓ǂݍ���
`wwwroot/index.html`�܂���`Components/App.razor`�Ɉȉ���ǉ����܂��B
```html
<script src="_content/CSStack.PrimeBlazor.Bootstrap/js/bootstrap.bundle.min.js"></script>
```
## DI�R���e�i�ɃT�[�r�X��o�^
`Program.cs`�Ɉȉ���ǉ����܂��B
```csharp
builder.Services.AddPrimeBlazorBootstrap();
```