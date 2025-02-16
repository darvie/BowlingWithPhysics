using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private float score = 0;  
    [SerializeField] private TextMeshProUGUI scoreText;
    private FallTrigger[] pins;  
    
    void Start()
    {
        pins = FindObjectsByType<FallTrigger>((FindObjectsSortMode)FindObjectsInactive.Include);

        foreach (FallTrigger pin in pins){
            pin.OnPinFall.AddListener(IncrementScore);
        }

    }

    // Update is called once per frame
    private void IncrementScore()
    {
        score++;
        scoreText.text = $"Score: {score}";
    }
}
