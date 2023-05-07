using DataAccess.DTOs;
using DataAccess.EmployeeInterfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EmployeeRepositories
{
    public class ContractRepository : IContractRepository
    {
        ConnectionHelper connectionHelper = new ConnectionHelper();
        public ContractRepository()
        {
        }
        public void UpdateContract(ContractDTO contract)
        {
            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                {
                    connection.Open();
                    SqlCommand command;
                    if (contract.endDate != null)
                    {
                        command = new SqlCommand("UPDATE dbo.Contracts SET StartDate=@startDate ,EndDate=@endDate ,WeeklyHours=@hours,Salary=@salary WHERE EmployeeID = @employeeID", connection);
                    }
                    else
                    {
                        command = new SqlCommand("UPDATE dbo.Contracts SET StartDate=@startDate ,EndDate=null,WeeklyHours=@hours,Salary=@salary WHERE EmployeeID = @employeeID", connection);
                    }
                    using (command)
                    {
                        command.Parameters.AddWithValue("@employeeID", contract.employeeId);
                        command.Parameters.AddWithValue("@startDate", contract.startDate);
                        if (contract.endDate != null)
                            command.Parameters.AddWithValue("@endDate", contract.endDate);
                        command.Parameters.AddWithValue("@hours", contract.hoursPerWeek);
                        command.Parameters.AddWithValue("@salary", contract.salary);
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
        }
    }
}
