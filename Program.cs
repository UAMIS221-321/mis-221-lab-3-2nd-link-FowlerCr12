//start main
string enjoymentLevel = GetEnjoymentLevel();
string stadium = GetStadiumReccomendations(enjoymentLevel);
string game = GetGameReccomendations(stadium);
DisplayStadiumDetails(stadium, game);

// end main


static string GetEnjoymentLevel()
{
    Console.WriteLine("What is the enjoyment level of the game you want to attend? \n Your options are Boring, Average, Fun, or Epic");
    return Console.ReadLine();
}

static string GetStadiumReccomendations(string enjoymentLevel)
{
    if(enjoymentLevel.ToLower() == "epic"){
        return "Saban Field at Bryant Denny Stadium";
    } else if(enjoymentLevel.ToLower() == "fun") {
        return "Tiger Stadium";
    } else if(enjoymentLevel.ToLower() == "average") {
        return "Jordan-Hare Stadium";
    } else if(enjoymentLevel.ToLower() == "boring") {
        return "Neyland Stadium";
    } else {
        return "That is an invalid stadium choice.";
    }
}

static string GetGameReccomendations(string stadium)
{
    if(stadium == "Saban Field at Bryant Denny Stadium"){
        return "Alabama vs. Auburn";
    } else if(stadium == "Tiger Stadium"){
        return "LSU vs. Alabama";
    } else if(stadium == "Jordan-Hare Stadium"){
        return "Auburn vs. Kentucky";
    } else if(stadium == "Neyland Stadium"){
        return "UT vs. Kent State";
    } else {
        return "Invalid game selection.";
    }
}

static void DisplayStadiumDetails(string stadium, string game)
{
    // returns a message detailing the college stadium, including the name of the stadium and the best game to attend.
    Console.WriteLine($"Based on your answers, the best stadium for you is {stadium} and the best game to attend is {game}.");
}