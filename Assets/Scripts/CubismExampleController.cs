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

    public void OnLateUpdate()
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
