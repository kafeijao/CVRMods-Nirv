﻿using System;
using MelonLoader;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;
using BTKUILib;
using BTKUILib.UIObjects;
using ABI.CCK.Components;

namespace LocalLightMod
{
    class BTKUI_Cust
    {
        public static void loadAssets()
        {
            QuickMenuAPI.PrepareIcon("NirvMisc", "NirvMisc", Assembly.GetExecutingAssembly().GetManifestResourceStream("LocalLightMod.Icons.NirvMisc.png"));
            QuickMenuAPI.PrepareIcon("LocalLightMod", "Settings", Assembly.GetExecutingAssembly().GetManifestResourceStream("LocalLightMod.Icons.Settings.png"));
            QuickMenuAPI.PrepareIcon("LocalLightMod", "AngleMinus", Assembly.GetExecutingAssembly().GetManifestResourceStream("LocalLightMod.Icons.AngleMinus.png"));
            QuickMenuAPI.PrepareIcon("LocalLightMod", "AnglePlus", Assembly.GetExecutingAssembly().GetManifestResourceStream("LocalLightMod.Icons.AnglePlus.png"));
            QuickMenuAPI.PrepareIcon("LocalLightMod", "BrightnessHigher", Assembly.GetExecutingAssembly().GetManifestResourceStream("LocalLightMod.Icons.BrightnessHigher.png"));//
            QuickMenuAPI.PrepareIcon("LocalLightMod", "BrightnessLower", Assembly.GetExecutingAssembly().GetManifestResourceStream("LocalLightMod.Icons.BrightnessLower.png"));//
            QuickMenuAPI.PrepareIcon("LocalLightMod", "SizeMinus", Assembly.GetExecutingAssembly().GetManifestResourceStream("LocalLightMod.Icons.SizeMinus.png"));
            QuickMenuAPI.PrepareIcon("LocalLightMod", "SizePlus", Assembly.GetExecutingAssembly().GetManifestResourceStream("LocalLightMod.Icons.SizePlus.png"));
            QuickMenuAPI.PrepareIcon("LocalLightMod", "Reset", Assembly.GetExecutingAssembly().GetManifestResourceStream("LocalLightMod.Icons.Reset.png"));
            QuickMenuAPI.PrepareIcon("LocalLightMod", "Red-Minus", Assembly.GetExecutingAssembly().GetManifestResourceStream("LocalLightMod.Icons.Red-Minus.png"));
            QuickMenuAPI.PrepareIcon("LocalLightMod", "Red-Plus", Assembly.GetExecutingAssembly().GetManifestResourceStream("LocalLightMod.Icons.Red-Plus.png"));
            QuickMenuAPI.PrepareIcon("LocalLightMod", "Green-Minus", Assembly.GetExecutingAssembly().GetManifestResourceStream("LocalLightMod.Icons.Green-Minus.png"));
            QuickMenuAPI.PrepareIcon("LocalLightMod", "Green-Plus", Assembly.GetExecutingAssembly().GetManifestResourceStream("LocalLightMod.Icons.Green-Plus.png"));
            QuickMenuAPI.PrepareIcon("LocalLightMod", "Blue-Minus", Assembly.GetExecutingAssembly().GetManifestResourceStream("LocalLightMod.Icons.Blue-Minus.png"));
            QuickMenuAPI.PrepareIcon("LocalLightMod", "Blue-Plus", Assembly.GetExecutingAssembly().GetManifestResourceStream("LocalLightMod.Icons.Blue-Plus.png"));
            QuickMenuAPI.PrepareIcon("LocalLightMod", "White-Minus", Assembly.GetExecutingAssembly().GetManifestResourceStream("LocalLightMod.Icons.White-Minus.png"));
            QuickMenuAPI.PrepareIcon("LocalLightMod", "White-Plus", Assembly.GetExecutingAssembly().GetManifestResourceStream("LocalLightMod.Icons.White-Plus.png"));
            QuickMenuAPI.PrepareIcon("LocalLightMod", "Color-Blue", Assembly.GetExecutingAssembly().GetManifestResourceStream("LocalLightMod.Icons.Color-Blue.png"));
            QuickMenuAPI.PrepareIcon("LocalLightMod", "Color-Cyan", Assembly.GetExecutingAssembly().GetManifestResourceStream("LocalLightMod.Icons.Color-Cyan.png"));
            QuickMenuAPI.PrepareIcon("LocalLightMod", "Color-Green", Assembly.GetExecutingAssembly().GetManifestResourceStream("LocalLightMod.Icons.Color-Green.png"));
            QuickMenuAPI.PrepareIcon("LocalLightMod", "Color-Magenta", Assembly.GetExecutingAssembly().GetManifestResourceStream("LocalLightMod.Icons.Color-Magenta.png"));
            QuickMenuAPI.PrepareIcon("LocalLightMod", "Color-Red", Assembly.GetExecutingAssembly().GetManifestResourceStream("LocalLightMod.Icons.Color-Red.png"));
            QuickMenuAPI.PrepareIcon("LocalLightMod", "Color-Yellow", Assembly.GetExecutingAssembly().GetManifestResourceStream("LocalLightMod.Icons.Color-Yellow.png"));
            QuickMenuAPI.PrepareIcon("LocalLightMod", "Color-White", Assembly.GetExecutingAssembly().GetManifestResourceStream("LocalLightMod.Icons.Color-White.png"));
            QuickMenuAPI.PrepareIcon("LocalLightMod", "Color-Black", Assembly.GetExecutingAssembly().GetManifestResourceStream("LocalLightMod.Icons.Color-Black.png"));
            QuickMenuAPI.PrepareIcon("LocalLightMod", "flashLight", Assembly.GetExecutingAssembly().GetManifestResourceStream("LocalLightMod.Icons.flashLight.png"));
            QuickMenuAPI.PrepareIcon("LocalLightMod", "flashLight-save", Assembly.GetExecutingAssembly().GetManifestResourceStream("LocalLightMod.Icons.flashLight-save.png"));
            QuickMenuAPI.PrepareIcon("LocalLightMod", "LightOn", Assembly.GetExecutingAssembly().GetManifestResourceStream("LocalLightMod.Icons.LightOn.png"));
            QuickMenuAPI.PrepareIcon("LocalLightMod", "UpdateLight", Assembly.GetExecutingAssembly().GetManifestResourceStream("LocalLightMod.Icons.UpdateLight.png"));
            QuickMenuAPI.PrepareIcon("LocalLightMod", "LightSave", Assembly.GetExecutingAssembly().GetManifestResourceStream("LocalLightMod.Icons.LightSave.png"));
            QuickMenuAPI.PrepareIcon("LocalLightMod", "SpotPoint", Assembly.GetExecutingAssembly().GetManifestResourceStream("LocalLightMod.Icons.SpotPoint.png"));
            QuickMenuAPI.PrepareIcon("LocalLightMod", "Save", Assembly.GetExecutingAssembly().GetManifestResourceStream("LocalLightMod.Icons.Save.png"));
            QuickMenuAPI.PrepareIcon("LocalLightMod", "Load", Assembly.GetExecutingAssembly().GetManifestResourceStream("LocalLightMod.Icons.Load.png"));
            QuickMenuAPI.PrepareIcon("LocalLightMod", "LayerMask", Assembly.GetExecutingAssembly().GetManifestResourceStream("LocalLightMod.Icons.LayerMask.png"));                                                                                                                         //QuickMenuAPI.PrepareIcon("LocalLightMod", "", Assembly.GetExecutingAssembly().GetManifestResourceStream("LocalLightMod.Icons..png"));//
            QuickMenuAPI.PrepareIcon("LocalLightMod", "ShadowsLess", Assembly.GetExecutingAssembly().GetManifestResourceStream("LocalLightMod.Icons.ShadowsLess.png"));
            QuickMenuAPI.PrepareIcon("LocalLightMod", "ShadowsMore", Assembly.GetExecutingAssembly().GetManifestResourceStream("LocalLightMod.Icons.ShadowsMore.png"));
            QuickMenuAPI.PrepareIcon("LocalLightMod", "Delete", Assembly.GetExecutingAssembly().GetManifestResourceStream("LocalLightMod.Icons.Delete.png"));
            QuickMenuAPI.PrepareIcon("LocalLightMod", "ShadowType", Assembly.GetExecutingAssembly().GetManifestResourceStream("LocalLightMod.Icons.ShadowType.png"));
            QuickMenuAPI.PrepareIcon("LocalLightMod", "LightFromConfig", Assembly.GetExecutingAssembly().GetManifestResourceStream("LocalLightMod.Icons.LightFromConfig.png"));
            QuickMenuAPI.PrepareIcon("LocalLightMod", "LightToConfig", Assembly.GetExecutingAssembly().GetManifestResourceStream("LocalLightMod.Icons.LightToConfig.png"));
            QuickMenuAPI.PrepareIcon("LocalLightMod", "Select", Assembly.GetExecutingAssembly().GetManifestResourceStream("LocalLightMod.Icons.Select.png"));
            QuickMenuAPI.PrepareIcon("LocalLightMod", "PixelLess", Assembly.GetExecutingAssembly().GetManifestResourceStream("LocalLightMod.Icons.PixelLess.png"));
            QuickMenuAPI.PrepareIcon("LocalLightMod", "PixelMore", Assembly.GetExecutingAssembly().GetManifestResourceStream("LocalLightMod.Icons.PixelMore.png"));
            //QuickMenuAPI.PrepareIcon("LocalLightMod", "", Assembly.GetExecutingAssembly().GetManifestResourceStream("LocalLightMod.Icons..png"));//
        }

