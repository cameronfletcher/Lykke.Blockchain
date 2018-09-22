namespace Lykke.Blockchain
{
    /// <summary>
    /// Represents a blockchain transaction.
    /// </summary>
    public class Transaction
    {
        /// <summary>
        /// Gets or sets the identifier for this transaction.
        /// </summary>
        /// <value>The identifier.</value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the address to transact from.
        /// </summary>
        /// <value>The address to transact from.</value>
        //// NOTE (Cameron): Not sure why we're not using wallet here instead of address.
        public string FromAddress { get; set; }

        /// <summary>
        /// Gets or sets the address context.
        /// </summary>
        /// <value>The address context.</value>
        public string FromAddressContext { get; set; }

        /// <summary>
        /// Gets or sets the address to transact to.
        /// </summary>
        /// <value>The address to transact to.</value>
        public string ToAddress { get; set; }

        /// <summary>
        /// Gets or sets the asset identifier.
        /// </summary>
        /// <value>The asset identifier.</value>
        public string AssetId { get; set; }

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <remarks>This is an integer as a string aligned to the asset accuracy.</remarks>
        /// <value>The amount.</value>
        //// TODO (Cameron): This should be enforced by the asset.
        public string Amount { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include a fee.
        /// </summary>
        /// <value>Set to <c>true</c> if [include fee]; otherwise, <c>false</c>.</value>
        public bool IncludeFee { get; set; }
    }
}
