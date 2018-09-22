namespace Lykke.Blockchain
{
    /// <summary>
    /// Represents a wallet.
    /// </summary>
    public class Wallet
    {
        /// <summary>
        /// Gets or sets the address which identifies the wallet in the blockchain.
        /// </summary>
        /// <remarks>For the blockchains with address mapping this should be the virtual address.</remarks>
        /// <value>The address.</value>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the address context.
        /// </summary>
        /// <value>The address context.</value>
        public string AddressContext { get; set; }

        /// <summary>
        /// Gets or sets the private key which may be used for signing transactions for this wallet.
        /// </summary>
        /// <value>The private key.</value>
        //// TODO (Cameron): I'm not sure we should ever be sending the private key across the wire.
        public string PrivateKey { get; set; }
    }
}
