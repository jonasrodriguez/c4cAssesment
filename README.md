# c4cAssesment

### Run 
In order to run the app you need to first install the dotnet cli from [here](https://code.visualstudio.com/docs/languages/dotnet).   
Once installed, simply run `dotnet run --project program/program.csproj [Path_to_files]`.   

### Test
Project contains small test suite made with XUnit, you can run it using `dotnet test` command.   

### Run with docker
In case you don't have the proper sdk installed, you can easily run the assesment app with docker.   
Simply build the dockerfile with `docker build -t assesment .` and run it pointing to your file folder `docker run -i -t -v [Path_to_files]:/App/files assesment`.   
For example: `docker run -i -t -v C:\text:/App/files assesment`.   
