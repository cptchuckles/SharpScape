using System.Data.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SharpScape.Api.Controllers;
using SharpScape.Api.Data;
using SharpScape.Api.Services;
using SharpScape.Shared.Dto;

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
			var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

			var rsaKeyProvider = new RsaKeyProvider(config);
			_crypto = new Crypto(config, rsaKeyProvider);
			_tokenService = new TokenService(config, rsaKeyProvider);

			_connection = new SqliteConnection("Filename=:memory:");
			_connection.Open();

			// These options will be used by the context instances in this test suite, including the connection opened above.
			_contextOptions = new DbContextOptionsBuilder<AppDbContext>()
				.UseSqlite(_connection)
				.Options;

			_dbContext = new SqliteDbContext(_contextOptions);
			_dbContext.Database.EnsureCreated();

			_authController = new AuthController(_dbContext, _crypto, _tokenService);
		}

		public void Dispose() => _connection.Dispose();

		[Test]
		public void RegisterNewUser()
		{
			var user = new UserRegisterDto()
			{
				Username = "test1",
				Email = "test1@test.t",
				Password = "passtest",
				Avatar = "Default"
			};

			var result = _authController.Register(user).Result;

			Assert.IsTrue(result.Result is ObjectResult);
			var objectResult = (ObjectResult?) result.Result;
			Assert.IsNotNull(objectResult);
			var objectValue = (string?) objectResult?.Value;
			Assert.IsNotNull(objectValue);
			Assert.IsTrue(objectValue?.Length > 0);
		}
	}
}