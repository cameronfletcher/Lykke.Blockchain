namespace Lykke.Blockchain
{
    /// <summary>
    /// Represents an asset.
    /// </summary>
    public class Asset
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the address which identifies asset in the blockchain, if applicable.
        /// </summary>
        /// <value>The address.</value>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the accuracy.
        /// </summary>
        /// <remarks>This is the maximum number of significant decimal digits to the right of the decimal point in the asset amount. Valid range: [0..28]</remarks>
        /// <value>The accuracy.</value>
        public int Accuracy { get; set; }
    }
}
