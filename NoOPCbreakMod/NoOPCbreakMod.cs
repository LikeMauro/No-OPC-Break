using OWML.Common;
using OWML.ModHelper;
using UnityEngine;

namespace NoOPCbreakMod
{
    public class NoOPCbreakMod : ModBehaviour
    {
        private void Awake()
        {
            // You won't be able to access OWML's mod helper in Awake.
            // So you probably don't want to do anything here.
            // Use Start() instead.
        }

        private void Start()
        {
            ModHelper.Console.WriteLine($"No OPC Break Mod Loaded!");

            ModHelper.HarmonyHelper.AddPrefix<OrbitalProbeLaunchController>("LaunchProbe", typeof(NoOPCbreakMod), nameof(NoOPCbreakMod.NoProbeLaunch));
            
        }

        private static bool NoProbeLaunch()
        {
            return false;
        }
    }
}
