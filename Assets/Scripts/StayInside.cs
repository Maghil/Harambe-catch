using UnityEngine;

public class StayInside : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -1.6f, 1.6f), Mathf.Clamp(transform.position.y, -2.5f, -2.5f));
    }
}
