using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnermyMove : MonoBehaviour
{
    NavMeshAgent nav;
   [SerializeField]
    Transform target;
    // Start is called before the first frame update
    private void Awake()
    {
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            nav.SetDestination (target.position);
        }
        }
    }

