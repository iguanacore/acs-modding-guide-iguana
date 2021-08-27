using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;
using XiaWorld;
using HarmonyLib;


namespace LLExample
{
    public class LLExample
    {
        public static void Patch()
        {
            try
            {
                Assembly.LoadFrom(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "0Harmony.dll"));
                Harmony harmony = new Harmony("LLExample.Mod");
                harmony.PatchAll();
                KLog.Dbg("[LLExample] Loaded!");
            }
            catch (Exception e)
            {
                KLog.Dbg("[LLExample] error" + e.ToString());
            }
        }

        [HarmonyPatch(typeof(BodyPractice), "GetItemCost")]
        class LLExamplePatch
        {
            static void Postfix(ref float __result, string part)
            {
                KLog.Dbg("[LLExample] GetItemCost (" + __result + ")");
                __result = 1f;
            }
        }
    }
}
