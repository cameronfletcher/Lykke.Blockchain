namespace Lykke.Blockchain.Services
{
    using System.Collections.Generic;

    /// <summary>
    /// Exposes he public members of the blockchain service.
    /// </summary>
    public interface IBlockchainService
    {
        /// <summary>
        /// Signs the specified transaction.
        /// </summary>
        /// <param name="transactionContext">The transaction context in the blockchain specific format.</param>
        /// <param name="privateKeys">One or more private keys used for signing the transaction.</param>
        /// <returns>The signed transaction.</returns>
        string SignTransaction(string transactionContext, params string[] privateKeys);

        /// <summary>
        /// Creates a new wallet.
        /// </summary>
        /// <returns>The new wallet.</returns>
        Wallet CreateWallet();

        /// <summary>
        /// Determines whether the specified address is valid.
        /// </summary>
        /// <param name="address">The address.</param>
        /// <returns>Returns <c>true</c> if the specified address is valid; otherwise, <c>false</c>.</returns>
        bool IsValidAddress(string address);

        /// <summary>
        /// Gets the assets.
        /// </summary>
        /// <returns>A range of assets.</returns>
        //// TODO (Cameron): Implement pagination correctly.
        IEnumerable<Asset> GetAssets();

        /// <summary>
        /// Gets the specified asset.
        /// </summary>
        /// <param name="assetId">The asset identifier.</param>
        /// <returns>The asset.</returns>
        Asset GetAsset(string assetId);

        /// <summary>
        /// Builds the transaction.
        /// </summary>
        /// <param name="transaction">The transaction.</param>
        /// <returns>The transaction context.</returns>
        string BuildTransaction(Transaction transaction);

        /// <summary>
        /// Broadcasts the transaction.
        /// </summary>
        /// <param name="transactionId">The transaction identifier.</param>
        /// <param name="signedTransaction">The signed transaction.</param>
        void BroadcastTransaction(string transactionId, string signedTransaction);
    }
}
