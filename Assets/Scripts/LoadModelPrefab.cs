using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadModelPrefab : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //1  Resources
        //GameObject modelPrefab =  Resources.Load<GameObject>("Gantzert_Felixander");
        //Instantiate(modelPrefab);
        //2  StreamingAssets
        //.......................
        //

        //3  string
        string loadpath = Application.streamingAssetsPath + "/model.live2d";
        AssetBundle assetBundle =  AssetBundle.LoadFromFile(loadpath);
        GameObject modelPrefab =  assetBundle.LoadAsset<GameObject>("Gantzert_Felixander");
        Instantiate(modelPrefab);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
