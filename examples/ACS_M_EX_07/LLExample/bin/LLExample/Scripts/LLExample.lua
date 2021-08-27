local LLExample = GameMain:GetMod("LLExample");
function LLExample:OnBeforeInit()
  xlua.private_accessible(CS.XLua.LuaEnv)
  xlua.private_accessible(CS.XLua.ObjectTranslator)
  local thisData = CS.ModsMgr.Instance:FindMod("LLExample", nil, true)
  local thisPath = thisData.Path
  local mllFile = CS.System.IO.Path.Combine(thisPath, "LLExample.dll")
  local asm = CS.System.Reflection.Assembly.LoadFrom(mllFile)
  CS.XiaWorld.LuaMgr.Instance.Env.translator.assemblies:Add(asm)
  CS.ModnameNamespace.ModnameClass.Patch()
end
