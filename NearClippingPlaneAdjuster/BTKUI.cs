﻿using System.Reflection;
using UnityEngine;
using System.IO;
using BTKUILib;
using BTKUILib.UIObjects;
using System.Collections.Generic;

namespace NearClipPlaneAdj
{
    public class CustomBTKUI
    {
        public static void loadAssets()
        {
            QuickMenuAPI.PrepareIcon("NirvMisc", "NirvMisc", Assembly.GetExecutingAssembly().GetManifestResourceStream("NearClipPlaneAdj.Icons.btk.NirvMisc.png"));
            QuickMenuAPI.PrepareIcon("NearClipPlaneAdj", "0001", Assembly.GetExecutingAssembly().GetManifestResourceStream("NearClipPlaneAdj.Icons.btk.n0001.png"));
            QuickMenuAPI.PrepareIcon("NearClipPlaneAdj", "001", Assembly.GetExecutingAssembly().GetManifestResourceStream("NearClipPlaneAdj.Icons.btk.n001.png"));
            QuickMenuAPI.PrepareIcon("NearClipPlaneAdj", "01", Assembly.GetExecutingAssembly().GetManifestResourceStream("NearClipPlaneAdj.Icons.btk.n01.png"));
            QuickMenuAPI.PrepareIcon("NearClipPlaneAdj", "05", Assembly.GetExecutingAssembly().GetManifestResourceStream("NearClipPlaneAdj.Icons.btk.n05.png"));

        }

        public static void InitUi()
        {
            loadAssets();
            Category cat = null;
            if (Main.useNirvMiscPage.Value)
            {
                var page = new Page("NirvMisc", "Nirv Misc Page", true, "NirvMisc");
                page.MenuTitle = "Nirv Misc Page";
                page.MenuSubtitle = "Misc page for mods by Nirv, can disable this in MelonPrefs for the individual mods";
                cat = page.AddCategory("Nearclip Plane Adjust", "NearClipPlaneAdj");
            }
            else
            {
                cat = QuickMenuAPI.MiscTabPage.AddCategory("Nearclip Plane Adjust", "NearClipPlaneAdj");
            }
     
            var clipList = new float[] {
                .05f,
                .01f,
                .001f,
                .0001f
            };

            foreach (var clip in clipList)
            {
                var butt = cat.AddButton($"{clip}", clip.ToString().Replace("0.",""), $"Sets Nearclipping plane to {clip}");
                butt.OnPress += () =>
                {
                    Main.ChangeNearClipPlane(clip, true);
                };
            }
        }
    }
}