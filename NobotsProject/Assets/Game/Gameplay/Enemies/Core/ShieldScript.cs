using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        //Destruccion
		if (collision.transform.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
