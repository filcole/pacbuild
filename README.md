# Demo Package Deployer Setup

This repo contains a 1st draft demo of building a package deployer package via a single command.  The command builds:

* PCF Control (including npm install)
* Plugin 
* Solution (exported from Dataverse via `pac solution clone`)
* Package Deployer Package

# Build in release mode

```powershell
cd package
dotnet publish --framework net472 --configuration Release
```

Note that release package will be created in `package\bin\Release\package.1.0.0.pdpkg.zip`.  This zip alone contains any compiled custom install code, any other artifacts such as solutions or data.

# Create auth profile in pac

```powershell
pac auth create --url <url> --name <friendlyname>
```

# Deploy via pac

```powershell
pac deploy --logConsole --logFile installlog.txt --package bin\Release\package.1.0.0.pdpkg.zip
```