        public static Page pageLightConfig, pageCustomColors, pageSelectLight, pageSetName, pageLayers, pageSavedColors, pageSavedSlots;
        public static BTKUILib.UIObjects.Components.Button pageLightConfig_Name;
        
        private static FieldInfo _uiInstance = typeof(QMUIElement).Assembly.GetType("BTKUILib.UserInterface").GetField("Instance", BindingFlags.NonPublic | BindingFlags.Static);
        private static MethodInfo _registerRootPage = typeof(QMUIElement).Assembly.GetType("BTKUILib.UserInterface").GetMethod("RegisterRootPage", BindingFlags.NonPublic | BindingFlags.Instance);
        public static void HackRegisterRoot(Page element)
        {
            _registerRootPage.Invoke(_uiInstance.GetValue(null), new object[] { element });
        }

        public static void UpDateActiveOnChange()
        {
            if(Main.updateActiveWithChange.Value)
                Main.UpdateLight(Main.activeLight);
        }

        public static void SetupUI()
        {
            loadAssets();
            pageSetName = new Page("LocalLightMod", "Light - Set Name", false);
            HackRegisterRoot(pageSetName);
            pageLayers = new Page("LocalLightMod", "Light - Layers", false);
            HackRegisterRoot(pageLayers);
            pageSavedColors = new Page("LocalLightMod", "Light - Saved Colors", false);
            HackRegisterRoot(pageSavedColors);
            pageSavedSlots = new Page("LocalLightMod", "Light - Saved Slots", false);
            HackRegisterRoot(pageSavedSlots);
            pageCustomColors = new Page("LocalLightMod", "Light - Colors", false);
            HackRegisterRoot(pageCustomColors);

            Category cat = null;
            if (Main.useNirvMiscPage.Value)
            {
                var page = new Page("NirvMisc", "Nirv Misc Page", true, "NirvMisc");
                page.MenuTitle = "Nirv Misc Page";
                page.MenuSubtitle = "Misc page for mods by Nirv, can disable this in MelonPrefs for the individual mods";
                cat = page.AddCategory("Local Lights", "LocalLightMod");
            }
            else
            {
                cat = QuickMenuAPI.MiscTabPage.AddCategory("Local Lights", "LocalLightMod");
            }
            cat.AddButton("Create Light", "LightOn", "Create a new light with current settings").OnPress += () =>
            {
                Main.CreateLight();
            };
            pageLightConfig = new Page("LocalLightMod", "Light - Config", false);
            HackRegisterRoot(pageLightConfig);
            cat.AddButton("Light Config", "Settings", "Light Configuration Settings").OnPress += () =>
            {
                LightConfig();
            };
            pageSelectLight = new Page("LocalLightMod", "Light - Select Specific", false);
            HackRegisterRoot(pageSelectLight);
            cat.AddButton("Select Light", "Select", "Select a created light for editing").OnPress += () =>
            {
                SelectSpecific();
            };

            cat.AddButton("Delete All Lights", "Delete", "Delete All Lights").OnPress += () =>
            {
                QuickMenuAPI.ShowConfirm("Delete All Lights?", "This will delete all lights in the world", () => { Main.CleanupVisObjects(); }, () => { }, "Yes", "No");
            };
            
        }

