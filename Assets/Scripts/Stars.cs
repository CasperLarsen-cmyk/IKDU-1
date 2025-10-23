using UnityEngine;

public class Stars : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;

    private bool sActive1 = false;
    private bool sActive2 = false;
    private bool sActive3 = false;

    void Start()
    {
        UpdateStars();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (sActive1 && sActive2 && sActive3)
        {
            star1.transform.Rotate(0, 0, -1.25f, Space.Self);
            star2.transform.Rotate(0, 0, -1.25f, Space.Self);
            star3.transform.Rotate(0, 0, -1.25f, Space.Self);
        }
    }

    public void UpdateStar1(bool active)
    {
        sActive1 = active;
        UpdateStars();
    }

    public void UpdateStar2(bool active)
    {
        sActive2 = active;
        UpdateStars();
    }

    public void UpdateStar3(bool active)
    {
        sActive3 = active;
        UpdateStars();
    }

    private void UpdateStars()
    {
        star1.SetActive(sActive1);
        star2.SetActive(sActive2);
        star3.SetActive(sActive3);

        //if (sActive1 && sActive2 && sActive3) Application.OpenURL("https://www.youtube.com/");
    }
}
