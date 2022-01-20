using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Live2D.Cubism.Framework.Json;
using System;
using System.IO;

public class InitModel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string path = Application.dataPath + "/Gantzert_Felixander/runtime/Gantzert_Felixander.model3.json";//json配置路径
        CubismModel3Json cubismModel3Json = CubismModel3Json.LoadAtPath(path, BuiltInLoadPath);

        //模型实例化
        cubismModel3Json.ToModel();
    }   

    // Update is called once per frame
    void Update()
    {
        
    }
    public static object BuiltInLoadPath(Type assetType, string absolutePath)
    {
        if (assetType == typeof(byte[]))
        {
            return File.ReadAllBytes(absolutePath);
        }
        else if (assetType == typeof(string))
        {
            return File.ReadAllText(absolutePath);
        }
        else if (assetType == typeof(Texture2D))
        {
            Texture2D texture2D = new Texture2D(1, 1);
            texture2D.LoadImage(File.ReadAllBytes(absolutePath));
            return texture2D;
        }
        throw new NotSupportedException();
    }
}
