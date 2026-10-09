using UnityEngine;

public class BallMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject pivotLeft, pivotRight, player, ceiling, respawn;
    public float ballVerticalSpeed, ballHorizontalSpeed, sign, timer;
    

    void Start()
    {
        ballVerticalSpeed = -10f;
        ballHorizontalSpeed = 0f;
        timer = 0.3f;

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.right * ballHorizontalSpeed * Time.deltaTime + Vector3.up * ballVerticalSpeed * Time.deltaTime);
        timer -= Time.deltaTime;
        if (Mathf.Abs(this.transform.position.y - player.transform.position.y) < 1f && Mathf.Abs(this.transform.position.x - player.transform.position.x) < 1.8f && timer <= 0f)
        {
            timer = 0.3f;
            this.GetComponent<AudioSource>().Play();
            ballVerticalSpeed *= -1f;
            ballHorizontalSpeed += Input.GetAxis("Horizontal") * 10f;
            if (Mathf.Abs(ballHorizontalSpeed) > 10f)
            {
                sign = Mathf.Sign(ballHorizontalSpeed);
                ballHorizontalSpeed = 10f * sign;

            }
        }
        if (Mathf.Abs(this.transform.position.y - ceiling.transform.position.y) < 1f && this.transform.position.y < ceiling.transform.position.y)
        {
            this.GetComponent<AudioSource>().Play();
            ballVerticalSpeed *= -1f;
        }
        if (Mathf.Abs(this.transform.position.x - pivotLeft.transform.position.x) < 1f || Mathf.Abs(this.transform.position.x - pivotRight.transform.position.x) < 1f)
        {
            this.GetComponent<AudioSource>().Play();
            ballHorizontalSpeed *= -1f;

        }


        if (Mathf.Abs(this.transform.position.y - respawn.transform.position.y) < 1f)
        {
            this.GetComponent<AudioSource>().Play();
            this.transform.position = Vector3.zero;
            ballVerticalSpeed = -10f;
            ballHorizontalSpeed = 0f;

        }

    }
}
