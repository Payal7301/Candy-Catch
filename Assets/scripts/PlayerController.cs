using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public bool canMove=true;
    [SerializeField] private float speed;
    [SerializeField] private float maxPosn;
    public static PlayerController instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            Move();
        }
    }

    void Move()
    {
        float inputX = Input.GetAxis("Horizontal");
        Vector3 pos = new Vector3(1, 0, 0);
        transform.position += pos * inputX * speed * Time.deltaTime;

        float roundedPosition = Mathf.Clamp(transform.position.x, -maxPosn, maxPosn);
        transform.position = new Vector3(roundedPosition, transform.position.y, transform.position.z);
    }
}
