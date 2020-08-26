using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrightnessRegulator : MonoBehaviour
{

    Material myMaterial;

    private float minEmission = 0.3f;
    private float magEmission = 2.0f;
    private int degree = 0;
    private int speed = 10;

    Color defaultColer = Color.white;

    // Start is called before the first frame update
    void Start()
    {
        if(tag == "SmallStarTag")
        {
            this.defaultColer = Color.white;
        }
        else if(tag == "SmallCloudTag" || tag == "LargeClougTag")
        {
            this.defaultColer = Color.cyan;
        }
        else if(tag == "LargeStarTag")
        {
            this.defaultColer = Color.yellow;
        }
        this.myMaterial = GetComponent<Renderer>().material;

        myMaterial.SetColor("_EmissionColor", this.defaultColer * minEmission);
    }

    // Update is called once per frame
    void Update()
    {
        if (this.degree >= 0)
        {
            Color emissionColor = this.defaultColer * (this.minEmission + Mathf.Sin(this.degree * Mathf.Deg2Rad) * this.magEmission);
            myMaterial.SetColor("_EmissionColor", emissionColor);
            this.degree -= this.speed;
        }
    }
    void OnCollisionEnter(Collision other)
    {
        this.degree = 180;
    }
}
