using UnityEngine;

public class FoodPanel : MonoBehaviour
{
    public GameObject videoPanel;
    public GameObject mathPanel;
    public GameObject kebabPanel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangePanel(GameObject panel)
    {
        videoPanel.SetActive(panel == videoPanel);
        mathPanel.SetActive(panel == mathPanel);
        kebabPanel.SetActive(panel == kebabPanel);
    }
}
