using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Live2D.Cubism.Framework.Json;
using Live2D.Cubism.Framework.Expression;
using UnityEditor;
using System;

public class ExpressionCreator : MonoBehaviour
{
    //使用表情功能的步骤
    //1.创建[.exp3.asset]
    //2.创建[.expressionList.asset]并添加[.exp3.asset]
    //3.播放面部表情动画

    //创建[.exp3.asset]步骤
    //[.exp3.asset]是从[exp3.json] 转换而来的ScriptableObject资产。
    //此文件不能修改或者损坏，如果更改，则无法保证正常操作。
    //要将[exp.json] 转换为[.exp3.asset]需要三步：
    //a.解析[exp.json]
    //b.用CubismExpressionData存贮解析信息
    //c.创建[.exp3.asset]

    // Start is called before the first frame update
    void Start()
    {
        //1.创建[.exp3.asset]
        //a.解析[exp.json]
        TextAsset[] textAssets = Resources.LoadAll<TextAsset>("Natori/exp");

        CubismExpressionData[] cubismExpressionDatas = new CubismExpressionData[textAssets.Length];

        for (int i = 0; i < textAssets.Length; i++)
        {
            string json = textAssets[i].text;
            //b.用CubismExpressionData存贮解析信息
            CubismExp3Json cubismExp3Json = CubismExp3Json.LoadFrom(json);
            CubismExpressionData cubismExpressionData =
                CubismExpressionData.CreateInstance(cubismExp3Json);

            cubismExpressionDatas[i] = cubismExpressionData;

            //c.创建[.exp3.asset]
            string assetsPath = "Assets/Resources/Natori/expTest/" + i + ".exp3.asset";
            AssetDatabase.CreateAsset(cubismExpressionData, assetsPath);
            EditorUtility.SetDirty(cubismExpressionData);
        }
        //2.创建[.expressionList.asset]
        CubismExpressionList cubismExpressionList = new CubismExpressionList();
        AssetDatabase.CreateAsset(cubismExpressionList,
            "Assets/Resources/Natori/expTest/Natori.expressionList.asset");
        EditorUtility.SetDirty(cubismExpressionList);
        //添加[.exp3.asset]到[.expressionList.asset]
        cubismExpressionList.CubismExpressionObjects = new CubismExpressionData[0];
        for (int i = 0; i < cubismExpressionDatas.Length; i++)
        {
            int index = cubismExpressionList.CubismExpressionObjects.Length;
            Array.Resize(ref cubismExpressionList.CubismExpressionObjects,
                index + 1);
            cubismExpressionList.CubismExpressionObjects[index] = cubismExpressionDatas[i];
        }
        EditorUtility.SetDirty(cubismExpressionList);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
