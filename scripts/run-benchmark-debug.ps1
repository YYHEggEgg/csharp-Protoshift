cd Tests\ProtoshiftBenchmark
Write-Host "This script is used for attaching a debugger on the Benchmark program. Please don't forget this!"
dotnet build --configuration Debug --property:DefineConstants=TRACE%3bDEBUG%3bNET%3bNET6_0%3bNETCOREAPP%3bMIHOMO_KCP%3bPROTOSHIFT_BENCHMARK
$build_exitcode = $LastExitCode
if ($build_exitcode -eq 0)
{
    Write-Host MSBuild finished. Running...
    Write-Host "Please, attach a debugger now. Project is named as 'ProtoshiftBenchmark'."
    dotnet run --no-build --configuration Debug --property:DefineConstants=TRACE%3bDEBUG%3bNET%3bNET6_0%3bNETCOREAPP%3bMIHOMO_KCP%3bPROTOSHIFT_BENCHMARK -- --extra-property "DefineConstants=TRACE%3bDEBUG%3bNET%3bNET6_0%3bNETCOREAPP%3bMIHOMO_KCP%3bPROTOSHIFT_BENCHMARK" $args
    cd ..\..
    exit $LastExitCode
}
else
{
    Write-Host MSBuild failed with exitcode $build_exitcode.
    cd ..\..
    exit $build_exitcode
}
