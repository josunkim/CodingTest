using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    public GameObject enermyCanvasGo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
      /*  if(collision.transform.CompareTag("Bullet"))
        {
            enermyCanvasGo.GetComponent<EmermyHP>().curHP -= 2f;*/
        }
    }



