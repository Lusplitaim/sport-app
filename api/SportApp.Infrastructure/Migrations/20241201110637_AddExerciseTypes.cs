using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddExerciseTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                "ExerciseTypes",
                new string[] { "Id", "Name" },
                new string[,] {
                    { "1", "warmup" },
                    { "2", "running" },
                    { "3", "jumping" },
                    { "4", "strolling" },
                    { "5", "pushups" },
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData("ExerciseTypes", new string[] { "Id" }, new string[] { "1", "2", "3", "4", "5" });
        }
    }
}
