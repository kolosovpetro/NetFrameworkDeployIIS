## NET Framework IIS Deploy

[![Build Web App](https://github.com/kolosovpetro/NetFrameworkDeployIIS/actions/workflows/build_and_publish.yml/badge.svg)](https://github.com/kolosovpetro/NetFrameworkDeployIIS/actions/workflows/build_and_publish.yml)

### Deployment process

- Create a new IIS website
  ![03_create_new_website](./img/03_iis_create_site.png)
- Publish project to the website physical path
- Open port in network security group
- Open port in Windows Firewall
- Validate the website
  ![04_validate_website](./img/04_published_site_check.PNG)

### Video how to deploy

- [How to deploy locally IIS](https://www.youtube.com/watch?v=PPaqVyBkwMk)
- [How to expose IP to internet](https://www.youtube.com/watch?v=e2Mx-y2eXeQ)

### How to enable IIS on Windows server

- [How to enable IIS](https://thesecmaster.com/step-by-step-procedure-to-configure-iis-on-the-windows-server/)
- [Required features to RUN (!!!)](https://stackoverflow.com/a/33622291)
- [How to Enable SSL on IIS using CertBot](https://medium.com/@nvbach91/how-to-create-lets-encrypt-s-free-wildcard-ssl-certificates-for-windows-server-iis-web-servers-aa01d939e0ad)