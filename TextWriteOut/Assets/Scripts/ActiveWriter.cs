using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActiveWriter : MonoBehaviour
{
    [SerializeField] private TextWriter textWriter;
    private Text messageText;

    private void Awake()
    {
        messageText = transform.Find("Child").GetComponent<Text>();
    }

    void Start()
    {
        textWriter.AddWriter(messageText, "Living alone and never having had a girlfriend, 37-year-old Satoru Mikami is dissatisfied with how his life has turned out. " +
            "But after dying at the hands of a robber, he awakens to a fresh start in a new world... as a slime monster.", 0.1f, true);
    }
}
