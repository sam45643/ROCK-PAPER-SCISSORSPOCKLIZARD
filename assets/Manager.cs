using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Manager : MonoBehaviour
{
    public TextMeshProUGUI Result;
    public Image AIChoice;

    public const string RockChoice = "Rock";
    public const string PaperChoice = "Paper";
    public const string ScissorsChoice = "Scissors";
    public const string LizardChoice = "Lizard";
    public const string SpockChoice = "Spock";

    public string[] Choices;
    public Sprite Rock, Paper, Scissors, Lizard, Spock;

    public void Play(string myChoice)
    {
        if (myChoice != RockChoice && myChoice != PaperChoice && myChoice != ScissorsChoice && myChoice != LizardChoice && myChoice != SpockChoice)
        {
            Debug.LogError("Invalid choice: " + myChoice);
            return;
        }

        string randomChoice = Choices[Random.Range(0, Choices.Length)];

        switch (randomChoice)
        {
            case RockChoice:
                switch (myChoice)
                {
                    case RockChoice:
                        Result.text = "Tie!";
                        break;

                    case PaperChoice:
                        Result.text = "The paper covers the rock, you win!";
                        break;

                    case ScissorsChoice:
                        Result.text = "The rock destroys the scissors, you win!";
                        break;

                    case LizardChoice:
                        Result.text = "The rock crushes the lizard, you win!";
                        break;

                    case SpockChoice:
                        Result.text = "Spock vaporizes the rock, you lose!";
                        break;
                }

                AIChoice.sprite = Rock;
                break;

            case PaperChoice:
                switch (myChoice)
                {
                    case RockChoice:
                        Result.text = "The paper covers the rock, you lose!";
                        break;

                    case PaperChoice:
                        Result.text = "Tie!";
                        break;

                    case ScissorsChoice:
                        Result.text = "The scissors cuts the paper, you win!";
                        break;

                    case LizardChoice:
                        Result.text = "The lizard eats the paper, you lose!";
                        break;

                    case SpockChoice:
                        Result.text = "The paper disproves Spock, you win!";
                        break;
                }

                AIChoice.sprite = Paper;
                break;

            case ScissorsChoice:
                switch (myChoice)
                {
                    case RockChoice:
                        Result.text = "The rock destroys the scissors, you lose!";
                        break;

                    case PaperChoice:
                        Result.text = "The scissors cuts the paper, you lose!";
                        break;

                    case ScissorsChoice:
                        Result.text = "Tie!";
                        break;

                    case LizardChoice:
                        Result.text = "The scissors decapitates the lizard, you win!";
                        break;

                    case SpockChoice:
                        Result.text = "Spock smashes the scissors, you lose!";
                        break;
                }

                AIChoice.sprite = Scissors;
                break;

            case LizardChoice:
                switch (myChoice)
                {
                    case RockChoice:
                        Result.text = "The rock crushes the lizard, you lose!";
                        break;

                    case PaperChoice:
                        Result.text = "The lizard eats the paper, you win!";
                        break;

                    case ScissorsChoice:
                        Result.text = "The scissors decapitates the lizard, you lose!";
                        break;

                    case LizardChoice:
                        Result.text = "Tie!";
                        break;

                    case SpockChoice:
                        Result.text = "The lizard poisons Spock, you win!";
                        break;
                }

                AIChoice.sprite = Lizard;
                break;
        }
    }
}
