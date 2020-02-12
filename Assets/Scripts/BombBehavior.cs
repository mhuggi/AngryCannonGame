using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BombBehavior : MonoBehaviour
{
    Vector2 v = new Vector2(0, 0);
    Vector2 originalPos = new Vector2(-7, -2);
    Vector2 wind = new Vector2(0, 0);

    GameObject Bomb;
    public Rigidbody2D rb;
    private float power;
    private float angle;
    public Text countPower;
    public Text countAngle;
    public Text displayWind;




    // Start is called before the first frame update


    void Start()
    {
        Bomb = GameObject.Find("Bomb");
        rb = GetComponent<Rigidbody2D>();
        //Vector2 orginalPos = new Vector2(-7, -2);
        power = 0;
        angle = 0;
        wind.x = Random.Range(-2f, 2f);
        wind.x = Mathf.Round(wind.x * 100) / 100;

        countPower.text = "Power: " + power * 4 + "%";
        countAngle.text = "Angle: " + angle.ToString();
        displayWind.text = "Wind: " + wind.x;




        //setCountText();



    }


    // Update is called once per frame
    void Update()
    {
        countPower.text = "Power: " + power * 4 + "%";
        countAngle.text = "Angle: " + angle.ToString();
       






        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            //rb.velocity = new Vector2(0, 0);
            //transform.rotation = Quaternion.Euler(new Vector2(0, 0));

            Bomb.transform.position = originalPos;
            v += wind;


            float rad = angle * Mathf.Deg2Rad;


            v.x = Mathf.Cos(rad) * power + wind.x;
            v.y = Mathf.Sin(rad) * power;

            Debug.Log(v);

            rb.velocity = new Vector2(v.x, v.y);
            //rb.velocity = 


        }
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            if (power < 25)
            {


                power += 1;
            }
            /*if (v.x < 20)
            {
                v = new Vector2((v.x + 0.25f), v.y);
            }*/
        }
        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            if (power > 0)
            {


                power -= 1;
            }
            /* if (v.x > 0)
             {
                 v = new Vector2((v.x - 0.25f), v.y);
             }*/
        }
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            if (angle < 90)
            {


                angle += 1;
            }
            /*if (v.y < 22)
            {
                v = new Vector2(v.x, (v.y + 0.25f));
            }*/
        }
        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            if (angle > 0)
            {


                angle -= 1;
            }
            /*            if (v.y > 0)
                        {
                            v = new Vector2(v.x, (v.y - 0.25f));
                        }
                    */


        }
    }
}