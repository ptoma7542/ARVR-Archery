using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;


public class ClearArrows : MonoBehaviour
{
    public GameObject[] prefabToClear; // The prefab to clear

    public void ClearPrefabInstances()
    {
        foreach (GameObject prefab in prefabToClear)
        {
            GameObject[] instances = GameObject.FindGameObjectsWithTag(prefab.tag);

            foreach (GameObject instance in instances)
            {
                if (instance.tag == prefab.tag)
                {
                    Destroy(instance);
                }
            }
        }
    }
}
