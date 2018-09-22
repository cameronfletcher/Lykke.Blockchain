Should {accountId} be an internal ID for the account? If not, we need a composite ID to include blockchain/bank.

GET  /api/currencies
[
    "GPB",
    "BTC"
]
GET  /api/currencies/{currency}
{
    "id": "GPB",
    "impl": [
        "BankFrick.dll v2.1.0"
    ]
}

GET  /api/accounts (for user)
GET  /api/accounts/{accountId}
GET  /api/accounts/{accountId}/transactions?skip={skip}&take={take}
GET  /api/accounts/{accountId}/transactions/{transactionId}
{
    "status": "pending confirmation"
}

POST /api/accounts
{
    "ccy": "GBP"
}

POST /api/accounts/{accountId}/transactions
{
    "tx": "123",
    "to": "IBAN",
    ""
}