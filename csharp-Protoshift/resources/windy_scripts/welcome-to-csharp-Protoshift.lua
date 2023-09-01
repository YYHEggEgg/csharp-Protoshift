local success = true

local LOG_FOLDER = "/data/data/com.miHoYo.GenshinImpact/files"
local LOG_LOG_FILE = LOG_FOLDER .. "/windy_welcome-to-csharp-Protoshift.log"
local log = io.open(LOG_LOG_FILE, "w")

local function main()
    local curuid = CS.UnityEngine.GameObject.Find("/BetaWatermarkCanvas(Clone)/Panel/TxtUID"):GetComponent("Text").text
    local newuid = curuid .. " <b><i><color=#11edb1>by YYHEggEgg/csharp-Protoshift</color></i></b>"
    CS.UnityEngine.GameObject.Find("/BetaWatermarkCanvas(Clone)/Panel/TxtUID"):GetComponent("Text").text = newuid
    success = true
end

local function on_error(error)
    log:write("windy failed, error: " .. error .. "\n")
    success = false
end

xpcall(main, on_error)
if(success)
then
    log:write("windy success")
end

log:close()