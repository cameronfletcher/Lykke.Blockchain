namespace Playground
{
    using Lykke.Blockchain;
    using Lykke.Blockchain.Services;
    using Lykke.Blockchain.Services.FakeBlockchain;

    internal class Program
    {
        public static void Main(string[] args)
        {
            IBlockchainService blockchainService = new FakeBlockchainService();

            var wallet = blockchainService.CreateWallet();

            var transaction = new Transaction
            {
                Id = "unique transaction id",
                FromAddress = wallet.Address,
                ToAddress = "some other address",
                AssetId = "Fake",
                Amount = "10000000", // 10 (if accuracy is 6)
                IncludeFee = false
            };

            // build
            var transactionContext = blockchainService.BuildTransaction(transaction);

            // sign
            var signedTransaction = blockchainService.SignTransaction(transactionContext, wallet.PrivateKey);

            // broadcast
            blockchainService.BroadcastTransaction(transaction.Id, signedTransaction);

            // observe
            // wait...?
        }
    }
}
