# Minikube

Getting our Local Development Environment Set Up to Replicate the Production Environment

## Overview

The cluster our application runs on has some facilities/services available that are created and maintained by the cluster administrator.

Examples include:

- Ingress
- Authentication and Authorization
- Certificates

## Creating Minikube Cluster

Set the driver to HyperV

```shell
minikube config set driver hyperv
```

Memory and CPUs

```shell
minikube config set memory 8192
minikube config set cpus 2
```

Start Minikube

```shell
minikube start
```

Enable Addons

```shell
minikube addons enable ingress
```

```shell
minikube addons enable ingress-dns
```

## Setting up Ingress DNS

Since our application (in 'production' is running at `https://*.ht-class.com/*`), we will trick out local machines into looking at the ingress dns we installed in the step above to start asking _that_ DNS where those services are.

To add the DNS rule

```powershell
Add-DnsClientNrptRule -Namespace ".ht-class.com" -NameServers "$(minikube ip)"
```

To REMOVE the DNS Rule:

> Note: ONLY do this when you are "done" and want to remove the redirect

```shell
Get-DnsClientNrptRule | Where-Object {$_.Namespace -eq '.ht-class.com'} | Remove-DnsClientNrptRule -Force;
```
