using UnityEngine;
public class Bubble : MonoBehaviour
{
    [SerializeField]
    private float _moveSpeed = 1f;

    void Start()
    {
        Reset();
    }


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * _moveSpeed);
        if (transform.position.y > 10)
        {
            Reset();
        }
    }

    void Reset()
    {
        float randomHeight = Random.Range(-8f, -18f);
        transform.position = new Vector3(transform.position.x, randomHeight, transform.position.z);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (OtherIsTheFish(other))
        {
            ScoreKeeper scoreKeeper = GameObject.FindObjectOfType<ScoreKeeper>();
            scoreKeeper.IncrementScore();
            Reset();
        }
    }

    bool OtherIsTheFish(Collider2D other)
    {
        return (other.GetComponent<Fish>() != null);
    }
}
