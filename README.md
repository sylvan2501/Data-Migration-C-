# Data-Migration-C-Sharp

Several points to keep in mind when working on Visual Studio on a Mac M1

1. The mac m1 version of the visual studio does not seem to support the "integrated" version of the database migration as it does for the Windows os. 
In order to smoothly migrate and update database. The "Azure SQL Edge" image needs to be pulled by Docker. The associated container and volume need to be configured
2. The Azure Data Studio needs to be installed to provide database query and database visualization
3. dotnet ef CLI need to be installed for commandline interface for adding migrations and update database
