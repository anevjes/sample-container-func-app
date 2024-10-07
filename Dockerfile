# Use the official Microsoft Azure Functions base image
FROM mcr.microsoft.com/azure-functions/dotnet:4

# Copy the function app files to the /home/site/wwwroot directory
COPY . /home/site/wwwroot

# Expose the port Azure Functions runtime listens on
EXPOSE 80

# Set the entry point for the Azure Functions runtime
ENTRYPOINT ["func", "host", "start", "--port", "80"]