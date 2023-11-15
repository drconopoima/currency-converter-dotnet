# currency-converter-dotnet

## Quarterly exchange rate Treasury Fiscal Data

### API request example

```sh
curl -s -X GET "https://api.fiscaldata.treasury.gov/services/api/fiscal_service/v1/accounting/od/rates_of_exchange?fields=country_currency_desc,exchange_rate,record_date&filter=country_currency_desc:in:(Canada-Dollar),record_date:gte:2023-09-01" | jq '.'
```

### API Response example

```json
{
  "data": [
    {
      "country_currency_desc": "Canada-Dollar",
      "exchange_rate": "1.343",
      "record_date": "2023-09-30"
    }
  ],
  "meta": {
    "count": 1,
    "labels": {
      "country_currency_desc": "Country - Currency Description",
      "exchange_rate": "Exchange Rate",
      "record_date": "Record Date"
    },
    "dataTypes": {
      "country_currency_desc": "STRING",
      "exchange_rate": "NUMBER",
      "record_date": "DATE"
    },
    "dataFormats": {
      "country_currency_desc": "String",
      "exchange_rate": "10.2",
      "record_date": "YYYY-MM-DD"
    },
    "total-count": 1,
    "total-pages": 1
  },
  "links": {
    "self": "&page%5Bnumber%5D=1&page%5Bsize%5D=100",
    "first": "&page%5Bnumber%5D=1&page%5Bsize%5D=100",
    "prev": null,
    "next": null,
    "last": "&page%5Bnumber%5D=1&page%5Bsize%5D=100"
  }
}
```