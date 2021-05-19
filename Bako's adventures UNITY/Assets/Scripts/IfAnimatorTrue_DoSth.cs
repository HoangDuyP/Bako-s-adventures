using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfAnimatorTrue_DoSth : MonoBehaviour
{
    private Animator AniObj_;
    public ParticleSystem Par_WaterSource;
    private void Awake()
    {
        AniObj_ = GetComponent<Animator>();
        Par_WaterSource.Stop();
    }
    private void Update()
    {
        if (AniObj_.enabled.Equals(true))
        {
            Debug.Log("success");
            Par_WaterSource.Play();
            //
        }
    }
    // Start is called before the first frame update

}
