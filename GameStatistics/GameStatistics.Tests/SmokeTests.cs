using NUnit.Framework;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using Newtonsoft.Json;
using GameStatistics.Models;

namespace NUnit.Tests
{
    [TestFixture]
    public class SmokeTest
    {
        // Base URL for the API. Change it for your localhost.
        private const string BaseUrl = "http://localhost:5212/gamedata";

        // HttpClient for making HTTP requests
        private readonly HttpClient _httpClient = new HttpClient();

        // Guid for an existing game data (replace with an actual existing ID)
        private Guid existingId;

        // Set up method to initialize the existingId
        [SetUp]
        public void SetUp()
        {
            // Check if existingId is already set
            if (!(existingId == Guid.Empty)) // TODO: Change it for OneTimeSetUp
            {
                return;
            }

            // If not set, initialize it using the Init method
            Task.Run(async () => await Init()).Wait();
        }

        // Initialize method to get an existing game ID from the DB
        public async Task Init()
        {
            HttpResponseMessage response = await _httpClient.GetAsync(BaseUrl);

            // Ensure the request was successful
            response.EnsureSuccessStatusCode();

            // You can process the response content here if needed
            string responseBody = await response.Content.ReadAsStringAsync();
            GameData[] myDeserializedClass = JsonConvert.DeserializeObject<GameData[]>(responseBody);

            // Set the existingId to the ID of the first game (assuming it exists)
            existingId = myDeserializedClass.First().Id;
        }

        // Test to ensure getting all games data returns OK
        [Test]
        public async Task GetAllGamesData_ShouldReturnOk()
        {
            var response = await _httpClient.GetAsync(BaseUrl);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        // Test to ensure getting game data by an existing ID returns OK
        [Test]
        public async Task GetGameDataById_ExistingId_ShouldReturnOk()
        {
            var response = await _httpClient.GetAsync($"{BaseUrl}/{existingId}");
            var responseContent = await response.Content.ReadAsStringAsync();

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        // Test to ensure getting game data by a non-existing ID returns NotFound
        [Test]
        public async Task GetGameDataById_NonExistingId_ShouldReturnNotFound()
        {
            Guid nonExistingId = Guid.NewGuid();
            var response = await _httpClient.GetAsync($"{BaseUrl}/{nonExistingId}");
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.NotFound));
        }

        // Test to ensure creating game data returns Created
        [Test]
        public async Task CreateGameData_ShouldReturnCreated()
        {
            var requestData = new
            {
                GameName = "Penny Poker",
                Category = "Poker",
                PopularityScore = 0.72,
                TotalBets = 7000,
                TotalWins = 5200,
                AverageBetAmount = 15.50,
            };

            var content = new StringContent(JsonConvert.SerializeObject(requestData), System.Text.Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(BaseUrl, content);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Created));
        }

        // Test to ensure updating game data returns NoContent
        [Test]
        public async Task UpdateGameData_ShouldReturnNoContent()
        {
            var requestData = new
            {
                GameName = "Updated Poker",
                Category = "Updated Category",
                PopularityScore = 0.8,
                TotalBets = 8000,
                TotalWins = 6000,
                AverageBetAmount = 20.0,
            };

            var content = new StringContent(JsonConvert.SerializeObject(requestData), System.Text.Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync($"{BaseUrl}/{existingId}", content);

            var responseContent = await response.Content.ReadAsStringAsync();

            Assert.AreEqual(HttpStatusCode.NoContent, response.StatusCode);
        }

        // Test to ensure deleting game data with a non-existing ID returns NotFound
        [Test]
        public async Task DeleteGameData_NonExistingId_ShouldReturnNotFound()
        {
            Guid nonExistingId = Guid.NewGuid();

            var response = await _httpClient.DeleteAsync($"{BaseUrl}/{nonExistingId}");

            Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
        }

        // Test to ensure deleting game data with an existing ID returns NoContent
        [Test]
        public async Task DeleteGameData_ExistingId_ShouldReturnNoContent()
        {
            // Creating a new game data to delete
            var requestData = new
            {
                GameName = "Penny Poker",
                Category = "Poker",
                PopularityScore = 0.72,
                TotalBets = 7000,
                TotalWins = 5200,
                AverageBetAmount = 15.50,
            };

            var content = new StringContent(JsonConvert.SerializeObject(requestData), System.Text.Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(BaseUrl, content);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Created));

            // Extracting the ID from the Location header
            var locationHeader = response.Headers.Location;
            var createdId = Guid.Parse(locationHeader.Segments.Last());

            // Deleting the created game data
            response = await _httpClient.DeleteAsync($"{BaseUrl}/{createdId}");

            Assert.AreEqual(HttpStatusCode.NoContent, response.StatusCode);
        }
    }
}
