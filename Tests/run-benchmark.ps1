cd ProtoshiftBenchmark
dotnet build --configuration Release --property:DefineConstants=TRACE%3bRELEASE%3bNET%3bNET6_0%3bNETCOREAPP%3bMIHOMO_KCP%3bPROTOSHIFT_BENCHMARK
$build_exitcode = $LastExitCode
if ($build_exitcode -eq 0)
{
    Write-Host MSBuild finished. Running...
    dotnet run --no-build --configuration Release --property:DefineConstants=TRACE%3bRELEASE%3bNET%3bNET6_0%3bNETCOREAPP%3bMIHOMO_KCP%3bPROTOSHIFT_BENCHMARK -- --extra-property "DefineConstants=TRACE%3bRELEASE%3bNET%3bNET6_0%3bNETCOREAPP%3bMIHOMO_KCP%3bPROTOSHIFT_BENCHMARK" $args
    cd ..
    exit $LastExitCode
}
else
{
    Write-Host MSBuild failed with exitcode $build_exitcode.
    cd ..
    exit $build_exitcode
}
