local success = true

-- local LOG_FOLDER = "/data/data/com.miHoYo.GenshinImpact/files" -- Better change yourself
-- local LOG_LOG_FILE = LOG_FOLDER .. "/windy_welcome-to-csharp-Protoshift.log"
-- local log = io.open(LOG_LOG_FILE, "w")

local function main()
    local curuid = CS.UnityEngine.GameObject.Find("/BetaWatermarkCanvas(Clone)/Panel/TxtUID"):GetComponent("Text").text
    if #curuid > 3 then
        if string.sub(curuid, 1, 3) ~= "UID" then
            curuid = "<color=#73c0da>Furina</color>"
        end
    end
    local newuid = "<i><color=#11edb1>miHomoTech</color></i> <color=#ff4500>❤️</color> " .. curuid
    CS.UnityEngine.GameObject.Find("/BetaWatermarkCanvas(Clone)/Panel/TxtUID"):GetComponent("Text").text = newuid
    success = true
end

local function on_error(error)
    -- log:write("windy failed, error: " .. error .. "\n")
    CS.UnityEngine.GameObject.Find("/BetaWatermarkCanvas(Clone)/Panel/TxtUID"):GetComponent("Text").text = "<color=#ff4500>Oh no error! - windy</color>"
    success = false
end

xpcall(main, on_error)
if success then
    -- log:write("windy success")
end

-- log:close()