        public static void LightConfig()
        {
            var page = pageLightConfig;
            page.ClearChildren();
            var catSettings1 = page.AddCategory("Control");
            var catSettings2 = page.AddCategory("Settings");

            var catSettings4 = page.AddCategory($"Intensity: {Utils.NumFormat(Main.Config.lightIntensity)}");

            var catSettings5 = page.AddCategory($"Range (Spot+Point Lights): {Utils.NumFormat(Main.Config.lightRange)}");
            var catSettings6 = page.AddCategory($"Angle (Spot Light): {Utils.NumFormat(Main.Config.lightSpotAngle)}");
            var catSettings10 = page.AddCategory($"Shadows - Str:{Utils.NumFormat(Main.Config.lightShadowStr)} - Res:{Utils.NumFormat(Main.Config.lightShadowCustRes)}");
            
            page.MenuTitle = "Options for Light creation";
            page.MenuSubtitle = "";

            catSettings1.AddButton("Create", "LightOn", "Create a new light with the settings from below").OnPress += () =>
            {
                Main.CreateLight();
            };
            catSettings1.AddButton("Update Active Light", "UpdateLight", "Update currently selected light with settings from below").OnPress += () =>
            {
                Main.UpdateLight(Main.activeLight);
            };
            catSettings1.AddButton("Reset to Defaults", "Reset", "Reset to Defaults").OnPress += () =>
            {
                QuickMenuAPI.ShowConfirm("Reset to Defaults", "Reset to Defaults?", () => {
                    Main.Config.name = "DefaultName";
                    Main.Config.pickupOrient = false;
                    Main.Config.pickupable = true;
                    Main.Config.lightType = LightType.Point;
                    Main.Config.lightRange = 10;
                    Main.Config.lightSpotAngle = 30;
                    Main.Config.lightColor = Color.white;
                    Main.Config.lightIntensity = 1;
                    Main.Config.lightBounceIntensity = 1;
                    Main.Config.lightShadows = LightShadows.None;
                    Main.Config.lightShadowStr = 1;
                    Main.Config.lightShadowCustRes = 2048;
                    Main.Config.cullingMask = -1;
                    LightConfig();
                }, () => { }, "Yes", "No");
            };
            catSettings1.AddButton("Saved Presets", "LightSave", "Open a menu for saving and loading presets").OnPress += () =>
            {
                SavedPrefSlots();
            };

            pageLightConfig_Name = catSettings2.AddButton($"Name: {Main.Config.name}", "blank", Main.Config.name);
            pageLightConfig_Name.OnPress += () =>
            {
                SetName();
            };
            catSettings2.AddToggle("Pickupable", "Pickupable", Main.Config.pickupable).OnValueUpdated += action =>
            {
                Main.Config.pickupable = action;
                UpDateActiveOnChange();
            };
            catSettings2.AddToggle("Pickup Snaps to Hand", "Pickup Snaps to Hand", Main.Config.pickupOrient).OnValueUpdated += action =>
            {
                Main.Config.pickupOrient = action;
                UpDateActiveOnChange();
            };
            catSettings2.AddToggle("Hide Mesh", "", Main.Config.hideMeshRender).OnValueUpdated += action =>
            {
                Main.Config.hideMeshRender = action;
                UpDateActiveOnChange();
            };
            catSettings2.AddToggle("Texture Name", "Place light name on the texture of mesh that gets created.", Main.textureLights.Value).OnValueUpdated += action =>
            {
                Main.textureLights.Value = action;
            };
            var lightType = catSettings2.AddButton($"Light Type: {Main.Config.lightType}", "SpotPoint", "Toggle light type: Spot/Point/Directional");
            lightType.OnPress += () =>
            {
                switch (Main.Config.lightType)
                {
                    case LightType.Spot: Main.Config.lightType = LightType.Point; break;
                    case LightType.Point: Main.Config.lightType = LightType.Directional; break;
                    case LightType.Directional: Main.Config.lightType = LightType.Spot; break;
                    default: Main.Config.lightType = LightType.Point; break;
                }
                lightType.ButtonText = $"Light Type: {Main.Config.lightType}";
                UpDateActiveOnChange();
            };

            catSettings2.AddButton($"Change Color", "flashLight", "Change the color of the light").OnPress += () =>
            {
                CustomColorSelect();
            };
            catSettings2.AddButton($"Saved Colors", "flashLight-save", "Open a menu for saving and loading color presets").OnPress += () =>
            {
                StoredColorsMenu();
            };
            catSettings2.AddButton($"LayerMask", "LayerMask", $"Edit the layer make that lights effect - Current: {Main.Config.cullingMask}").OnPress += () =>
            {
                LightLayerMask();
            };
            catSettings2.AddToggle("Update Active Light /w changes", "Update Active Light after every change", Main.updateActiveWithChange.Value).OnValueUpdated += action =>
            {
                Main.updateActiveWithChange.Value = action;
            };
            catSettings2.AddToggle("Load Slot 1 as Default", "Load slot 1 as the default values on game load", Main.loadDefaults.Value).OnValueUpdated += action =>
            {
                Main.loadDefaults.Value = action;
            };

            //Intensity
            {
                BTKUILib.UIObjects.Components.Button angleReset = null;
                var fast = false;
                catSettings4.AddButton("Intensity -", "BrightnessLower", "").OnPress += () =>
                {
                    Main.Config.lightIntensity = Utils.Clamp(Main.Config.lightIntensity - (fast ? 1 : .1f), 0f, 1000f); UpdateText(); UpDateActiveOnChange();
                };
                angleReset = catSettings4.AddButton("--Reset--", "Reset", "");
                angleReset.OnPress += () =>
                {
                    Main.Config.lightIntensity = 1f; UpdateText(); UpDateActiveOnChange();
                };
                catSettings4.AddButton("Intensity +", "BrightnessHigher", "").OnPress += () =>
                { 
                    Main.Config.lightIntensity += fast ? 1 : .1f; UpdateText(); UpDateActiveOnChange();
                };
                catSettings4.AddToggle("Quick Adj", "Faster adjust", fast).OnValueUpdated += action =>
                {
                    fast = action;
                };
                void UpdateText()
                {
                    catSettings4.CategoryName = $"Intensity: {Utils.NumFormat(Main.Config.lightIntensity)}";
                }
            }

            //Range
            {
                BTKUILib.UIObjects.Components.Button reset = null;
                var fast = false;
                catSettings5.AddButton("Range -", "SizeMinus", "").OnPress += () =>
                {
                    Main.Config.lightRange = Utils.Clamp(Main.Config.lightRange - (fast ? 5 : .5f), 0f, 10000f); UpdateText(); UpDateActiveOnChange();
                };
                reset = catSettings5.AddButton("--Reset--", "Reset", "");
                reset.OnPress += () =>
                {
                    Main.Config.lightRange = 10f; UpdateText(); UpDateActiveOnChange();
                };
                catSettings5.AddButton("Range +", "SizePlus", "").OnPress += () =>
                {
                    Main.Config.lightRange += fast ? 5 : .5f; UpdateText(); UpDateActiveOnChange();
                };
                catSettings5.AddToggle("Quick Adj", "Faster adjust", fast).OnValueUpdated += action =>
                {
                    fast = action;
                };
                void UpdateText()
                {
                    catSettings5.CategoryName = $"Range (Spot+Point Lights): {Utils.NumFormat(Main.Config.lightRange)}";
                }
            }

            //Angle
            {
                BTKUILib.UIObjects.Components.Button reset = null;
                var fast = false;
                catSettings6.AddButton("Angle -", "AngleMinus", "").OnPress += () =>
                {
                    Main.Config.lightSpotAngle = Utils.Clamp(Main.Config.lightSpotAngle - (fast ? 10 : .2f), 0f, 300f); UpdateText(); UpDateActiveOnChange();

                };
                reset = catSettings6.AddButton("--Reset--", "Reset", "");
                reset.OnPress += () =>
                {
                    Main.Config.lightSpotAngle = 30f; UpdateText(); UpDateActiveOnChange();
                };
                catSettings6.AddButton("Angle +", "AnglePlus", "").OnPress += () =>
                {
                    Main.Config.lightSpotAngle += fast ? 10 : 2f; UpdateText(); UpDateActiveOnChange();
                };
                catSettings6.AddToggle("Quick Adj", "Faster adjust", fast).OnValueUpdated += action =>
                {
                    fast = action;
                };
                void UpdateText()
                {
                    catSettings6.CategoryName = $"Angle (Spot Light): {Utils.NumFormat(Main.Config.lightSpotAngle)}";
                }
            }

            //Shadows Str
            {
                BTKUILib.UIObjects.Components.Button rest = null;
                var fast = false;
                catSettings10.AddButton("Shadow Str -", "ShadowsLess", "Shadow Strength").OnPress += () =>
                {
                    Main.Config.lightShadowStr = Utils.Clamp(Main.Config.lightShadowStr - (fast ? 1 : .1f), 0f, 1000f); UpdateText(); UpDateActiveOnChange();
                };
                rest = catSettings10.AddButton("--Reset--", "Reset", "Shadow Strength Reset");
                rest.OnPress += () =>
                {
                    Main.Config.lightShadowStr = 1f; UpdateText(); UpDateActiveOnChange();
                };
                catSettings10.AddButton("Shadow Str +", "ShadowsMore", "Shadow Strength").OnPress += () =>
                {
                    Main.Config.lightShadowStr += fast ? 1 : .1f; UpdateText(); UpDateActiveOnChange();
                };
                catSettings10.AddToggle("Quick Adj", "Faster adjust", fast).OnValueUpdated += action =>
                {
                    fast = action;
                };
                void UpdateText()
                {
                    catSettings10.CategoryName = $"Shadows - Str:{Utils.NumFormat(Main.Config.lightShadowStr)} - Res:{Utils.NumFormat(Main.Config.lightShadowCustRes)}";
                }
            }
            //Shadow Settings
            {
                BTKUILib.UIObjects.Components.Button rest = null;
                catSettings10.AddButton("Shadow Cust Res -", "PixelLess", "Shadow Resolution").OnPress += () =>
                {
                    Main.Config.lightShadowCustRes = Main.Config.lightShadowCustRes > 2 ? Main.Config.lightShadowCustRes / 2 : Main.Config.lightShadowCustRes; UpdateText(); UpDateActiveOnChange();
                };
                rest = catSettings10.AddButton("--Reset--", "Reset", "Shadow Resolution Reset");
                rest.OnPress += () =>
                {
                    Main.Config.lightShadowCustRes = 2048; UpdateText(); UpDateActiveOnChange();
                };
                catSettings10.AddButton("Shadow Cust Res +", "PixelMore", "Shadow Resolution").OnPress += () =>
                {
                    Main.Config.lightShadowCustRes = Main.Config.lightShadowCustRes < 8192 ? Main.Config.lightShadowCustRes * 2 : Main.Config.lightShadowCustRes; UpdateText(); UpDateActiveOnChange();
                };
                void UpdateText()
                {
                    catSettings10.CategoryName = $"Shadows - Str:{Utils.NumFormat(Main.Config.lightShadowStr)} - Res:{Utils.NumFormat(Main.Config.lightShadowCustRes)}";
                }
                //
                var shadowType = catSettings10.AddButton($"Shadow Type: {Main.Config.lightShadows}", "ShadowType", "Type - None/Soft/Hard");
                shadowType.OnPress += () =>
                {
                    switch (Main.Config.lightShadows)
                    {
                        case LightShadows.None: Main.Config.lightShadows = LightShadows.Soft; break;
                        case LightShadows.Soft: Main.Config.lightShadows = LightShadows.Hard; break;
                        case LightShadows.Hard: Main.Config.lightShadows = LightShadows.None; break;
                        default: Main.Config.lightShadows = LightShadows.None; break;
                    }
                    shadowType.ButtonText = $"Shadow Type: {Main.Config.lightShadows}";
                    UpDateActiveOnChange();
                };
            }
            page.OpenPage();
        }


