using UnityEngine;
using UnityEditor;
using UnityEditor.Experimental.AssetImporters;
using System.IO;
using HipHopFile;
using RenderWareFile;


[ScriptedImporter(1, "HIP")]
public class HIPImporter: ScriptedImporter {

 public override void OnImportAsset(AssetImportContext ctx) {
  int pos = ctx.assetPath.LastIndexOf("/") + 1;
  string LevelExtension = ctx.assetPath.Substring(pos, ctx.assetPath.Length - pos);
  string LevelName = LevelExtension.Substring(0, LevelExtension.IndexOf("."));
  var hipFile = new HipFile(ctx.assetPath);

  if (!AssetDatabase.IsValidFolder("Assets/" + LevelName)) {
   AssetDatabase.CreateFolder("Assets", LevelName);
  foreach (var AHDR in hipFile.DICT.ATOC.AHDRList){
  if (AHDR.assetType == AssetType.MODL)
    {
        var model = ReadFileMethods.ReadRenderWareFile(AHDR.data)[0];
        

    }
  }
  }

 }
}