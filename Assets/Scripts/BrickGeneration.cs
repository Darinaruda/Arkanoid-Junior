using UnityEngine;

public class BrickGeneration : MonoBehaviour
{
    public GameObject brick,finishScreen;
    private int chance;
    public int brickNumber;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = -9; i < 9; i++)
            for (int j = 4; j > 2; j--)
            {
                chance = Random.Range(1, 11);
                if(chance <= 3)
                    {
                    Instantiate(brick, Vector3.right * i + Vector3.up * j, this.transform.rotation);
                    i++;
                    brickNumber++;
                    }
                
            }
    }

    // Update is called once per frame
    void Update()
    {
        if (brickNumber == 0)
        {
            Time.timeScale = 0;
            Cursor.visible = true;
            finishScreen.SetActive(true);
        
        }

    }
}
