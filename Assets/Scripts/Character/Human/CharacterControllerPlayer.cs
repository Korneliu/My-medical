using UnityEngine;

public class CharacterControllerPlayer : MonoBehaviour
{
    [SerializeField] private Animator animator;

    [SerializeField] private float speed;
    [SerializeField] private float laneDistance;
    [SerializeField] private int desiredLane;

    [SerializeField] private GameObject panelLose;
    [SerializeField] private GameObject panelMenu;

    [SerializeField] private GameObject quiz1;
    [SerializeField] private GameObject quiz2;
    [SerializeField] private GameObject quiz3;
    [SerializeField] private GameObject quiz4;
    [SerializeField] private GameObject quiz5;
    [SerializeField] private GameObject quiz6;
    [SerializeField] private GameObject quiz7;
    [SerializeField] private GameObject quiz8;
    [SerializeField] private GameObject quiz9;
    [SerializeField] private GameObject quiz10;
    [SerializeField] private GameObject quiz11;
    [SerializeField] private GameObject quiz12;
    [SerializeField] private GameObject quiz13;
    [SerializeField] private GameObject quiz14;
    [SerializeField] private GameObject quiz15;
    [SerializeField] private GameObject quiz16;
    [SerializeField] private GameObject quiz17;
    [SerializeField] private GameObject quiz18;
    [SerializeField] private GameObject quiz19;
    [SerializeField] private GameObject quiz20;
    [SerializeField] private GameObject quiz21;

    [SerializeField] private CharacterController controller;

    private Vector3 direction;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        controller.Move(direction * Time.deltaTime);

        direction.z = speed;

        if (SwipeManager.swipeRight)
        {
            desiredLane++;
            if (desiredLane == 3)
                desiredLane = 2;
        }

        if (SwipeManager.swipeLeft)
        {
            desiredLane--;
            if (desiredLane == -1)
                desiredLane = 0;
        }

        Vector3 targetPosition = transform.position.z * transform.forward + transform.position.y * transform.up;
        controller.center = controller.center;

        if (desiredLane == 0)
        {
            targetPosition += Vector3.left * laneDistance;
        }
        else if (desiredLane == 2)
        {
            targetPosition += Vector3.right * laneDistance;
        }

