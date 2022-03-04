using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Live2D.Cubism.Framework;

public class CubismExampleController : MonoBehaviour,ICubismUpdatable
{
    public int executionOrder;
    //执行顺序（调用顺序）
    public int ExecutionOrder => executionOrder;

    //public int ExecutionOrder()
    //{ 
    //return executionOrder;
    //}


    public bool NeedsUpdateOnEditing => false;

    public bool HasUpdateController { get ; set ; }
    
    /// <summary>
    /// 控制执行数据的函数
    /// </summary>
    public void OnLateUpdate()
    {
        Debug.Log(ExecutionOrder.ToString() + "被调用~！");
    }

    // Start is called before the first frame update
    void Start()
    {
        HasUpdateController =  GetComponent<CubismUpdateController>() != null;    }

    // Update is called once per frame
    void Update()
    {
        if (!HasUpdateController)
        {
            OnLateUpdate();
        }
    }
}
