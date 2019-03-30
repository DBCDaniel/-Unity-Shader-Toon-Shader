using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToonLight : MonoBehaviour
{
    private Light light = null;

    void OnEnable()
    {
        light = this.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (light != null)
        {
            Shader.SetGlobalVector("_ToonShader_LightDirection_Vector4", -this.transform.forward);
        }
    }
}
