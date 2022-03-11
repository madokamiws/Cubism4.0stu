using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Live2D.Cubism.Framework.MouthMovement;

public class Mousetest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<CubismMouthController>().MouthOpening = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
