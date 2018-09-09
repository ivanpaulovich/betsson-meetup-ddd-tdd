public sealed class Personnummer
{
    private string _text;
    const string RegExForValidation = @"^\d{6,8}[-|(\s)]{0,1}\d{4}$";

    public Personnummer(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            throw new SSNShouldNotBeEmptyException("The 'Personnummer' field is required");

        Regex regex = new Regex(RegExForValidation);
        Match match = regex.Match(text);

        if (!match.Success)
            throw new InvalidSSNException("Invalid Personnummer format. Use YYMMDDNNNN.");

        _text = text;
    }
}

