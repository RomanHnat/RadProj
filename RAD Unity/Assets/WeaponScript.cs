using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{

    public float damage = 25;
    public float fireRate = 1;
    public GameObject muzzleFlash;
    public AudioClip shot;
    public AudioSource audioSourcee;
    public Camera kam;
    public float range = 15;
    public Transform bulletspawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        audioSourcee.PlayOneShot(shot);
        Instantiate(muzzleFlash, bulletspawn.position, bulletspawn.rotation );
        


        RaycastHit hit;

        if(Physics.Raycast(kam.transform.position, kam.transform.forward, out hit, range))
        {
            Debug.Log("GOT IT");
        }

    }

}

