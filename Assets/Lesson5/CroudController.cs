using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CroudController : MonoBehaviour
{

    private float minimum = 1.0f;
    private float magSpeed = 7.0f;
    private float magnification = 0.07f;

    //最小サイズ、拡大縮小スピード、拡大率

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.localScale = new Vector3(this.minimum + Mathf.Sin(Time.time * this.magSpeed) * this.magnification, this.transform.localScale.y, this.minimum + Mathf.Sin(Time.time * this.magSpeed) * this.magnification);
    }

}