        private static void CustomColorSelect()
        {
            var page = pageCustomColors;
            page.ClearChildren();
            page.MenuTitle = "Light Color";
            var catColors = page.AddCategory("Colors");
            void SetCustomColorsSub()
            {
                page.MenuSubtitle = $"Current color - R:{Utils.NumFormat(Main.Config.lightColor.r)}" +
                    $" G:{Utils.NumFormat(Main.Config.lightColor.g)} B:{Utils.NumFormat(Main.Config.lightColor.b)}";
            }
            page.MenuTitle = "Color";
            SetCustomColorsSub();
            //Color Presets
            {
                var buttonWhite = catColors.AddButton("White", "Color-White", "");
                buttonWhite.OnPress += () =>
                {
                    Main.Config.lightColor = Color.white; SetCustomColorsSub(); UpDateActiveOnChange();
                };
                var buttonRed = catColors.AddButton("Red", "Color-Red", "");
                buttonRed.OnPress += () =>
                {
                    Main.Config.lightColor = Color.red; SetCustomColorsSub(); UpDateActiveOnChange();
                };
                var buttonGreen = catColors.AddButton("Green", "Color-Green", ""); SetCustomColorsSub();
                buttonGreen.OnPress += () =>
                {
                    Main.Config.lightColor = Color.green; SetCustomColorsSub(); UpDateActiveOnChange();
                };
                var buttonBlue = catColors.AddButton("Blue", "Color-Blue", "");
                buttonBlue.OnPress += () =>
                {
                    Main.Config.lightColor = Color.blue; SetCustomColorsSub(); UpDateActiveOnChange();
                };
                var buttonBlack = catColors.AddButton("Black", "Color-Black", "");
                buttonBlack.OnPress += () =>
                {
                    Main.Config.lightColor = Color.black; SetCustomColorsSub(); UpDateActiveOnChange();
                };
                var buttonMagenta = catColors.AddButton("Magenta", "Color-Magenta", "");
                buttonMagenta.OnPress += () =>
                {
                    Main.Config.lightColor = Color.magenta; SetCustomColorsSub(); UpDateActiveOnChange();
                };
                var buttonYellow = catColors.AddButton("Yellow", "Color-Yellow", "");
                buttonYellow.OnPress += () =>
                {
                    Main.Config.lightColor = Color.yellow; SetCustomColorsSub(); UpDateActiveOnChange();
                };
                var buttonCyan = catColors.AddButton("Cyan", "Color-Cyan", "");
                buttonCyan.OnPress += () =>
                {
                    Main.Config.lightColor = Color.cyan; SetCustomColorsSub(); UpDateActiveOnChange();
                };
            }

            var catCustomColors = page.AddCategory("Custom Colors");
            //Colors Plus
            {
                var buttonRedPlus = catCustomColors.AddButton("Red +", "Red-Plus", "");
                buttonRedPlus.OnPress += () =>
                {
                    Main.Config.lightColor.r = Utils.Clamp(Main.Config.lightColor.r + .1f, 0f, 2f); SetCustomColorsSub(); UpDateActiveOnChange();
                };
                var buttonGreenPlus = catCustomColors.AddButton("Green +", "Green-Plus", "");
                buttonGreenPlus.OnPress += () =>
                {
                    Main.Config.lightColor.g = Utils.Clamp(Main.Config.lightColor.g + .1f, 0f, 2f); SetCustomColorsSub(); UpDateActiveOnChange();
                };
                var buttonBluePlus = catCustomColors.AddButton("Blue +", "Blue-Plus", "");
                buttonBluePlus.OnPress += () =>
                {
                    Main.Config.lightColor.b = Utils.Clamp(Main.Config.lightColor.b + .1f, 0f, 2f); SetCustomColorsSub(); UpDateActiveOnChange();
                };
                var buttonAllPlus = catCustomColors.AddButton("All +", "White-Plus", "");
                buttonAllPlus.OnPress += () =>
                {
                    Main.Config.lightColor.r = Utils.Clamp(Main.Config.lightColor.r + .1f, 0f, 2f);
                    Main.Config.lightColor.g = Utils.Clamp(Main.Config.lightColor.g + .1f, 0f, 2f);
                    Main.Config.lightColor.b = Utils.Clamp(Main.Config.lightColor.b + .1f, 0f, 2f);
                    SetCustomColorsSub(); UpDateActiveOnChange();
                };
            }
            //Colors Minus
            {
                var buttonRedMinus = catCustomColors.AddButton("Red -", "Red-Minus", "");
                buttonRedMinus.OnPress += () =>
                {
                    Main.Config.lightColor.r = Utils.Clamp(Main.Config.lightColor.r - .1f, 0f, 2f); SetCustomColorsSub(); UpDateActiveOnChange();
                };
                var buttonGreenMinus = catCustomColors.AddButton("Green -", "Green-Minus", "");
                buttonGreenMinus.OnPress += () =>
                {
                    Main.Config.lightColor.g = Utils.Clamp(Main.Config.lightColor.g - .1f, 0f, 2f); SetCustomColorsSub(); UpDateActiveOnChange();
                };
                var buttonBlueMinus = catCustomColors.AddButton("Blue -", "Blue-Minus", "");
                buttonBlueMinus.OnPress += () =>
                {
                    Main.Config.lightColor.b = Utils.Clamp(Main.Config.lightColor.b - .1f, 0f, 2f); SetCustomColorsSub(); UpDateActiveOnChange();
                };
                var buttonAllMinus = catCustomColors.AddButton("All -", "White-Minus", "");
                buttonAllMinus.OnPress += () =>
                {
                    Main.Config.lightColor.r = Utils.Clamp(Main.Config.lightColor.r - .1f, 0f, 2f);
                    Main.Config.lightColor.g = Utils.Clamp(Main.Config.lightColor.g - .1f, 0f, 2f);
                    Main.Config.lightColor.b = Utils.Clamp(Main.Config.lightColor.b - .1f, 0f, 2f);
                    SetCustomColorsSub(); UpDateActiveOnChange();
                };
            }
            //Colors Reset
            {
                var buttonRedReset = catCustomColors.AddButton("Red Reset", "Reset", "");
                buttonRedReset.OnPress += () =>
                {
                    Main.Config.lightColor.r = 1f; SetCustomColorsSub(); UpDateActiveOnChange();
                };
                var buttonGreenReset = catCustomColors.AddButton("Green Reset", "Reset", "");
                buttonGreenReset.OnPress += () =>
                {
                    Main.Config.lightColor.g = 1f; SetCustomColorsSub(); UpDateActiveOnChange();
                };
                var buttonBlueReset = catCustomColors.AddButton("Blue Reset", "Reset", "");
                buttonBlueReset.OnPress += () =>
                {
                    Main.Config.lightColor.b = 1f; SetCustomColorsSub(); UpDateActiveOnChange();
                };
                var buttonAllReset = catCustomColors.AddButton("All Reset", "Reset", "");
                buttonAllReset.OnPress += () =>
                {
                    Main.Config.lightColor.r = 1f;
                    Main.Config.lightColor.g = 1f;
                    Main.Config.lightColor.b = 1f;
                    SetCustomColorsSub(); UpDateActiveOnChange();
                };
            }
            page.OpenPage();
        }

