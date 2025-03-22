using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorController : MonoBehaviour
{
    public GameObject tile1, tile2;

    public GameObject[] tiles;
    
    void FixedUpdate()
    {
        if (GameManager.instance.inGame == false) return;

        tile1.transform.position -=
            new Vector3(GameManager.instance.worldScrollingSpeed, 0, 0);

        tile2.transform.position -=
           new Vector3(GameManager.instance.worldScrollingSpeed, 0, 0);

        if(tile2.transform.position.x < 0)
        {
            //  tile1.transform.position += new Vector3(32, 0, 0);

            int number = Random.Range(0, tiles.Length);

            var newTile = Instantiate(
                tiles[number],
               tile2.transform.position + new Vector3(16,0,0),
                Quaternion.identity);

            



            Destroy(tile1);

          //  var tmp = tile1;
            tile1 = tile2;
            tile2 = newTile;
        }
    }
}
