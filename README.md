# async-await-coverage

### Build and test

```charp
dotnet.exe test -c Debug /p:CollectCoverage=true /p:CoverletOutputFormat="json%2ccobertura" /p:CoverletOutput=../Coverage/coubertura
```

### Get the coverage

Use your local report generator or ...

On Windows
```charp
docker run -v ${PWD}:/Project moikot/report-generator -reports:/Project/Coverage/coubertura.cobertura.xml -targetdir:/Project/Coverage/Html -sourcedirs:/Project
```

On Linux
```charp
docker run -v $(PWD):/Project moikot/report-generator -reports:/Project/Coverage/coubertura.cobertura.xml -targetdir:/Project/Coverage/Html -sourcedirs:/Project
```