        private static void SelectSpecific()
        {
            var page = pageSelectLight;
            page.ClearChildren();

            page.MenuTitle = "Select Specific Light";
            //page.MenuSubtitle = "This page lists currently existing lights";
            page.MenuSubtitle = CurrentConfig();

            float i = 0;
            foreach (var obj in Main.lightList)
            {
                if (!obj?.Equals(null) ?? false)
                {
                    i++;
                    var cat = pageSelectLight.AddCategory((obj==Main.activeLight?"*":"") + Main.LightDetailsString(obj) + (obj == Main.activeLight ? "*" : ""));

                    cat.AddButton("Set as Active", "Select", "Set as active light | THIS DOES NOT LOAD SETTINGS INTO CONFIG - USE THE LOAD LIGHT'S SETTINGS BUTTON FOR THAT").OnPress += () =>
                    {
                        Main.activeLight = obj;
                        SelectSpecific();
                    };
                    cat.AddButton("Update w/ Cur Settings", "LightFromConfig", "Updates this light's settings with the current config").OnPress += () =>
                    {
                        Main.UpdateLight(obj);
                        SelectSpecific();
                    };
                    cat.AddButton("Load Light's Settings", "LightToConfig", "Load this light's settings into the current config").OnPress += () =>
                    {
                        Main.LoadLightSettings(obj);
                        SelectSpecific();
                    };
                    
                    cat.AddButton("Delete", "Delete", "").OnPress += () =>
                    {
                        Main.CleanupOneObject(obj);
                        SelectSpecific();
                    };
                    cat.AddToggle("Pickupable", "Pickupable", obj.GetOrAddComponent<CVRPickupObject>().enabled).OnValueUpdated += action =>
                    {
                        obj.GetOrAddComponent<CVRPickupObject>().enabled = action;
                    };
                    cat.AddToggle("Hide Mesh", "Hide Mesh", !obj.GetOrAddComponent<MeshRenderer>().enabled).OnValueUpdated += action =>
                    {
                        obj.GetOrAddComponent<MeshRenderer>().enabled = !action;
                    };
                }
            }
            page.OpenPage();
        }

