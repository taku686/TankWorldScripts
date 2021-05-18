using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GManager : SingletonMonoBehaviour<GManager>
{
    [SerializeField] int int_PlayerLocalNumber;

    public int Int_PlayerLocalNumber
    {
        get { return int_PlayerLocalNumber; }
        set
        {
            if (value > 0)
            {
                int_PlayerLocalNumber = value;
            }
        }
    }

    protected override void Awake()
    {
        base.Awake();
        Application.targetFrameRate = 60;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
