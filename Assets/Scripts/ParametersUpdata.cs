using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Live2D.Cubism.Core;
using Live2D.Cubism.Framework;
public class ParametersUpdata : MonoBehaviour
{
    private CubismModel cubismModel;
    private float timeCount;

    private string ParameterID = "PARAM_ANGLE_Z";
    private CubismParameter ParameterAngleZ;

    // Start is called before the first frame update
    void Start()
    {
        cubismModel = this.FindCubismModel();//FindCubismModel找到脚本挂载的模型类
        ParameterAngleZ = cubismModel.Parameters.FindById(ParameterID);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /// <summary>
    /// 动画修改在update之后，lateupdate之前，所以放到LU中
    /// </summary>
    private void LateUpdate()
    {
        timeCount += Time.deltaTime * 4;
        float value = Mathf.Sin(timeCount) * 30f;


        /// <summary>
        //通过参数索引获取
        /// </summary>
        //CubismParameter cubismParameter =  cubismModel.Parameters[2];
        //cubismParameter.Value = value;

        //ParameterAngleZ.Value = value;
        ParameterAngleZ.BlendToValue(CubismParameterBlendMode.Override,value);//混合赋值

    }
}