        public static void SetName()
        {
            var chars = "abcdefghijklmnopqrstuvwxyz-_ ".ToCharArray();
            bool cas = true;

            var page = pageSetName;
            page.ClearChildren();

            page.MenuTitle = "Set a name for the light";
            void SetCustomSub()
            {
                page.MenuSubtitle = $"Current name: {Main.Config.name}";
            }
            SetCustomSub();

            var cat1 = page.AddCategory("");
            var cat2 = page.AddCategory("");

            cat1.AddButton("BackSpace", "blank", "").OnPress += () =>
            {
                if (Main.Config.name.Length > 0) Main.Config.name = Main.Config.name.Remove(Main.Config.name.Length - 1, 1); SetCustomSub();
            };
            cat1.AddButton("Clear", "blank", "").OnPress += () =>
            {
                Main.Config.name = ""; SetCustomSub();
            };
            cat1.AddToggle("Upper Case", "Toggle Upper/Lower Case", cas).OnValueUpdated += action =>
            {
                cas = action;
            };

            foreach (char c in chars)
            {
                var s = c.ToString();
                cat2.AddButton(s.ToUpper(), "blank", $"{s.ToUpper()}/{s.ToLower()}").OnPress += () =>
                {
                    Main.Config.name += cas ? s.ToUpper() : s.ToLower(); SetCustomSub();
                    pageLightConfig_Name.ButtonText = $"Name: {Main.Config.name}";
                    pageLightConfig_Name.ButtonTooltip = Main.Config.name;
                };
            }
            page.OpenPage();
        }

