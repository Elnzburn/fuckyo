using UnityEngine;
using UnityEngine.AI;

public class AIChicken : MonoBehaviour
{
    NavMeshAgent _chicken;
    public Transform PlayerTransform;
    void Start()
    {
        _chicken = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        _chicken.SetDestination(PlayerTransform.position);
    }
}