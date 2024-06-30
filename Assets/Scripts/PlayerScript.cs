using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody2D frontWheelRB;
    public Rigidbody2D backWheelRB;
    public float PedalPower;
    float moveInput;
    public AudioClip[] dieSounds;
    public GameObject myParticle;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        moveInput = Input.GetAxisRaw("Horizontal");
        
    }

    private void FixedUpdate()
    {
        backWheelRB.AddTorque(moveInput * PedalPower * Time.fixedDeltaTime);
        frontWheelRB.AddTorque(moveInput * PedalPower * Time.fixedDeltaTime);

        if(transform.position.y < -5f)
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            //AudioManagerScript.instance.PlaySoundClip(dieSound, transform, 1f);
            AudioManagerScript.instance.PlayRandomSoundClip(dieSounds, transform, 1f);
            Instantiate(myParticle);
            AudioManagerScript.instance.playerDead = true;
            Destroy(gameObject);
        }

    }

}
