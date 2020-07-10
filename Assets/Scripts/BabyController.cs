using UnityEngine;

public class BabyController : MonoBehaviour
{
    public GameObject poof;
    private void OnCollisionEnter2D(Collision2D collision) //detecting collision between harambe and baby
    {
        FindObjectOfType<GameManager>().ScoreManager();
        Instantiate(poof, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5f) //destroy babies if they drop out of screen
        {
            Destroy(gameObject);
        }
        //Vector3 move = transform.forward;
        //controller.Move(move * speed * Time.deltaTime);
    }
}
