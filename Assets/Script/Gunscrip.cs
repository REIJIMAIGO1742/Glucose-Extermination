using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Gunscrip : MonoBehaviour
{
    public GameObject Bulletfap;
    public Transform Bulletspawn;
    public Animator anim;

    public float bulletvelocity = 30;
    public float bulletlifhttime = 0.5f;
    public AudioSource Firegun;
    public PlayerMovementTutorial gunfire;
    public int HP;

    public float fireRate = 1f;
    private float nextFireTime = 0f;

    public void Start()
    {
        Firegun.GetComponent<AudioSource>();
        anim = GetComponent<Animator>();

    }
    public void Takehp(int take)
    {
        HP = take;
        
    
    }


    // Update is called once per frame
    void Update()
    {
        print(HP);
        

        if (Input.GetKey(KeyCode.Mouse0) && HP >= 1 && Time.time >= nextFireTime)
        {
            print(HP);
            nextFireTime = Time.time + fireRate;
            Fireweapon();
             
        }

        
    }

    public void Fireweapon()
    {
        
        GameObject bullet = Instantiate(Bulletfap, Bulletspawn.position, Quaternion.identity);
        bullet.GetComponent<Rigidbody>().AddForce(Bulletspawn.forward.normalized * bulletvelocity, ForceMode.Impulse);
        StartCoroutine(DestroyBulletAftertime(bullet, bulletlifhttime));
    }

    private IEnumerator DestroyBulletAftertime(GameObject bullet, float Delay)
    {
        Delay = 0.3f;
        yield return new WaitForSeconds(Delay);
        Firegun.Play(1);
        Destroy(bullet);
    }

    
}
