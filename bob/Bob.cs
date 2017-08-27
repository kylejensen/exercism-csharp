using System;

public static class Bob
{
    public static string Response(string statement)
    {
        statement = statement.Trim();
        int len = statement.Length;
        bool shouting = false;
        bool question = false;

        if (statement == "") {
            return "Fine. Be that way!";
        } else if (statement.EndsWith("?")) {
            question = true;
        }

        for (int i = 0; i < len; i++) {
            if (Char.IsLetter(statement[i])) {
                shouting = true;
                if (Char.IsLower(statement[i])) {
                    shouting = false;
                    break;
                }
            }
        }

        if (shouting) {
            return "Whoa, chill out!";
        } else if (question) {
            return "Sure.";
        }

        return "Whatever.";
    }
}