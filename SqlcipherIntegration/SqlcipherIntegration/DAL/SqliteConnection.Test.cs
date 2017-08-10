namespace SqlcipherIntegration.DAL
{
	using Models;
	public class SqliteConnectionTest
	{
		public void TestCreateTable()
		{
			var conn = SqliteConnectionFactory.Create();
			try
			{
				conn.CreateTable<Product>();
			}
			catch (System.Exception)
			{

			}
			finally
			{
				conn.Close();
			}

		}

		// This one will throw exception
		public void TestInsertProductThrowsExceptionWOKey()
		{

			var conn = SqliteConnectionFactory.CreateNew();
			try
			{
				conn.Insert(new Product() { ProductId = "P1", Description = "Pen" });
			}
			catch (System.Exception ex)
			{
				throw ex;

			}
			finally
			{
				conn.Close();
			}

		}
	}
}
