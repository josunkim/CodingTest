using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpbarEnermy : MonoBehaviour
{ 
    [SerializeField] GameObject m_goPrefab = null;

    List<Transform> m_objectList = new List<Transform>();
    List<GameObject> m_hpBarList = new List<GameObject>();

    Camera m_cam = null;
    // Start is called before the first frame update
    void Start()
    {
        m_cam = Camera.main;

        GameObject[] t_object = GameObject.FindGameObjectsWithTag("Enermy");
        for (int i = 0; i < t_object.Length; i++)
        {
            m_objectList.Add(t_object[i].transform);
            GameObject t_hpbar = Instantiate(m_goPrefab, t_object[i].transform.position, Quaternion.identity, transform);
            m_hpBarList.Add(t_hpbar);


        }
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < m_objectList.Count; i++)
        {
            m_hpBarList[i].transform.position = m_cam.WorldToScreenPoint(m_objectList[i].transform.position + 
               new Vector3(0, 1f , 0 ));
        }
    }
}
