using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Live2D.Cubism.Editor.Importers;
using Live2D.Cubism.Framework.Json;
using Live2D.Cubism.Core;

public static class MaterialCusomizer
{
    /// <summary>
    /// 保存使用自定义材质的部分对应的ID
    /// </summary>
    private static string[] drawablesToCustomize = { "D_PSD_42", "D_PSD_45", "D_PSD_44", "D_PSD_43", "D_PSD_04", "D_PSD_05", "D_PSD_01" };
    /// <summary>
    /// 自定义材质
    /// </summary>
    private static Material customMaterial;
    /// <summary>
    /// 加载材质，注册使用材质的方法
    /// </summary>
    [InitializeOnLoadMethod]
    private static void RegisterMaterialInitialize()
    {
        //Debug.Log("当前方法被调用");  
        customMaterial = AssetDatabase.LoadAssetAtPath<Material>("Assets/Materials/CustomMat.mat");
        CubismImporter.OnPickMaterial = CustomizeMaterial;
    }
    private static Material CustomizeMaterial(CubismModel3Json sender, CubismDrawable drawable)
    {
        for (int i = 0; i < drawablesToCustomize.Length; i++)
        {
            if (drawablesToCustomize[i] == drawable.Id)
            {
                return customMaterial;
            }
        }
        return CubismBuiltinPickers.MaterialPicker(sender, drawable);
    }

}
