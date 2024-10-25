using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    private bool isPushed = false;

    public GameObject cannonball;
    public GameObject spawnPoint;

    public Material defaultMaterial;
    public Material usedMaterial;
    public MeshRenderer myMr;

    private void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (!isPushed)
        {
            isPushed = true; 
            Debug.Log("Button was pushed");
            Shoot(); 
            StartCoroutine(ButtonReset()); 
        }     


    }

    IEnumerator ButtonReset()
    {
        yield return new WaitForSeconds(5);
        isPushed = false; 
    }

    public void Shoot()
    {
       
    }

}
