using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ScoreUi : MonoBehaviour
{
    public RowUi rowUi;
    public ScoreListManager scoreListManager;

    void Start()
    {
        //generiramo unos rezultata
        scoreListManager.AddScore(new Score(name: "Sub", score: 999));

        //spremamo rezultate u niz
        var scores = scoreListManager.GetHighScores().ToArray();
        for (int i = 0; i < scores.Length; i++)
        {
            //koristimo rowUi kako bi odredili gdje upisati komponente rank, name i score
            var row = Instantiate(rowUi, transform).GetComponent<RowUi>();
            row.rank.text = (i + 1).ToString();
            row.name.text = scores[i].name;
            row.score.text = scores[i].score.ToString();
        }
    }
}