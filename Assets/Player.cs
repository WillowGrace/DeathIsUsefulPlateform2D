using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int lit;
    private Rigidbody2D rb;
    private Transform playerPoint;
    public Transform spawnPoint;
    //time start/stop

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerPoint = GameObject.Find("Player").transform;
        //start time
    }

    // Update is called once per frame
    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(x * 7f,rb.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector3(rb.velocity.x, 14, 0);
        }

    }
    void OnTriggerEnter2D(Collider2D collid)
    {
        
        if (collid.gameObject.CompareTag("Light"))
        {
            Debug.Log("Fire");
            //chance sprit to lit
            lit = lit + 1;
            //change tag
            collid.gameObject.tag = "Done";

        }
        if (collid.gameObject.CompareTag("willDie"))
        { 
            Debug.Log("Dead");
            //change players position back to bed;
            switch (lit)
            {
                case 0:
                    //Bed Spawn
                    spawnPoint = GameObject.Find("Bed/Spawn").transform;
                    Debug.Log("0 tourches");
                    break;
                case 1:
                    // Bed2 Spawn
                    spawnPoint = GameObject.Find("Bed2/Spawn").transform;
                    Debug.Log("1 tourch");
                    break;
                case 2:
                    //Bed3 Spawn
                    spawnPoint = GameObject.Find("Bed3/Spawn").transform;
                    Debug.Log("2 tourches");
                    break;
                case 3:
                    //Bed4 Spawn
                    spawnPoint = GameObject.Find("Bed4/Spawn").transform;
                    Debug.Log("3 tourches");
                    break;
                case 4:
                    //add to score to file
                    //change to Score screen
                    //end time

                    //testing end game
                    //float score = Clock.Keepscore.score;
                   // Debug.Log(score);
                    Debug.Log("End Game");
                    break;
            }
            //respawn
            playerPoint.position = spawnPoint.position;


        }



    }

}
