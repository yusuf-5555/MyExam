public class Post
{
    public string Title { get; set; }
    public string Description { get; set; }
    public int LikeCount { get; set; }
    public List<string> Comments { get; set; } = new List<string>();
    public bool IsPublished { get; set; }

    public void Publish()
    {
        System.Console.WriteLine("The post is published.");
        IsPublished = true;
    }
    public void Like()
    {
        LikeCount++;
    }
    public void Comment(string message)
    {
        Comments.Add(message);
    }
}