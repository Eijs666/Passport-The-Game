using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameManager GM;
    public bool isPass;

    public float rotateSpeed = 50f;

    private void Start()
    {
        if(gameObject.CompareTag("Passport"))
        {
            isPass = true;
        }
        else
        {
            isPass = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(transform.position, transform.up, rotateSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        GM.hasKey = true;
        if(isPass && other.CompareTag("Player"))
        {
            GM.GameOver();
        }
        Destroy(gameObject);
    }
}
