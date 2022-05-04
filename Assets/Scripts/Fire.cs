using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject Bullet;
    public Transform FirePos;
    public AudioSource audioSource;
    public AudioClip shotsound;
    public float damage = 2;

    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
    if (Input.GetMouseButtonDown(0))
        {
            Instantiate(Bullet, FirePos.transform.position, FirePos.transform.rotation);
                 audioSource.PlayOneShot(shotsound);
        }
        
    }


}
