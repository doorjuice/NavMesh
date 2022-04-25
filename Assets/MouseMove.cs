
using UnityEngine;
using UnityEngine.AI;

public class MouseMove : MonoBehaviour
{
    public NavMeshAgent agent;
    public LayerMask layer;

    public GameObject pikuniku;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject.layer == LayerMask.NameToLayer("Movable"))
            {
                pikuniku.GetComponent<MeshRenderer>().material.color = Color.magenta;
                pikuniku = hit.collider.gameObject;
                pikuniku.GetComponent<MeshRenderer>().material.color = Color.cyan;
            }

            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject.layer == LayerMask.NameToLayer("Walkable"))
            {
                //pikuniku.transform.position = hit.point;
                pikuniku.GetComponent<NavMeshAgent>().SetDestination(hit.point);
            }
        }
    }
}
