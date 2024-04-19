using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.Rendering.DebugUI;

public class TargetLogic : MonoBehaviour
{

    public Slider slider;
    public Text meters;
    public GameObject[] prefabToCarry; // The prefab to clear

    void Start()
    {
        // Subscribe to the OnValueChanged event of the slider
        slider.onValueChanged.AddListener(OnSliderValueChanged);
    }

    public void OnSliderValueChanged(float distance)
    {
        meters.text = (distance * 100).ToString() + "M";
        foreach (GameObject prefab in prefabToCarry)
        {
            GameObject[] instances = GameObject.FindGameObjectsWithTag(prefab.tag);

            foreach (GameObject instance in instances)
            {
                if (instance.tag == prefab.tag)
                {
                    Vector3 newPosition1 = instance.transform.position;

                    if (newPosition1.y > 0.3)
                    {
                        // Set the x position of the target object to the specified distance value
                        newPosition1.x = distance * 50 - 0.5f;

                        // Update the position of the target object
                        instance.transform.position = newPosition1;
                    }

                }
            }

            // Get the current position of the target object
            Vector3 newPosition = transform.position;

            // Set the x position of the target object to the specified distance value
            newPosition.x = distance * 50;

            // Update the position of the target object
            transform.position = newPosition;

            // Check if there's another mesh within the specified distance
        }


    }
}
