using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateS3 : MonoBehaviour
{
    int random;
    public GameObject[] Cars;

    void Start()
    {
        InvokeRepeating("CreateS3", 0, 1.5f);
    }

    void CreateS3()
    {
        if (GameObject.Find("Manager").GetComponent<Manager>().UnoThree)

        {
            random = Random.Range(0, 19);
            Instantiate(Cars[random], transform.position, Quaternion.identity);
        }
    }
}
