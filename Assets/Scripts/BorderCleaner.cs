using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderCleaner : MonoBehaviour 
{
    private void OnTriggerExit2D(Collider2D col)
    {
        Debug.Log("Ushel " + col.tag);

        if (!col.CompareTag("Missile"))
            Destroy(col.gameObject);
    }
}
