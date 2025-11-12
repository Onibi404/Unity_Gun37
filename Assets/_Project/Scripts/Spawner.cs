using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    void Start()
    {
        Instantiate(bullet,gameObject.transform.position,gameObject.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(bullet,gameObject.transform.position,gameObject.transform.rotation);
    }
}
