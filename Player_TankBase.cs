using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Player_Move))]
[RequireComponent(typeof(Shot))]

public class Player_TankBase : StateMachineBase<Player_TankBase>
{
    [SerializeField] Material[] m_material_PlayerColor;
    [SerializeField] Renderer m_rend_Body;
    [SerializeField] Renderer m_rend_LeftTrack;
    [SerializeField] Renderer m_rend_RightTrack;
    [SerializeField] Renderer m_rend_Turret;
    private Button m_btn_ShotButton;
    private Button m_btn_BombButton;
    private Shot m_sc_Shot;    
    private Player_Move m_sc_PlayerMove;

    private void Awake()
    {
        gameObject.name = $"Player{GManager.Instance.Int_PlayerLocalNumber}";
    }
    // Start is called before the first frame update
    void Start()
    {
        //  Debug.Log("PlayerNum" + GManager.Instance.m_int_PlayerNumber);
        SetMaterial();
        m_sc_PlayerMove = GetComponent<Player_Move>();
        m_sc_Shot = GetComponent<Shot>();
        m_btn_ShotButton = GameObject.Find("ShotButton").GetComponent<Button>();
        m_btn_BombButton = GameObject.Find("BombButton").GetComponent<Button>();
        SetState(new Player_TankBase.Idle(this));
    }

    private void SetMaterial()
    {
        for (int i = 0; i < m_rend_Body.materials.Length; i++)
        {
            m_rend_Body.materials[i].color = m_material_PlayerColor[GManager.Instance.Int_PlayerLocalNumber - 1].color;
        }
        for (int i = 0; i < m_rend_LeftTrack.materials.Length; i++)
        {
            m_rend_LeftTrack.materials[i].color = m_material_PlayerColor[GManager.Instance.Int_PlayerLocalNumber - 1].color;
        }
        for (int i = 0; i < m_rend_RightTrack.materials.Length; i++)
        {
            m_rend_RightTrack.materials[i].color = m_material_PlayerColor[GManager.Instance.Int_PlayerLocalNumber - 1].color;
        }
        for (int i = 0; i < m_rend_Turret.materials.Length; i++)
        {
            m_rend_Turret.materials[i].color = m_material_PlayerColor[GManager.Instance.Int_PlayerLocalNumber - 1].color;
        }
    }

    private class Idle : StateBase<Player_TankBase>
    {
        public Idle(Player_TankBase _machine) : base(_machine)
        {
        }

        public override void OnEnterState()
        {
 
        }

        public override void OnUpdateState()
        {
            machine.m_sc_PlayerMove.Update();

        }
    }
}
