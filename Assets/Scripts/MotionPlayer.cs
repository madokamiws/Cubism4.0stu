using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Live2D.Cubism.Framework.Motion;
public class MotionPlayer : MonoBehaviour
{
    private CubismMotionController cubismMotionController;
    // Start is called before the first frame update
    void Start()
    {
        cubismMotionController = GetComponent<CubismMotionController>();
    }

    public void PlayMotion(AnimationClip animationClip)
    {
        if (animationClip == null || cubismMotionController == null)
        {
            Debug.LogError("控制器或者播放的资源为空");
            return;
        }
        cubismMotionController.PlayAnimation(animationClip, isLoop:false);
    }
}
