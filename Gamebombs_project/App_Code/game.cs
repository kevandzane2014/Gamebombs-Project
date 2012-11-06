using System;

// Define the delegate that represents the event.
public delegate void PriceChangedEventHandler();

public class Game
{
    private string name;
    private string imageUrl;

    //Constructor
    public Game(string name, string imageUrl)
    {
        Name = name;
        ImageUrl = imageUrl;
    }

    //Getters and Setters
    public string Name
    {
        get
        { return name; }
        set
        { name = value; }
    }

    public string ImageUrl
    {
        get
        { return imageUrl; }
        set
        { imageUrl = value; }
    }




    //Code for Creating the page
    public virtual string GetHtml()
    {

        string htmlString;
        htmlString = "<h1>" + name + "</h1><br>";
        htmlString += "<img src='" + imageUrl + "' />";
        htmlString += "<hr />";
        return htmlString;

    }




}