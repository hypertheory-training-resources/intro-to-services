# General Notes

General Plan:

See if I can have all the "infrastructure" stuff up and waiting in a minikube install _before_ the class starts.

Will probably need to:

-

## Some templates:

### Deployment

```yaml
apiVersion: apps/v1
kind: Deployment
metadata:
  name: demo-angular
spec:
  selector:
    matchLabels:
      app: demo-angular
  template:
    metadata:
      labels:
        app: demo-angular
    spec:
      containers:
        - name: demo-angular
          image: jeffrygonzalez/demo:v1

          ports:
            - containerPort: 80
```

### Service

```yaml
apiVersion: v1
kind: Service
metadata:
  name: demo-angular-service
spec:
  selector:
    app: demo-angular
  ports:
    - port: 80
      targetPort: 80
```

### Ingress

> Note: for the secret for TLS, see [03-certs.md](./03-certs.md)

```yaml
apiVersion: networking.k8s.io/v1
kind: Ingress
metadata:
  name: angular-ingress
  labels:
    name: angular-ingress
  annotations:
    kubernetes.io/ingress.class: nginx
spec:
  tls:
    - hosts:
        - ht-class.com
      secretName: mkcert
  rules:
    - host: ht-class.com
      http:
        paths:
          - pathType: Prefix
            path: "/"
            backend:
              service:
                name: demo-angular-service
                port:
                  number: 80
```
