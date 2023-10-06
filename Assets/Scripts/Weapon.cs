using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    //todo 

    /*
     *weapon ammo 
     * projectile spawn
     * sound effect for trigger
     * aiming anim
     * wobble(procedurally generate?)
     * 
    */


    public int  weaponCapacity;
    public int ammoLeft;

    public GameObject bullet;
    public int bulletSpeed;
    public Transform bulletSpawnPos;
    public float bulletLifetime = 3f;

    public Transform aimingPosition, nonAimingPosition;

    // Start is called before the first frame update
    void Start()
    {
        ammoLeft = weaponCapacity;    
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            this.transform.position = nonAimingPosition.position;
         
        }
        if(Input.GetKeyDown(KeyCode.Mouse1))
        {
            this.transform.position = aimingPosition.position;
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && ammoLeft>0)
        {

           
            FireWeapon();
            //ammoLeft--;
        }
    }

    public void FireWeapon()
    {
        GameObject bulletIns = Instantiate(bullet, bulletSpawnPos.position, Quaternion.identity);

        bulletIns.GetComponent<Rigidbody>().AddForce(bulletSpeed * bulletSpawnPos.forward.normalized, ForceMode.Impulse);

        Destroy(bulletIns, bulletLifetime);
    }



    


}
