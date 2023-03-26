namespace SpaceTraders.Ui.Models
{
    public class LoanDto
    {
        /// <summary>
        /// When the loan is due to be repaid
        /// </summary>
        public DateTime Due { get; set; }

        /// <summary>
        /// The unique identity of the loan
        /// </summary>
        public string? Id { get; set; }

        /// <summary>
        /// The amount required to repay the loan
        /// </summary>
        public int RepaymentAmount { get; set; }

        /// <summary>
        /// The current loan status
        /// </summary>
        public string? Status { get; set; }

        /// <summary>
        /// The type of loan
        /// </summary>
        public string? Type { get; set; }
    }
}
