using Unity.Mathematics;
using UnityEngine;

public class WhatTheDogDoing : MonoBehaviour
{
    public int moveW;
    public int moveH;
    private float cycle = math.PI;

    private Vector3 originalPos;
    private Vector3 originalScale;
    private Vector3 flippedScale;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        originalPos = this.transform.position;
        originalScale = this.transform.localScale;
        flippedScale = new Vector3(-originalScale.x, originalScale.y, originalScale.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (!this.isActiveAndEnabled) return;

        this.transform.position = originalPos + new Vector3(moveW * math.sin(cycle * 5), moveH * math.cos(cycle), 0);

        cycle += math.PI * 2 * Time.deltaTime / 5;
        //cycle += 0.01f;
        if (this.transform.position.x > originalPos.x + moveW * math.sin(cycle * 5))
        {
            this.transform.localScale = originalScale;
        }
        else
        {
            this.transform.localScale = flippedScale;
        }
    }
}
