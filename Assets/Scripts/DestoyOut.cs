using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoyOut : MonoBehaviour {

    void OnTriggerExit2D(Collider2D col)
    {
        Debug.Log("Uzhel "+col.tag);

        if (!col.CompareTag("Missile"))
            Destroy(col.gameObject);
    }
}
