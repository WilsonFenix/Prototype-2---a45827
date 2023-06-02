using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool onClick = true;


    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && onClick)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            onClick = false;

            if (!onClick)
            {
                StartCoroutine(WaiteForSecond());
            }
        }
    }
    IEnumerator WaiteForSecond()
    {
        yield return new WaitForSeconds(1.5f);
        onClick = true;
    }
}