        transform.position = Vector3.Lerp(transform.position, targetPosition, 80 * Time.deltaTime);
    }

     public void OpenPanelMenu()
    {
        panelMenu.SetActive(true);
        Time.timeScale = 0;
        FindObjectOfType<AudioManager>().PlaySound("Button");
    }

    public void ClosePanelMenu()
    {
        panelMenu.SetActive(false);
        Time.timeScale = 1;
        FindObjectOfType<AudioManager>().PlaySound("Button");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Quiz1"))
        {
            quiz1.SetActive(true);
            Time.timeScale = 0;
        }

        if (other.tag.Equals("Quiz2"))
        {
            quiz2.SetActive(true);
            Time.timeScale = 0;
        }

        if (other.tag.Equals("Quiz3"))
        {
            quiz3.SetActive(true);
            Time.timeScale = 0;
        }

        if (other.tag.Equals("Quiz4"))
        {
            quiz4.SetActive(true);
            Time.timeScale = 0;
        }
        if (other.tag.Equals("Quiz5"))
        {
            quiz5.SetActive(true);
            Time.timeScale = 0;
        }
        if (other.tag.Equals("Quiz6"))
        {
            quiz6.SetActive(true);
            Time.timeScale = 0;
        }
        if (other.tag.Equals("Quiz7"))
        {
            quiz7.SetActive(true);
            Time.timeScale = 0;
        }
        if (other.tag.Equals("Quiz8"))
        {
            quiz8.SetActive(true);
            Time.timeScale = 0;
        }
        if (other.tag.Equals("Quiz9"))
        {
            quiz9.SetActive(true);
            Time.timeScale = 0;
        }
        if (other.tag.Equals("Quiz10"))
        {
            quiz10.SetActive(true);
            Time.timeScale = 0;
        }
        if (other.tag.Equals("Quiz11"))
        {
            quiz11.SetActive(true);
            Time.timeScale = 0;
        }
        if (other.tag.Equals("Quiz12"))
        {
            quiz12.SetActive(true);
            Time.timeScale = 0;
        }
        if (other.tag.Equals("Quiz13"))
        {
            quiz13.SetActive(true);
            Time.timeScale = 0;
        }
        if (other.tag.Equals("Quiz14"))
        {
            quiz14.SetActive(true);
            Time.timeScale = 0;
        }
        if (other.tag.Equals("Quiz15"))
        {
            quiz15.SetActive(true);
            Time.timeScale = 0;
        }
        if (other.tag.Equals("Quiz16"))
        {
            quiz16.SetActive(true);
            Time.timeScale = 0;
        }
        if (other.tag.Equals("Quiz17"))
        {
            quiz17.SetActive(true);
            Time.timeScale = 0;
        }
        if (other.tag.Equals("Quiz18"))
        {
            quiz18.SetActive(true);
            Time.timeScale = 0;
        }
        if (other.tag.Equals("Quiz19"))
        {
            quiz19.SetActive(true);
            Time.timeScale = 0;
        }
        if (other.tag.Equals("Quiz20"))
        {
            quiz20.SetActive(true);
            Time.timeScale = 0;
        }
        if (other.tag.Equals("Quiz21"))
        {
            quiz21.SetActive(true);
            Time.timeScale = 0;
        }

        if (other.tag.Equals("Pizza"))
        {
            panelLose.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void WrongAnswer()
    {
        quiz1.SetActive(false);
        quiz2.SetActive(false);
        quiz3.SetActive(false);
        quiz4.SetActive(false);
        quiz5.SetActive(false);
        quiz6.SetActive(false);
        quiz7.SetActive(false);
        quiz8.SetActive(false);
        quiz9.SetActive(false);
        quiz10.SetActive(false);
        quiz11.SetActive(false);
        quiz12.SetActive(false);
        quiz13.SetActive(false);
        quiz14.SetActive(false);
        quiz15.SetActive(false);
        quiz16.SetActive(false);
        quiz17.SetActive(false);
        quiz18.SetActive(false);
        quiz19.SetActive(false);
        quiz20.SetActive(false);
        quiz21.SetActive(false);
        panelLose.SetActive(true);
        Time.timeScale = 0;
        FindObjectOfType<AudioManager>().PlaySound("Lose");
    }

    public void CorrectAnswer1()
    {
        quiz1.SetActive(false);
        Time.timeScale = 1;
        speed += 1;
        Coins.coinsCount += 10;
    }

    public void CorrectAnswer2()
    {
        quiz2.SetActive(false);
        Time.timeScale = 1;
        speed += 1;
    }

    public void CorrectAnswer3()
    {
        quiz3.SetActive(false);
        Time.timeScale = 1;
        speed += 1;
    }

    public void CorrectAnswer4()
    {
        quiz4.SetActive(false);
        Time.timeScale = 1;
        speed += 1;
    }

    public void CorrectAnswer5()
    {
        quiz5.SetActive(false);
        Time.timeScale = 1;
        speed += 1;
    }

    public void CorrectAnswer6()
    {
        quiz6.SetActive(false);
        Time.timeScale = 1;
        speed += 1;
    }

    public void CorrectAnswer7()
    {
        quiz7.SetActive(false);
        Time.timeScale = 1;
        speed += 1;
    }

    public void CorrectAnswer8()
    {
        quiz8.SetActive(false);
        Time.timeScale = 1;
        speed += 1;
    }

    public void CorrectAnswer9()
    {
        quiz9.SetActive(false);
        Time.timeScale = 1;
        speed += 1;
    }

    public void CorrectAnswer10()
    {
        quiz10.SetActive(false);
        Time.timeScale = 1;
        speed += 1;
    }

    public void CorrectAnswer11()
    {
        quiz11.SetActive(false);
        Time.timeScale = 1;
        speed += 1;
    }

    public void CorrectAnswer12()
    {
        quiz12.SetActive(false);
        Time.timeScale = 1;
        speed += 1;
    }

    public void CorrectAnswer13()
    {
        quiz13.SetActive(false);
        Time.timeScale = 1;
        speed += 1;
    }

    public void CorrectAnswer14()
    {
        quiz14.SetActive(false);
        Time.timeScale = 1;
        speed += 1;
    }

    public void CorrectAnswer15()
    {
        quiz15.SetActive(false);
        Time.timeScale = 1;
        speed += 1;
    }

    public void CorrectAnswer16()
    {
        quiz16.SetActive(false);
        Time.timeScale = 1;
        speed += 1;
    }

    public void CorrectAnswer17()
    {
        quiz17.SetActive(false);
        Time.timeScale = 1;
        speed += 1;
    }

    public void CorrectAnswer18()
    {
        quiz18.SetActive(false);
        Time.timeScale = 1;
        speed += 1;
    }

    public void CorrectAnswer19()
    {
        quiz19.SetActive(false);
        Time.timeScale = 1;
        speed += 1;
    }

    public void CorrectAnswer20()
    {
        quiz20.SetActive(false);
        Time.timeScale = 1;
        speed += 1;
    }

    public void CorrectAnswer21()
    {
        quiz21.SetActive(false);
        Time.timeScale = 1;
        speed += 1;
    }
}

