using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 1;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);

        if (transform.position.x < -15)
            transform.position += new Vector3(30, 0, 0); //Vector3.right * 30;
    }
}
