using Microsoft.EntityFrameworkCore.Migrations;
using SharpScape.Api.Models;
using SharpScape.Shared.Dto;

#nullable disable

namespace SharpScape.Api.Migrations
{
    public partial class Seed_Database : Migration
    {
        private List<User> users = new() {
            new User("Admin", "admin@sharpscape.net", "StrongPassword12345") { Id = 1, Role = UserRole.Admin },
            new User("Pringleton", "pringle@example.com", "StrongPringle") { Id = 2 },
            new User("John Dotnet", "john@dot.net", "ilovedotnet123") { Id = 3 }
        };

        private List<ForumCategory> forumCategories = new() {
            new ForumCategory(){ 
                Id = 1, 
                Name = "General Discussion", 
                Description = "Talk about sports, entertainment, music, movies, your favorite color, talk about enything."
            },
            new ForumCategory(){ 
                Id = 2, 
                Name = "Introductions", 
                Description = "New to the community? Please stop by, say hi and tell us a bit about yourself."
            },
            new ForumCategory(){ 
                Id = 3, 
                Name = "Announcements", 
                Description = "This forum features announcements from the community staff. If there is a new post in this forum, please check it out."
            },
            new ForumCategory(){ 
                Id = 4, 
                Name = "Staff Discussion", 
                Description = "This forum is for private, staff member only discussions, usually pertaining to the community itself."
            },
            new ForumCategory(){ 
                Id = 5, 
                Name = "Lorem Ipsum is simply dummy text", 
                Description = "Various versions have evolved over the years, sometimes by accident, sometimes on purpose passage of Lorem Ipsum (injected humour and the like)."
            },
            new ForumCategory(){ 
                Id = 6, 
                Name = "There are many variations of passages", 
                Description = "If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the."
            },
            new ForumCategory(){ 
                Id = 7, 
                Name = "The standard chunk of Lorem Ipsum", 
                Description = "Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet."
            },
            new ForumCategory(){ 
                Id = 8, 
                Name = "Lorem Ipsum, you need to be sure there", 
                Description = "Internet tend to repeat predefined chunks as necessary, making this the."
            }
        };

