using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarningController : MonoBehaviour
{
    public GameObject obstacle;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(obstacle, new Vector2(transform.position.x, 4.5f),Quaternion.identity);
        Destroy(gameObject, 1f);
    }

}
