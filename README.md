# Running Neon database migrations in an Entity Framework project

This application is a simple C-sharp application built using the Entity framework and Neon database. It returns a list of authors and books written by them. This project uses the Entity Framework to interact with the Neon database and generate/run migrations. 

To build this project from scratch, check out the [guide in Neon's documentation](https://neon.tech/docs/guides/entity-migrations). 

## Set up Locally

You will need the following:
- A [Neon](https://neon.tech) account and a project
- A recent version of the .Net SDK installed on your local machine

1. Run the following command to clone the project repository:

```bash
git clone https://github.com/neondatabase/guide-neon-entityframework.git
```

2. Navigate to the project directory and run the following command to install the project dependencies:

```bash
cd guide-neon-entityframework
dotnet restore
dotnet tool install --global dotnet-ef
```

3. Create a `.env` file in the project root directory. 

    Fetch the connection string from your Neon project, which is in the following format:
    ```bash
    postgres://username:password@hostname/dbname?sslmode=require
    ```
    
    Identify the components of the connection string and add them to the `.env` file by combining them as shown below:
    ```bash
    DATABASE_URL="Host=hostname;Port=5432;Database=dbname;Username=username;Password=password;SSLMode=Require"
    ```

4. Run the database migrations and seed the database with sample data:

```bash
dotnet ef database update
```

5. Start the development server:
```bash
dotnet run
```

6. Open your web browser and visit `http://localhost:5000` to view the list of authors and books.