        public static void LightLayerMask()
        {
            var page = pageLayers;
            page.ClearChildren();
            page.MenuTitle = "Light culling mask";
            page.MenuSubtitle = $"Enabled layers will be lit by the light";
            var cat1 = page.AddCategory("");
            var cat2 = page.AddCategory("");

            cat1.AddButton("Enable All", "blank", "").OnPress += () =>
            {
                Main.Config.cullingMask = -1; LightLayerMask();
                UpDateActiveOnChange();
            };
            cat1.AddButton("Disable All", "blank", "").OnPress += () =>
            {
                Main.Config.cullingMask = 0; LightLayerMask();
                UpDateActiveOnChange();
            };
            cat1.AddButton("Only Players", "blank", "Only enable layers used by players").OnPress += () =>
            {
                Main.Config.cullingMask = 0 | (1 << 8) | (1 << 9) | (1 << 10) | (1 << 11); LightLayerMask();
                UpDateActiveOnChange();
            };

            foreach (KeyValuePair<int, string> entry in layerList)
            {
                cat2.AddToggle($"Layer #{entry.Key}", $"Layer #{entry.Key} ID:{entry.Value}", Utils.IsLayerEnabled(Main.Config.cullingMask, entry.Key)).OnValueUpdated += action =>
                {
                    if (action)
                        Main.Config.cullingMask = Main.Config.cullingMask | (1 << entry.Key); //Add
                    else
                        Main.Config.cullingMask = Main.Config.cullingMask & ~(1 << entry.Key); //Remove
                    UpDateActiveOnChange();
                };
            }
            page.OpenPage();
        }

