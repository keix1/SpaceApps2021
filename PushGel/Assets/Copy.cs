using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Copy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i<1000; i++)
        {
            GameObject original = GameObject.Find("Polymer");
            GameObject copied = Object.Instantiate(original) as GameObject;
            //copied.transform.Translate(Random.Range(-5.0f, 5.0f), 0, Random.Range(-5.0f, 5.0f));

            //Vector3 pos = original.transform.position;
            //copied.transform.Translate(23.714f + Random.Range(-0.1f, 0.1f), 5.157282f + Random.Range(-0.1f, 0.3f), -1.892553f + Random.Range(-0.3f, 0.3f));
        }

        for (int i = 0; i < 1000; i++)
        {
            GameObject original = GameObject.Find("Air");
            GameObject copied = Object.Instantiate(original) as GameObject;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
