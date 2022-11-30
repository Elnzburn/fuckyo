using UnityEngine;
using UnityEngine.AI;

public class AIChicken : MonoBehaviour
{
    public GameObject chickenEnemy;
    public void activateEnemy()
    {
        chickenEnemy.GetComponent<Collider>().enabled = true;
    }
    public void nonactivateEnemy()
    {
        chickenEnemy.GetComponent<Collider>().enabled = false;
    }
    
    NavMeshAgent _chicken;
    public Transform PlayerTransform;
    void Start()
    {
        _chicken = GetComponent<NavMeshAgent>();
    }
    
    void Update()
    {
        _chicken.SetDestination(PlayerTransform.position);
    }
}