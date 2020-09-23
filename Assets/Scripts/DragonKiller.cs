using UnityEngine;
using UnityEngine.SceneManagement;

public class DragonKiller : MonoBehaviour
{
    public GameObject RedDragon;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 6)
            SceneManager.LoadScene(0);

        if (transform.position.y < - 7.5)
            SceneManager.LoadScene(0);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        SceneManager.LoadScene(0);
    }
}
