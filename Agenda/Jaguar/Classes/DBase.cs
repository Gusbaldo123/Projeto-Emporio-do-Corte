using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Jaguar.Classes
{
    class DBase
    {
        static string Host = "Host", Database = "Database", Login= "Login", Password= "Password";


        static string connString = "Server="+ Host + ";Database="+ Database + ";Uid="+Login+";Pwd="+ Password;
        public string DbCommand(string sqlCom, Classes.Person p1)
        {
            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();

            try
            {
                try
                {
                    connection.Open();
                    command.CommandText = sqlCom;

                    int a = command.ExecuteNonQuery();
                    if (a == 0)
                    {
                        return "Ocorreu um erro";
                    }
                    else
                    {
                    }
                    return p1.Name + " inserido com sucesso";
                }
                catch (Exception e)
                {
                    //return "Ocorreu um erro";
                    return e.ToString();
                }
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();

            }
        }
        public string DbScheAdd(string sqlCom)
        {
            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();

            try
            {
                try
                {
                    connection.Open();
                    command.CommandText = sqlCom;

                    int a = command.ExecuteNonQuery();
                    if (a == 0)
                    {
                        return "Ocorreu um erro";
                    }
                    else
                    {
                    }
                    return "Inserido com sucesso";
                }
                catch (Exception e)
                {
                    //return "Ocorreu um erro";
                    return e.ToString();
                }
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();

            }
        }
        public string DbDel(string sqlCom, Classes.Person p1)
        {
            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();

            try
            {
                try
                {
                    connection.Open();
                    command.CommandText = sqlCom;
                    int a = command.ExecuteNonQuery();
                    if (a == 0)
                    {
                        return "Ocorreu um erro";
                    }
                    else
                    {
                    }
                    return p1.Name + " deletado com sucesso";
                }
                catch
                {
                    return "Ocorreu um erro";
                }
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();

            }
        }
        public string DbDelSche(string sqlCom, Classes.Schedule sc)
        {
            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();

            try
            {
                try
                {
                    connection.Open();
                    command.CommandText = sqlCom;
                    int a = command.ExecuteNonQuery();
                    if (a == 0)
                    {
                        return "Ocorreu um erro";
                    }
                    else
                    {
                    }
                    return "Nº"+sc.ID + " deletado com sucesso";
                }
                catch(Exception ex)
                {
                    return ex.Message;
                    //return "Ocorreu um erro";
                }
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();

            }
        }
        public string DbUpdate(string sqlCom, Classes.Person p1)
        {
            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();

            try
            {
                try
                {

                    string sql = "UPDATE `person` SET `name`='" + p1.Name + "',`phone`='" + p1.Phone + "'," +
                     "`cellphone`='" + p1.Cellphone + "' WHERE id = " + p1.ID.ToString();
                    connection.Open();
                    command.CommandText = sqlCom;

                    //"UPDATE `person` SET `name`=@name,`phone`=@phone," +
                    //"`cellphone`=@cellphone,`address`=@address,`complement`=@complement," +
                    //"`city`=@city,`state`=@state,`houseid`=@houseid WHERE id = @id";


                    command.Parameters.AddWithValue("@name", p1.Name);
                    command.Parameters.AddWithValue("@phone", p1.Phone);
                    command.Parameters.AddWithValue("@cellphone", p1.Cellphone);
                    int a = command.ExecuteNonQuery();
                    if (a == 0)
                    {
                        return "Ocorreu um erro";
                    }
                    else
                    {
                    }
                    return p1.Name + " atualizado com sucesso";
                }
                catch
                {
                    return "Ocorreu um erro";
                }
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();

            }
        }
        public string DbUpdateOpen(string sqlCom, Classes.Schedule p1)
        {
            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();

            try
            {
                try
                {
                    string Op = p1.DtOpen.Year + "-" + p1.DtOpen.Month + "-" + p1.DtOpen.Day;
                    string Cl = p1.DtClose.Year + "-" + p1.DtClose.Month + "-" + p1.DtClose.Day;
                    string Pr = p1.DtPrize.Year + "-" + p1.DtPrize.Month + "-" + p1.DtPrize.Day;

                    string sql = "UPDATE opensche SET DtaAbertura = '"+ Op + "', " +
                    " DtaEntrega = '" + Pr + "', State = '" + p1.State + "', Descricao = '" + p1.Desc
                    + "' WHERE id = " + p1.ID;
                    connection.Open();
                    command.CommandText = sql;
                    int a = command.ExecuteNonQuery();

                    if (a == 0)
                    {
                        return "Ocorreu um erro";
                    }
                    else
                    {
                    }
                    return "Pedido Nº"+p1.ID + " atualizado com sucesso";
                }
                catch
                {
                    return "Ocorreu um erro";
                }
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();

            }
        }
        public string DbUpdateClose(string sqlCom, Classes.Schedule p1)
        {
            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();

            try
            {
                try
                {
                    string Op = p1.DtOpen.Year + "-" + p1.DtOpen.Month + "-" + p1.DtOpen.Day;
                    string Cl = p1.DtClose.Year + "-" + p1.DtClose.Month + "-" + p1.DtClose.Day;
                    string Pr = p1.DtPrize.Year + "-" + p1.DtPrize.Month + "-" + p1.DtPrize.Day;

                    string sql = "UPDATE closedsche SET DtaAbertura ='" + Op + "'," +
                        "DataFechamento ='" + Cl + "',DtaEntrega ='" + Pr + "'" +
                        ",Descricao ='" + p1.Desc + "' WHERE id =" + p1.ID;
                    
                    connection.Open();
                    command.CommandText = sql;
                    int a = command.ExecuteNonQuery();

                    if (a == 0)
                    {
                        return "Ocorreu um erro";
                    }
                    else
                    {
                    }
                    return "Pedido Nº" + p1.ID + " atualizado com sucesso";
                }
                catch
                {
                    return "Ocorreu um erro";
                }
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();

            }
        }
        public DataTable DbReader(string sqlCom)
        {
            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();

            try
            {
                try
                {
                    connection.Open();
                    command.CommandText = sqlCom;
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                    dataAdapter.SelectCommand = new MySqlCommand(sqlCom, connection);
                    DataTable table = new DataTable();
                    dataAdapter.Fill(table);
                    return table;
                }
                catch
                {
                    return new DataTable();
                }
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();

            }
        }
    }
}
