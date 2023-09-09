using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableExamples : MonoBehaviour
{

    private BoxCollider2D BoxCollider2D;
    private Rigidbody2D Rigidbody2D;
    private Animator animator;

    private void Start()
    {

        Rigidbody2D = GetComponent<Rigidbody2D>();
        
        transform.position = new Vector3(20, 20, 20);

    }
}
