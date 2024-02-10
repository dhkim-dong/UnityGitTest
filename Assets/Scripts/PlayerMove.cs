using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(NavMeshAgent))]
public class PlayerMove : MonoBehaviour
{
    public float rotationSpeed = 15f;
    public float moveSpeed = 5f;

    private NavMeshAgent navMeshAgent;
    private Rigidbody rb;

    void Start()
    {
        // Get the NavMeshAgent and Rigidbody components attached to the player GameObject
        navMeshAgent = GetComponent<NavMeshAgent>();
        rb = GetComponent<Rigidbody>();

        // Disable the Rigidbody's gravity so it doesn't interfere with NavMeshAgent's movement
        rb.useGravity = false;
    }

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        // Handle NavMeshAgent movement
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                navMeshAgent.SetDestination(hit.point);
            }
        }
    }
}
