namespace Assignment2;

public class Queries
{

    public List<string> extensionRowling()
    {
        var wizardlst = WizardCollection.Create();
        var sithL = wizardlst
            .Where(wizard => wizard.Creator.Contains("Rowling"))
            .Select(wizard => wizard.Name);
        return sithL.ToList();

    }

    public List<string> linqRowling()
    {
        var wizardlst = WizardCollection.Create();

        var wList = from w in wizardlst
                    where w.Creator.Contains("Rowling")
                    select w.Name;
        return wList.ToList();
    }

    public string extention1stDarth()
    {
        var wizardlst = WizardCollection.Create();
        var darth = wizardlst
            .Where(wizard => wizard.Name.Contains("Darth"))
            .OrderBy(wizard => wizard.Year)
            .Select(wizard => wizard.Year)
            .First();
        return darth.ToString();
    }

    public string linq1stDarth()
    {
        var wizardlst = WizardCollection.Create();
        var darth =
            from w in wizardlst
            where w.Name.Contains("Darth")
            orderby w.Year
            select w.Year.Value;

        return darth.First().ToString();
    }

    public IEnumerable<(string, int)> extentionHarry()
    {
        var wizardlst = WizardCollection.Create();
        var harryWizs = wizardlst
            .Where(wizard => wizard.Medium.Contains("Harry"))
            .Select(wizard => (wizard.Name, (int)wizard.Year));

        return harryWizs.ToList();
    }

    public IEnumerable<(string, int)> linqHarry()
    {
        var wizardlst = WizardCollection.Create();
        var harryWizs =
            from w in wizardlst
            where w.Medium.Contains("Harry")
            select (w.Name, (int)w.Year);

        return harryWizs.ToList();
    }

    public IEnumerable<string> emGroup()
    {
        var wizardlst = WizardCollection.Create();
        var groupwizz = wizardlst
            .OrderBy(wizz => wizz.Creator)
            .ThenBy(wizz => wizz.Name)
            .Select(wizz => wizz.Name);
        
        return groupwizz.ToList();
    }

    public IEnumerable<string> linqGroup()
    {
        var wizardlst = WizardCollection.Create();
        var wizards = from w in wizardlst
                      orderby w.Creator ascending, w.Name
                      select w.Name;
        return wizards;
    }
}
