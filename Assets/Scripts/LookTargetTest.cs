using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Live2D.Cubism.Framework.LookAt;

public class LookTargetTest : MonoBehaviour, ICubismLookTarget
{
    public Vector3 GetPosition()
    {
        if (Input.GetMouseButton(0))
        {
            return Vector3.zero;
        }
         Vector3 targetpos = Input.mousePosition;
        targetpos = Camera.main.ScreenToWorldPoint(new Vector3(targetpos.x, targetpos.y, 0 - Camera.main.transform.position.z));
        return targetpos;

    }

    public bool IsActive()
    {
        return gameObject.activeInHierarchy;
    }


}
