using Microsoft.EntityFrameworkCore;
using MySqlX.XDevAPI;

namespace EmployeeInfo
{
    public class text
    {
        //       dotnet add package Microsoft.EntityFrameWorkCore
        //dotnet add package Microsoft.EntityFrameWorkCore.Design
        //dotnet add package MySQL.Data
        //dotnet add package MySQL.EntityFrameWorkCore

     //   dotnet ef dbcontext scaffold "server=localhost; database=employees; uid=root; password = 1234" MySql.EntityFrameworkCore -o Models

        //"ConnectionStrings": {
        // "DbString": "server=localhost; database=employees;uid=root; password=root;"
        // }
        //   }

        //     var DbString = builder.Configuration.GetConnectionString("DbString");

        //     builder.Services.AddDbContext<ThuchanhContext>(options =>
        //options.UseMySQL(DbString));
        // builder.Services.AddScoped<IEmployeeRepo, EmployeeRepo>();
}
