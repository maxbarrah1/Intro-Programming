using System;
using System.Data.SqlClient;
using System.Collections.Generic;



namespace API_DB_CONNECT_DEMO
{
    public static class DatabaseHandler
    {
        static string GetConnectionString() {
            try {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "dad.cbrifzw8clzr.us-east-1.rds.amazonaws.com";
                builder.UserID = "admin";
                builder.Password = "Kitemud$41";
                builder.InitialCatalog = "MAXB";
                return builder.ConnectionString;

            }
            catch(Exception e){
                throw new Exception(" Error in GetConnectionString() : " + e.Message);
            }
        }

        public static  List<OrganisationBrief> GetOrganisationBriefs(){
            List<OrganisationBrief> briefs = new List<OrganisationBrief>();

            using(SQLConnection conn = new SQLConnection(GetConnectionString())){

                conn.Open();

                using (SQLCommand command = new SQLCommand("SELECT * FROM ORGANISATION")){

                    using(SqlDataReader reader = command.ExecuteReader()){

                        while(reader.Read()){
                            briefs.Add(new OrganisationBrief(){OrgName = reader.GetString(0), Notes = reader.GetString(1)});
                        }
                    }
                }



                conn.Close();
            }
            return briefs;
        }

    }
}