using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().color = UnityEngine.Random.ColorHSV();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
