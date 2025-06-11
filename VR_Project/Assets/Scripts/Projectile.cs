using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    [Header("Shooting Parameter")]
    [Tooltip("V0(m/s)")]
    public float initialSpeed = 20f;

    [Tooltip("Initial Direction, Only for Initial Speed. When in 'World' Space, Please make sure it is Unit Vector.")]
    public Vector3 launchDirection = Vector3.forward;

    [Tooltip("Auto Shoot？true:false")]
    public bool autoLaunch = true;

    private Rigidbody _rb;
    private bool _launched = false;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        if (_rb == null)
        {
            Debug.LogError("Projectile: Less of Rigidbody Components");
        }
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
