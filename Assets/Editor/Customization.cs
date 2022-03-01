using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Live2D.Cubism.Editor.Importers;
using Live2D.Cubism.Editor.Deleters;
public class ImporterCustomization : CubismImporterBase
{
    [UnityEditor.InitializeOnLoadMethod]

    //指定导入器在导入哪些类型的文件会触发回调方法
    private static void RegisterImporter()
    {
        CubismImporter.RegisterImporter<ImporterCustomization>(".asset");//注册导入器
    }

    /// <summary>
    /// 导入器在导入文件时执行的回调方法
    /// </summary>
    public override void Import()
    {
        //throw new System.NotImplementedException();
        Debug.Log("Asset Import as path : " + AssetPath);

    }
}
public class DeleterCubismization : CubismDeleterBase
{
    [UnityEditor.InitializeOnLoadMethod]

    //指定导入器在导入哪些类型的文件会触发回调方法
    private static void RegisterDeleter()
    {
        CubismDeleter.RegisterDeleter<DeleterCubismization>(".asset");//注册导入器
    }
    public override void Delete()
    {
        Debug.Log("Asset Deleted as path : " + AssetPath);

    }
}