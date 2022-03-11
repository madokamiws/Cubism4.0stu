using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Live2D.Cubism.Framework.Json;
using Live2D.Cubism.Core;
using Live2D.Cubism.Framework.UserData;
//using Live2D.Cubism.Framework.Physics;
public class ParseAndSetUserdata : MonoBehaviour
{
    private CubismModel cubismModel;

    // Start is called before the first frame update
    void Start()
    {
        string json = Resources.Load<TextAsset>("Haruto/haruto_t01.userdata3").text;
        CubismUserData3Json cubismUserData3Json = CubismUserData3Json.LoadFrom(json);//json解析
        CubismUserDataBody[] cubismUserDataBodies = cubismUserData3Json.ToBodyArray(CubismUserDataTargetType.ArtMesh);
        foreach (var item in cubismUserDataBodies)
        {
            Debug.Log("item.Id:" + item.Id + "\n" + "item.Value:" + item.Value);
        }
        cubismModel = GetComponent<CubismModel>();
        CubismDrawable[] drawables = cubismModel.Drawables;
        for (int i = 0; i < drawables.Length; i++)
        {
            int index = -1;
            for (int j = 0; j < cubismUserDataBodies.Length; j++)
            {
                if (cubismUserDataBodies[j].Id!=drawables[i].Id)
                {
                    continue;
                }
                index = j;
                break;
            }
            if (index<0)
            {
                continue;
            }
            CubismUserDataTag tag = drawables[i].gameObject.GetComponent<CubismUserDataTag>();
            if (tag == null)
            {
                tag = drawables[i].gameObject.AddComponent<CubismUserDataTag>();
                tag.Initialize(cubismUserDataBodies[index]);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
