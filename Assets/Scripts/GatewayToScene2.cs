using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatewayToScene2 : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            Debug.Log("Trigger Succes");
            gameObject.GetComponent<SceneLoader>().LoadScn2();
        }
    }
}
