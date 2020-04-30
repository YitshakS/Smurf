using UnityEngine;

public class goCam : MonoBehaviour
{
    [Tooltip("speed")] [SerializeField] float speed;

    // Start is called before the first frame update
    void Start()
    {
        /*
            Debug.Log("Start");
            Transform t = GetComponent<Transform>();
            t.position = new Vector3(0, 0, 0);
        
        transform.position = new Vector3(0, 0, 0);
        */
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 5 || transform.position.x < -5)
            speed *= -1;

        transform.position = new Vector3(transform.position.x + speed * Time.deltaTime,
        transform.position.y,
        transform.position.z);
    }
}
