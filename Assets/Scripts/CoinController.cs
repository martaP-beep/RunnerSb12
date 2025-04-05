using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{

    Transform player;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

   
    void FixedUpdate()
    {
        if (GameManager.instance.magnet.isActive == false) return;

        if(Vector3.Distance(transform.position, player.position) 
            <= GameManager.instance.magnet.GetRange())
        {
            var direction = (player.position - transform.position).normalized;


            transform.position += 
                direction * GameManager.instance.magnet.GetSpeed();
        }
    }
}
