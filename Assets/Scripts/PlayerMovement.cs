using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Pentru a detecta marginea ecranului, folosesc doi pivoti, pivotLeft si pivotRight si calculez distanta dintre ei si player
    public GameObject pivotLeft, pivotRight;
    // playerSpeed = viteza jucatorului
    public float playerSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerSpeed = 15f;
    }

    // Update is called once per frame
    void Update()
    {
        
        
        this.transform.Translate(Vector3.right * playerSpeed * Input.GetAxis("Horizontal") * Time.deltaTime); // miscarea efectiva a jucatorului
        // daca distanta dintre oricare pivot cu jucatorul este mai mica decat o distanta arbitrara jucatorul nu se mai poate misca
        if (Vector3.Distance(this.transform.position, pivotLeft.transform.position) < 1.5f || Vector3.Distance(this.transform.position, pivotRight.transform.position) < 1.5f)
        {
            playerSpeed = 0f;
            // daca jucatorul este la pivotul stang si are intentia de a se misca la dreapta se reia miscarea
            if (Vector3.Distance(this.transform.position, pivotLeft.transform.position) < 1.5f && Input.GetAxis("Horizontal") > 0f)
                playerSpeed = 15f;
            // la fel ca mai sus, dar pentru pivotul drept
            if (Vector3.Distance(this.transform.position, pivotRight.transform.position) < 1.5f && Input.GetAxis("Horizontal") < 0f)
                playerSpeed = 15f;
        }

    }

   
}
