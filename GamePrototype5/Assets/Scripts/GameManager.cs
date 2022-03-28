using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int score; 

    public List<GameObject> targets;
    private float spawnRate = 1.0f;

    public void SetScore(int score)
    {
        this.score = score;   
    }
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnTarget());
        score = 0;
        UpdateScore(0);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    


    IEnumerator SpawnTarget()
    {
        while(true)
        { 
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count); 
            Instantiate(targets[index]);
            
        }
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

}
