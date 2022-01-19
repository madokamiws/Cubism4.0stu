using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Live2D.Cubism.Framework.Json;

public class InitModel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string path = Application.dataPath + "/Gantzert_Felixander/runtime/Gantzert_Felixander.model3.json";//json配置路径
        CubismModel3Json cubismModel3Json = CubismModel3Json.LoadAtPath(path);

        //模型实例化
        cubismModel3Json.ToModel();
    }   

    // Update is called once per frame
    void Update()
    {
        
    }
}
