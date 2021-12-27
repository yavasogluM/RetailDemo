# Retail Demo

API and Test projects gives discounted price of customer's invoice to you. You can test your datas at .Tests solution and also you can try API with following "Data Examples"

# Data Examples for API

/*NonDiscounted*/ ->
{
  "customer": {
    "id": 1,
    "type": 3
  },
  "invoice": {
    "id": 1,
    "totalPrice": 450,
    "type": 2
  }
}

/*Discounted*/ -> 
{
  "customer": {
    "id": 1,
    "type": 3
  },
  "invoice": {
    "id": 1,
    "totalPrice": 450,
    "type": 1
  }
}


Thanks!
