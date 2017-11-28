# AgileContent CDN File Converter#

This a node.js application develop to convert txt remote log files into csv files.

## installing and running application ##

### Requirements ###
Npm
NodeJS 6.10+
Git


## Steps ##

1 - Clone repository using git
```shell
git clone git@bitbucket.org/mauriciotetech/agilecontent
```

2 - Go to the download path and run the npm command install to install all dependencies
```shell
npm install
```

## Calling App ##

```shell
node converter https://s3.amazonaws.com/uux-itaas-static/minha-cdn-logs/input-01.txt ../log-file.csv
```