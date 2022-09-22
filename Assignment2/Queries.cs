namespace Assignment2;

public class Queries
{

    public string query1em()
    {
        var wizardlst = WizardCollection.Create();
        var sithL = wizardlst.Where(wizard => wizard.Name.Contains("Darth"));


        sithL.ToList().ForEach(wizard => Console.WriteLine(wizard.ToString()));
        return "hej";
    }
}
