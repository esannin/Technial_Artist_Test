using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopulateGrid : MonoBehaviour
{
    public GameObject prefab; // Prefab objec to populate grid

    public int numberToCreate; //number of objects to create
    
    void Populate()
    {
        GameObject newObj; //Create instance of GameObject

        for (int i = 0; i < numberToCreate; i++)
        {
            newObj = (GameObject)Instantiate(prefab, transform);
            
        }
    }

    void Start()
    {
        Populate();
    }


    void Update()
    {

    }
}