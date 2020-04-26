## Trying out GraphQL Mesh

### Running it

- Start the first service

```
dotnet run -p service1
```

&darr;

http://localhost:5001/playground/

- Start the second service

```
dotnet run -p service2
```

&darr;

http://localhost:5002/playground/

- Start the first Mesh

```
cd gateway && arn graphql-mesh serve
```

&darr;

http://localhost:4000/graphql

query:

```graphql
{
  widgets {
    id
    gadgets {
      name
    }
  }
}
```
