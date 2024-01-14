using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameStatistics.Migrations
{
    /// <inheritdoc />
    public partial class InitDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GamesData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    GameName = table.Column<string>(type: "text", nullable: false),
                    Category = table.Column<string>(type: "text", nullable: false),
                    TotalBets = table.Column<int>(type: "integer", nullable: false),
                    TotalWins = table.Column<int>(type: "integer", nullable: false),
                    AverageBetAmount = table.Column<float>(type: "real", nullable: false),
                    PopularityScore = table.Column<float>(type: "real", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GamesData", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "GamesData",
                columns: new[] { "Id", "AverageBetAmount", "Category", "GameName", "LastUpdated", "PopularityScore", "TotalBets", "TotalWins" },
                values: new object[,]
                {
                    { new Guid("0279e3dd-386a-47f4-be2a-fa57afd55d9f"), 0.5f, "Recreational Machine", "Penny Bingo", new DateTime(2024, 1, 13, 13, 43, 16, 907, DateTimeKind.Utc).AddTicks(208), 8f, 10000, 5000 },
                    { new Guid("08900a1f-1343-42ab-8da4-83aa649a363f"), 10f, "Card Game", "Crazy 4 Poker", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9883), 7.8f, 5000, 2500 },
                    { new Guid("0942b1e8-1c73-4ef4-8bb5-63af0c4f2c0a"), 9f, "Recreational machines", "Baseball Game", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9689), 7f, 90, 40 },
                    { new Guid("094bafb1-5d9d-4bb7-abdc-a3fe34299e6e"), 0.5f, "Recreational Machine", "Penny Arcade Slots", new DateTime(2024, 1, 13, 13, 43, 16, 907, DateTimeKind.Utc).AddTicks(109), 9.9f, 35000, 17500 },
                    { new Guid("0bcaabf8-9bd9-49c9-8e9a-8b682ce04492"), 5f, "Recreational Machine", "Slot Machine", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9762), 9.8f, 50000, 25000 },
                    { new Guid("0cb85667-c898-4ff8-817d-272c1a8599b8"), 1f, "Recreational Machine", "Video Keno", new DateTime(2024, 1, 13, 13, 43, 16, 907, DateTimeKind.Utc).AddTicks(49), 9.1f, 18000, 9000 },
                    { new Guid("0e802480-9bb6-436e-875b-1aa2b9e91403"), 12f, "Card Game", "Caribbean Stud Poker", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9915), 7.4f, 9000, 4500 },
                    { new Guid("10b219c8-b80a-4ad2-989a-953f52a847a7"), 5f, "Recreational machines", "Cricket Game", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9630), 5f, 50, 20 },
                    { new Guid("10e2acec-98e9-470a-adcf-2c2a1beccd6d"), 25f, "Table Game", "Roulette", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9729), 7.9f, 20000, 10000 },
                    { new Guid("111aebe7-1d35-4df9-be22-c94716bf65bd"), 50f, "Sports", "Sports Betting", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9265), 9.7f, 5000, 2500 },
                    { new Guid("11debc72-3852-4c3a-b150-497b730afbf7"), 42f, "Sports", "Basketball Betting", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9293), 6.8f, 1800, 800 },
                    { new Guid("121c32c3-3084-4e37-8739-50200b113387"), 10.5f, "Card Game", "Poker", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9709), 8.7f, 10000, 5000 },
                    { new Guid("13e93757-59ae-4c80-8ae9-8a8e2811a01f"), 7f, "Recreational machines", "Tennis Game", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9498), 6.1f, 70, 25 },
                    { new Guid("17b0467d-fbba-41af-be2c-36d9ce1186e9"), 8f, "Card Game", "Red Dog", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9863), 5.9f, 3000, 1500 },
                    { new Guid("1a37fa34-3940-4628-b1ed-dd7ab1ba1b7f"), 100f, "Sports", "MMA Betting", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9348), 5.1f, 400, 200 },
                    { new Guid("1af990a3-fe48-45de-b15e-33f8dbf63427"), 3f, "Recreational machines", "Volleyball Game", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9601), 4.8f, 30, 10 },
                    { new Guid("1c036f58-e259-45d7-a88c-0082f542bb97"), 200f, "Sports", "Cycling Betting", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9359), 4.8f, 200, 100 },
                    { new Guid("220d1caa-71e3-474c-a939-31877d246de3"), 6f, "Recreational machines", "Boxing Game", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9551), 6.2f, 60, 20 },
                    { new Guid("27cbb875-d953-42fe-827a-4240d305248a"), 1f, "Recreational Machine", "Keno Slot", new DateTime(2024, 1, 13, 13, 43, 16, 907, DateTimeKind.Utc).AddTicks(29), 8.9f, 12000, 6000 },
                    { new Guid("3164b1a8-5c4d-497c-9df9-5a6dd228bae7"), 18.2f, "Table Game", "Craps", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9783), 7.1f, 12000, 6000 },
                    { new Guid("352b6067-f3ba-43eb-bf74-44e53a8e57c1"), 10f, "Dice Game", "Sic Bo", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9803), 4.6f, 6000, 3000 },
                    { new Guid("37747df6-62de-42bf-a2e2-ded6bc5b70b5"), 10f, "Recreational machines", "Basketball Game", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9699), 7.5f, 100, 40 },
                    { new Guid("39290877-93d0-4845-a2ad-522ebf690448"), 48f, "Sports", "Baseball Betting", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9302), 6.5f, 1500, 700 },
                    { new Guid("3f181897-9608-43c7-abae-1b1b19e6d02e"), 3f, "Recreational machines", "Hockey Game", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9640), 4.4f, 30, 10 },
                    { new Guid("41bcf3a1-159e-4f3d-b95d-a4e796871036"), 60f, "Sports", "Tennis Betting", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9321), 6f, 1000, 500 },
                    { new Guid("43fcdb06-8bc8-4b6c-9da4-8e0d54418c37"), 0.5f, "Recreational Machine", "Penny Slots", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9925), 9.6f, 25000, 12500 },
                    { new Guid("48edddaf-0c9d-4a5f-bbd9-012ae12218b0"), 8f, "Card Game", "Cribbage Poker", new DateTime(2024, 1, 13, 13, 43, 16, 907, DateTimeKind.Utc).AddTicks(198), 6.6f, 5000, 2500 },
                    { new Guid("4a47b239-3a41-43c3-8ec1-c3666f744e01"), 6.2f, "Recreational machines", "Keno", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9255), 6.1f, 400, 200 },
                    { new Guid("4ed085f7-f5bf-4992-871f-cc92e335d483"), 5f, "Card Game", "Crazy Eights", new DateTime(2024, 1, 13, 13, 43, 16, 907, DateTimeKind.Utc).AddTicks(119), 5.4f, 3000, 1500 },
                    { new Guid("4f631c44-5485-4ef6-ac2f-ca78cd5f27f0"), 15.2f, "Casinos", "Blackjack", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9204), 7.6f, 1500, 800 },
                    { new Guid("5110ed46-edb3-46ae-b380-f242c8f36346"), 1f, "Recreational Machine", "Video Poker", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9946), 9.3f, 15000, 7500 },
                    { new Guid("533da2dc-673a-4e01-8d3f-0354b8770d90"), 10f, "Card Game", "Cassino", new DateTime(2024, 1, 13, 13, 43, 16, 907, DateTimeKind.Utc).AddTicks(59), 6.4f, 7000, 3500 },
                    { new Guid("5856b3c4-1a41-40b8-986f-722f41488b76"), 7f, "Recreational machines", "Baseball Game", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9581), 6f, 70, 25 },
                    { new Guid("58e26e52-7efb-4215-9d8c-35f066370210"), 4f, "Recreational machines", "Racing Game", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9650), 4.9f, 40, 15 },
                    { new Guid("5ab7593a-1a27-4989-8f04-d215004765ea"), 2.5f, "Recreational machines", "Slot Machines", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9215), 9.3f, 5000, 2000 },
                    { new Guid("60321e6e-1513-4304-8ee6-fe63ef782ca1"), 8f, "Recreational machines", "Darts Game", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9385), 6f, 80, 30 },
                    { new Guid("62cb172c-ed06-4d82-9723-4463e11ff3b6"), 5f, "Recreational Game", "Bingo", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9853), 7.6f, 4000, 2000 },
                    { new Guid("641b4bcb-75d5-459b-acb1-b3348077ae50"), 5f, "Recreational Machine", "Big Six Wheel", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9905), 8.1f, 8000, 4000 },
                    { new Guid("6b1e550b-be64-474b-a05f-4eed694472f5"), 7f, "Recreational machines", "Foosball", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9412), 6.3f, 70, 25 },
                    { new Guid("6bf857bc-6918-46cb-92eb-5657fffeb3f8"), 5f, "Card Game", "War", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9895), 6.3f, 4000, 2000 },
                    { new Guid("6cce60e8-6673-4c97-9ce6-f467484af37f"), 2f, "Recreational Machine", "Slingo", new DateTime(2024, 1, 13, 13, 43, 16, 907, DateTimeKind.Utc).AddTicks(69), 8.3f, 10000, 5000 },
                    { new Guid("6de60a03-6814-4d8b-b875-b9123757d60b"), 1f, "Recreational Machine", "Video Lottery", new DateTime(2024, 1, 13, 13, 43, 16, 907, DateTimeKind.Utc).AddTicks(129), 9.7f, 40000, 20000 },
                    { new Guid("70014949-7ea3-4900-8f3a-bcfa503cfc8e"), 5f, "Board Game", "Backgammon", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9996), 7.3f, 5000, 2500 },
                    { new Guid("746de52f-dc12-4a0f-9450-de9390768d97"), 4f, "Recreational machines", "Tennis Game", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9611), 4.2f, 40, 15 },
                    { new Guid("75878170-cccc-4023-bce6-31471f735cf6"), 8f, "Recreational machines", "Soccer Game", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9680), 6.5f, 80, 30 },
                    { new Guid("7f254273-f828-4e41-a4a6-4726c04ff163"), 10f, "Card Game", "Three Card Poker", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9844), 8.4f, 10000, 5000 },
                    { new Guid("7f2644ce-35d6-4e56-b29d-c2003e0c39f1"), 5f, "Card Game", "Cribbage", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9935), 4.9f, 2000, 1000 },
                    { new Guid("8233527f-fd4b-42f7-bec1-d4262c142de6"), 4f, "Recreational machines", "Cricket Game", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9518), 4.6f, 40, 15 },
                    { new Guid("862e3cc9-8475-45a0-8a1d-6457c988f981"), 9f, "Recreational machines", "Racing Game", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9540), 7.5f, 90, 40 },
                    { new Guid("87fd4045-8506-4f9a-9caf-7d389cb7f6ae"), 12f, "Recreational machines", "Guitar Hero Arcade", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9394), 8.7f, 120, 60 },
                    { new Guid("88461d8e-89c6-45ac-a6da-0849fff451b8"), 10f, "Recreational Machine", "Wheel of Fortune", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9823), 8.2f, 10000, 5000 },
                    { new Guid("8a2fb661-4473-4fc8-9e10-4df1c6ffe881"), 12.5f, "Card Game", "Pai Gow Poker", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9813), 6.9f, 7000, 3500 },
                    { new Guid("8afaf069-d259-4492-b247-dbba77d8cb1c"), 1f, "Recreational Machine", "Fruit Machine", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9966), 8.5f, 10000, 5000 },
                    { new Guid("8d6d1429-6fc2-441a-8e1f-977df16efeca"), 9f, "Recreational machines", "Air Hockey", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9403), 7.9f, 90, 40 },
                    { new Guid("8fd48a61-5e1a-4740-9681-35802e725a79"), 55f, "Sports", "Cricket Betting", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9312), 6.2f, 1200, 600 },
                    { new Guid("9234da64-2a9f-4885-8fe7-f5f636fe0bb5"), 80f, "Sports", "Boxing Betting", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9339), 5.4f, 600, 300 },
                    { new Guid("925c8d5c-b4f3-48ba-8b24-583c353839dd"), 5f, "Recreational machines", "Volleyball Game", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9508), 5.3f, 50, 20 },
                    { new Guid("9270e2e0-497a-46f4-aacb-09ef98d24f80"), 6f, "Recreational machines", "Golf Game", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9621), 5.6f, 60, 20 },
                    { new Guid("9608e874-0739-4b9f-959c-e5d42dc541f5"), 15f, "Recreational machines", "Football Game", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9477), 8.4f, 150, 60 },
                    { new Guid("9a3fc456-17b8-4441-b772-c7580f77d227"), 8f, "Card Game", "Gin Rummy Poker", new DateTime(2024, 1, 13, 13, 43, 16, 907, DateTimeKind.Utc).AddTicks(218), 5.6f, 3000, 1500 },
                    { new Guid("9a93c0d6-077f-4d63-9b58-2a81828252ec"), 0.5f, "Recreational Machine", "Penny Roulette", new DateTime(2024, 1, 13, 13, 43, 16, 907, DateTimeKind.Utc).AddTicks(149), 8.6f, 10000, 5000 },
                    { new Guid("9ca63c63-826e-43bd-a7ed-46c0a74cac48"), 1f, "Recreational Machine", "Video Lottery Terminal", new DateTime(2024, 1, 13, 13, 43, 16, 907, DateTimeKind.Utc).AddTicks(89), 9.4f, 30000, 15000 },
                    { new Guid("9f74e2b1-fcea-49e6-b20b-1ff07fc988ce"), 8f, "Card Game", "Gin Poker", new DateTime(2024, 1, 13, 13, 43, 16, 907, DateTimeKind.Utc).AddTicks(79), 5.7f, 5000, 2500 },
                    { new Guid("a25a2a54-8ddf-44ab-9985-0e085a6ffde3"), 8f, "Recreational machines", "Soccer Game", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9571), 6.7f, 80, 30 },
                    { new Guid("a26c8941-76dd-4b04-8f8a-c538c49face2"), 25f, "Sports", "Horse Racing", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9274), 8.4f, 3000, 1200 },
                    { new Guid("a3829083-5598-41b2-8ea2-a0a333901c1e"), 6f, "Recreational machines", "Boxing Game", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9660), 5.5f, 60, 20 },
                    { new Guid("a673642f-5143-452b-b650-22d90bf6be4d"), 3f, "Recreational machines", "Hockey Game", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9530), 3.9f, 30, 10 },
                    { new Guid("a681b18a-bedd-4a93-9360-eeb7a1ad9763"), 20f, "Card Game", "Baccarat", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9772), 6.5f, 8000, 4000 },
                    { new Guid("a6ae2f12-ec04-4f83-8e68-74c8953c735a"), 6f, "Recreational machines", "Skiing Game", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9421), 5.6f, 60, 20 },
                    { new Guid("ad104886-ee40-4a14-b6d1-234f05f3e169"), 2.5f, "Recreational Game", "Keno", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9793), 5.3f, 3000, 1500 },
                    { new Guid("ae9c1c55-9aaf-46da-87b2-6aed9ae7d6bb"), 5.7f, "Recreational machines", "Bingo", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9245), 7.8f, 300, 150 },
                    { new Guid("afe04999-dcf2-4d9e-bd0f-f3e2a35de771"), 10f, "Recreational machines", "Basketball Game", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9445), 7.2f, 100, 40 },
                    { new Guid("b47542d0-44fb-4346-8677-a15ebdf3ce34"), 5f, "Recreational machines", "Basketball Game", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9592), 5.4f, 50, 20 },
                    { new Guid("b493fd80-c0a4-48a5-803a-f9787825302a"), 15.2f, "Card Game", "Blackjack", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9719), 9.2f, 15000, 7500 },
                    { new Guid("b6424ba6-5ba4-4b49-ba7e-75a53d18a4ca"), 5f, "Card Game", "Spades", new DateTime(2024, 1, 13, 13, 43, 16, 907, DateTimeKind.Utc).AddTicks(178), 6.2f, 4000, 2000 },
                    { new Guid("b9312149-64f1-45a1-a269-74302fd7d2da"), 10f, "Card Game", "Pontoon", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9956), 6.7f, 6000, 3000 },
                    { new Guid("bb790464-ae0b-44d5-827c-826347605ab2"), 5f, "Card Game", "Euchre", new DateTime(2024, 1, 13, 13, 43, 16, 907, DateTimeKind.Utc).AddTicks(159), 4.7f, 3000, 1500 },
                    { new Guid("bcc89328-5d6c-408b-9948-fc21ba7ca12b"), 5f, "Card Game", "Canasta", new DateTime(2024, 1, 13, 13, 43, 16, 907, DateTimeKind.Utc).AddTicks(100), 4.8f, 2000, 1000 },
                    { new Guid("c303a47b-61f3-4bdc-9efe-e093f4c9975e"), 1f, "Recreational Machine", "Video Blackjack", new DateTime(2024, 1, 13, 13, 43, 16, 907, DateTimeKind.Utc).AddTicks(169), 9.5f, 20000, 10000 },
                    { new Guid("c34bca87-b6bd-4db4-aab6-867b602fda36"), 35f, "Sports", "Soccer Betting", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9284), 7.2f, 2000, 900 },
                    { new Guid("c3e8c6de-2df7-4b76-9d41-7ab08708a382"), 12.8f, "Casinos", "Craps", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9234), 5.4f, 800, 300 },
                    { new Guid("c884c080-4673-40f7-a540-be097d404a5a"), 70f, "Sports", "Golf Betting", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9330), 5.7f, 800, 400 },
                    { new Guid("ccc484a9-5ed0-4ed4-9ac2-f77615566dd6"), 0.5f, "Recreational Machine", "Penny Poker", new DateTime(2024, 1, 13, 13, 43, 16, 907, DateTimeKind.Utc).AddTicks(188), 9.2f, 15000, 7500 },
                    { new Guid("cd950473-3c70-4c47-9787-2ca888fb9ddd"), 10f, "Recreational machines", "Fishing Game", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9368), 7.5f, 100, 50 },
                    { new Guid("d418071b-eb4c-42bf-9f8f-f890d6b01f25"), 15.3f, "Card Game", "Texas Hold'em", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9834), 9.5f, 18000, 9000 },
                    { new Guid("d57982f4-36fb-44f5-b0f6-c3dfc026ed5e"), 4f, "Recreational machines", "Wrestling Game", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9561), 5.1f, 40, 15 },
                    { new Guid("d7c9e809-4615-4111-9593-04d6c837bdf4"), 5f, "Recreational machines", "Bowling Game", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9377), 6.7f, 50, 20 },
                    { new Guid("e33746ed-0790-48ae-9e42-a970fa22c9da"), 10.5f, "Casinos", "Poker", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9173), 8.2f, 1000, 500 },
                    { new Guid("e7c1bec8-2ab8-4fd1-9105-4852d1556dc6"), 8f, "Recreational machines", "Golf Game", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9488), 6.9f, 80, 30 },
                    { new Guid("e9a7905a-c687-43bc-bc08-29b39952c68e"), 5f, "Card Game", "Gin Rummy", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9976), 5.2f, 3000, 1500 },
                    { new Guid("efcc6d32-ca3f-4250-bca9-53cee747f893"), 1f, "Recreational Machine", "Pachinko", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9873), 9f, 20000, 10000 },
                    { new Guid("f5a2ece4-7623-43ac-a122-ebc91089d2d4"), 20f, "Casinos", "Roulette", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9224), 6.9f, 2000, 1000 },
                    { new Guid("f630c325-1104-41ac-91f6-639249ec55e6"), 5f, "Card Game", "Hearts", new DateTime(2024, 1, 13, 13, 43, 16, 907, DateTimeKind.Utc).AddTicks(39), 6.1f, 4000, 2000 },
                    { new Guid("fd606ffa-c422-426d-b99a-9dad0469929e"), 2f, "Recreational Machine", "Video Slots", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9986), 9.7f, 35000, 17500 },
                    { new Guid("fe93ed6e-f17c-487e-bc0e-b3f5dfb8f450"), 7f, "Recreational machines", "Wrestling Game", new DateTime(2024, 1, 13, 13, 43, 16, 906, DateTimeKind.Utc).AddTicks(9670), 6f, 70, 25 },
                    { new Guid("ff920073-08df-48d5-84ef-2e525f76c100"), 5f, "Card Game", "Pinochle", new DateTime(2024, 1, 13, 13, 43, 16, 907, DateTimeKind.Utc).AddTicks(139), 5.1f, 2500, 1250 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GamesData");
        }
    }
}
