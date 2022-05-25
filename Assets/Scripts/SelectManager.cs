using UnityEngine;
using UnityEngine.UI;

public class SelectManager : MonoBehaviour
{
    [SerializeField]
    public Camera arCamera;
    bool IsZoomIn = false;
    public Text Descriptions;
    public Text Label;

    private Vector2 touchPosition = default;

    private void Start()
    {
        Descriptions.gameObject.SetActive(false);
        Label.gameObject.SetActive(false);
    }

    void Update()
    {

        if (Input.GetTouch(0).phase==TouchPhase.Stationary)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("Selected" +hit.transform.name.ToString());
                if (hit.transform.name == "SunHigh")
                {
                    IsZoomIn = !IsZoomIn;
                    if (IsZoomIn == true)
                    {
                        hit.transform.localScale = new Vector3(.005f, .005f, .005f);
                        Label.gameObject.SetActive(true);
                        Descriptions.gameObject.SetActive(true);
                        Label.text = "The Sun";
                        Descriptions.text = "The Sun is a 4.5 billion-year-old-star - a hot glowing ball of hydrogen and helium at the center of our solar system." +
                            "The Sun is the largest object in our solar system." +
                            "The Sun is about 93 million miles (150 million kilometers) from Earth." +
                            "The Sun doesn't have moons." +
                            "The Sun’s volume would need 1.3 million Earths to fill it.";
                    }
                    else
                    {
                        hit.transform.localScale = new Vector3(.001f, .001f, .001f);
                        Label.gameObject.SetActive(false);
                        Descriptions.gameObject.SetActive(false);
                    }
                }
                if (hit.transform.name == "MercuryHigh")
                {
                    IsZoomIn = !IsZoomIn;
                    if (IsZoomIn == true)
                    {
                        hit.transform.localScale = new Vector3(.005f, .005f, .005f);
                        Label.gameObject.SetActive(true);
                        Descriptions.gameObject.SetActive(true);
                        Label.text = "Mercury";
                        Descriptions.text = "Mercury is the smallest planet in our solar system and nearest to the Sun." +
                            "Mercury is only slightly larger than Earth's Moon." +
                            "Mercury is the fastest planet in our solar system because the closer a planet is to the Sun, the faster it travels." +
                            "Mercury has no moons." +
                            "Length of year = 88 earth days";
                    }
                    else
                    {
                        hit.transform.localScale = new Vector3(.00008f, .00008f, .00008f);
                        Label.gameObject.SetActive(false);
                        Descriptions.gameObject.SetActive(false);
                    }
                }
                if (hit.transform.name == "VenusHigh")
                {
                    IsZoomIn = !IsZoomIn;
                    if (IsZoomIn == true)
                    {
                        hit.transform.localScale = new Vector3(.005f, .005f, .005f);
                        Label.gameObject.SetActive(true);
                        Descriptions.gameObject.SetActive(true);
                        Label.text = "Venus";
                        Descriptions.text = "Venus is often called `Earth'twin` because they're similar in size and structure, but Venus has extreme surface heat and a dense, toxic atmosphere." +
                            "Venus is the second closest planet to the Sun." +
                            "Venus was the first planet explored by a spacecraft and was intensely studied early in the history of space exploration." +
                            "Venus does not have moons." +
                            "Length of year = 225 earth days";
                    }
                    else
                    {
                        hit.transform.localScale = new Vector3(.0001f, .0001f, .0001f);
                        Label.gameObject.SetActive(false);
                        Descriptions.gameObject.SetActive(false);
                    }
                }
                if (hit.transform.name == "EarthHigh")
                {
                    IsZoomIn = !IsZoomIn;
                    if (IsZoomIn == true)
                    {
                        hit.transform.localScale = new Vector3(.005f, .005f, .005f);
                        Label.gameObject.SetActive(true);
                        Descriptions.gameObject.SetActive(true);
                        Label.text = "Earth";
                        Descriptions.text = "Earth is the third planet from the Sun." +
                            "Earth is only the fifth largest planet in the solar system, it is the only world in our solar system with liquid water on the surface." +
                            "All the planets, except for Earth, were named after Greek and Roman gods and goddesses." +
                            "The name of Earth is a Germanic word, which simply means `the ground`." +
                            "Earth has one moon." +
                            "Length of year 365 days";
                    }
                    else
                    {
                        hit.transform.localScale = new Vector3(.0001f, .0001f, .0001f);
                        Label.gameObject.SetActive(false);
                        Descriptions.gameObject.SetActive(false);
                    }
                }
                if (hit.transform.name == "MarsHigh")
                {
                    IsZoomIn = !IsZoomIn;
                    if (IsZoomIn == true)
                    {
                        hit.transform.localScale = new Vector3(.005f, .005f, .005f);
                        Label.gameObject.SetActive(true);
                        Descriptions.gameObject.SetActive(true);
                        Label.text = "Mars";   
                        Descriptions.text = "Mars is the fourth planet from the Sun." +
                            "Mars has two moons named Phobos and Deimos." +
                            "Mars is known as the Red Planet because iron minerals in the Martian soil oxidize, or rust, causing the soil and atmosphere to look red." +
                            "The first true Mars mission success was the Mariner 4 flyby in 1965." +
                            "Length of year 687 earth days.";
                    }
                    else
                    {
                        hit.transform.localScale = new Vector3(.00008f, .00008f, .00008f);
                        Label.gameObject.SetActive(false);
                        Descriptions.gameObject.SetActive(false);
                    }
                }
                if (hit.transform.name == "JupiterHigh")
                {
                    IsZoomIn = !IsZoomIn;
                    if (IsZoomIn == true)
                    {
                        hit.transform.localScale = new Vector3(.005f, .005f, .005f);
                        Label.gameObject.SetActive(true);
                        Descriptions.gameObject.SetActive(true);
                        Label.text = "Jupiter";
                        Descriptions.text = "Fifth in line from the Sun, Jupiter is the largest planet in the solar system." +
                            "Jupiter has more than 75 moons." +
                            "Jupiter's iconic Great Red Spot is a giant storm bigger than Earth that has raged for hundreds of years." +
                            "Jupiter's atmosphere is made up mostly of hydrogen (H2) and helium (He)." +
                            "Length of year = 11 earth years.";
                    }
                    else
                    {
                        hit.transform.localScale = new Vector3(.0004f, .0004f, .0004f);
                        Label.gameObject.SetActive(false);
                        Descriptions.gameObject.SetActive(false);
                    }
                }
                if (hit.transform.name == "SaturnHigh")
                {
                    IsZoomIn = !IsZoomIn;
                    if (IsZoomIn == true)
                    {
                        hit.transform.localScale = new Vector3(.005f, .005f, .005f);
                        Label.gameObject.SetActive(true);
                        Descriptions.gameObject.SetActive(true);
                        Label.text = "Saturn";
                        Descriptions.text = "Saturn is the sixth planet from the Sun and the second-largest planet in our solar system." +
                            "Saturn has in total 82 moons." +
                            "Saturn's atmosphere is made up mostly of hydrogen (H2) and helium (He)." +
                            "Saturn has the most spectacular ring system, with seven rings and several gaps and divisions between them." +
                            "Length of year = 29 earth years.";
                    }
                    else
                    {
                        hit.transform.localScale = new Vector3(.0003f, .0003f, .0003f);
                        Label.gameObject.SetActive(false);
                        Descriptions.gameObject.SetActive(false);
                    }
                }
                if (hit.transform.name == "UranusHigh")
                {
                    IsZoomIn = !IsZoomIn;
                    if (IsZoomIn == true)
                    {
                        hit.transform.localScale = new Vector3(.005f, .005f, .005f);
                        Label.gameObject.SetActive(true);
                        Descriptions.gameObject.SetActive(true);
                        Label.text = "Uranus";
                        Descriptions.text = "Uranus is the seventh planet from the Sun, and has the third-largest diameter in our solar system." +
                            "It was the first planet found with the aid of a telescope, Uranus was discovered in 1781 by astronomer William Herschel." +
                            "Uranus has an atmosphere made mostly of molecular hydrogen and atomic helium, with a small amount of methane." +
                            "Uranus has 27 moons." +
                            "Length of year = 84 earth years.";
                    }
                    else
                    {
                        hit.transform.localScale = new Vector3(.0001f, .0001f, .0001f);
                        Label.gameObject.SetActive(false);
                        Descriptions.gameObject.SetActive(false);
                    }
                }
                if (hit.transform.name == "NeptuneHigh")
                {
                    IsZoomIn = !IsZoomIn;
                    if (IsZoomIn == true)
                    {
                        hit.transform.localScale = new Vector3(.005f, .005f, .005f);
                        Label.gameObject.SetActive(true);
                        Descriptions.gameObject.SetActive(true);
                        Label.text = "Neptune";
                        Descriptions.text = "Dark, cold, and whipped by supersonic winds, ice giant Neptune is the eighth and most distant planet in our solar system." +
                            "Neptune is the only planet in our solar system not visible to the naked eye and the first predicted by mathematics before its discovery." +
                            "In 2011 Neptune completed its first 165-year orbit since its discovery in 1846." +
                            "Neptune has 14 moons." +
                            "Length of year = 164 earth years.";
                    }
                    else
                    {
                        hit.transform.localScale = new Vector3(.0001f, .0001f, .0001f);
                        Label.gameObject.SetActive(false);
                        Descriptions.gameObject.SetActive(false);
                    }
                }
                if (hit.transform.name == "PlutoHigh")
                {
                    IsZoomIn = !IsZoomIn;
                    if (IsZoomIn == true)
                    {
                        hit.transform.localScale = new Vector3(.005f, .005f, .005f);
                        Label.gameObject.SetActive(true);
                        Descriptions.gameObject.SetActive(true);
                        Label.text = "Pluto";
                        Descriptions.text = "Pluto is a dwarf planet in the Kuiper Belt, a donut-shaped region of icy bodies beyond the orbit of Neptune." +
                            "Pluto – which is smaller than Earth’s Moon and has a heart-shaped glacier." +
                            "Pluto has 5 moons. The largest, Charon, is so big that Pluto and Charon orbit each other like a double planet." +
                            "Length of year = 248 earth years.";
                    }
                    else
                    {
                        hit.transform.localScale = new Vector3(.00007f, .00007f, .00007f);
                        Label.gameObject.SetActive(false);
                        Descriptions.gameObject.SetActive(false);
                    }
                }
            }
            else
            {
                Debug.Log("Nothing Selected");
            }
        }
    }
}