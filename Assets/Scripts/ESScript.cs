using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ESScript : MonoBehaviour
{
    public float scorePoints;
    public int dieChance;
    bool collected = false;
    public Rigidbody2D rb;
    public float moveForce;

    public AudioClip[] dieSounds;

    public GameObject myParticle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (UnityEngine.Random.Range(0, 10000) < dieChance)
        {
            Destroy(gameObject);
        }
    }

    private void OnMouseDown()
    {
        if(!collected)
        {
            Instantiate(myParticle, transform);
            transform.DetachChildren();
            //Transform.child
            AudioManagerScript.instance.PlayRandomSoundClip(dieSounds, transform, 1f);
            TimerScript.instance.currentTime += scorePoints;
            collected = true;
            float x = UnityEngine.Random.Range(-moveForce * 5, moveForce * 5);
            float y = UnityEngine.Random.Range(moveForce, moveForce * 20);
            float z = UnityEngine.Random.Range(-360, 360);
            
            transform.Rotate(new Vector3(0, 0, z));

            rb.AddForce(new Vector2(x, y));

            
        }
        //Destroy(gameObject);
    }
}
