using UnityEngine;

public class BrickBehaviour : MonoBehaviour
{
    public int hp;
    public GameObject ball,brickGenerator;
    public Color damaged;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(this.transform.position, ball.transform.position) < 2f)
        {
            ball.GetComponent<BallMovement>().ballVerticalSpeed *= -1f;
            ball.GetComponent<BallMovement>().ballHorizontalSpeed *= -1f;
            hp -= 1;
            this.GetComponent<SpriteRenderer>().color = Color.softYellow;
            ball.GetComponent<AudioSource>().Play();
            if (hp <= 0)
                { 
                Destroy(this.gameObject);
                brickGenerator.GetComponent<BrickGeneration>().brickNumber--;
            
            }
            

        }
        
    }
}
