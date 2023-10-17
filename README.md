# Compliance Checklist Application

This document provides a step-by-step guide on how to build and run the Compliance Checklist application. The application consists of two main parts: an API developed in .NET and a UI built with Angular.
## About the Compliance Checklist Application

The **Compliance Checklist** is a simple application that allows users to visualize compliance tasks.

### Tech Stack Overview:

- **Frontend:** Developed using Angular, the frontend showcases a dynamic list of items and an interactive form that facilitates the addition of new items. The styling is done with bootstrap.

- **Backend:** Built with .NET 7 and ASP.NET core.

## NB: The Docker set up is not fully configured.

To get started, follow the instructions below to set up your environment.

## Directory Structure

The application resides in the `compliance-checklist` directory, which contains two main subfolders:

- **CompChecklistAPI**: Houses the .NET backend.
    - **src**: The source code for the API.
    - **tests**: Contains tests for the API.
- **Compliance.UI**: Contains the Angular frontend.

## Building and Running the API

1. Navigate to the API source directory:
    ```bash
    cd /CompChecklistAPI/src
    ```

2. Restore the .NET packages:
    ```bash
    dotnet restore
    ```

3. Build the API:
    ```bash
    dotnet build
    ```

4. Run the API:
    ```bash
    dotnet run
    ```

## Building and Running the Angular UI

1. Navigate to the UI directory:
    ```bash
    cd /Compliance.UI
    ```


2. Install the required npm packages:
    ```bash
    npm install
    ```

3. Build and run the Angular app:
    ```bash
    npm start
    ```

The application should now be running locally. Open a browser and navigate to `http://localhost:4200` to access the UI, and the API will be available at `http://localhost:5000`.

## Running the Tests

### API Tests

To run the tests for the `CompChecklistAPI`:

1. Navigate to the `tests` folder inside `CompChecklistAPI`:
    ```bash
    cd compliance-checklist/CompChecklistAPI/tests
    ```

2. Run the tests using the `dotnet test` command:
    ```bash
    dotnet test
    ```
