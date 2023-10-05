using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeLight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator delay() {
        bool checkQ = false;
        bool on = true;
        int i = 0;
        while (checkQ == false && i < 45) {
            Debug.Log("Hello: " + i);
        StartCoroutine(delay());
            if (on == true) {
                GetComponent<Renderer>().material.color = new Color(55f/255f,79f/255,107f/255);
                on = false;
            } else {
                GetComponent<Renderer>().material.color = new Color(255f/255,11f/255,11f/255);
                on = true;
            }
            //yield return new WaitForSeconds(1);
            if (Input.GetKeyDown(KeyCode.Q)) {
                checkQ = true;
            }
            i++;
        }
        yield return new WaitForSeconds(1);
    }
}
