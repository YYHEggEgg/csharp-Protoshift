# This is a script for you to run simple after-build tasks. 
# Change its name to 'afterbuild_task_win.ps1' to enable it.
# Notice that it's for unix (macOS & Linux). 

# The script will be given only one param, the full path
# of the generated build, e.g. 
# afterbuild_task_win.ps1 "/../Builds/output_20231003_f215adf". 

# For example, you can run something like scp to copy the build somewhere else.

Write-Host Build completed! New build at: $args[0]