        private static void StoredColorsMenu()
        {//type T|F - Pos|Rot
            string current = $"Current:\nR:{Utils.NumFormat(Main.Config.lightColor.r)}\nG:{Utils.NumFormat(Main.Config.lightColor.g)}\nB:{Utils.NumFormat(Main.Config.lightColor.b)}";
            var page = pageSavedColors;
            page.ClearChildren();
            page.MenuTitle = "Save/Load custom colors";
            page.MenuSubtitle = current;

            var catMain = page.AddCategory("");

            catMain.AddButton("Update Active Light", "UpdateLight", "").OnPress += () =>
            {
                Main.UpdateLight(Main.activeLight);
            };
            foreach (KeyValuePair<int, System.Tuple<float, float, float>> slot in SaveSlots.GetSavedColors())
            {
                string label = $"Slot: {slot.Key}\nR:{Utils.NumFormat(slot.Value.Item1)}\nG:{Utils.NumFormat(slot.Value.Item2)}\nB:{Utils.NumFormat(slot.Value.Item3)}";
                var cat = page.AddCategory(label);

                cat.AddButton("Load", "Load", "").OnPress += () =>
                {
                    Main.Config.lightColor.r = slot.Value.Item1;
                    Main.Config.lightColor.g = slot.Value.Item2;
                    Main.Config.lightColor.b = slot.Value.Item3;
                    StoredColorsMenu();
                };
                cat.AddButton("Save", "Save", "").OnPress += () =>
                {
                    SaveSlots.Store(slot.Key, new System.Tuple<float, float, float>(Main.Config.lightColor.r, Main.Config.lightColor.g, Main.Config.lightColor.b));
                    StoredColorsMenu();
                };
            }
            page.OpenPage(); 
        }

        private static void SavedPrefSlots()
        {
            var page = pageSavedSlots;
            page.ClearChildren();
            page.MenuTitle = "Save/Load Presets";
            string current = CurrentConfig();
            page.MenuSubtitle = current;

            var catMain = page.AddCategory("");
            catMain.AddButton("Update Active Light", "UpdateLight", "").OnPress += () =>
            {
                Main.UpdateLight(Main.activeLight);
            };

            foreach (KeyValuePair<int, (bool, bool, LightType, float, float, Color, float, float, LightShadows, float, string, bool, int)> slot in SaveSlots.GetSavedPrefs())
            {
                string label = $"Slot:{slot.Key} {slot.Value.Item11} {slot.Value.Item3} R:{slot.Value.Item6.r}G:{slot.Value.Item6.g}B:{slot.Value.Item6.b} Inten:{slot.Value.Item7} Range:{slot.Value.Item4} Hidden:{slot.Value.Item12}";//\nUp:{Utils.NumberFormat(slot.Value.Item1)}\nForward:{Utils.NumberFormat(slot.Value.Item2)}\nSide:{Utils.NumberFormat(slot.Value.Item3)}"
                var cat = page.AddCategory(label);

                cat.AddButton("Load", "Load", "").OnPress += () =>
                {
                    Main.Config.name = slot.Value.Item11;
                    Main.Config.pickupOrient = slot.Value.Item1;
                    Main.Config.pickupable = slot.Value.Item2;
                    Main.Config.lightType = slot.Value.Item3;
                    Main.Config.lightRange = slot.Value.Item4;
                    Main.Config.lightSpotAngle = slot.Value.Item5;
                    Main.Config.lightColor = slot.Value.Item6;
                    Main.Config.lightIntensity = slot.Value.Item7;
                    Main.Config.lightBounceIntensity = slot.Value.Item8;
                    Main.Config.lightShadows = slot.Value.Item9;
                    Main.Config.lightShadowStr = slot.Value.Item10;
                    Main.Config.hideMeshRender = slot.Value.Item12;
                    Main.Config.cullingMask = slot.Value.Item13;
                    SavedPrefSlots();
                };

                cat.AddButton("Save", "Save", "").OnPress += () =>
                {
                    SaveSlots.StorePrefs(slot.Key, (Main.Config.pickupOrient, Main.Config.pickupable, Main.Config.lightType, Main.Config.lightRange, Main.Config.lightSpotAngle, Main.Config.lightColor, Main.Config.lightIntensity, Main.Config.lightBounceIntensity, Main.Config.lightShadows, Main.Config.lightShadowStr, Main.Config.name, Main.Config.hideMeshRender, Main.Config.cullingMask));
                    SavedPrefSlots();
                };  
            }
            page.OpenPage();
        }

        private static string CurrentConfig()
        {
            return $"Current:{Main.Config.name} {Main.Config.lightType} R:{Main.Config.lightColor.r}G:{Main.Config.lightColor.g}B:{Main.Config.lightColor.b}" +
                $" Inten:{Utils.NumFormat(Main.Config.lightIntensity)} Range:{Utils.NumFormat(Main.Config.lightRange)} Hidden:{Main.Config.hideMeshRender}"; // Up:{Utils.NumberFormat(melonPref1.Value)}\nForward:{Utils.NumberFormat(melonPref2.Value)}\nSide:{Utils.NumberFormat(melonPref3.Value)}";
        }

        private static Dictionary<int, string> layerList = new Dictionary<int, string>()
        {
            {0, "Default"},
            {1, "TransparentFX"},
            {2, "Ignore Raycast"},
            {3, ""},
            {4, "Water"},
            {5, "UI"},
            {6, ""},
            {7, ""},
            {8, "PlayerLocal"},
            {9, "PlayerClone"},
            {10, "PlayerNetwork"},
            {11, "MirrorReflection"},
            {12, "CVRReserved1"},
            {13, "CVRReserved2"},
            {14, "CVRReserved3"},
            {15, "CVRReserved4"},
            {16, "PostPorcessing"},
            {17, "CVRPickup"},
            {18, "CVRInteractable*"},
            {19, "19"},
            {20, "20"},
            {21, "21"},
            {22, "22"},
            {23, "23"},
            {24, "24"},
            {25, "25"},
            {26, "26"},
            {27, "27"},
            {28, "28"},
            {29, "29"},
            {30, "30"},
            {31, "31"}
        }; 
    }
}

