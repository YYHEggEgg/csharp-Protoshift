git pull
cd HandlerGenerator
dotnet build
$build_exitcode = $LastExitCode
if ($build_exitcode -eq 0)
{
    Write-Host MSBuild finished. Running...
    dotnet run --no-build -- --update $args
    cd ..
    exit $LastExitCode
}
else
{
    Write-Host MSBuild failed with exitcode $build_exitcode.
    cd ..
    exit $build_exitcode
}
