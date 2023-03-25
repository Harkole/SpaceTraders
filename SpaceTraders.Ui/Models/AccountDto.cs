using System.Text.Json.Serialization;

namespace SpaceTraders.Ui.Models
{
    public class AccountDto
    {
        /// <summary>
        /// Total amount of credits available to spend
        /// </summary>
        public int Credits { get; set; }

        /// <summary>
        /// The time stamp the user was created/joined the game world
        /// </summary>
        public DateTime JoinedAt { get; set; }

        /// <summary>
        /// The number of ships the player owns
        /// </summary>
        public int ShipCount { get; set; }

        /// <summary>
        /// The number of structures the player owns
        /// </summary>
        public int StructureCount { get; set; }

        /// <summary>
        /// The identity of the player, this will be the same as the username
        /// </summary>
        public string Username { get; set; } = string.Empty;
    }
}
