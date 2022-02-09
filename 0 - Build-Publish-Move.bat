@echo off

dotnet restore

dotnet build --no-restore -c Release

move /Y Panosen.CodeDom.Tag.Engine\bin\Release\Panosen.CodeDom.Tag.Engine.*.nupkg D:\LocalSavoryNuget\
move /Y Panosen.CodeDom.Tag.Html\bin\Release\Panosen.CodeDom.Tag.Html.*.nupkg D:\LocalSavoryNuget\
move /Y Panosen.CodeDom.Tag.Html.Engine\bin\Release\Panosen.CodeDom.Tag.Html.Engine.*.nupkg D:\LocalSavoryNuget\
move /Y Panosen.CodeDom.Tag\bin\Release\Panosen.CodeDom.Tag.*.nupkg D:\LocalSavoryNuget\
move /Y Panosen.CodeDom.Tag.Core\bin\Release\Panosen.CodeDom.Tag.Core.*.nupkg D:\LocalSavoryNuget\

pause