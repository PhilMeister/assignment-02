namespace Assignment2.Tests;

public class QueriesTests
{

    [Fact]
    public void rowling_EM_return_3_wizards()
    {
        var expected = new List<string> { "Albus Dumbledore", "Severus Snape", "Harry Potter" };
        var query = new Queries();
        var res = query.extensionRowling();

        Assert.Equal(expected, res);
    }

    [Fact]
    public void rowling_linq_returns_3_wizards()
    {
        var expected = new List<string> { "Albus Dumbledore", "Severus Snape", "Harry Potter" };
        var query = new Queries();
        var res = query.linqRowling();

        Assert.Equal(expected, res);
    }

    [Fact]
    public void first_darth_EM_returns_vader()
    {
        var expected = "1977";
        var query = new Queries();
        var res = query.extention1stDarth();

        Assert.Equal(expected, res);

    }

    [Fact]
    public void first_darth_linq_returns_vader()
    {
        var expected = "1977";
        var query = new Queries();
        var res = query.linq1stDarth();

        Assert.Equal(expected, res);
    }

    [Fact]
    public void harry_wizs_EM_returns_()
    {
        var expected = new List<(string, int)> { ("Albus Dumbledore", 1864), ("Severus Snape", 1864), ("Harry Potter", 1864) };
        var query = new Queries();
        var res = query.extentionHarry();

        Assert.Equal(expected, res);
    }

    [Fact]
    public void harry_wizs_linq_returns_()
    {
        var expected = new List<(string, int)> { ("Albus Dumbledore", 1864), ("Severus Snape", 1864), ("Harry Potter", 1864) };
        var query = new Queries();
        var res = query.linqHarry();

        Assert.Equal(expected, res);
    }

    [Fact]
    public void em_group()
    {
        var expected = new List<string> { "Jafar", "Merlin", "Darth Maul", "Darth Vader", "Palpatine", "Albus Dumbledore", "Harry Potter", "Severus Snape", "Gandalf", "Sauron", "The Wizard" };
        var query = new Queries();
        var res = query.emGroup();

        Assert.Equal(expected, res);
    }

    [Fact]
    public void linq_group()
    {
        var expected = new List<string> { "Jafar", "Merlin", "Darth Maul", "Darth Vader", "Palpatine", "Albus Dumbledore", "Harry Potter", "Severus Snape", "Gandalf", "Sauron", "The Wizard" };
        var query = new Queries();
        var res = query.linqGroup();

        Assert.Equal(expected, res);
    }

}
