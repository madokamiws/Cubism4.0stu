using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Live2D.Cubism.Framework.Raycasting;
public class CubismHitTest : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        if (!Input.GetMouseButtonDown(0))
        {
            return;
        }
        CubismRaycaster cubismRaycaster = GetComponent<CubismRaycaster>();
        CubismRaycastHit[] cubismRaycastHits = new CubismRaycastHit[4];

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);//射线
        int hitCount = cubismRaycaster.Raycast(ray,cubismRaycastHits);//射线检测
        string requestText = hitCount.ToString();
        for (int i = 0; i < hitCount; i++)
        {
            requestText += "n" + cubismRaycastHits[i].Drawable.name;
        }
        Debug.Log(requestText);
    }
}
