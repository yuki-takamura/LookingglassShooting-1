using LooklingGlassShooting.Models;
using UnityEngine;
using UniRx;

public class BattleStage : MonoBehaviour
{
    private float roundTime;
    private Timer _timer;
    private Player[] Players;
    private RoundEffect _roundEffect;

    [SerializeField] private GameObject Player1Prefab;
    [SerializeField] private GameObject Player2Prefab;
    
    void Start()
    {
        _timer = GetComponent<Timer>();
        roundTime = GlobalRegistory.GetRoundTime();
        _timer.TimerSet((int)roundTime);
        _roundEffect = GetComponent<RoundEffect>();

        var p1 = Instantiate(Player1Prefab);
        var p2 = Instantiate(Player2Prefab);
        Players = new []
        {
            p1.transform.GetComponent<Player>(),
            p2.transform.GetComponent<Player>()
        };
    }

    void Update()
    {
        
    }

    public void EventReady()
    {
        _roundEffect.ShowReady();
    }

    public void EventBattleStart()
    {
        _roundEffect.ShowGo();
        _timer.TimerStart();
        for (int i = 0; i < 2; i++)
        {
            Players[i].status = PlayerState.Fight;
        }
    }

    public void EventKnockOut()
    {
        _roundEffect.ShowFinish();
        _timer.TimerStop();
        for (int i = 0; i < 2; i++)
        {
            if(Players[i].status != PlayerState.Down)
            {
                Debug.Log("勝負あり！ " + i + " の勝ちだ！！！");
                Judge(i);
            }
        }
        
    }

    public void EventCountDown()
    {
        
    }

    public void EventTimeUp()
    {
        _roundEffect.ShowTimeup();
        _timer.TimerStop();
        if (Players[0].Life == Players[1].Life)
        {
            Debug.Log("引き分け！");
            
        }
        else if(Players[0].Life > Players[1].Life)
        {
            Debug.Log("勝負あり！ 0 の勝ちだ！！！");
            Judge(0);
        }
        else if(Players[0].Life < Players[1].Life)
        {
            Debug.Log("勝負あり！ 1 の勝ちだ！！！");
            Judge(1);
        }
    }

    private void Judge(int i)
    {
        _roundEffect.ShowWinnerEffect(i);
    }
}
