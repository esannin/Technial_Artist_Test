using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RandomColor : MonoBehaviour
{
    public GameObject Player_Image;
    // Start is called before the first frame update
    void Start()
    {
        
        Player_Image.GetComponent<Image>().color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
