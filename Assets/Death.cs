using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
   private float lit;//get from player

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider collid)
    {
         Debug.Log("Dead");

        if (collid.name == "Player")
        {
            //change players position back to bed;
            switch(lit)
            {
                case 0: Debug.Log("0 tourches");
                    break;
                case 1: Debug.Log("1 tourch");
                    break;
                case 2: Debug.Log("2 tourches");
                    break;
                case 3: Debug.Log("3 tourches");
                    break;
                case 4: Debug.Log("End Game");
                    break;
            }    

        }
           
       

    }
}
