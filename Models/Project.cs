public class Project
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Link { get; set; }
    public string Stack { get; set; }
    public string Image { get; set; }
    public string Live { get; set; }
    public List<string> Features { get; set; } = new();
}