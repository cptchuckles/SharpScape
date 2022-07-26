using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SharpScape.Api.Controllers;
using SharpScape.Api.Data;
using SharpScape.Api.Services;
using SharpScape.Shared.Dto;
using System.Data.Common;
using System.Net;

namespace Sharpscape.Tests
{
	public class AuthControllerTests
	{
		AuthController _authController;
		private Crypto _crypto;
		private ITokenService _tokenService;
		private DbConnection _connection;
		private DbContextOptions<AppDbContext> _contextOptions;
		private AppDbContext _dbContext;

		[SetUp]
		public void SetUp()
		{
			if (!File.Exists("config.json"))
			{

				var resp = new HttpClient().GetAsync("https://raw.githubusercontent.com/cptchuckles/SharpScape/master/Api/appsettings.json").Result;

				if (resp.StatusCode == HttpStatusCode.OK)
				{
					File.WriteAllTextAsync("config.json", resp.Content.ReadAsStringAsync().Result);
				}
				else throw new Exception("Failed to fetch config file");
			}

			IConfiguration config = new ConfigurationBuilder().AddJsonFile("config.json").Build();

			var rsa = new RsaKeyProvider(config);

			_crypto = new Crypto(config, rsa);

			

			_tokenService = new TokenService(config, rsa);

			_connection = new SqliteConnection("Filename=:memory:");
			_connection.Open();

			// These options will be used by the context instances in this test suite, including the connection opened above.
			_contextOptions = new DbContextOptionsBuilder<AppDbContext>()
				.UseSqlite(_connection)
				.Options;

			_dbContext = new SqliteDbContext(_contextOptions);

			_authController = new AuthController(_dbContext, _crypto, _tokenService);
		}

		[Test]
		public void CreateToken()
		{
			var user = new UserRegisterDto()
			{
				Username = "test1",
				Email = "test1@test.t",
				Password = "passtest"
			};

			var token = _authController.Register(user);
			Assert.IsTrue(token != null);

			_connection.Dispose();
		}
	}
}