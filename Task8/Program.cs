using System.Net.WebSockets;

List<Post> posts = new List<Post>();
var post1 = new Post();
post1.Title = "Норак";
post1.Description = "Хело зебо";
post1.LikeCount = 0;
post1.Comment("hello");
post1.Comment("World");
post1.Comment("Name");
post1.Comment("Yooov");
post1.Comment("Zuur");
post1.Like();
post1.Like();
var post2 = new Post();
post2.Title = "Саёхат";
post2.Description = "Хело зебо";
post2.LikeCount = 0;
post2.Comment("hello");
post2.Like();
post2.Like();
post2.Like();
var post3 = new Post();
post3.Title = "Сафеддара";
post3.Description = "Хнк бдай";
post3.LikeCount = 0;
post3.Comment("good");
post3.Like();
post3.Like();
var post4 = new Post();
post4.Title = "Дубай";
post4.Description = "Ганда гарм";
post4.LikeCount = 0;
post4.Comment("good");
var post5 = new Post();
post5.Title = "Америка";
post5.Description = "Ганда хушру";
post5.LikeCount = 0;
post5.Comment("hello");
posts.Add(post1);
posts.Add(post2);
posts.Add(post3);
posts.Add(post4);
posts.Add(post5);

foreach (var item in posts)
{
    System.Console.WriteLine($"{item.Title} – {item.Description} – number of Likes: {item.LikeCount}");
}
foreach (var item in post1.Comments)
{
    System.Console.Write(item + ",");
}