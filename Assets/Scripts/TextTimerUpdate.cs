using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextTimerUpdate : MonoBehaviour
{
    public GameObject textObject;
    public float displayDuration = 3f;
    private float timer = 0f;

    void Update()
    {
        if (textObject.activeSelf)
        {
            timer += Time.deltaTime;
            if (timer >= displayDuration)
            {
                textObject.SetActive(false);
                timer = 0f;
            }
        }
    }
}