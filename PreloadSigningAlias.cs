using UnityEngine;
using UnityEditor;
using System.IO;

//It should be under 'Editor' folder in unity
[InitializeOnLoad]
public class PreloadSigningAlias
{
    static PreloadSigningAlias()
    {
        string keystorePath = Path.GetFullPath(Path.Combine(Application.dataPath, @"..\")); //Project Folder
        PlayerSettings.Android.keystoreName = keystorePath + "myGame.keystore";
        PlayerSettings.Android.keystorePass = "myGameKeyStorePass";
        PlayerSettings.Android.keyaliasName = "myGameAliasName";
        PlayerSettings.Android.keyaliasPass = "myGameAliasPassword";
    }
}