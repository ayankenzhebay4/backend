# backend

cmd in the folder nnn:
dotnet restore
dotnet run

1. REST API для страницы категорий товара:
   Postman: get https://localhost:5001/api/categories
   post {
  "name": "string"
    }

2. REST API для страницы создание товара
  post 
{
  "name": "string",
  "quantityInPackage": 100,
  "unitOfMeasurement": 5,
  "categoryId": 0
}
   

3. REST API для страницы просмотра списка товара
   request url: https://localhost:5001/api/products?CategoryId=100
curl: curl -X 'GET' \
  'https://localhost:5001/api/products?CategoryId=100' \
  -H 'accept: application/json'

4. REST API для страницы детальной информации по товару
  get http://localhost:5001/api/products
