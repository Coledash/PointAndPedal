using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrogodiiliScripti : MonoBehaviour
{
    bool dying = false;
    public float moveForce;
    public Rigidbody2D rb;
    public AudioClip[] spawnSounds;
    public AudioClip[] dieSounds;
    public GameObject myParticle;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        AudioManagerScript.instance.PlayRandomSoundClip(spawnSounds, transform, 0.25f);
        int rand = UnityEngine.Random.Range(-25, 25);
        transform.eulerAngles = new Vector3(0, 0, rand);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if(!dying)
        {
            AudioManagerScript.instance.currentTime -= Time.fixedDeltaTime * 2;

        }
    }

    private void OnMouseDown()
    {
        if (!dying) {
            dying = true;
            Instantiate(myParticle, transform);
            transform.DetachChildren();
            AudioManagerScript.instance.PlayRandomSoundClip(dieSounds, transform, 0.2f);
            float x = UnityEngine.Random.Range(-moveForce * 5, moveForce * 5);
            float y = UnityEngine.Random.Range(-moveForce, -moveForce * 20);
            float z = UnityEngine.Random.Range(-45, 45);

            //transform.Rotate(new Vector3(0, 0, z));

            rb.AddForce(new Vector2(x, y));
        }

        if(dying && transform.position.y < -10)
        {
            Destroy(gameObject);

        }
    }
}
