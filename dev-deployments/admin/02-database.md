# Creating the Database

We will have a single instance of a Postgresql database that we will use for various things in our cluster:

    - Keycloak (Authentication/Authorization)
    - Our Apis

## Create and Use a NameSpace in the Cluster for our Database

```shell
kubectl create namespace db
```

```shell
kubectl config set-context minikube --namespace=db
```

## Deploy the Helm Chart

In the folder with the values:

```shell
helm install postgres bitnami/postgresql  -f ./postgresql-values.yaml
```
