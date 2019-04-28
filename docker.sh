docker login calculajuros.azurecr.io
docker tag calculajuros:latest calculajuros.azurecr.io/calculajuros
docker push calculajuros.azurecr.io/calculajuros

#To run in local machine
docker run -p 5000:80 --rm calculajuros