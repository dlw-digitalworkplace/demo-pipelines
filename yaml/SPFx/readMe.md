# Steps to deploy SPFx package to app catalog

We have more extensive documentation on this (Workspaces - Deployment guide.docx).

## Create AAD app called ‘dlw365 Deployment App’

Important! Add certain permissions to the AAD app:

- Microsoft Graph - Application - Sites.FullControl.All
- SharePoint - Application - Sites.FullControl.All

## Create certificate

e.g. using openssl

openssl req -x509 -sha256 -nodes -days 3650 -newkey rsa:2048 -keyout privateKey.key -out certificate.cer
openssl pkcs12 -export -out protected.pfx -inkey privateKey.key -in certificate.cer -password pass:"..."
openssl pkcs12 -in protected.pfx -out deployment_cert_DEV.pem -nodes

## Upload certificate to AAD app & DevOps secure files

Copy the thumbprint in the AAD app, you will need it later.

Set security such that all pipelines can use your secure file.

## Set necessary variables in relevant variable group

- spoCertificateThumbprint
- spoAppCatalogUrl
