using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Live2D.Cubism.Framework.UserData;

public class UserdataTest : MonoBehaviour
{
    public void UserDateEventLister(string value)
    {
        AnimatorStateInfo currentState = GetComponent<Animator>().GetCurrentAnimatorStateInfo(0);
        Debug.Log("value = "+ value);
    }
}
