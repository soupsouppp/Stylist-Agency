using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hair : MonoBehaviour
{
    Vector3 Endpos;
    Vector3 Startpos;
    public float slideSpeed;


    // Start is called before the first frame update
    void Start()
    {
        Startpos = transform.position;


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void WPressed()
    {
        Endpos = transform.position + new Vector3(6, 0, 0);
        transform.position = Vector3.Lerp(Startpos, Endpos, slideSpeed);
    }

    public void SPressed()
    {
        Endpos = transform.position + new Vector3(-6, 0, 0);
        transform.position = Vector3.Lerp(Startpos, Endpos, slideSpeed);
    }
}
