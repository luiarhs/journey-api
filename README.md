# Journey API
DevOps Journey API 

### commands to build and push the image
```bash
docker login
docker build -t journey_api .
docker tag journey-api luiarhs/journey-api:lastest
docker push luiarhs/journey-api:lastest
```

https://www.codeproject.com/Articles/5381609/NET-8-Minimum-API-and-React-Frontend