# Certificates

Using `mkcert` [github](https://github.com/FiloSottile/mkcert)

Installing it:

```powershell
choco install mkcert
```

Generating Certs:

```shell

mkdir certs
cd certs
mkcert ht-class.com "*.ht-class.com" localhost 127.0.0.1 ::1
```

Create the secret for the certs:

```shell

kubectl  create secret tls mkcert --key ht-class.com+4-key.pem --cert ht-class.com+4.pem

```

Trusting the certs:

```shell
mkcert --install
```
