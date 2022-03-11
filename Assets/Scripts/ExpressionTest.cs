using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Live2D.Cubism.Framework.Expression;

public class ExpressionTest : MonoBehaviour
{
    private CubismExpressionController expressionController;
    private int index=-1;

    void Start()
    {
        expressionController = GetComponent<CubismExpressionController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            index++;
            if (index>= expressionController.ExpressionsList.CubismExpressionObjects.Length)
            {
                index = -1;
            }
            expressionController.CurrentExpressionIndex = index;
        }
        
    }
}
