using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraController : MonoBehaviour
{
    [SerializeField] Vector3 m_vec3_Offset;
    private GameObject m_obj_Player;
    // Start is called before the first frame update
    void Start()
    {
        m_obj_Player = GameObject.Find($"Player{GManager.Instance.Int_PlayerLocalNumber}");
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = m_obj_Player.transform.position + m_vec3_Offset;
    }
}
