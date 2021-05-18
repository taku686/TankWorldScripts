using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageCreater : MonoBehaviour
{
    [SerializeField] GameObject m_obj_GroundObject;
    [SerializeField] Transform m_tra_GroundParent;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 21; i++)
        {
            for (int j = 0; j < 21; j++)
            {
                Instantiate(m_obj_GroundObject, new Vector3((i * 50) - 500, -0.5f, (j * 50) - 500), m_obj_GroundObject.transform.rotation, m_tra_GroundParent);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
