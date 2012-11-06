using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

public partial class Cards : System.Web.UI.Page
{
    private OneOf25[,] Arr = new OneOf25[5, 5];
    protected void Page_Init(object sender, EventArgs e)
    {

        // fill Arr
        Arr[0, 0] = OneOf25_1; Arr[1, 0] = OneOf25_2; Arr[2, 0] = OneOf25_3; Arr[3, 0] = OneOf25_4; Arr[4, 0] = OneOf25_5;
        Arr[0, 1] = OneOf25_6; Arr[1, 1] = OneOf25_7; Arr[2, 1] = OneOf25_8; Arr[3, 1] = OneOf25_9; Arr[4, 1] = OneOf25_10;
        Arr[0, 2] = OneOf25_11; Arr[1, 2] = OneOf25_12; Arr[2, 2] = OneOf25_13; Arr[3, 2] = OneOf25_14; Arr[4, 2] = OneOf25_15;
        Arr[0, 3] = OneOf25_16; Arr[1, 3] = OneOf25_17; Arr[2, 3] = OneOf25_18; Arr[3, 3] = OneOf25_19; Arr[4, 3] = OneOf25_20;
        Arr[0, 4] = OneOf25_21; Arr[1, 4] = OneOf25_22; Arr[2, 4] = OneOf25_23; Arr[3, 4] = OneOf25_24; Arr[4, 4] = OneOf25_25;

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Arr[i, j].OnClick += CardButton_Click;
            }
        }
    }


    protected void Page_PreRender(object sender, EventArgs e)
    {
        string[] AllCards = new string[52]  {"AC","2C","3C","4C","5C","6C","7C","8C","9C","TC","JC","QC","KC",
                                           "AS","2S","3S","4S","5S","6S","7S","8S","9S","TS","JS","QS","KS",
                                           "AH","2H","3H","4H","5H","6H","7H","8H","9H","TH","JH","QH","KH",
                                           "AD","2D","3D","4D","5D","6D","7D","8D","9D","TD","JD","QD","KD"};

        string[] DealedCards = new string[25];

        if (ViewState["Step"] == null)
        {
            ViewState["Step"] = 0;
            for (int i = 0; i < DealedCards.Length; i++)
            {
                Random rand = new Random(Environment.TickCount);
                String Card = "";
                do
                {
                    int r = rand.Next(52);
                    Card = AllCards[r];
                    DealedCards[i] = Card;
                    AllCards[r] = "";
                } while (Card.Equals(""));
                NewDeal.Visible = false;
                DealCard.Visible = true;
            }
            ViewState["DealedCards"] = DealedCards;
            DealCard.ImageUrl = "~/Cards/" + DealedCards[0] + ".gif";
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Arr[i, j].Card = "";
                }
            }
            Row1.Text = ""; Row2.Text = ""; Row3.Text = ""; Row4.Text = ""; Row5.Text = "";
            Col1.Text = ""; Col2.Text = ""; Col3.Text = ""; Col4.Text = ""; Col5.Text = "";
            Dia1.Text = ""; Dia2.Text = ""; Total.Text = "";
        }
    }

    protected void NewDeal_Click(object sender, EventArgs e)
    {
        ViewState.Remove("Step");
    }

    protected void CardButton_Click(object sender, EventArgs e)
    {
        string[] DealedCards = (string[])ViewState["DealedCards"];
        (sender as OneOf25).Card = DealedCards[(int)ViewState["Step"]];
        int Step = (int)ViewState["Step"];
        Step += 1;
        ViewState["Step"] = Step;
        if (Step < 25)
        {
            DealCard.ImageUrl = "~/Cards/" + DealedCards[Step] + ".gif";
            NewDeal.Visible = false;
            DealCard.Visible = true;
        }
        else
        {
            string[] Cards = new string[5];

            // count all lines
            int Suma = 0;
            for (int i = 0; i < 5; i++) Cards[i] = Arr[i, 0].Card;
            Suma += GetArrayValue(Cards);
            Row1.Text = GetArrayValue(Cards).ToString();

            for (int i = 0; i < 5; i++) Cards[i] = Arr[i, 1].Card;
            Suma += GetArrayValue(Cards);
            Row2.Text = GetArrayValue(Cards).ToString();

            for (int i = 0; i < 5; i++) Cards[i] = Arr[i, 2].Card;
            Suma += GetArrayValue(Cards);
            Row3.Text = GetArrayValue(Cards).ToString();

            for (int i = 0; i < 5; i++) Cards[i] = Arr[i, 3].Card;
            Suma += GetArrayValue(Cards);
            Row4.Text = GetArrayValue(Cards).ToString();

            for (int i = 0; i < 5; i++) Cards[i] = Arr[i, 4].Card;
            Suma += GetArrayValue(Cards);
            Row5.Text = GetArrayValue(Cards).ToString();

            // count all columns
            for (int i = 0; i < 5; i++) Cards[i] = Arr[0, i].Card;
            Suma += GetArrayValue(Cards);
            Col1.Text = GetArrayValue(Cards).ToString();

            for (int i = 0; i < 5; i++) Cards[i] = Arr[1, i].Card;
            Suma += GetArrayValue(Cards);
            Col2.Text = GetArrayValue(Cards).ToString();

            for (int i = 0; i < 5; i++) Cards[i] = Arr[2, i].Card;
            Suma += GetArrayValue(Cards);
            Col3.Text = GetArrayValue(Cards).ToString();

            for (int i = 0; i < 5; i++) Cards[i] = Arr[3, i].Card;
            Suma += GetArrayValue(Cards);
            Col4.Text = GetArrayValue(Cards).ToString();

            for (int i = 0; i < 5; i++) Cards[i] = Arr[4, i].Card;
            Suma += GetArrayValue(Cards);
            Col5.Text = GetArrayValue(Cards).ToString();

            //count all diagonals
            for (int i = 0; i < 5; i++) Cards[i] = Arr[i, i].Card;
            int j = GetArrayValue(Cards);
            if (j > 0) j += 10;
            Suma += j;
            Dia1.Text = j.ToString();

            for (int i = 4; i > -1; i--) Cards[i] = Arr[4 - i, i].Card;
            j = GetArrayValue(Cards);
            if (j > 0) j += 10;
            Suma += j;
            Dia2.Text = j.ToString();

            Total.Text = Suma.ToString();
            NewDeal.Visible = true;
            DealCard.Visible = false;
        }


    }

    #region Logic
    private int GetCardValue(char CardVal)
    {
        int retval = 0;
        char[] Cards = new char[13] { 'A', '2', '3', '4', '5', '6', '7', '8', '9', 'T', 'J', 'Q', 'K' };
        int[] Values = new int[13] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
        for (int i = 0; i < Cards.Length; i++)
        {
            if (CardVal == Cards[i])
            {
                retval = Values[i];
                break;
            }
        }
        return retval;
    }


    private int GetArrayValue(string[] Cards)
    {
        //to array
        int retval = 0;
        int[] arr = new int[5];
        string[] RegexVari = new String[14] { "1111",                                                //straight
                                              "000[1-9]", "[1-9]000",                                //four of kind, poker
                                              "0[1-9]00", "00[1-9]0",                                //full house  
                                              "0[1-9]0[1-9]", "[1-9]0[1-9]0",                        //two pair
                                              "00[1-9][1-9]", "[1-9]00[1-9]", "[1-9][1-9]00",        //three of a kind  
                                              "0",                                                   //one pair
                                              "AAAA",                                                //four aces
                                              "AJKQT",                                               //royal flush
                                              "AAAKK" };                                             //ace full house
        int[] RegexVals = new int[14] { 50, 
                                        160, 160, 
                                        80, 80, 
                                        20, 20, 
                                        40, 40, 40, 
                                        10, 
                                        200,
                                        150,
                                        100};

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = GetCardValue(Cards[i][0]);
        }
        Array.Sort(Cards);
        Array.Sort(arr);

        // regular combinations
        String S = "";
        for (int i = 0; i < 4; i++) S = S + (Math.Abs(arr[i] - arr[i + 1]) > 1 ? 9 : Math.Abs(arr[i] - arr[i + 1]));
        for (int i = 0; i < RegexVari.Length; i++)
        {
            Regex rx = new Regex(RegexVari[i]);
            if (rx.Match(S).Success)
            {
                retval = RegexVals[i];
                break;
            }
        }

        // special combinations  
        S = "";
        for (int i = 0; i < 5; i++) S = S + Cards[i][0];
        for (int i = 0; i < RegexVari.Length; i++)
        {
            Regex rx = new Regex(RegexVari[i]);
            if (rx.Match(S).Success)
            {
                retval = RegexVals[i];
                break;
            }
        }
        return retval;
    }


    #endregion

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Games/Games.aspx?name=CARDS");
    }
}