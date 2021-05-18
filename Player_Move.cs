using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player_Move : MonoBehaviour
{
    [SerializeField] GameObject m_obj_Body;
    [SerializeField] GameObject m_obj_Head;
    [SerializeField]  float m_float_MoveSpeed;
    private Rigidbody m_Rigidbody;
  

    private void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    public void Update()
    {
        Move();
        Turn();
    }

    private void Move()
    {
        Vector3 dir;
       
        dir = new Vector3(UltimateJoystick.GetHorizontalAxis("PlayerMove"), 0, UltimateJoystick.GetVerticalAxis("PlayerMove")).normalized;
        m_Rigidbody.velocity = new Vector3(dir.x * m_float_MoveSpeed * Time.deltaTime, 0, dir.z * m_float_MoveSpeed * Time.deltaTime);
        float turnY = Mathf.Acos(UltimateJoystick.GetVerticalAxis("PlayerMove")) / Mathf.PI * 180;
        float vertical = UltimateJoystick.GetHorizontalAxis("PlayerMove");
        if (vertical < 0)
        {
            m_obj_Body.transform.rotation = Quaternion.Euler(0, -turnY, 0);
        }
        else if (vertical > 0)
        {
            m_obj_Body.transform.rotation = Quaternion.Euler(0, turnY, 0);
        }
    }

    private void Turn()
    {
        float turnY = Mathf.Acos(UltimateJoystick.GetVerticalAxis("PlayerTurn")) / Mathf.PI * 180;
        float vertical = UltimateJoystick.GetHorizontalAxis("PlayerTurn");
        if (vertical > 0)
        {
            m_obj_Head.transform.rotation = Quaternion.Euler(0, turnY, 0);
        }
        else if (vertical < 0)
        {
            m_obj_Head.transform.rotation = Quaternion.Euler(0, -turnY, 0);
        }
    }
}
