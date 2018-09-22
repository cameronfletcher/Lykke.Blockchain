namespace Lykke.Blockchain.Services.FakeBlockchain
{
    using System.Collections.Generic;

    public class FakeBlockchainService : IBlockchainService
    {
        public Wallet CreateWallet()
        {
            return new Wallet
            {
                Address = "abc",
                PrivateKey = "secret",
            };
        }

        public Asset GetAsset(string assetId)
        {
            return new Asset
            {
                Id = assetId,
                Name = "Fake",
                Address = "xyz",
                Accuracy = 6
            };
        }

        public IEnumerable<Asset> GetAssets()
        {
            yield return this.GetAsset("123");
        }

        public bool IsValidAddress(string address)
        {
            return true;
        }

        public string SignTransaction(string transactionContext, params string[] privateKeys)
        {
            return "signed";
        }

        public string BuildTransaction(Transaction transaction)
        {
            return "transaction context";
        }

        public void BroadcastTransaction(string transactionId, string signedTransaction)
        {
        }
    }
}
