
2
3
4
5
6
7
8
9
10
11
12

@echo Off
set config=%1
if "%config%" == "" (
   set config=Release
)
 
set version=1.0.0
if not "%PackageVersion%" == "" (
   set version=%PackageVersion%
)
 
set nuget=
if "%nuget%" == "" (
	set nuget=nuget
)
 
%WINDIR%\Microsoft.NET\Framework\v4.0.30319\msbuild QuadModels.sln /p:Configuration="%config%" /m /v:M /fl /flp:LogFile=msbuild.log;Verbosity=diag /nr:false
 
mkdir Build
mkdir Build\lib
mkdir Build\lib\net40
 
%nuget% pack "QuadModels.nuspec" -NoPackageAnalysis -verbosity detailed -o Build -Version %version% -p Configuration="%config%"
