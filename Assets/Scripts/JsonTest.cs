using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Live2D.Cubism.Framework.Json;
using Live2D.Cubism.Core;
using Live2D.Cubism.Framework.UserData;
using Live2D.Cubism.Framework.Physics;
public class JsonTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ////cubismmodel3json
        ////以.model3.json结尾的json文件对应的解析器
        ////.model3.json是模型的最主要信息文件 可以获取其他各种json的路径，
        ////例如.model3.json中描述的动作和面部表情。
        ///

        //-------------------------------------------------------------------------------------------
        string path = Application.dataPath + "/Haruto/haruto_t01.model3.json";
        CubismModel3Json cubismModel3Json = CubismModel3Json.LoadAtPath(path, InitModel.BuiltInLoadPath);

        cubismModel3Json.ToModel();
        //CubismModel cubismModel = cubismModel3Json.ToModel();
        //获取.moc文件
        string mocPath = cubismModel3Json.FileReferences.Moc;
        //获取.physics.json文件
        string physicsPath = cubismModel3Json.FileReferences.Physics;
        //-------------------------------------------------------------------------------------------


        //cubismmotion3json
        //以.motion3.json结尾的json文件对应的解析器。
        //可以根据.motion3.json中描述的曲线信息生成AnimationClip。
        //motion3.json个是模型的动画文件，老版本是mtn文件，
        //现在变成了motion3.json文件，即模型师为这个模型制作的动画文件 
        //string json = Resources.Load<TextAsset>("Haruto/01.motion3").text;
        //CubismMotion3Json cubismMotion3Json = CubismMotion3Json.LoadFrom(json);//json解析
        //AnimationClip animationClip = cubismMotion3Json.ToAnimationClip();
        //-------------------------------------------------------------------------------------------


        ////cubismuserdata3json  
        ////以.userdata3.json结尾的json文件的解析器。
        ////.userdata3.json中描述的信息即用户数据可以对艺
        ////术网格以及模型各部分进行打标签和分组。

        //string json = Resources.Load<TextAsset>("Haruto/haruto_t01.userdata3").text;
        //CubismUserData3Json cubismUserData3Json = CubismUserData3Json.LoadFrom(json);//json解析
        //CubismUserDataBody[] cubismUserDataBodies = cubismUserData3Json.ToBodyArray(CubismUserDataTargetType.ArtMesh);
        //foreach (var item in cubismUserDataBodies)
        //{
        //    Debug.Log("item.Id:" + item.Id + "\n" + "item.Value:" + item.Value);
        //}
        //-------------------------------------------------------------------------------------------


        ////cubismphysics3json
        ////这是.physics3.json的解析器。
        ////在.physics3.json中描述Physics设定值Unity可以转换使用。
        ////这是物理效果文件，比如做模型时候的头发随风飘动等各种物理效果


        //string json = Resources.Load<TextAsset>("Haruto/haruto_t01.physics3").text;
        //CubismPhysics3Json cubismPhysics3Json = CubismPhysics3Json.LoadFrom(json);
        //CubismPhysicsController cubismPhysicsController = cubismModel.GetComponent<CubismPhysicsController>();
        //cubismPhysicsController.Initialize(cubismPhysics3Json.ToRig());
        //-------------------------------------------------------------------------------------------


        ////cubismexp3json
        ////这是.exp3.json的解析器。
        ////.exp3.json是模型表情的文件或者配饰显示文件，如果与其他动画合用不需要
        ////单独制作或提取表情，这个解析器以及.exp3.json则没有用处。
        ////加载格式
        //string json = Resources.Load<TextAsset>("xx/xx.exp3").text;
        //CubismExp3Json exp3Json = CubismExp3Json.LoadFrom(json);

        //-------------------------------------------------------------------------------------------
        ////cubismpose3json
        ////是.pose3.json.的解析器
        ////用于做姿势与换装的文件,如果动画中包含此功能，则没有用处
        ////加载格式
        //string json = Resources.Load<TextAsset>("xx/xx.pose3").text;
        //CubismPose3Json pose3Json = CubismPose3Json.LoadFrom(json);

        //-------------------------------------------------------------------------------------------
        //CubismDisplayInfo3Json
        //CubismDisplayInfo3Json是.cdi3.json的解析器
        //.cdi3.json中记述了Cubism编辑器中设定的参数、零件、参数组的名称以及与之相对的各ID
        //在Cubism SDKfor Unity中，用于显示Inspector窗口中显示的参数和部件的名称。没有这个
        //配置文件，Unity中的Inspector面板将不会显示对应的ID以及各个部分

        //-------------------------------------------------------------------------------------------

    }

    void Update()
    {
        
    }
}
