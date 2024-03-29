#!/bin/bash

cd ProtoshiftBenchmark
dotnet build --configuration Release --property:DefineConstants=TRACE%3bRELEASE%3bNET%3bNET6_0%3bNETCOREAPP%3bMIHOMO_KCP%3bPROTOSHIFT_BENCHMARK
build_exitcode=$?
if [ $build_exitcode == 0 ]; then
    echo MSBuild finished. Running...
    dotnet run --no-build --configuration Release --property:DefineConstants=TRACE%3bRELEASE%3bNET%3bNET6_0%3bNETCOREAPP%3bMIHOMO_KCP%3bPROTOSHIFT_BENCHMARK -- --extra-property "DefineConstants=TRACE%3bRELEASE%3bNET%3bNET6_0%3bNETCOREAPP%3bMIHOMO_KCP%3bPROTOSHIFT_BENCHMARK" $@
    exit $?
else
    echo MSBuild failed with exitcode $build_exitcode.
    exit $build_exitcode
fi
