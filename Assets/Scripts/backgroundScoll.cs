using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundScoll : MonoBehaviour
{
    Material material;
    Vector2 offset;

    public float xVelocity, yVelocity;


    void Start()
    {
        material = GetComponent<Renderer>().material;
        offset = new Vector2(xVelocity, yVelocity);
    }

    // Update is called once per frame
    void Update()
    {
        material.mainTextureOffset += offset * Time.deltaTime;
    }
}