        private List<ForumThread> forumThreads = new() {
            // belongto category 1, users 1, 2, 3
            new ForumThread() { 
                Id = 1, 
                CategoryId = 1, 
                UserId = 1,
                Title = "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", 
                Body = "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 2, 
                CategoryId = 1, 
                UserId = 2,
                Title = "qui est esse", 
                Body = "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 3, 
                CategoryId = 1, 
                UserId = 3,
                Title = "ea molestias quasi exercitationem repellat qui ipsa sit aut", 
                Body = "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 4, 
                CategoryId = 1, 
                UserId = 1,
                Title = "eum et est occaecati", 
                Body = "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 5, 
                CategoryId = 1, 
                UserId = 2,
                Title = "nesciunt quas odio", 
                Body = "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 6, 
                CategoryId = 1, 
                UserId = 3,
                Title = "dolorem eum magni eos aperiam quia", 
                Body = "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 7, 
                CategoryId = 1, 
                UserId = 1,
                Title = "magnam facilis autem", 
                Body = "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 8, 
                CategoryId = 1, 
                UserId = 2,
                Title = "dolorem dolore est ipsam", 
                Body = "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            // belong to category 2, users 1, 2, ,3
            new ForumThread() { 
                Id = 9, 
                CategoryId = 2, 
                UserId = 2,
                Title = "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", 
                Body = "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 10, 
                CategoryId = 2, 
                UserId = 3,
                Title = "qui est esse", 
                Body = "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 11, 
                CategoryId = 2, 
                UserId = 1,
                Title = "ea molestias quasi exercitationem repellat qui ipsa sit aut", 
                Body = "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 12, 
                CategoryId = 2, 
                UserId = 3,
                Title = "eum et est occaecati", 
                Body = "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 13, 
                CategoryId = 2, 
                UserId = 2,
                Title = "nesciunt quas odio", 
                Body = "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 14, 
                CategoryId = 2, 
                UserId = 1,
                Title = "dolorem eum magni eos aperiam quia", 
                Body = "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 15, 
                CategoryId = 2, 
                UserId = 3,
                Title = "magnam facilis autem", 
                Body = "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 16, 
                CategoryId = 2, 
                UserId = 2,
                Title = "dolorem dolore est ipsam", 
                Body = "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
                // belong to category 3, users 1, 2, ,3
            new ForumThread() { 
                Id = 17, 
                CategoryId = 3, 
                UserId = 2,
                Title = "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", 
                Body = "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 18, 
                CategoryId = 3, 
                UserId = 3,
                Title = "qui est esse", 
                Body = "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 19, 
                CategoryId = 3, 
                UserId = 1,
                Title = "ea molestias quasi exercitationem repellat qui ipsa sit aut", 
                Body = "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 20, 
                CategoryId = 3, 
                UserId = 3,
                Title = "eum et est occaecati", 
                Body = "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 21, 
                CategoryId = 3, 
                UserId = 2,
                Title = "nesciunt quas odio", 
                Body = "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 22, 
                CategoryId = 3, 
                UserId = 1,
                Title = "dolorem eum magni eos aperiam quia", 
                Body = "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 23, 
                CategoryId = 3, 
                UserId = 3,
                Title = "magnam facilis autem", 
                Body = "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 24, 
                CategoryId = 3, 
                UserId = 2,
                Title = "dolorem dolore est ipsam", 
                Body = "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
                // belong to category 4, users 1, 2, ,3
            new ForumThread() { 
                Id = 25, 
                CategoryId = 3, 
                UserId = 2,
                Title = "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", 
                Body = "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 26, 
                CategoryId = 3, 
                UserId = 3,
                Title = "qui est esse", 
                Body = "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 27, 
                CategoryId = 3, 
                UserId = 1,
                Title = "ea molestias quasi exercitationem repellat qui ipsa sit aut", 
                Body = "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 28, 
                CategoryId = 3, 
                UserId = 3,
                Title = "eum et est occaecati", 
                Body = "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 29, 
                CategoryId = 3, 
                UserId = 2,
                Title = "nesciunt quas odio", 
                Body = "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 30, 
                CategoryId = 3, 
                UserId = 1,
                Title = "dolorem eum magni eos aperiam quia", 
                Body = "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 31, 
                CategoryId = 3, 
                UserId = 3,
                Title = "magnam facilis autem", 
                Body = "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 32, 
                CategoryId = 3, 
                UserId = 2,
                Title = "dolorem dolore est ipsam", 
                Body = "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
                // belong to category 5, users 1, 2, ,3
            new ForumThread() { 
                Id = 33, 
                CategoryId = 5, 
                UserId = 2,
                Title = "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", 
                Body = "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 34, 
                CategoryId = 5, 
                UserId = 3,
                Title = "qui est esse", 
                Body = "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 35, 
                CategoryId = 5, 
                UserId = 1,
                Title = "ea molestias quasi exercitationem repellat qui ipsa sit aut", 
                Body = "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 36, 
                CategoryId = 5, 
                UserId = 3,
                Title = "eum et est occaecati", 
                Body = "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 37, 
                CategoryId = 5, 
                UserId = 2,
                Title = "nesciunt quas odio", 
                Body = "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 38, 
                CategoryId = 5, 
                UserId = 1,
                Title = "dolorem eum magni eos aperiam quia", 
                Body = "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 39, 
                CategoryId = 5, 
                UserId = 3,
                Title = "magnam facilis autem", 
                Body = "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 40, 
                CategoryId = 5, 
                UserId = 2,
                Title = "dolorem dolore est ipsam", 
                Body = "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
                // belong to category 6, users 1, 2, ,3
            new ForumThread() { 
                Id = 41, 
                CategoryId = 6, 
                UserId = 2,
                Title = "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", 
                Body = "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 42, 
                CategoryId = 6, 
                UserId = 3,
                Title = "qui est esse", 
                Body = "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 43, 
                CategoryId = 6, 
                UserId = 1,
                Title = "ea molestias quasi exercitationem repellat qui ipsa sit aut", 
                Body = "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 44, 
                CategoryId = 6, 
                UserId = 3,
                Title = "eum et est occaecati", 
                Body = "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 45, 
                CategoryId = 6, 
                UserId = 2,
                Title = "nesciunt quas odio", 
                Body = "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 46, 
                CategoryId = 6, 
                UserId = 1,
                Title = "dolorem eum magni eos aperiam quia", 
                Body = "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 47, 
                CategoryId = 6, 
                UserId = 3,
                Title = "magnam facilis autem", 
                Body = "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 48, 
                CategoryId = 6, 
                UserId = 2,
                Title = "dolorem dolore est ipsam", 
                Body = "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
                // belong to category 7, users 1, 2, ,3
            new ForumThread() { 
                Id = 49, 
                CategoryId = 7, 
                UserId = 2,
                Title = "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", 
                Body = "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 50, 
                CategoryId = 7, 
                UserId = 3,
                Title = "qui est esse", 
                Body = "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 51, 
                CategoryId = 7, 
                UserId = 1,
                Title = "ea molestias quasi exercitationem repellat qui ipsa sit aut", 
                Body = "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 52, 
                CategoryId = 7, 
                UserId = 3,
                Title = "eum et est occaecati", 
                Body = "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 53, 
                CategoryId = 7, 
                UserId = 2,
                Title = "nesciunt quas odio", 
                Body = "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 54, 
                CategoryId = 7, 
                UserId = 1,
                Title = "dolorem eum magni eos aperiam quia", 
                Body = "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 55, 
                CategoryId = 7, 
                UserId = 3,
                Title = "magnam facilis autem", 
                Body = "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 56, 
                CategoryId = 7, 
                UserId = 2,
                Title = "dolorem dolore est ipsam", 
                Body = "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
                // belong to category 8, users 1, 2, ,3
            new ForumThread() { 
                Id = 57, 
                CategoryId = 8, 
                UserId = 2,
                Title = "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", 
                Body = "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 58, 
                CategoryId = 8, 
                UserId = 3,
                Title = "qui est esse", 
                Body = "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 59, 
                CategoryId = 8, 
                UserId = 1,
                Title = "ea molestias quasi exercitationem repellat qui ipsa sit aut", 
                Body = "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 60, 
                CategoryId = 8, 
                UserId = 3,
                Title = "eum et est occaecati", 
                Body = "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 61, 
                CategoryId = 8, 
                UserId = 2,
                Title = "nesciunt quas odio", 
                Body = "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 62, 
                CategoryId = 8, 
                UserId = 1,
                Title = "dolorem eum magni eos aperiam quia", 
                Body = "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 63, 
                CategoryId = 8, 
                UserId = 3,
                Title = "magnam facilis autem", 
                Body = "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            },
            new ForumThread() { 
                Id = 64, 
                CategoryId = 8, 
                UserId = 2,
                Title = "dolorem dolore est ipsam", 
                Body = "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", 
                Created = DateTime.Now, 
                Replies = 0, 
                Views = 0, 
                Votes = 0 
            }
        };

        private List<ForumPost> forumPosts = new();
        public Seed_Database()
        {
            for (int i = 1; i <= 64; i++)
            {
                ForumPost post = new ForumPost(i,(i%8)+1,(i%3)+1,"est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et");
                forumPosts.Add(post);
            }
        }

        protected override void Up(MigrationBuilder migrationBuilder)
        {

            foreach (var user in users)
            {
                migrationBuilder.InsertData("Users",
                    new[] { "Id", "Username", "Email", "Role", "PasswordHash", "PasswordSalt", "Created" },
                    new object[] { user.Id, user.Username, user.Email, user.Role, user.PasswordHash, user.PasswordSalt, user.Created });
            }

            foreach (var forumCategory in forumCategories)
            {
                migrationBuilder.InsertData("ForumCategories",
                    new[] { "Id", "Name", "Description" },
                    new object[] { forumCategory.Id, forumCategory.Name, forumCategory.Description });
            }

            foreach (var forumThread in forumThreads)
            {
                migrationBuilder.InsertData("ForumThreads",
                    new[] { "Id", "CategoryId", "UserId", "Title", "Body", "Created", "Replies", "Views", "Votes" },
                    new object[]
                    {
                        forumThread.Id,
                        forumThread.CategoryId,
                        forumThread.UserId,
                        forumThread.Title,
                        forumThread.Body,
                        forumThread.Created,
                        forumThread.Replies,
                        forumThread.Views,
                        forumThread.Votes
                    });
            }

            foreach (var forumPost in forumPosts)
            {
                migrationBuilder.InsertData("ForumPosts",
                    new[] { "Id", "ThreadId", "AuthorId", "Body", "Created" },
                    new object[]
                    {
                        forumPost.Id,
                        forumPost.ThreadId,
                        forumPost.AuthorId,
                        forumPost.Body,
                        forumPost.Created
                    });
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            foreach (var user in users)
            {
                migrationBuilder.DeleteData("Users", "Id", user.Id);
            }

            foreach (var forumCategory in forumCategories)
            {
                migrationBuilder.DeleteData("ForumCategories", "Id", forumCategory.Id);
            }
            foreach (var forumThread in forumThreads)
            {
                migrationBuilder.DeleteData("ForumThreads", "Id", forumThread.Id);
            }
            foreach (var forumPost in forumPosts)
            {
                migrationBuilder.DeleteData("ForumPosts", "Id", forumPost.Id);
            }
        }
    }
}
