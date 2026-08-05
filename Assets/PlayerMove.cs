using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;

public class PlayerMove : MonoBehaviour
{
    public int mvspd;
    public int score;
    public TextMeshProUGUI scoreval;
    public int Health;
    public TextMeshProUGUI healthval;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = 0;
        Health = 10;

    }

    // Update is called once per frame
    void Update()
    {
        float HInpt = Input.GetAxisRaw("Horizontal");
        float VInpt = Input.GetAxisRaw("Vertical");
        scoreval.text = score.ToString();
        healthval.text = Health.ToString();
        Vector3 direction = new Vector3(-HInpt, 0f, -VInpt).normalized;
        transform.Translate(direction * mvspd * Time.deltaTime, Space.World);
    }
}
