@echo off

dotnet restore

dotnet build --no-restore -c Release

move /Y Panosen.CodeDom.Tag\bin\Release\Panosen.CodeDom.Tag.*.nupkg D:\LocalSavoryNuget\
move /Y Panosen.CodeDom.Tag.Engine\bin\Release\Panosen.CodeDom.Tag.Engine.*.nupkg D:\LocalSavoryNuget\
move /Y Panosen.CodeDom.Tag.Basic\bin\Release\Panosen.CodeDom.Tag.Basic.*.nupkg D:\LocalSavoryNuget\
move /Y Panosen.CodeDom.Tag.Basic.Engine\bin\Release\Panosen.CodeDom.Tag.Basic.Engine.*.nupkg D:\LocalSavoryNuget\
move /Y Panosen.CodeDom.Tag.Script\bin\Release\Panosen.CodeDom.Tag.Script.*.nupkg D:\LocalSavoryNuget\
move /Y Panosen.CodeDom.Tag.Script.Engine\bin\Release\Panosen.CodeDom.Tag.Script.Engine.*.nupkg D:\LocalSavoryNuget\

pause